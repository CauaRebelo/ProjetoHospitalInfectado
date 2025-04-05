using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacienteAnimationController : MonoBehaviour
{
    [SerializeField] private Animator agentAnimator;

    private void SetLeaveAnimation(bool val)
    {
        agentAnimator.SetBool("Open", val);
    }

    private void SetAnomalyAnimation(int val)
    {
        agentAnimator.SetInteger("Anomaly", val);
    }

    public void AnimateLeave(bool val)
    {
        SetLeaveAnimation(val);
    }

    public void AnimateAnomaly(int val)
    {
        SetAnomalyAnimation(val);
    }
}
