using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd2333 : MonoBehaviour {

    public Camera cam;
    public GameObject pr;
    public GameObject py;
    public GameObject pg;
    public GameObject pb;
    // We need to actually hit an object
    RaycastHit hitt = new RaycastHit();


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out hitt, 100);
        //    Debug.DrawLine(cam.transform.position, ray.direction,Color.red);
        if (null != hitt.transform)
        {
            ////print(hitt.point);//鼠标点击的坐标
            pr.transform.LookAt(hitt.point);
            pg.transform.LookAt(hitt.point);
            py.transform.LookAt(hitt.point);
            pb.transform.LookAt(hitt.point);
        }
    }
}
