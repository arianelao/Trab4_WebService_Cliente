using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Operacao
/// </summary>
public class Operacao
{
    int id_cliente;
    string id_operacao;
    string nome_empresa;

    public Operacao(String id_operacao, string nomeEmpresa, int id_usuario)
    {
        Nome_empresa = nomeEmpresa;
        Id_cliente = id_usuario;
        Id_operacao = id_operacao;
    }

    public string Nome_empresa { get => nome_empresa; set => nome_empresa = value; }
    public int Id_cliente { get => id_cliente; set => id_cliente = value; }
    public string Id_operacao { get => id_operacao; set => id_operacao = value; }
}