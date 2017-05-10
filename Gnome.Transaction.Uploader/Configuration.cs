namespace Gnome.Transactions.Uploader
{
    public class Configuration
    {
        public string Password { get; private set; }
        public string Username { get; private set; }
        public string BaseUrl { get; private set; }

        public Configuration(string password, string username, string baseUrl)
        {
            this.Password = password;
            this.Username = username;
            this.BaseUrl = baseUrl;
        }
    }
}
