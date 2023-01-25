using EntityDBApplication.Models;

namespace EntityDBApplication.Operations
{
	public class Operacoes
	{
		public bool InsertAccount(Conta novaConta)
		{
			try
			{
				using (var db = new ContaContext())
				{
					db.Contas.Add(novaConta);
					db.SaveChanges();
				}
				return true;
			}
			catch
			{
				return false;
			}
		}

		public List<Conta> SelectAccount(string conta)
		{
			try
			{
				using (var db = new ContaContext())
				{
					var contas = db.Contas.Where(w => w.Nome.ToLower().Contains(conta)).ToList();
					return contas;
				}
			}
			catch
			{
				return new List<Conta>();
			}
		}

		public bool UpdateAccount(Conta conta)
		{
			try
			{
				using (var db = new ContaContext())
				{
					var contaAtualizada = db.Contas.First(f => f.IdConta == conta.IdConta);
					contaAtualizada.Nome = conta.Nome;
					contaAtualizada.Descricao = conta.Descricao;
					db.SaveChanges();
					return true;
				}
			}
			catch
			{
				return false;
			}
		}

		public Conta DeleteAccount(Conta conta)
		{
			try
			{
				using (var db = new ContaContext())
				{
					var contaApagada = db.Contas.First(f => f.IdConta == conta.IdConta);
					db.Contas.Remove(contaApagada);
					db.SaveChanges();
					return contaApagada;
				}
			}
			catch
			{
				return new Conta();
			}
		}
	}
}
