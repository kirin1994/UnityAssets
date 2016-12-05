﻿using UnityEngine;

public class WizardScript : MonoBehaviour {

    static Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("Jump");
        }
	}
}
