using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class focus : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vuforia.CameraDevice.Instance.SetFocusMode(Vuforia.CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
