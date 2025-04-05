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
        dia = Info_Progresso.dia;
        dificuldade = dia * 2;
        aceleracaoDificuldade = dia + 1;
        doencas = Resources.LoadAll("Doencas", typeof(Doenca));
        GenerateDoenca();
    }

    public Doenca GetDoenca()
    {
        return doencaEscolhida;
    }

    void GenerateDoenca()
    {
        while (true)
        {
            doencaEscolhida = (Doenca)doencas[Random.Range(0, doencas.Length)];
            if (doencaEscolhida.dificuldade <= dia)
            {
                break;
            }
        }
    }

    void onPacienteSaiu()
    {
        dificuldade += aceleracaoDificuldade;
        GenerateDoenca();
    }
}
