using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarefas.webapi.Domain.ApiModel;

namespace tarefas.webapi.Domain.Services
{
	public class TarefaService
	{
		public bool CriarNovaTarefa(TarefaCreateModel model)
		{
			if (model == null || model.Descricao == null || string.IsNullOrWhiteSpace(model.Descricao))
			{
				return false;
			}
			else
			{
				//chamar repositório aqui dentro
				return true;
			}

		}
	}
}
