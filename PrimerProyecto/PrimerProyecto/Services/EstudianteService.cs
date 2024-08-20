using PrimerProyecto.DAL;
using PrimerProyecto.Models;

namespace PrimerProyecto.Services
{
    public class EstudianteService
    {
        private readonly Contexto contexto;

        public EstudianteService(Contexto contexto) {
            this.contexto = contexto;
        }

        public async Task<bool> Guardar(Estudiantes estudiantes) {
            if(! await Existe(estudiantes.EstudianteId))
                return await Insertar(estudiantes);
            else
                return await Modificar(estudiantes);
        }

        private async Task<bool> Modificar(Estudiantes estudiantes) {
            contexto.Update(estudiantes);
            var modificado = await contexto.SaveChangesAsync() > 0;
            contexto.Entry(estudiantes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return modificado;


        }

        private async Task<bool> Insertar(Estudiantes estudiantes)
        {
            contexto.Estudiantes.Add(estudiantes);
            return await contexto.SaveChangesAsync() > 0;
        }

        private async Task<bool> Existe(int estudianteId)
        {
            
        }

        public async Task<Estudiantes> Eliminar(Estudiantes estudiantes)
        {
            return await contexto.Estudiantes.
        }
    }
}
