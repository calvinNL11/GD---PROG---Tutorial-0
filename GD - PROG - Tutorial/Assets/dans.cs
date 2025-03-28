using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dans : MonoBehaviour
{
    Animator m_Animator;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Dans");
            //Reset the "Crouch" trigger
            m_Animator.SetTrigger("Dans");

        }
        
    }
}
