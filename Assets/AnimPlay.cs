using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlay : MonoBehaviour
{
    // Start is called before the first frame update

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            anim.Play("Walk", -1, 0f);
        }
        if (Input.GetMouseButtonDown(2))
        {
            anim.Play("Flip", -1, 0f);
        }
    }
}