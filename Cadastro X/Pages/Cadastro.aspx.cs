using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cadastro_X.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        //private DBCadastroX banco { get; set; }
        private MeuBanco banco { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Instanciar nossa conexão do banco
            //banco = new DBCadastroX();
            banco = new MeuBanco();
           
        }

        protected void btPersist_Click(object sender, EventArgs e)
        {
            
            // Criar um objeto Funcionarios e suas propriedades
            try
            {
          
                Funcionarios fun = new Funcionarios()
                {
                    Bairro = txtDistrict.Text,
                    CEP = txtCEP.Text,
                    Cidade = txtCity.Text,
                    CPF = txtCPF.Text,
                    Departamento = 1,
                    Email = txtEmail.Text,
                    Endereco = txtAddress.Text,
                    Nome = txtName.Text,
                    UF = txtUF.Text,
                    Dtt_Birth = Convert.ToDateTime(txtBirth.Text),
                    Dtt_Record = DateTime.Now
                };

                // Adicionando no banco
                banco.Funcionarios.Add(fun);
                banco.SaveChanges();
                txtResp.Text = "Cadastro efetuado com Sucesso!!!";

            }
            catch (Exception ex)
            {
                txtResp.Text = ex.Message;
                //throw;
            }
            

        }
    }
}