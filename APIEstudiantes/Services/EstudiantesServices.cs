using APIEstudiantes.Interfaces;
using APIEstudiantes.Models;

namespace APIEstudiantes.Services;


public class EstudiantesServices : IEstudianteService

{
    private static List<Estudiante> estudiantes = new List<Estudiante>
    {
        new Estudiante { Id = Guid.NewGuid(), Nombre = "Juan Perez", Edad = 20, Activo = true },

        new Estudiante { Id = Guid.NewGuid(), Nombre = "Maria Gomez", Edad = 22, Activo = true }
        };


    public List<Estudiante> GetAll() => estudiantes;
    public List<Estudiante> GetActivos() => estudiantes.Where(e => e.Activo).ToList();
    public List<Estudiante> GetMayoresQue(int edad) => estudiantes.Where(e => e.Edad > edad).ToList();
    public Estudiante GetById(Guid id) => estudiantes.FirstOrDefault(e => e.Id == id);
    public Estudiante Create(Estudiante estudiante)
    {
        estudiante.Id = Guid.NewGuid();
        estudiantes.Add(estudiante);
        return estudiante;
    }
    public bool Update(Guid id, Estudiante editedEstudiante)
    {
        var existing = GetById(id);
        if (existing == null) return false;
        if (editedEstudiante.Edad <= 0) return false;
        existing.Nombre = editedEstudiante.Nombre;
        existing.Edad = editedEstudiante.Edad;
        existing.Activo = editedEstudiante.Activo;
        return true;
    }
    public bool Delete(Guid id)
    {
        var estudiante = GetById(id);
        if (estudiante == null) return false;
        estudiantes.Remove(estudiante);
        return true;
    }
    public bool ChangeStatus(Guid id)
    {
        var estudiante = GetById(id);
        if (estudiante == null) return false;
        estudiante.Activo = !estudiante.Activo;
        return true;
    }

}

