using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.GetComponentInChildren<MeshRenderer>().enabled)
            global.nextChess = 2.2F;

    }
}
