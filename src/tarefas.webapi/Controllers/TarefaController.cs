using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarefas.webapi.Domain.ApiModel;
using tarefas.webapi.Domain.Entities;
using tarefas.webapi.Domain.Services;

namespace tarefas.webapi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TarefaController : ControllerBase
	{

		[HttpGet]
		public IActionResult GetTarefas()
		{
			var lista = new List<Tarefa>();
			lista.Add(new Tarefa() { IdTarefa = 1, Descricao = "descricao", Concluido = false });
			return Ok(lista);
		}


		[HttpPost]
		public IActionResult Post(TarefaCreateModel model)
		{
			var service = new TarefaService();

			var resultado = service.CriarNovaTarefa(model);

			if (resultado == true)
			{
				return Ok();
			}
			else {
				return BadRequest();
			}
		}

	}
}
