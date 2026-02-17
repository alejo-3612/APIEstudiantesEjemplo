namespace APIEstudiantes.Controllers;
    using Microsoft.AspNetCore.Mvc;
using APIEstudiantes.Interfaces;
using APIEstudiantes.Models;

    [ApiController]
    [Route("api/[controller]")]
    public class EstudiantesControllers : ControllerBase
{
    private readonly IEstudianteService _EstudiantesService;
    public EstudiantesControllers(IEstudianteService EstudiantesService)
    {
        _EstudiantesService = EstudiantesService;
    }
    [HttpGet]
    public ActionResult<List<Estudiante>> GetAll() => Ok(_EstudiantesService.GetAll());
    [HttpGet("{id}")]
    public ActionResult<Estudiante> GetById(Guid id)
    {
        var estudiante = _EstudiantesService.GetById(id);
        return estudiante == null ? NotFound() : Ok(estudiante);
    }
    [HttpPost]
    public ActionResult<Estudiante> Create([FromBody] Estudiante estudiante)
    {
     var created = _EstudiantesService.Create(estudiante);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }
    [HttpPut("{id}")]
    public IActionResult Update(Guid id, [FromBody] Estudiante estudiante)
    {
        return _EstudiantesService.Update(id, estudiante) ? NoContent() : NotFound();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        return _EstudiantesService.Delete(id) ? NoContent() : NotFound();
    }
    [HttpPatch("{id}/status")]
    public IActionResult ChangeStatus(Guid id)
    {
        return _EstudiantesService.ChangeStatus(id) ? NoContent() : NotFound();
    }
}
