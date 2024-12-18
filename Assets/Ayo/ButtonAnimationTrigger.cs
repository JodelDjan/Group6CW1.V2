using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationTrigger : MonoBehaviour
{
    public Animator animator;

    public void PlayJump()
    {
        if (animator != null)
        {
            animator.SetTrigger("Jump");
        }
    }

    public void PlayWalk()
    {
        if (animator != null)
        {
            animator.SetTrigger("Walk");
        }
    }
}
