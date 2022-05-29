﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarefas.webapi.Domain.ApiModel;
using tarefas.webapi.Domain.Entities;
using tarefas.webapi.Repository;

namespace tarefas.webapi.Domain.Services
{
	public class TarefaService
	{
		private readonly TarefaRepository repositorio;
		public TarefaService(TarefaRepository repositorio)
		{
			this.repositorio = repositorio;
		}
		public ResultadoOperacao<bool> CriarNovaTarefa(TarefaCreateModel model)
		{
			if (model == null || model.Descricao == null || string.IsNullOrWhiteSpace(model.Descricao))
			{
				return new ResultadoOperacao<bool>(false).AdicionarMensagemErro("Descricao não pode ser nulo ou vazio");
			}
			else
			{
				repositorio.Criar(model.Descricao, false);
				return new ResultadoOperacao<bool>(true);
			}

		}

		public IEnumerable<Tarefa> Listar() {
			return repositorio.SelecionarTodos();
		}
	}
}
