using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Import for Button functionality

public class AnimatorTrigger : MonoBehaviour
{
    private Animator animator; // Store reference to the Animator

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component attached to this GameObject
        animator = GetComponent<Animator>();
    }

    // Function to be called when the button is pressed
    public void PlayAnimation()
    {
        // Play the animation using the Animator's Play function
        animator.Play("walk");
    }
}