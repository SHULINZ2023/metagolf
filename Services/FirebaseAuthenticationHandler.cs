
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Dynamic;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace GolfApi.Services
{
    public class FirebaseAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly FirebaseApp _firebaseApp;
        private readonly ILogger<FirebaseAuthenticationHandler> _logger;
        public FirebaseAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, FirebaseApp firebaseApp) : base(options, logger, encoder, clock)
        {
            _firebaseApp = firebaseApp;
            _logger = logger.CreateLogger<FirebaseAuthenticationHandler>();
 
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if(!Context.Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.NoResult();
            } 
            _logger.LogInformation("here in handle token");
            string url = Context.Request.GetEncodedUrl();
            _logger.LogInformation(url);
            string bearerToken = Context.Request.Headers["Authorization"];
            _logger.LogInformation("here bearer token0: " + bearerToken);
            if (bearerToken  == null || !bearerToken.StartsWith("Bearer "))
            {
                return AuthenticateResult.Fail("Invalid Scheme.");
            }

            string token = bearerToken.Substring("Bearer ".Length);
            _logger.LogInformation("here bearer token1: " + token);
            try { 

                var firebaseToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(token); 
                            
                _logger.LogInformation("await done" + firebaseToken.ToString());
                return AuthenticateResult.Success(new AuthenticationTicket(new System.Security.Claims.ClaimsPrincipal(new List<ClaimsIdentity>()
                {
                    new ClaimsIdentity(ToClaims(firebaseToken),nameof(FirebaseAuthenticationHandler))
                }), JwtBearerDefaults.AuthenticationScheme));
            }
            catch (Exception ex)
            {
                return AuthenticateResult.Fail(ex);
            }


        }
      
        private IEnumerable<Claim>? ToClaims(FirebaseToken firebaseToken)
        {
            dynamic fireBase = JsonConvert.DeserializeObject<ExpandoObject>(firebaseToken.Claims["firebase"].ToString())!;

            return new List<Claim>
            {
                new Claim("id", firebaseToken.Claims["user_id"].ToString()),
                new Claim("email", fireBase.identities.email[0]),
            };
        }
    }
}
