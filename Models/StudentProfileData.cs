namespace SkillMatch.Models
{
    public class StudentProfileData
    {
        public string Bio { get; set; } = string.Empty;
        public string School { get; set; } = string.Empty;
        public List<SkillProgress> SkillList { get; set; } = new();
        public List<WorkExperience> Experiences { get; set; } = new();

        // Thêm cấu trúc mới phục vụ các Tab vừa bổ sung
        public List<StudentService> Services { get; set; } = new();
        public List<PortfolioProject> Portfolio { get; set; } = new();
    }

    public class SkillProgress
    {
        public string Name { get; set; } = string.Empty;
        public int Percentage { get; set; } = 100;
    }

    public class WorkExperience
    {
        public string Role { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    // Đối tượng Tab Dịch vụ
    public class StudentService
    {
        public string Title { get; set; } = string.Empty;
        public string OrdersCount { get; set; } = "0 đơn hàng";
        public string PriceRange { get; set; } = "0k";
        public double Rating { get; set; } = 5.0;
    }

    // Đối tượng Tab Portfolio
    public class PortfolioProject
    {
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = "/images/portfolio-default.jpg";
        public string Views { get; set; } = "0";
        public string Likes { get; set; } = "0";
    }
}