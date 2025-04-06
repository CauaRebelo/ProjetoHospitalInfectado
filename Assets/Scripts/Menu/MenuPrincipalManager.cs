using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoesDoSom;
    [SerializeField] private GameObject painelDeOpcoesDeIdioma;
    [SerializeField] private GameObject MensagemDeDesenvolvilmento;
    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void AbrirOpcoesDoSom()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoesDoSom.SetActive(true);
    }

    public void FecharOpcoesDosom()
    {
        painelOpcoesDoSom.SetActive(false);
        painelMenuInicial.SetActive(true);
    }
    public void AbrirOpcoesDeIdioma()
    {
        painelMenuInicial.SetActive(false);
        painelDeOpcoesDeIdioma.SetActive(true);
    }

    public void FecharOpcoesDeIdioma()
    {
        painelDeOpcoesDeIdioma.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void AbrirMensagemDeDesenvolvimento()
    {
        painelDeOpcoesDeIdioma.SetActive(false);
        MensagemDeDesenvolvilmento.SetActive(true);
    }

    public void FecharMensagemDeDesenvolvimento()
    {
        painelDeOpcoesDeIdioma.SetActive(true);
        MensagemDeDesenvolvilmento.SetActive(false);
    }
    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
