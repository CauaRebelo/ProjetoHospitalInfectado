using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CounterMonitorButton : MonoBehaviour
{
    int clicked = 0;
    [field: SerializeField]
    public UnityEvent<int> OnClickMonitor { get; set; }

    public void ClickMonitor()
    {
        clicked++;
        Debug.Log(clicked);
        OnClickMonitor?.Invoke(clicked);
    }

}
