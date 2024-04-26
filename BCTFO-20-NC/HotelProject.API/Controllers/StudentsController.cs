using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.API.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> _students = new List<Student>()
        {
            new Student() { Id = 1,FirstName = "ლუკა",LastName = "ცაგარეიშვილი"},
            new Student() { Id = 2,FirstName = "ლაშა",LastName = "ანდღულაძე"},
            new Student() { Id = 3,FirstName = "ნუცა",LastName = "მურუსიძე"},
            new Student() { Id = 4,FirstName = "ანა",LastName = "მაღრაძე"}
        };



        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            if (_students.Count <= 0)
            {
                return NotFound("Students not found");
            }

            return Ok(_students);
        }


        [HttpGet("{id:int}")]
        public ActionResult<Student> GetStudentById([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid id parameter");
            }

            var student = _students.FirstOrDefault(x => x.Id == id);

            if (student == null)
            {
                return NotFound("Student not found");
            }

            return Ok(student);

        }


        [HttpPost]
        public ActionResult<Student> AddNewStudent([FromBody] Student model)
        {
            if (model is null)
            {
                return BadRequest("Invalid parameter");
            }

            int newId = _students.Max(x => x.Id) + 1;
            model.Id = newId;

            _students.Add(model);
            return Ok(model);
        }



        [HttpDelete("{id:int}")]
        public ActionResult<Student> DeleteStudent([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid id parameter");
            }

            var student = _students.FirstOrDefault(x => x.Id == id);

            if (student == null)
            {
                return NotFound("Student not found");
            }

            _students.Remove(student);
            return NoContent();
        }
    }
}
