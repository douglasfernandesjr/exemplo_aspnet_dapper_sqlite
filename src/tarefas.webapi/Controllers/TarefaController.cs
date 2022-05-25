using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarefas.webapi.Domain.Entities;

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

	}
}
