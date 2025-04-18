using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    public bool tutorial = false;

    bool sintomaEncontrado = true;

    void Start()
    {
        totalElements = ContentHolder.transform.childCount;

        doencas = Resources.LoadAll("Doencas", typeof(Doenca));

        Element = new GameObject[totalElements];

        Doenca doenca;

        if(tutorial)
        {
            return;
        }

        for (int i = 0; i < totalElements; i++)
        {
            Element[i] = ContentHolder.transform.GetChild(i).gameObject;
            if (i < doencas.Length)
            {
                doenca = (Doenca)doencas[i];
                Element[i].transform.GetComponent<BotaoDoencaComputador>().SetName(doenca);
            }
        }
    }

    public void AddSintoma(Sintoma sintoma)
    {
        if (tutorial)
        {
            return;
        }
        sintomasFiltrar.Add(sintoma);
        sintomaEncontrado = true;
        Search();
    }

    public void RemoveSintoma(Sintoma sintoma)
    {
        if (tutorial)
        {
            return;
        }
        sintomasFiltrar.Remove(sintoma);
        sintomaEncontrado = true;
        Search();
    }

    // Update is called once per frame
    public void Search()
    {
        if (tutorial)
        {
            return;
        }
        string SearchText = SearchBar.GetComponent<TMP_InputField>().text;
        int searchTxtlenght = SearchText.Length;

        Doenca doenca;

        int searchedElements = 0;

        int achados = 0;

        for (int i = 0; i < doencas.Length; i++)
        {
            searchedElements++;
            doenca = (Doenca)doencas[i];
            bool sintomaNaoComp = false;

            if (doenca.nome.Length >= searchTxtlenght && achados < totalElements)
            {
                if (SearchText.ToLower() == doenca.nome.Substring(0, searchTxtlenght).ToLower())
                {
                    foreach(Sintoma sintoma in sintomasFiltrar)
                    {
                        foreach (Sintoma sintomy in doenca.sintomas)
                        {
                            if(sintoma != sintomy)
                            {
                                sintomaEncontrado = false;
                            }
                            else
                            {
                                sintomaEncontrado = true;
                                break;
                            }
                        }
                        if (sintomaEncontrado == false)
                        {
                            sintomaNaoComp = true;
                            break;
                        }
                    }
                    if (sintomaNaoComp == true)
                    {
                        sintomaNaoComp = false;
                        continue;
                    }
                    Element[achados].transform.GetComponent<BotaoDoencaComputador>().SetName(doenca);
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
