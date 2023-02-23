using Microsoft.AspNetCore.Mvc;
using DependencyInversion.Repository;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    //Error instanciando elementos de clase. Dependencia directa.
    // StudentRepository studentRepository = new StudentRepository();
    // Logbook logbook = new Logbook();

    IStudentRepository _studentRepository;
    ILogbook _logbook;

    public StudentController(IStudentRepository studentRepository, ILogbook logbook)
    {
        _studentRepository = studentRepository;
        _logbook = logbook;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        _logbook.Add($"returning student's list");
        return _studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody] Student student)
    {
        _studentRepository.Add(student);
        _logbook.Add($"The Student {student.Fullname} have been added");
    }
}
