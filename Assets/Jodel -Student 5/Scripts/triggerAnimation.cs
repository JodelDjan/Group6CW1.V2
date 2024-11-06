using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class triggerAnimation : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown("1"))
        {
        this.GetComponent<Animator>().Play("AnimX");
        this.GetComponent<Animator>().Play("AnimY");
        this.GetComponent<Animator>().Play("AnimZ");
        }
    }
    void OnMouseDown()
        {
        this.GetComponent<Animator>().Play("AnimX");
        this.GetComponent<Animator>().Play("AnimY");
        this.GetComponent<Animator>().Play("AnimZ");
        }
}