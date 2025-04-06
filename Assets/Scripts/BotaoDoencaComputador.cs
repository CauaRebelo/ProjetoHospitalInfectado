using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BotaoDoencaComputador : MonoBehaviour
{
    public Doenca doenca;

    public void Start()
    {
    }
    public void SetName(Doenca doency)
    {
        doenca = doency;
        doenca.name = doency.nome;
        doenca.descricao = doency.descricao;
        doenca.transmissao = doency.transmissao;
        doenca.letalidade = doency.letalidade;
        doenca.dificuldade = doency.dificuldade;
        doenca.sintomas = doency.sintomas;
        this.gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = doency.nome;
    }

    public Doenca ChamarDadosDoenca(Doenca doency)
    {
        doency = this.doenca;
        return doenca;
    }

    
}
