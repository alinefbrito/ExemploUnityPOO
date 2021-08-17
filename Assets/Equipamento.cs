using System;
using UnityEngine;

public class Equipamento : Item
{
    //atributo que não depende da instancia, apenas da classe
    public static int InstanciasEquipamento = 0;

    public int Forca { get; set; }
    public int Danos { get; set; }

    public Equipamento()
    {
        InstanciasEquipamento += 1;
    }

    public Equipamento(string nome, double vlr, bool permitevenda, int forca, int dano)
    {
        InstanciasEquipamento += 1;
        this.Nome = nome;
        this.Valor = vlr;
        this.VendaPermitida = permitevenda;
        this.Forca = forca;
        this.Danos = dano;
    }

    //métodos
    
    public override void LogInfo()
    {

        Debug.Log("O Equipamento " + this.Nome + "  vale" + this.Valor.ToString() + ". Venda Permitida  = " + this.VendaPermitida.ToString() + "Possui Força de ataque de " + this.Forca.ToString() + " e sofre danos de " + this.Danos.ToString());
    }

    public  static void QtdInstanciasEquipamento()
    {
        Debug.Log("Nro de intâncias  = " + InstanciasEquipamento.ToString());
    }

    public static int NroInstancias()
    {
        return InstanciasEquipamento;

    }

    public string NomeEquipto()
    {
        return this.Nome.ToUpper();

    }
}