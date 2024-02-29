using GolfApi.Model.Authorization.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace GolfApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AuthorizationController : Controller
    {
        private readonly ILogger<AuthorizationController> _logger;
        private readonly DomainEntities.GolfDbContext _dbContext;
        //private readonly DomainLogic.Facade.AuthenticationFacade _authenticationFacade;
        private readonly DomainLogic.Service.AuthenticationService _authenticationService;

        public AuthorizationController(ILogger<AuthorizationController> logger, DomainEntities.GolfDbContext dbContext, DomainLogic.Service.AuthenticationService authenticationService)
        {
            _logger = logger;
            _dbContext = dbContext;
            _authenticationService = authenticationService;
        }

        [HttpPost("SignIn")]
        [AllowAnonymous]
        public IActionResult SignIn([FromBody]SignInRequest request)
        {
            _logger.LogInformation(request.Email);
            _logger.LogInformation(request.Password);
            var result = _authenticationService.SignIn(request.Email, request.Password);
            var response = new GolfApi.Model.ResponseModel<string>();
            _logger.LogInformation(result.Result.FirebaseToken);
            response.Value = result.Result.FirebaseToken;

            return Ok(response); 
        }
        [HttpPost("SignUp")]
        [AllowAnonymous]
        public IActionResult SignUp([FromBody]SignUpRequest request)
        {
            _logger.LogInformation(request.LastName);
            _logger.LogInformation(request.FirstName);
            _logger.LogInformation(request.Email);
            _logger.LogInformation(request.Password);
            try{
                var result = _authenticationService.SignUp(request.Email,request.LastName,request.FirstName, request.Password);
                var response = new GolfApi.Model.ResponseModel<string>();
                _logger.LogInformation(result.Result.FirebaseToken);
                response.Value = result.Result.FirebaseToken;

                return Ok(response); 
            }
            catch(Exception E)
            {
                var response = new GolfApi.Model.ResponseModel<string>();
                _logger.LogInformation("bad request");
                response.Value = null;
                if(E.Message.IndexOf("EMAIL_EXISTS") >= 0)
                  response.ErrorMessages.Add("reason","EMAIL_EXISTS");
                else
                   response.ErrorMessages.Add("reason","unknown"); 

                return Ok(response); 
            }

        }
        [HttpGet("ConnectTest")]
        [AllowAnonymous]
        public IActionResult ConnectTest()
        {            
            var response = new GolfApi.Model.ResponseModel<string>();
            _logger.LogInformation("in ConnectTest");
            response.Value = "Connection successful";
            return Ok(response);
        }
        [HttpPost("AuthTest")]
        [Authorize]
        public IActionResult AuthTest()
        {            
            return Ok();
        }
    }
}
