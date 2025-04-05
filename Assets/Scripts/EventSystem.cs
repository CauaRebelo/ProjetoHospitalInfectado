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
}
