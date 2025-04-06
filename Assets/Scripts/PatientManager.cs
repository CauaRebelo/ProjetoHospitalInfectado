using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientManager : MonoBehaviour
{
    public GameObject Patient;
    public GameObject RaioX;

    public void ChangeState(bool val)
    {
        Patient.SetActive(val);
        RaioX.SetActive(val);
    }
}
