using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Paciente : MonoBehaviour
{
    public string nome;
    public Doenca doenca;
    public int paciencia = 8;
    public int tipoDialogo = -1;
    public bool tutorial = false;
    public Sintoma sintoma;
    public List<string> dialogos = new List<string>();
    public GameObject sprite;
    public GameObject anomaly1;
    public GameObject anomaly2;
    public GameObject anomaly3;
    public GameObject spriteX;
    public GameObject anomaly1X;
    public GameObject anomaly2X;
    [field: SerializeField]
    public UnityEvent<string> OnFala { get; set; }
    [field: SerializeField]
    public UnityEvent<Sintoma> OnEncontrarSintoma { get; set; }
    [field: SerializeField]
    public UnityEvent<bool> OnGoAway { get; set; }
    void Awake()
    {
        EventSystem.current.onComecar += OnComecar;
        EventSystem.current.onErrou += OnErrou;
        EventSystem.current.onAcertou += OnAcertou;
    }

    public void OnComecar()
    {
        paciencia = 8;
        StartCoroutine(PacienciaEsgotar());
        foreach (Sintoma sintomy in doenca.sintomas)
        {
            sintoma = sintomy;
            OnEncontrarSintoma?.Invoke(sintoma);
        }
    }

    public void OnSintomaDialogo(int index)
    {
        tipoDialogo = index;
    }

    public void OnDialogo()
    {
        if(tipoDialogo >= 0)
        {
            if(tipoDialogo == 0)
            {
                dialogos.Add("Seus olhos me irritam, se continuar vou puxa-los para fora.");
                dialogos.Add("... Sua cabeça faria um ótimo trófeu, o que acha da ideia?");
                dialogos.Add("Se não fosse os remédios, você já seria uma pilha de tripas agora.");
                dialogos.Add("Tantas ferramentas afiadas e você nem sequer tenta matar? Eu mal posso segurar a vontade de fazer o mesmo com você.");
            }
            if (tipoDialogo == 1)
            {
                dialogos.Add("Dojtor a augu ellado cumigu?");
                dialogos.Add("Ple... pleção demaius, pale di ouliar asin pre min!");
                dialogos.Add("Cuel... qi miundo cuel!!");
                dialogos.Add("Naum i mi clupa, naum quiru fazeir mau a nunguem!");
            }
            if (tipoDialogo == 2)
            {
                dialogos.Add("Voltará... Aquilo voltará... Acabou para nós... O fim está próximo...");
                dialogos.Add("A rosa negra me disse há muito tempo atrás, tudo isso foi predeterminado, preciso me tornar uma delas...");
                dialogos.Add("Tapete... Tapete... Tapete... Tapete... Tapete... Turfe?");
                dialogos.Add("Nós não somos as vitimas, a culpa é toda nossa, isso é apenas nossa punição, não há escapatória além de se juntar a eles.");
            }
        }
        else
        {
            dialogos.Add("Não enche.");
            dialogos.Add("Não tenho o que responder a você.");
            dialogos.Add("Tá olhando o que?");
            dialogos.Add("Eu sei que é seu trabalho, mas não quero papo.");
        }
        if(tutorial)
        {
            dialogos.Add("Minha *funga* saude *funga* está perfeitamente *funga* bem... *espirra*");
            dialogos.Add("*funga*");
            dialogos.Add("*funga* Você é chato, sabia? *espirra*");
            dialogos.Add("*espirra* Desculpe, aqui tem muita poeira... *funga*");
        }
        int aux = Random.Range(0, dialogos.Count);
        OnFala?.Invoke(dialogos[aux]);
    }

    public void GuessDoenca(Doenca doency)
    {
        if(doency == this.doenca)
        {
            EventSystem.current.Acertou();
        }
        else
        {
            EventSystem.current.Errou();
        }
    }

    public void ExameFeito(int perca)
    {
        paciencia -= perca;
        if(paciencia <= 0)
        {
            EventSystem.current.Errou();
        }
    }

    public IEnumerator PacienciaEsgotar()
    {
        yield return new WaitForSeconds(Info_Progresso.pacienciaTimer * 0.65f);
        //Mensagem de paciencia esgotando
        yield return new WaitForSeconds(Info_Progresso.pacienciaTimer * 0.35f);
        EventSystem.current.Errou();
    }

    public void OnErrou()
    {
        OnGoAway?.Invoke(true);
    }

    public void OnAcertou()
    {
        OnGoAway?.Invoke(true);
    }

    public void Left()
    {
        EventSystem.current.PatientExit();
        sprite.SetActive(true);
        anomaly1.SetActive(false);
        anomaly2.SetActive(false);
        anomaly3.SetActive(false);
        spriteX.SetActive(true);
        anomaly1X.SetActive(false);
        anomaly2X.SetActive(false);
        this.gameObject.transform.GetComponentInParent<PatientManager>().ChangeState(false);
    }
}
