//Entity Framework:
//Ativar Migração - Enable-Migrations
//Adicionar Migração - Add-Migration InitialCreate
//Atualizar/Aplicar modificação no banco de dados - Update-DataBase

using EntityDBApplication.Models;
using EntityDBApplication.Operations;

namespace EntityDBApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Operacoes op = new Operacoes();
            Conta conta = new Conta()
            {
                Descricao = txtDescricao.Text,
                Nome = txtNome.Text,
            };
            op.InsertAccount(conta);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Operacoes op = new Operacoes();
            string conta = txtId.Text;
            op.SelectAccount(conta);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Operacoes op = new Operacoes();
            Conta conta = new Conta()
            {
                IdConta = int.Parse(txtId.Text),
            };
            op.DeleteAccount(conta);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Operacoes op = new Operacoes();
            Conta conta = new Conta()
            {
                IdConta = int.Parse(txtId.Text),
                Descricao = txtDescricao.Text,
                Nome = txtNome.Text,
            };
            op.UpdateAccount(conta);
        }
    }
}