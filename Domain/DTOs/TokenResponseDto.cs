namespace Domain.Models
{
    public class TokenResponseDto
    {
        public required string AccessToken { get; set; }

        public required string Role { get; set; }
        public required int Customer { get; set; }
        public required int userID { get; set; }

        
    }
}
