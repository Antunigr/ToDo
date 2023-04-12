using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Crud.Api.Models;
using Crud.Repository;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Crud.Controllers
{
    [Route("Home")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IRegisterTasks _tasksRepository;

        public HomeController(IRegisterTasks tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Index(Tarefas tarefas)
        {
            var viewModel = new Tarefas()
            {
                Tarefa = tarefas.Tarefa

            };

            return View(viewModel);

        }

        public async Task<IEnumerable<Tarefas>> GetTasks()
        {
            return await _tasksRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tarefas>> GetTask(int id)
        {
            return await _tasksRepository.Get(id);
        }



        [HttpPost]
        public async Task<ActionResult<Tarefas>> CreateTask([FromForm] Tarefas tarefaSubmit)
        {
            if (tarefaSubmit.Tarefa == "")
            {
                tarefaSubmit.Tarefa = "Default name";
            }
            var newTask = await _tasksRepository.Create(tarefaSubmit);
            var routeValues = new { id = newTask.Id, version = "1.0" };

            CreatedAtAction(newTask.Tarefa, routeValues, newTask);

            return RedirectToAction("Index", "Home");
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var taskDelete = await _tasksRepository.Get(id);

            if (taskDelete == null)
                return NotFound();

            await _tasksRepository.Delete(taskDelete.Id);
            return NoContent();


        }

        [HttpPut]
        public async Task<ActionResult> PutTasks(int id, [FromBody] Tarefas tarefas)
        {
            if (id != tarefas.Id)
                return BadRequest();

            await _tasksRepository.Update(tarefas);

            return NoContent();
        }
    }


}

