using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour {

    public GameObject d_roll;
    public GameObject d_1;
    public GameObject d_2;
    public GameObject d_3;
    public GameObject d_4;
    public GameObject d_5;
    public GameObject d_6;
    public static DiceRoll var;
    public int steps;
    public bool isRoll = false;

    // Use this for initialization
    void Start () {
        reset();
    }
	
  
	// Update is called once per frame
	void Update () {
        if (this.GetComponentInChildren<MeshRenderer>().enabled)
        {
            if (!isRoll) rollTheDice();
        }
        else
        {
            reset();
        }
    }

    void rollTheDice()
    {
        d_roll.gameObject.SetActive(true);
        steps = Random.Range(1, 7);
        global.diceNumber = steps;
        Invoke("rollprocess", 1.0f);
    }

    void rollprocess()
    {
        switch (steps)
        {
            case 1:
                d_roll.gameObject.SetActive(false);
                d_1.gameObject.SetActive(true);
                break;
            case 2:
                d_roll.gameObject.SetActive(false);
                d_2.gameObject.SetActive(true);
                break;
            case 3:
                d_roll.gameObject.SetActive(false);
                d_3.gameObject.SetActive(true);
                break;
            case 4:
                d_roll.gameObject.SetActive(false);
                d_4.gameObject.SetActive(true);
                break;
            case 5:
                d_roll.gameObject.SetActive(false);
                d_5.gameObject.SetActive(true);
                break;
            case 6:
                d_roll.gameObject.SetActive(false);
                d_6.gameObject.SetActive(true);
                break;
        }

        isRoll = true;
        num_instruction.Instance.ShowNumIns();

    }

    void reset()
    {
        d_1.gameObject.SetActive(false);
        d_2.gameObject.SetActive(false);
        d_3.gameObject.SetActive(false);
        d_4.gameObject.SetActive(false);
        d_5.gameObject.SetActive(false);
        d_6.gameObject.SetActive(false);
        d_roll.gameObject.SetActive(false);
        isRoll = false;
    }

}
