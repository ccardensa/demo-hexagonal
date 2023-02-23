namespace demo.mono.dominio.login
{
    public class Authentication : IAuthentication
    {
      
        public bool ValidacionLogin(string user, string pass, string token)
        {
            return true;
        }
    }
}