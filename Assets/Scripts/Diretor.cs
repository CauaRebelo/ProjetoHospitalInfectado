using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    public int dificuldade = 0;
    public int dia = 0;
    public int aceleracaoDificuldade = 0;
    public int failsafe = 1;
    public bool tutorial = false;
    private Object[] doencas;
    public List<PatientManager> patientManagers = new List<PatientManager>();
    private Doenca doencaEscolhida;
    public Doenca doencaTutorial;
    public Doenca doencaPlayer;
    void Start()
    {
        if(tutorial)
        {
            doencaEscolhida = doencaTutorial;
            patientManagers[0].ChangeState(true);
            return;
        }
        dia = Info_Progresso.dia;
        dificuldade = dia * 2;
        aceleracaoDificuldade = dia + 1;
        doencas = Resources.LoadAll("Doencas", typeof(Doenca));
        EventSystem.current.onErrou += OnErrou;
        EventSystem.current.onAcertou += OnAcertou;
        EventSystem.current.onPatientExit += OnPatientExit;
        patientManagers[Random.Range(0, patientManagers.Count)].ChangeState(true);
        GenerateDoenca();
    }

    public Doenca GetDoenca()
    {
        return doencaEscolhida;
    }

    public void SetDoenca(Doenca doenca)
    {
        doencaPlayer = doenca;
    }

    public void ConfirmChoice()
    {
        if (doencaPlayer != null && doencaPlayer == doencaEscolhida)
        {
            EventSystem.current.Acertou();
        }
        else
        {
            EventSystem.current.Errou();
        }
    }
    void GenerateDoenca()
    {
        GameObject paciente = GameObject.FindWithTag("Paciente");
        while (true)
        {
            doencaEscolhida = (Doenca)doencas[Random.Range(0, doencas.Length)];
            if (doencaEscolhida.dificuldade < dia)
            {
                continue;
            }
            paciente.transform.gameObject.GetComponent<Paciente>().doenca = doencaEscolhida;
            break;
        }
        EventSystem.current.Comecar();
    }

    void OnPatientExit()
    {
        if(tutorial)
        {
            return;
        }
        dificuldade += aceleracaoDificuldade;
        StartCoroutine(OnCooldown());
    }

    public IEnumerator OnCooldown()
    {
        yield return new WaitForSeconds(2f);
        patientManagers[Random.Range(0, patientManagers.Count)].ChangeState(true);
        GenerateDoenca();
    }

    public void OnErrou()
    {
        if(failsafe >= 1)
        {
            failsafe--;
            //Mensagem de Aviso que a proxima faz perder dinehrio
        }
        //Perde dinheiro caso não possa mais errar no dia
    }

    public void OnAcertou()
    {
        //Ganha dinheiro
    }
}
