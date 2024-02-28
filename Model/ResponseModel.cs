namespace GolfApi.Model
{
    public class ResponseModel <T>
    {
        public ResponseModel()
        {
            ErrorMessages = new Dictionary<string, string>();
        }
        public T Value { get; set; }
        public bool Success
        {
            get
            {
                if (ErrorMessages.Count() == 0)
                {
                    return true;
                }

                return false;
            }
        }
        public Dictionary<string,string> ErrorMessages { get; set; }
    }
}
