using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillMatch.Data;
using System.Security.Claims;

namespace SkillMatch.Controllers
{
    [Authorize(Roles = "Student")] // Chỉ cho phép tài khoản sinh viên truy cập
    public class StudentController : Controller
    {
        private readonly SkillMatchDbContext _context;

        public StudentController(SkillMatchDbContext context)
        {
            _context = context;
        }

        // Trang Dashboard của sinh viên: Xem danh sách việc đã nộp đơn và trạng thái tương ứng
        public async Task<IActionResult> MyApplications()
        {
            // Lấy ID của sinh viên hiện tại từ Session/Cookie
            var studentIdClaim = User.FindFirst("UserId")?.Value;
            if (studentIdClaim == null) return Challenge();
            int studentId = int.Parse(studentIdClaim);

            // Tìm tất cả các đơn ứng tuyển của sinh viên này kèm theo thông tin của công việc đó
            var apps = await _context.Applications
                .Include(a => a.Job)
                .Where(a => a.StudentId == studentId)
                .OrderByDescending(a => a.AppliedAt)
                .ToListAsync();

            return View(apps);
        }
    }
}