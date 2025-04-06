using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacienteAnimationController : MonoBehaviour
{
    [SerializeField] private Animator agentAnimator;

    private void SetLeaveAnimation(bool val)
    {
        agentAnimator.SetBool("Leave", val);
    }

    private void SetAnomalyAnimation(int val)
    {
        agentAnimator.SetInteger("Anomaly", val);
    }

    private void SetGottenAnomalyAnimation(int val)
    {
        agentAnimator.SetInteger("GottenAnomaly", val);
    }

    public void AnimateLeave(bool val)
    {
        SetLeaveAnimation(val);
    }

    public void AnimateAnomaly(int val)
    {
        SetAnomalyAnimation(val);
    }

    public void AnimateGottenAnomaly(int val)
    {
        SetGottenAnomalyAnimation(val);
    }
}
