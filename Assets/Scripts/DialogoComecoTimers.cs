using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoComecoTimers : MonoBehaviour
{
    public TMP_Text dialogo;
    public TMP_Text dialogo2;
    public GameObject cena;
    public GameObject panel;
    public GameObject dialogueBox;
    public GameObject dialogueBox2;
    public GameObject diretor;
    public GameObject paciente;

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
        panel.SetActive(false);
        cena.SetActive(true);
        yield return new WaitForSeconds(1f);
        dialogueBox.SetActive(true);
        dialogo.text = "...";
        yield return new WaitForSeconds(1f);
        dialogueBox.SetActive(false);
        dialogueBox.SetActive(true);
    }
}
