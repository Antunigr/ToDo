using Crud.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud.Repository
{
    public class RegisterTasks : IRegisterTasks
    {
        public readonly Context _context;
        public RegisterTasks(Context context)
        {
            _context = context;
        }

        public async Task<Tarefas> Create(Tarefas tarefas)
        {
            _context.TaksRegister.Add(tarefas);
            await _context.SaveChangesAsync();

            return tarefas;
        }

        public async Task Delete(int id)
        {
            var taskDelete = await _context.TaksRegister.FindAsync(id);
            _context.TaksRegister.Remove(taskDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Tarefas>> Get()
        {
            return await _context.TaksRegister.ToListAsync();
        }

        public async Task<Tarefas> Get(int id)
        {
            return await _context.TaksRegister.FindAsync(id);
        }

        public async Task Update(Tarefas tarefas)
        {
            _context.Entry(tarefas).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}