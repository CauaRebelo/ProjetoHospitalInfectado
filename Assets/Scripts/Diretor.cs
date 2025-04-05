using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    public int dificuldade = 0;
    public int dia = 0;
    public int aceleracaoDificuldade = 0;
    private Object[] doencas;
    private Doenca doencaEscolhida;
    void Start()
    {
        doencas = Resources.LoadAll("Doencas", typeof(Doenca));
    }

    public Doenca GetDoenca()
    {
        return doencaEscolhida;
    }

    void onPacienteSaiu()
    {
        dificuldade += aceleracaoDificuldade;
        while(true)
        {
            doencaEscolhida = (Doenca)doencas[Random.Range(0, doencas.Length)];
            if(doencaEscolhida.dificuldade <= dia)
            {
                break;
            }
        }
    }
}
