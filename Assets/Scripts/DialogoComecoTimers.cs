using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogoComecoTimers : MonoBehaviour
{
    public TMP_Text dialogo;
    public GameObject cena;
    public GameObject panel;
    public GameObject dialogueBox;
    public GameObject monitor;
    public GameObject counter;
    public GameObject diretor;
    public GameObject paciente;

    void Start()
    {
        StartCoroutine(PrimeiroMomento());
        EventSystem.current.onTerminarVideo += OnTerminarVideo;
        EventSystem.current.onPatientExit += OnPatientExit;

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
        dialogo.text = "...";
        yield return new WaitForSeconds(1f);
        dialogo.text = "";
        dialogo.transform.gameObject.SetActive(false);
        dialogueBox.SetActive(false);
        monitor.SetActive(true);
        counter.SetActive(true);
    }

    public void OnTerminarVideo()
    {
        monitor.SetActive(false);
        counter.SetActive(false);
        diretor.SetActive(true);
        paciente.SetActive(true);
    }

    public void On()
    {
        monitor.SetActive(false);
        counter.SetActive(false);
        diretor.SetActive(true);
        paciente.SetActive(true);
    }
}
