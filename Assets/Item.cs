using System;
using UnityEngine;

public class Item
{
    //atributo que não depende da instancia, apenas da classe
    public static int Instancias = 0;

    //atributos de instancia
    public string Nome { get; set; }
    public double Valor { get; set; }
    public bool VendaPermitida { get; set; }

    //construtor da classe
    public Item()
    {
        Instancias += 1;
    }
    //construtor com parâmetros de inicialização
    public  Item(string nome, double vlr, bool permitevenda)
    {
        Instancias += 1;
        this.Nome = nome;
        this.Valor = vlr;
        this.VendaPermitida = permitevenda;
    }
    public Item(string nome, double vlr)
    {
        Instancias += 1;
        this.Nome = nome;
        this.Valor = vlr;
        this.VendaPermitida = true;
    }
    //métodos
    public virtual void LogInfo()
    {
        Debug.Log("O item " + this.Nome + " vale" + this.Valor.ToString() + ". Venda Permitida  = " + this.VendaPermitida.ToString());
    }

    public static void QtdInstancias()
    {
        Debug.Log("Nro de intâncias  = " + Instancias.ToString());
    }

}