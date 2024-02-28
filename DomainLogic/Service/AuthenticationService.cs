using DomainEntities;
using Firebase.Auth;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Service
{
    public class AuthenticationService
    {
        private readonly GolfDbContext _dbContext;
        private readonly IConfiguration _configuration;        
        private readonly string _apiEndpoint;
        private readonly FirebaseAuthProvider _firebaseAuthProvider;
        private readonly ILogger<AuthenticationService> _logger;

        public AuthenticationService(ILogger<AuthenticationService> logger,GolfDbContext dbContext, IConfiguration configuration, FirebaseAuthProvider firebaseAuthProvider)
        {
            _dbContext = dbContext;
            _configuration = configuration;            
            _apiEndpoint = configuration.GetSection("FireBase").GetSection("EndPoint").Value.ToString();
            _firebaseAuthProvider = firebaseAuthProvider;
            _logger = logger;
        }

        public async Task<FirebaseAuthLink> SignUp(string email, string lastName, string firstName,string password)
        {
            try
            {
                //query if this email is existing in database

                var result = await _firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(email, password);
                var user = new Common.Entities.User()
                {   LastName = lastName,
                    FirstName= firstName,
                    Email = email,
                    Password = result.FirebaseToken,
                    Token = result.FirebaseToken
                };

                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
               
                return result;
            }
            catch (Exception E)
            {
                _logger.LogError(E.Message);
                throw E;

            }
            //return null;
        }
        public async Task<FirebaseAuthLink> SignIn(string email, string password)
        {
            try
            {
                var result = await _firebaseAuthProvider.SignInWithEmailAndPasswordAsync(email, password);                

                return result;
            }
            catch(Exception E)
            {
                int test = 2;
            }

            return null;
        }
    }
}
