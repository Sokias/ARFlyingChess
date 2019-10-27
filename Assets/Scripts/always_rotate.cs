using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class always_rotate : MonoBehaviour {

    public float speed;
    public float x;
    public float y;
    public float z;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        roll();
    }

    void roll()
    {
        this.transform.Rotate(new Vector3(x, 0, 0) * speed);
        this.transform.Rotate(new Vector3(0, y, 0) * speed);
        this.transform.Rotate(new Vector3(0, 0, z) * speed);
    }

}
