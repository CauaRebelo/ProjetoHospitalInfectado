using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    public void OnPatientExit()
    {
        panel.SetActive(true);
        dialogo.transform.gameObject.SetActive(true);
        StartCoroutine(Vitoria());
    }

    public IEnumerator Vitoria()
    {
        dialogo.text = "Depois que o paciente saiu da sala, fui parabenizado com uma musica animada e alguns brindes...";
        yield return new WaitForSeconds(2f);
        dialogo.text = "Apesar da comemoração, não parecia algo feliz, parecia algo vazio... mas a recompensa podia me sustentar por enquanto.";
        yield return new WaitForSeconds(2f);
        dialogo.text = "E afinal de contas... Um médico sempre está ajudando os outros, certo?";
        yield return new WaitForSeconds(2f);
        dialogo.text = "C e R t O?";
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("DayOne");
    }

    public IEnumerator Derrota()
    {
        dialogo.text = "Depois que o paciente saiu da sala, fui alertado que não foi o diagnostico certo...";
        yield return new WaitForSeconds(2f);
        dialogo.text = "Apesar disso, ainda recebi uma recompensa que podia me sustentar por um bom tempo.";
        yield return new WaitForSeconds(2f);
        dialogo.text = "Talvez isso possa funcionar... Um médico sempre está ajudando os outros, certo?";
        yield return new WaitForSeconds(2f);
        dialogo.text = "C e R t O?";
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("DayOne");
    }
}
