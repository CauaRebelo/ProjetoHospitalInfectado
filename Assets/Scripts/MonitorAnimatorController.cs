using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator agentAnimator;

    private void SetClickAnimation(int val)
    {
        agentAnimator.SetInteger("Click", val);
    }

    public void AnimateClick(int val)
    {
        SetClickAnimation(val);
    }
}
