using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator agentAnimator;

    private void SetUsingAnimation(bool val)
    {
        agentAnimator.SetBool("Using", val);
    }
    private void SetHoverAnimation(bool val)
    {
        agentAnimator.SetBool("Hover", val);
    }



    public void AnimateUsing(bool val)
    {
        SetUsingAnimation(val);
    }

    public void AnimateHover(bool val)
    {
        SetHoverAnimation(val);
    }

}
