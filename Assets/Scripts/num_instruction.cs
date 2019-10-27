using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class num_instruction : MonoBehaviour {

    GameObject RN1, RN2, RN3, RN4, BN1, BN2, BN3, BN4, GN1, GN2, GN3, GN4, YN1, YN2, YN3, YN4;
    private static num_instruction num_ins;
    public static num_instruction Instance
    {
        get
        {
            return num_ins;
        }
    }
	// Use this for initialization
	void Start () {
        num_ins = this;
        RN1 = GameObject.Find("RN1");
        RN2 = GameObject.Find("RN2");
        RN3 = GameObject.Find("RN3");
        RN4 = GameObject.Find("RN4");

        BN1 = GameObject.Find("BN1");
        BN2 = GameObject.Find("BN2");
        BN3 = GameObject.Find("BN3");
        BN4 = GameObject.Find("BN4");

        GN1 = GameObject.Find("GN1");
        GN2 = GameObject.Find("GN2");
        GN3 = GameObject.Find("GN3");
        GN4 = GameObject.Find("GN4");

        YN1 = GameObject.Find("YN1");
        YN2 = GameObject.Find("YN2");
        YN3 = GameObject.Find("YN3");
        YN4 = GameObject.Find("YN4");

        HideNumIns();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void ShowNumIns()
    {
        if (GameObject.Find("RedPlane1") != null) RN1.SetActive(true);
        if (GameObject.Find("RedPlane2") != null) RN2.SetActive(true);
        if (GameObject.Find("RedPlane3") != null) RN3.SetActive(true);
        if (GameObject.Find("RedPlane4") != null) RN4.SetActive(true);

        if (GameObject.Find("YellowPlane1") != null) YN1.SetActive(true);
        if (GameObject.Find("YellowPlane2") != null) YN2.SetActive(true);
        if (GameObject.Find("YellowPlane3") != null) YN3.SetActive(true);
        if (GameObject.Find("YellowPlane4") != null) YN4.SetActive(true);

        if (GameObject.Find("GreenPlane1") != null) GN1.SetActive(true);
        if (GameObject.Find("GreenPlane2") != null) GN2.SetActive(true);
        if (GameObject.Find("GreenPlane3") != null) GN3.SetActive(true);
        if (GameObject.Find("GreenPlane4") != null) GN4.SetActive(true);

        if (GameObject.Find("BluePlane1") != null) BN1.SetActive(true);
        if (GameObject.Find("BluePlane2") != null) BN2.SetActive(true);
        if (GameObject.Find("BluePlane3") != null) BN3.SetActive(true);
        if (GameObject.Find("BluePlane4") != null) BN4.SetActive(true);
    }

    public void HideNumIns()
    {
        if (GameObject.Find("RedPlane1") != null) RN1.SetActive(false);
        if (GameObject.Find("RedPlane2") != null) RN2.SetActive(false);
        if (GameObject.Find("RedPlane3") != null) RN3.SetActive(false);
        if (GameObject.Find("RedPlane4") != null) RN4.SetActive(false);

        if (GameObject.Find("YellowPlane1") != null) YN1.SetActive(false);
        if (GameObject.Find("YellowPlane2") != null) YN2.SetActive(false);
        if (GameObject.Find("YellowPlane3") != null) YN3.SetActive(false);
        if (GameObject.Find("YellowPlane4") != null) YN4.SetActive(false);

        if (GameObject.Find("GreenPlane1") != null) GN1.SetActive(false);
        if (GameObject.Find("GreenPlane2") != null) GN2.SetActive(false);
        if (GameObject.Find("GreenPlane3") != null) GN3.SetActive(false);
        if (GameObject.Find("GreenPlane4") != null) GN4.SetActive(false);

        if (GameObject.Find("BluePlane1") != null) BN1.SetActive(false);
        if (GameObject.Find("BluePlane2") != null) BN2.SetActive(false);
        if (GameObject.Find("BluePlane3") != null) BN3.SetActive(false);
        if (GameObject.Find("BluePlane4") != null) BN4.SetActive(false);
    }

}
