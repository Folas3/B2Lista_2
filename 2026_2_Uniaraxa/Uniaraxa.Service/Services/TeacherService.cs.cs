
using Uniaraxa.Domain.Entities;
using Uniaraxa.Domain.Interfaces;
using Uniaraxa.Service.Interfaces;

namespace Uniaraxa.Service.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repository;

        public TeacherService(ITeacherRepository repository)
        {
            _repository = repository;
        }

        public Teacher Inserir(Teacher teacher)
        {
            return _repository.Inserir(teacher);
        }

        public bool Atualizar(Teacher teacher)
        {
            return _repository.Atualizar(teacher);
        }

        public List<Teacher> ListarTodos()
        {
            return _repository.ListarTodos();
        }

        public Teacher? BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public bool Remover(int id)
        {
            return _repository.Remover(id);
        }
    }
}
