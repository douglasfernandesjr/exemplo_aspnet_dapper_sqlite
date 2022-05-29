using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarefas.webapi.Database;
using tarefas.webapi.Domain.Entities;

namespace tarefas.webapi.Repository
{
	public class TarefaRepository
	{
		private readonly DatabaseConfig databaseConfig;

		public TarefaRepository(DatabaseConfig databaseConfig)
		{
			this.databaseConfig = databaseConfig;
		}

		public void Criar(string descricao, bool concluido)
		{
			using var connection = new SqliteConnection(databaseConfig.ConnectionString);

			var parametros = new DynamicParameters();
			parametros.Add("@descricao", descricao);
			parametros.Add("@concluido", concluido);

			connection.Execute("INSERT INTO Tarefa (Descricao, Concluido)" +
				"VALUES (@descricao, @concluido);", parametros);

		}

		public IEnumerable<Tarefa> SelecionarTodos()
		{
			using var connection = new SqliteConnection(databaseConfig.ConnectionString);
			return  connection.Query<Tarefa>("SELECT IdTarefa, Descricao, Concluido FROM Tarefa;");
		}

	}
}
