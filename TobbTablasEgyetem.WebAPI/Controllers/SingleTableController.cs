using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TobbTablasEgyetem.WebAPI.Models;

namespace TobbTablasEgyetem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingleTableController : ControllerBase
    {
        private readonly EgyetemdbContext _context = new();

        [HttpGet("student/email/{email}/name")]
        public async Task<IActionResult> GetNAmeFromEmail(string email)
        {
            return Ok(await _context.Students
                .Where(x => x.Email == email)
                .Select(x => x.Name)
                .FirstOrDefaultAsync());
        }
        [HttpGet("name/{name}/enrollment")]
        public async Task<IActionResult> IsEnrolled(string name)
        {
            Student? enrolledStudent = await _context.Students.Where(x => x.Name == name).FirstOrDefaultAsync();
            return Ok((enrolledStudent == null ? "Not Found" : (enrolledStudent!.Enrolled == true ? "Enrolled" : "Not Enrolled")));
        }
    }
}
