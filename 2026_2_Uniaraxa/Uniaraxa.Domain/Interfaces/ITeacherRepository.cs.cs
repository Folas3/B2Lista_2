
using Uniaraxa.Domain.Entities;

namespace Uniaraxa.Domain.Interfaces
{
    public interface ITeacherRepository
    {
        Teacher Inserir(Teacher teacher);

        bool Atualizar(Teacher teacher);

        List<Teacher> ListarTodos();

        Teacher? BuscarPorId(int id);

        bool Remover(int id);
    }
}
