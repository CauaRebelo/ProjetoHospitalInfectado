using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorDieCall : MonoBehaviour
{
    public void MonitorDeath()
    {
        EventSystem.current.TerminarVideo();
    }
}
