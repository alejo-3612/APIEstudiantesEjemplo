using APIEstudiantes.Models;
using APIEstudiantes.Models;

namespace APIEstudiantes.Interfaces
{
    public interface IEstudianteService
    {
        // 🔹 Obtener todos los estudiantes
        List<Estudiante> GetAll();

        // 🔹 Obtener solo estudiantes activos
        List<Estudiante> GetActivos();

        // 🔹 Obtener estudiantes mayores a cierta edad
        List<Estudiante> GetMayoresQue(int edad);

        // 🔹 Obtener estudiante por Id
        Estudiante GetById(Guid id);

        // 🔹 Crear nuevo estudiante
        Estudiante Create(Estudiante estudiante);

        // 🔹 Actualizar estudiante
        bool Update(Guid id, Estudiante estudiante);

        // 🔹 Eliminar estudiante
        bool Delete(Guid id);

        // 🔹 Cambiar estado Activo ↔ Inactivo
        bool ChangeStatus(Guid id);
    }
}