namespace E_Nak.Application.Model.Requests.User
{
    public class CreateUserRequest
    {
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
