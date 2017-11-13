using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servidor_WebService;

/**
 * Esta classe é responsável pela lógica da página SessaoCliente.
 * Essa página tem o objetivo de estabelecer conexão com o servidor através das referências de serviços (com o endereço do WSDL)
 * além disso cria um usuário, a partir de um id definido por este.
 * Então é criado um objeto "Usuário" contendo informações do usuário.
 * 
 */


public partial class SessaoCliente : System.Web.UI.Page
{

    Servidor_WebService.Servidor_WebService proxy;
    Cliente usuario;
    int id;
    List<Cliente> usuarios;

    protected void Page_Load(object sender, EventArgs e)
    {
        proxy = new Servidor_WebService.Servidor_WebService();
        
        Session["Servidor"] = proxy;

        if (usuario != null)
        {
            Server.TransferRequest("Default.aspx", false, "GET", null,true) ;
        }
        
    }

    protected void Btn_GeraID_Click(object sender, EventArgs e)
    {
        Cliente usuario_sessão = (Cliente)Session["Usuario"];
        this.id = int.Parse(TextBox1.Text);
        usuario = new Cliente(id);

        Session["Usuario"] = usuario;
        Session["ID_usuario"] = id;
        Server.Transfer("Default.aspx", false);
    }

}
