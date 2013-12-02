using GalaSoft.MvvmLight.Messaging;

namespace Stockness.Core
{
    public class LoginMessage : MessageBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
