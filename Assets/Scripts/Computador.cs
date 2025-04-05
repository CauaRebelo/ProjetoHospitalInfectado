using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Computador : MonoBehaviour
{
    public GameObject ContentHolder;

    public GameObject SearchBar;

    public GameObject[] Element;

    private Object[] doencas;

    private List<Sintoma> sintomasFiltrar = new List<Sintoma>();

    public int totalElements;

    void Start()
    {
        totalElements = ContentHolder.transform.childCount;

        doencas = Resources.LoadAll("Doencas", typeof(Doenca));

        Element = new GameObject[totalElements];

        Doenca doenca;

        for (int i = 0; i < totalElements; i++)
        {
            Element[i] = ContentHolder.transform.GetChild(i).gameObject;
            if (i < doencas.Length)
            {
                doenca = (Doenca)doencas[i];
                Element[i].transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = doenca.nome;
            }
        }
    }

    void onSintomaSelect()
    {
        //sintomasFiltrar.Add(Prancheta.transform.gameObject.GetComponent<EscolherSintoma>().GetUltimoSintoma());
        ////foreach(Doenca doenca in doencasFiltrado)
        //{
        //    //if(doenca.sintomas.Any(sintomasFiltrar.Contains))
        //    {
        //        //gamb
        //    }
        //}
    }

    void onSintomaDeselect()
    {
        //sintomasFiltrar.Remove(Prancheta.transform.gameObject.GetComponent<EscolherSintoma>().GetUltimoSintoma());
    }

    // Update is called once per frame
    public void Search()
    {
        string SearchText = SearchBar.GetComponent<TMP_InputField>().text;
        int searchTxtlenght = SearchText.Length;

        Doenca doenca;

        int searchedElements = 0;

        int achados = 0;

        Debug.Log(SearchText);

        for (int i = 0; i < doencas.Length; i++)
        {
            searchedElements++;
            doenca = (Doenca)doencas[i];
            if (doenca.nome.Length >= searchTxtlenght && achados < totalElements)
            {
                if (SearchText.ToLower() == doenca.nome.Substring(0, searchTxtlenght).ToLower()) //&& doenca.sintomas.Any(sintomasFiltrar.Contains)
                {
                    Element[achados].transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = doenca.nome;
                    Element[achados].SetActive(true);
                    achados++;
                }
            }
        }
        if (achados < totalElements)
        {
            for (int i = achados; i < totalElements; i++)
            {
                Element[i].SetActive(false);
            }
        }
    }
}
