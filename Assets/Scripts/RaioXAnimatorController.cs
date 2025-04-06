using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaioXAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator agentAnimator;

    private void SetOpenAnimation(bool val)
    {
        agentAnimator.SetBool("Open", val);
    }

    private void SetDespawnAnimation(bool val)
    {
        agentAnimator.SetBool("Despawn", val);
    }

    private void SetAnomalyAnimation(int val)
    {
        agentAnimator.SetInteger("Anomaly", val);
    }

    private void SetGottenAnomalyAnimation(int val)
    {
        agentAnimator.SetInteger("GottenAnomaly", val);
    }

    public void AnimateOpen(bool val)
    {
        SetOpenAnimation(val);
    }

    public void AnimateDespawn(bool val)
    {
        SetDespawnAnimation(val);
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
