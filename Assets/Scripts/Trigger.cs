using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    private GameObject R1, R2, R3, R4, B1, B2, B3, B4, G1, G2, G3, G4, Y1, Y2, Y3, Y4;
    public Plane_Movement p;
    // Use this for initialization
    void Start() {
        this.gameObject.SetActive(true);
        R1 = GameObject.Find("RedPlane1");
        R2 = GameObject.Find("RedPlane2");
        R3 = GameObject.Find("RedPlane3");
        R4 = GameObject.Find("RedPlane4");
        B1 = GameObject.Find("BluePlane1");
        B2 = GameObject.Find("BluePlane2");
        B3 = GameObject.Find("BluePlane3");
        B4 = GameObject.Find("BluePlane4");
        Y1 = GameObject.Find("YellowPlane1");
        Y2 = GameObject.Find("YellowPlane2");
        Y3 = GameObject.Find("YellowPlane3");
        Y4 = GameObject.Find("YellowPlane4");
        G1 = GameObject.Find("GreenPlane1");
        G2 = GameObject.Find("GreenPlane2");
        G3 = GameObject.Find("GreenPlane3");
        G4 = GameObject.Find("GreenPlane4");
    }




    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider other)
    {
        // If we aren't currently the plane that is moving...
        // Do nothing.
        if (Plane_Movement.Instance.startObj != gameObject)
            return;

        //print(other.GetComponentInParent<GameObject>().name);
        switch (other.name)
        {
            case "RedPlane1":
                // Plane_Movement.Instance.startObj = R1;
                StartCoroutine(SetNewStartObj(R1));
                Plane_Movement.Instance.endPos2 = array.startPosR1;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.r1 = -1;
                break;
            case "RedPlane2":
                StartCoroutine(SetNewStartObj(R2));
                Plane_Movement.Instance.endPos2 = array.startPosR2;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.r2 = -1;
                break;
            case "RedPlane3":
                StartCoroutine(SetNewStartObj(R3));
                Plane_Movement.Instance.endPos2 = array.startPosR3;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.r3 = -1;
                break;
            case "RedPlane4":
                StartCoroutine(SetNewStartObj(R4));
                Plane_Movement.Instance.endPos2 = array.startPosR4;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.r4 = -1;
                break;

            case "GreenPlane1":
                StartCoroutine(SetNewStartObj(G1));
                Plane_Movement.Instance.endPos2 = array.startPosG1;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.g1 = -1;
                break;
            case "GreenPlane2":
                StartCoroutine(SetNewStartObj(G2));
                Plane_Movement.Instance.endPos2 = array.startPosG2;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.g2 = -1;
                break;
            case "GreenPlane3":
                StartCoroutine(SetNewStartObj(G3));
                Plane_Movement.Instance.endPos2 = array.startPosG3;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.g3 = -1;
                break;
            case "GreenPlane4":
                StartCoroutine(SetNewStartObj(G4));
                Plane_Movement.Instance.endPos2 = array.startPosG4;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.g4 = -1;
                break;

            case "YellowPlane1":
                StartCoroutine(SetNewStartObj(Y1));
                Plane_Movement.Instance.endPos2 = array.startPosY1;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.y1 = -1;
                break;
            case "YellowPlane2":
                StartCoroutine(SetNewStartObj(Y2));
                Plane_Movement.Instance.endPos2 = array.startPosY2;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.y2 = -1;
                break;
            case "YellowPlane3":
                StartCoroutine(SetNewStartObj(Y3));
                Plane_Movement.Instance.endPos2 = array.startPosY3;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.y3 = -1;
                break;
            case "YellowPlane4":
                StartCoroutine(SetNewStartObj(Y4));
                Plane_Movement.Instance.endPos2 = array.startPosY4;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.y4 = -1;
                break;

            case "BluePlane1":
                StartCoroutine(SetNewStartObj(B1));
                Plane_Movement.Instance.endPos2 = array.startPosB1;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.b1 = -1;
                break;
            case "BluePlane2":
                StartCoroutine(SetNewStartObj(B2));
                Plane_Movement.Instance.endPos2 = array.startPosB2;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.b2 = -1;
                break;
            case "BluePlane3":
                StartCoroutine(SetNewStartObj(B3));
                Plane_Movement.Instance.endPos2 = array.startPosB3;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.b3 = -1;
                break;
            case "BluePlane4":
                StartCoroutine(SetNewStartObj(B4));
                Plane_Movement.Instance.endPos2 = array.startPosB4;
                Plane_Movement.Instance.speed2 = Vector3.Distance(other.transform.localPosition, Plane_Movement.Instance.endPos2) / 2.0f;
                array.b4 = -1;
                break;
        }

        StartCoroutine(setObject2null());
    }

    IEnumerator SetNewStartObj(GameObject g)
    {
        yield return new WaitForEndOfFrame();
        //yield return new WaitForSeconds(0.5f);
        Plane_Movement.Instance.startObj2 = g;
    }

    IEnumerator setObject2null()
    {
        yield return new WaitForSeconds(2.01f);
        Plane_Movement.Instance.startObj2 = null;
    }
}
