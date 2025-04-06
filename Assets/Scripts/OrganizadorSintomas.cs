using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OrganizadorSintomas : MonoBehaviour
{
    [field: SerializeField]
    public UnityEvent<int> OnSintomaVisual { get; set; }
    [field: SerializeField]
    public UnityEvent<int> OnSintomaRaioX { get; set; }
    [field: SerializeField]
    public UnityEvent<int> OnSintomaDialogo { get; set; }
    
    public void OnSintomaReceber(Sintoma sintoma)
    {
        if(sintoma.tipo == Sintoma.Tipo.Visual)
        {
            if(sintoma.nome == "Olhos Vermelhos")
            {
                OnSintomaVisual?.Invoke(0);
            }
            else if (sintoma.nome == "Deformação Externa")
            {
                OnSintomaVisual?.Invoke(1);
            }
            else if (sintoma.nome == "Febre")
            {
                OnSintomaVisual?.Invoke(2);
            }
        }
        if(sintoma.tipo == Sintoma.Tipo.RaioX)
        {
            if(sintoma.nome == "Deformação Interna")
            {
                OnSintomaRaioX?.Invoke(0);
            }
            else if (sintoma.nome == "Objeto Estranho")
            {
                OnSintomaRaioX?.Invoke(1);
            }
        }
        if (sintoma.tipo == Sintoma.Tipo.Dialogo)
        {
            if (sintoma.nome == "Agressivamente Violento")
            {
                OnSintomaDialogo?.Invoke(0);
            }
            else if (sintoma.nome == "Problema de Diccao Grave")
            {
                OnSintomaDialogo?.Invoke(1);
            }
            else if (sintoma.nome == "Fala Incoompriensivel")
            {
                OnSintomaDialogo?.Invoke(2);
            }
        }
    }
}
