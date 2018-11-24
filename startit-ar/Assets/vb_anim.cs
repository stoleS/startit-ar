using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObj;
    public GameObject canvas;
    public Animator sphereAni;
    private bool spawned = false;

	// Use this for initialization
	void Start () {
        vbBtnObj = GameObject.Find("spawnButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        sphereAni.GetComponent<Animator>();
        sphereAni.speed = 0f;
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        
        if(!spawned)
        {
            sphereAni.Play("sphere_anim", -1, 0f);
            sphereAni.speed = 1f;
            spawned = true;
        } else
        {
            sphereAni.Play("sphere_anim_exit", -1, 0f);
            spawned = false;          
        }
  
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) { }
	
	// Update is called once per frame
	void Update () {
		
	}
}
