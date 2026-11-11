using EFcoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFcoreCrud.Controllers
{
    public class EmpController : Controller
    {
        private readonly EmpDbContext _dbContext;
        public EmpController(EmpDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Details(Models.Employee employee)
        {
            _dbContext.Employees.Add(employee); 
            _dbContext.SaveChanges();
            return View();
        }
    }
}
