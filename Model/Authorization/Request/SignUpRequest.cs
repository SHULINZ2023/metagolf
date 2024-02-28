namespace GolfApi.Model.Authorization.Request
{
    public class SignUpRequest
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public String Email{get;set;}
        public string Password { get; set; }
    }
}