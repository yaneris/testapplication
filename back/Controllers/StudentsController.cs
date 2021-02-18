using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using back.Models;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        public IEnumerable<Students> GetStudents()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students(){Id = 1, First_name = "Yanis", Last_name = "Hermassi", Age = 19});
            students.Add(new Students(){Id = 2, First_name = "Aurélien", Last_name = "Rebourg", Age = 19});
            students.Add(new Students(){Id = 3, First_name = "Aurélien", Last_name = "Isak", Age = 19});
            students.Add(new Students(){Id = 4, First_name = "Andy", Last_name = "Kyuchi", Age = 20});
            return students;
        }
        
        [HttpGet]
        public IEnumerable<Students> GetStudents_List()
        {
            return GetStudents();
        }

        [HttpGet("{id}")]
        public ActionResult<Students> GetStudents_ById(int id)
        {
            var students = GetStudents().SingleOrDefault(x=>x.Id == id);
            if(GetStudents().Any(x => x.Id == id) == true)
                return students;
            return NotFound();
        }
    }
}