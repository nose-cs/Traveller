namespace Traveller.Dtos
{
    public class TokenDto
    {
        public string Token { get; set; }
        public static TokenDto Map(string token)
        {
            return new TokenDto { Token = token };
        }
    }
}
