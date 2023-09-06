using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exemplo : MonoBehaviour
{
   

    

    double vlr;
    bool pode;
    string nome;
    //define a variavel para recebver a intância
 //   Item item;
    // Start is called before the first frame update
    void Start()
    {
        transform.ResetTransformation();
        nome = "Moeda";
        pode = true;
        vlr = 1.00;
        //exibe a qtde de instancias

        Item.QtdInstancias();
        Item i = new Item();
        //parametros podem ser definidos no construtor
        //Item i = new Item(nome, vlr, pode);
        i.Nome = nome;
        i.Valor = vlr;
        i.VendaPermitida = pode;
        i.LogInfo();
        Equipamento eq = new Equipamento("armadura", 100.50, true, 100, 50);
        eq.LogInfo();
        int insteqpto  = Equipamento.NroInstancias();
        string nome_eq = eq.NomeEquipto();

        Debug.Log(nome_eq);
        

    }

    // Update is called once per frame
    void Update()
    {
         vlr += 1.50;
        pode = !pode;
        Item item;
        if (pode)
        {
             item = new Item(nome, vlr);
            
        }
        else
        {
            //define uma nova instância
             item = new Item(nome + vlr.ToString(), vlr, pode);
           
        }
        //exibe os dados da instancia atual
        item.LogInfo();
        //exibe o total de instancias
        Item.QtdInstancias();
    }
}
