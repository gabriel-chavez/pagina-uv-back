namespace Aforo255.Cross.Token.Src
{
    public class JwtOptions
    {
        public bool Enabled { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Key { get; set; }
        public int Expiration { get; set; }
        //public bool UsedGateway { get; set; }

        ////
        //// Summary:
        ////     Key value for the authentication scheme, by default it is SECURITY-TOKEN
        //public string KeyAuthJwtGateway { get; set; } = "SECURITY-TOKEN";
    }
}
