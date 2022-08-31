namespace SkillsMatrix.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        public int FailedAttemptsCount { get; set; }

        public int Team { get; set; }

        public bool IsActive { get; set; }

    }
}