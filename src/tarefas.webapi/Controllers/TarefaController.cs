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
		private readonly TarefaService service;
		public TarefaController(TarefaService service)
		{
			this.service = service;
		}

		[HttpGet]
		public IActionResult GetTarefas()
		{
			return Ok(service.Listar());
		}


		[HttpPost]
		public IActionResult Post(TarefaCreateModel model)
		{
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
