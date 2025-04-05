using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paciente : MonoBehaviour
{
    public string nome;
    public Doenca doenca;
    public int paciencia = 8;
    public List<string> dialogos = new List<string>();
    void Start()
    {
        StartCoroutine(PacienciaEsgotar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDialogo()
    {
        int anomalia = 0;
        foreach(Sintoma sintomy in doenca.sintomas)
        {
            if(sintomy.tipo == Sintoma.Tipo.Dialogo)
            {
                anomalia = 1;
                //Fazer coisas dependendo do tipo;
            }
        }
        if(anomalia == 0)
        {
            dialogos.Add("N�o enche.");
            dialogos.Add("N�o tenho o que responder a voc�.");
            dialogos.Add("T� olhando o que?");
            dialogos.Add("Eu sei que � seu trabalho, mas n�o quero papo.");
        }
    }

    public void GuessDoenca(Doenca doency)
    {
        if(doency == this.doenca)
        {
            //Victory;
        }
        else
        {
            //Failure;
        }
    }

    public IEnumerator PacienciaEsgotar()
    {
        yield return new WaitForSeconds(Info_Progresso.pacienciaTimer * 0.65f);
        //Mensagem de paciencia esgotando
        yield return new WaitForSeconds(Info_Progresso.pacienciaTimer * 0.35f);
        //Fracasso
    }
}
