namespace JWTWeb_API.Model
{
    public class User
    {
        public string UserName { get; set; }=string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }

}
