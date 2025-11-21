using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkcykle : MonoBehaviour
{
    Animator tyrasAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tyrasAnimator = GetComponent<Animator>();

        tyrasAnimator.SetBool("Walk", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            tyrasAnimator.SetBool("Walk", true);
        }
        
        if (Input.GetKeyUp("d"))
        {
            tyrasAnimator.SetBool("Walk", false);
        }
    }
}
