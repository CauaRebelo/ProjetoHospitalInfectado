using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public static EventSystem current;

    void Awake()
    {
        current = this;
    }

    public event Action onPatientExit;
    public void PatientExit()
    {
        if (onPatientExit != null)
        {
            onPatientExit();

        }
    }

    public event Action onAcertou;
    public void Acertou()
    {
        if (onAcertou != null)
        {
            onAcertou();

        }
    }

    public event Action onErrou;
    public void Errou()
    {
        if (onErrou != null)
        {
            onErrou();

        }
    }

    public event Action onComecar;
    public void Comecar()
    {
        if (onComecar != null)
        {
            onComecar();

        }
    }
}
