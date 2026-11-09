
using Uniaraxa.Domain.Entities;

namespace Uniaraxa.Service.Interfaces
{
    public interface ITeacherService
    {
        Teacher Inserir(Teacher teacher);

        bool Atualizar(Teacher teacher);

        List<Teacher> ListarTodos();

        Teacher? BuscarPorId(int id);

        bool Remover(int id);
    }
}
