using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Service
{
    public class FirebaseService
    {
        IConfiguration _configuration;
        public FirebaseService(IConfiguration configuration) { 
            _configuration = configuration;
        }

        public void SignIn(string email, string password)
        {

        }
    }
}
