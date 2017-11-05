using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servidor_WebService;
using System.Threading;

/**
 * Esta classe é responsável por toda a lógica aplicada à pagina Default.
 * Nesta página são utilizadas as informações adquiridas na página anterior (SessaoUsuario) - Referência ao servidor, Objeto Usuário e ID.
 * Nesta página são encontradas as funções de cadastro interesse de compra, cadastro interesse de venda, consulta ação e consulta operações realizadas.
 * 
 */

public partial class _Default : System.Web.UI.Page
{
    //txtBox_consultar;
    //Button_consultar;
    //int id_usuario = -1;


    Servidor_WebService.Servidor_WebService proxy;
    Cliente usuario;
    int id_usuario;


    /**
     * "Construtora" da classe, essa função é executada quando a página está sendo carregada para exibição.
     */
    public void Page_Load(object sender, EventArgs e)
    {
         
           proxy = (Servidor_WebService.Servidor_WebService) Session["Servidor"];
           usuario = (Cliente) Session["Usuario"];

           id_usuario = (int)Session["ID_usuario"];
       Label_id.Text = "Seu id é: " + id_usuario;

    }

    /**
     * Função de ação do botão consultar.
     * Esta função tem o objetivo de obter as informações - Nome da ação e preço - das ações que o usuário solicitou.
     */
    protected void Button_consultar_Click1(object sender, EventArgs e)
    {
        Label_resposta_consultar.Text = proxy.consultar(txtBox_consultar.Text);
    }

    /**
    * Função é responsável por executar as rotinas de compra. 
    * Envia ao servidor os dados cadastrar o interesse de compra do usuário
    * Recebe uma combinação de string, sendo separada pelo delimitador "%%%", que contém o id do usuário, resultado da operação e id da operação.
    * Por fim, adicina a operação à um vetor de interesses do cliente e inicializa a thread de monitoramento das operações do usuário.
    **/

    protected void Button_comprar_Click(object sender, EventArgs e)
    {
        string nomeEmpresa = txtBox_nome_empresa.Text;
        string[] separador = {"%%%"};
        int Qtd = int.Parse(txtBox_qtdAcao.Text);
        int Vlr = int.Parse(txtBox_vlrMax.Text);
        
        string resposta = proxy.cadastra_interesse_compra(id_usuario, nomeEmpresa, Qtd, Vlr);
        string[] split = resposta.Split(separador, StringSplitOptions.None);

        //int id = Convert.ToInt32(split[0]);

        //label_compra.Text = usuario.Get_id_usuario() + "  " + split[0];

        //acrescenta operação à lista do cliente
        usuario.adiciona_operacao(split[2], nomeEmpresa, int.Parse(split[0]));

        // Inicializa thread
        usuario.inicializa_threads_operacoes();

        label_compra.Text = split[1];
    }

    /**
    * Função é responsável por executar as rotinas de venda. 
    * Envia ao servidor os dados para cadastrar o interesse de venda do usuário
    * Recebe uma combinação de string, sendo separada pelo delimitador "%%%", que contém o id do usuário, resultado da operação e id da operação.
    * Por fim, adicina a operação à um vetor de interesses do cliente e inicializa a thread de monitoramento das operações do usuário.
    **/


    protected void BtnVender_Click(object sender, EventArgs e)
    {
        string[] separador = { "%%%" };

        string nomeEmpresa = txtBox_empresa.Text;
        int Qtd = int.Parse(txtBox_qtd.Text);
        int Vlr = int.Parse(txtBox_vlrMin.Text);
        int id_usuario = usuario.Get_id_usuario();

        string resposta = proxy.cadastra_interesse_venda(id_usuario, nomeEmpresa, Qtd, Vlr);
        string[] split = resposta.Split(separador, StringSplitOptions.None);

        //int id = Convert.ToInt32(split[0]);

        //Label_venda.Text = usuario.Get_id_usuario() + "  " + split[0];

        //acrescenta operação à lista do cliente
        usuario.adiciona_operacao(split[2],nomeEmpresa,int.Parse(split[0]));

        // Inicializa thread
        usuario.inicializa_threads_operacoes();
        
        Label_venda.Text = split[1];
    }

    /**
     *Função responsável por verificar todas as operações já concluídas e mostrar na página do usuário.    
     **/

    protected void Btn_mostrar_operacoes_Click(object sender, EventArgs e)
    {
        Operacao[] x = usuario.GetOperacoesCompletadas();

        String mostrar = "\n";

        for(int i = 0; i < x.Count(); i++)
        {
            string c = x[i].Id_operacao.Substring(0, 1);
            if (x[i].Id_operacao.Substring(0,1)=="C")
                mostrar = mostrar + x[i].Id_operacao +": O usuário com id " + x[i].Id_cliente + " comprou " + x[i].Nome_empresa + "\n";
            else
                mostrar = mostrar + x[i].Id_operacao + ": O usuário com id " + x[i].Id_cliente + " vendeu " + x[i].Nome_empresa + "\n";
        }
        txtBox_venda.Text = mostrar;
    }



}
