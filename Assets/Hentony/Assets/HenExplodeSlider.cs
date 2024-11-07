using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HenExplodeSlider : MonoBehaviour
{
    Animator anim;
    public Slider animSlider;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.Play("Explode", -1, animSlider.value);
    }
}
