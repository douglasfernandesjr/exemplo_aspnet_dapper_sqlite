using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tarefas.webapi.Domain.Services
{
	public class ResultadoOperacao<T>
	{
		public ResultadoOperacao(T objetoRetorno)
		{
			ObjetoRetorno = objetoRetorno;
			Sucesso = true;
			Erros = new List<string>();
		}

		public ResultadoOperacao<T> AdicionarMensagemErro(string erro) {
			Erros.Add(erro);
			return this;
		}

		[JsonIgnore]
		public T ObjetoRetorno { get; private set; }

		public bool Sucesso { get; private set; }

		public List<String> Erros { get; private set; }

	}
}
