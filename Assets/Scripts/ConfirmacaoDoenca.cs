using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConfirmacaoDoenca : MonoBehaviour
{
    public TMP_Text conf;
    Doenca doenca;

    public void GetDoencaEscolhida()
    {
        doenca = GameObject.FindWithTag("Director").GetComponent<Diretor>().doencaPlayer;
        conf.text = ("Voc� tem certeza que deseja selecionar " + doenca.nome + " como a doen�a do paciente?");
    }


}
