
using Uniaraxa.Domain.Entities;
using Uniaraxa.Domain.Interfaces;

namespace Uniaraxa.Infra.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly List<Teacher> _teachers = new List<Teacher>();

        private int _nextId = 1;

        public Teacher Inserir(Teacher teacher)
        {
            teacher.Id = _nextId++;

            _teachers.Add(teacher);

            return teacher;
        }

        public bool Atualizar(Teacher teacher)
        {
            var existente = BuscarPorId(teacher.Id);

            if (existente == null)
                return false;

            existente.Name = teacher.Name;
            existente.Email = teacher.Email;
            existente.UrlLattes = teacher.UrlLattes;
            existente.DataAdmissao = teacher.DataAdmissao;

            return true;
        }

        public List<Teacher> ListarTodos()
        {
            return _teachers.ToList();
        }

        public Teacher? BuscarPorId(int id)
        {
            return _teachers.FirstOrDefault(t => t.Id == id);
        }

        public bool Remover(int id)
        {
            var teacher = BuscarPorId(id);

            if (teacher == null)
                return false;

            _teachers.Remove(teacher);

            return true;
        }
    }
}
