using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoComecoTimers : MonoBehaviour
{
    public TMP_Text dialogo;
    public TMP_Text dialogo2;
    public GameObject Cena;
    public GameObject Panel;
    public GameObject DialogueBox;
    public GameObject DialogueBox2;
    public GameObject Paciente;
    void Start()
    {
        StartCoroutine(PrimeiroMomento());
    }

    public IEnumerator PrimeiroMomento()
    {
        dialogo.text = "...Onde estou?...";
        yield return new WaitForSeconds(2f);
        dialogo.text = "A fumaça, os gritos, a dor, tudo é tão familiar...";
        yield return new WaitForSeconds(3f);
        dialogo.text = "Tão... distante?!";
        yield return new WaitForSeconds(1f);
        Panel.SetActive(false);
        Cena.SetActive(true);
        yield return new WaitForSeconds(1f);
        DialogueBox.SetActive(true);
        dialogo.text = "...";
        yield return new WaitForSeconds(1f);
        DialogueBox.SetActive(false);
        DialogueBox.SetActive(true);
        dialogo2.text = "Bem-vindo ao Clínica Lúmen! Aqui todos trabalhamos para o bem de todos!";
        yield return new WaitForSeconds(3f);
        dialogo2.text = "Seu trabalho vai ser diagnosticar possiveis pacientes para serem transferidos para o lugar certo!";
        yield return new WaitForSeconds(5f);
        Paciente.SetActive(true);
        dialogo2.text = "Esse é seu primeiro paciente! Você deve identificar sintomas para diagnosticar ele com uma doença!";
        yield return new WaitForSeconds(4f);
        dialogo2.text = "Como pode ver, o paciente tem apenas olhos irritados! Deve ser uma simples conjutivite!";
        yield return new WaitForSeconds(4f);
        dialogo2.text = "Agora pegue sua prancheta ou use seu computador para identificar os sintomas e dar um diagnostico.";
        yield return new WaitForSeconds(4f);
        dialogo2.text = "Isso é tudo que você precisa fazer! Pode descansar por hoje, amanhã será um grande dia!";
        yield return new WaitForSeconds(4f);
        dialogo2.text = "E não deixe se enganar, você pode clicar nos pacientes para conversar com eles ou checar o Raio X por mais sintomas!";
        yield return new WaitForSeconds(4f);
        dialogo2.text = "Queria poder responder suas perguntas, mas por agora você só precisa saber que será muito bem recompensado pelo seu trabalho, até mais!";
        yield return new WaitForSeconds(5f);
        Panel.SetActive(true);
    }
}
