using Crud.Api.Models;

namespace Crud.Repository
{
    public interface IRegisterTasks
    {
        Task<IEnumerable<Tarefas>> Get();

        Task<Tarefas> Get(int id);

        Task<Tarefas> Create(Tarefas tarefas);

        Task Update(Tarefas tarefas);

        Task Delete(int id);
    }
}