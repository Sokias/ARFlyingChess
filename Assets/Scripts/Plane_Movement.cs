using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
///using System.Timers;

public class Plane_Movement : MonoBehaviour
{
    public GameObject crown;
    public GameObject board;
    private num_instruction num_ins;
    private static Plane_Movement _inst;
    public static Plane_Movement Instance
    {
        get
        {
            return _inst;
        }
    }
    float chessState;
    public GameObject startObj;
    public Vector3 endPos;
    public GameObject startObj2;
    public Vector3 endPos2;
    ////Vector3 rotateVector;
    float time = 2f;
    public float speed = 0;
    public float speed2 = 0;
    int[] special_smalljump = new int[12] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45 };

    // Use this for initialization
    void Start()
    {
        _inst=this;

        chessState = global.nextChess;
    }

    // Update is called once per frame
    void Update()
    {
        float newChessState = global.nextChess;
        if (newChessState != chessState)
        {
            chessState = newChessState;
            switchCase(newChessState);
            //DiceRoll.var.isRoll = false;
        }

        // Orientation of planes
        if (startObj != null)
        {
            //startObj.transform.forward = -(endPos - startObj.transform.position);

            //Vector3 old_pos = startObj.transform.position;
            startObj.transform.localPosition = Vector3.MoveTowards(startObj.transform.localPosition, endPos, speed * Time.deltaTime);
            //Vector3 new_pos = startObj.transform.position;

            //if (endPos != old_pos)
            //    startObj.transform.forward = -(endPos - old_pos);
        }

        if (startObj2 != null)
        {
            startObj2.transform.localPosition = Vector3.MoveTowards(startObj2.transform.localPosition, endPos2, speed2 * Time.deltaTime);

        }
    }


    bool checkifinArray(int[] array, int num)
    {
        foreach (int i in array)
        {
            if (i == num)
            {
                return true;
            }
        }
        return false;
    }

    void switchCase(float chessState)
    {
        Debug.Log(chessState.ToString());
        // to move
        num_instruction.Instance.HideNumIns();
        switch (chessState.ToString())
        {
            case "1.1":
                movePlane(GameObject.Find("RedPlane1"), array.redArray, array.r1, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("RedPlane1"), array.redArray, array.r1, 4));
                break;
            case "1.2":
                movePlane(GameObject.Find("RedPlane2"), array.redArray, array.r2, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("RedPlane2"), array.redArray, array.r2, 4));
                break;
            case "1.3":
                movePlane(GameObject.Find("RedPlane3"), array.redArray, array.r3, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("RedPlane3"), array.redArray, array.r3, 4));
                break;
            case "1.4":
                movePlane(GameObject.Find("RedPlane4"), array.redArray, array.r4, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("RedPlane4"), array.redArray, array.r4, 4));
                break;

            case "2.1":
                movePlane(GameObject.Find("YellowPlane1"), array.yellowArray, array.y1, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("YellowPlane1"), array.yellowArray, array.y1, 4));
                break;
            case "2.2":
                movePlane(GameObject.Find("YellowPlane2"), array.yellowArray, array.y2, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("YellowPlane2"), array.yellowArray, array.y2, 4));
                break;
            case "2.3":
                movePlane(GameObject.Find("YellowPlane3"), array.yellowArray, array.y3, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("YellowPlane3"), array.yellowArray, array.y3, 4));
                break;
            case "2.4":
                movePlane(GameObject.Find("YellowPlane4"), array.yellowArray, array.y4, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("YellowPlane4"), array.yellowArray, array.y4, 4));
                break;

            case "3.1":
                movePlane(GameObject.Find("BluePlane1"), array.blueArray, array.b1, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("BluePlane1"), array.blueArray, array.b1, 4));
                break;
            case "3.2":
                movePlane(GameObject.Find("BluePlane2"), array.blueArray, array.b2, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("BluePlane2"), array.blueArray, array.b2, 4));
                break;
            case "3.3":
                movePlane(GameObject.Find("BluePlane3"), array.blueArray, array.b3, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("BluePlane3"), array.blueArray, array.b3, 4));
                break;
            case "3.4":
                movePlane(GameObject.Find("BluePlane4"), array.blueArray, array.b4, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("BluePlane4"), array.blueArray, array.b4, 4));
                break;

            case "4.1":
                movePlane(GameObject.Find("GreenPlane1"), array.greenArray, array.g1, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("GreenPlane1"), array.greenArray, array.g1, 4));
                break;
            case "4.2":
                movePlane(GameObject.Find("GreenPlane2"), array.greenArray, array.g2, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("GreenPlane2"), array.greenArray, array.g2, 4));
                break;
            case "4.3":
                movePlane(GameObject.Find("GreenPlane3"), array.greenArray, array.g3, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("GreenPlane3"), array.greenArray, array.g3, 4));
                break;
            case "4.4":
                movePlane(GameObject.Find("GreenPlane4"), array.greenArray, array.g4, global.diceNumber);
                StartCoroutine(specialCaseJump(GameObject.Find("GreenPlane4"), array.greenArray, array.g4, 4));
                break;
        }
    }

    IEnumerator specialCaseJump(GameObject o, Vector3[] array, int index, int number)
    {
        yield return new WaitForSeconds(2f);
        if (checkifinArray(special_smalljump, index))
        {
            if (index == 17) number += 8;
            movePlane(o, array, index, number);
        }
    }


    //index是当前位置,num_steps是要走的步数
    void movePlane(GameObject o, Vector3[] positionArray, int index, int num_steps)
    {
        
        Debug.Log(index);

        //此时的位置在array中的index
        int presentIndex = index;
        //加上骰子点数之后的index
        int futureIndex = presentIndex + num_steps;
        Debug.Log(futureIndex);
        if (futureIndex < 55)
        {
            //更新index
            switch (o.name)
            {
                case "RedPlane1":
                    array.r1 = futureIndex;
                    break;
                case "RedPlane2":
                    array.r2 = futureIndex;
                    break;
                case "RedPlane3":
                    array.r3 = futureIndex;
                    break;
                case "RedPlane4":
                    array.r4 = futureIndex;
                    break;
                case "YellowPlane1":
                    array.y1 = futureIndex;
                    break;
                case "YellowPlane2":
                    array.y2 = futureIndex;
                    break;
                case "YellowPlane3":
                    array.y3 = futureIndex;
                    break;
                case "YellowPlane4":
                    array.y4 = futureIndex;
                    break;
                case "GreenPlane1":
                    array.g1 = futureIndex;
                    break;
                case "GreenPlane2":
                    array.g2 = futureIndex;
                    break;
                case "GreenPlane3":
                    array.g3 = futureIndex;
                    break;
                case "GreenPlane4":
                    array.g4 = futureIndex;
                    break;
                case "BluePlane1":
                    array.b1 = futureIndex;
                    break;
                case "BluePlane2":
                    array.b2 = futureIndex;
                    break;
                case "BluePlane3":
                    array.b3 = futureIndex;
                    break;
                case "BluePlane4":
                    array.b4 = futureIndex;
                    break;

            }

            //通过array得到要去的位置
            Vector3 futurePosition = positionArray[futureIndex];

            o.GetComponent<Rigidbody>().velocity = new Vector3(0, 0.5f, 0);
            StartCoroutine(disableGravity(o));

            endPos = futurePosition;
            speed = Vector3.Distance(o.transform.localPosition, endPos) / time;
            startObj = o;
            float x1 = o.transform.position.x;
            float x2 = endPos.x;
            float y1 = o.transform.position.y;
            float y2 = endPos.y;
            //o.transform.localRotation=new Quaternion(0, Convert.ToSingle(Math.Atan((y1-y2)/(x1-x2))) ,0,0);
            o.transform.LookAt(endPos - o.transform.localPosition);
            //o.GetComponent<Trigger>().enabled = true;
            //StartCoroutine(disableTrigger(o));
        }

        //飞机刚好飞到终点
        else if (futureIndex == 55)
        {
            //update index
            switch (o.name)
            {
                case "RedPlane1":
                    array.r1 = futureIndex;
                    break;
                case "RedPlane2":
                    array.r2 = futureIndex;
                    break;
                case "RedPlane3":
                    array.r3 = futureIndex;
                    break;
                case "RedPlane4":
                    array.r4 = futureIndex;
                    break;
                case "YellowPlane1":
                    array.y1 = futureIndex;
                    break;
                case "YellowPlane2":
                    array.y2 = futureIndex;
                    break;
                case "YellowPlane3":
                    array.y3 = futureIndex;
                    break;
                case "YellowPlane4":
                    array.y4 = futureIndex;
                    break;
                case "GreenPlane1":
                    array.g1 = futureIndex;
                    break;
                case "GreenPlane2":
                    array.g2 = futureIndex;
                    break;
                case "GreenPlane3":
                    array.g3 = futureIndex;
                    break;
                case "GreenPlane4":
                    array.g4 = futureIndex;
                    break;
                case "BluePlane1":
                    array.b1 = futureIndex;
                    break;
                case "BluePlane2":
                    array.b2 = futureIndex;
                    break;
                case "BluePlane3":
                    array.b3 = futureIndex;
                    break;
                case "BluePlane4":
                    array.b4 = futureIndex;
                    break;

            }

            //通过array得到要去的位置
            Vector3 futurePosition = positionArray[55];

            o.GetComponent<Rigidbody>().velocity=new Vector3(0,0.5f,0);
            StartCoroutine(disableGravity(o));

            endPos = futurePosition;
            speed = Vector3.Distance(o.transform.localPosition, endPos) / time;
            startObj = o;

            //win
            switch (o.name)
            {
                case "RedPlane1":
                    StartCoroutine(win(o, array.startPosR1));
                    break;
                case "RedPlane2":
                    StartCoroutine(win(o, array.startPosR2));
                    break;
                case "RedPlane3":
                    StartCoroutine(win(o, array.startPosR3));
                    break;
                case "RedPlane4":
                    StartCoroutine(win(o, array.startPosR4));
                    break;
                case "YellowPlane1":
                    StartCoroutine(win(o, array.startPosY1));
                    break;
                case "YellowPlane2":
                    StartCoroutine(win(o, array.startPosY2));
                    break;
                case "YellowPlane3":
                    StartCoroutine(win(o, array.startPosY3));
                    break;
                case "YellowPlane4":
                    StartCoroutine(win(o, array.startPosY4));
                    break;
                case "GreenPlane1":
                    StartCoroutine(win(o, array.startPosG1));
                    break;
                case "GreenPlane2":
                    StartCoroutine(win(o, array.startPosG2));
                    break;
                case "GreenPlane3":
                    StartCoroutine(win(o, array.startPosG3));
                    break;
                case "GreenPlane4":
                    StartCoroutine(win(o, array.startPosG4));
                    break;
                case "BluePlane1":
                    StartCoroutine(win(o, array.startPosB1));
                    break;
                case "BluePlane2":
                    StartCoroutine(win(o, array.startPosB2));
                    break;
                case "BluePlane3":
                    StartCoroutine(win(o, array.startPosB3));
                    break;
                case "BluePlane4":
                    StartCoroutine(win(o, array.startPosB4));
                    break;
            }
        }
        else{
            Vector3 futurePosition = positionArray[55];

            o.GetComponent<Rigidbody>().velocity = new Vector3(0, 0.5f, 0);
            StartCoroutine(disableGravity(o));
            //update index
            switch (o.name)
            {
                case "RedPlane1":
                    array.r1 = futureIndex;
                    break;
                case "RedPlane2":
                    array.r2 = futureIndex;
                    break;
                case "RedPlane3":
                    array.r3 = futureIndex;
                    break;
                case "RedPlane4":
                    array.r4 = futureIndex;
                    break;
                case "YellowPlane1":
                    array.y1 = futureIndex;
                    break;
                case "YellowPlane2":
                    array.y2 = futureIndex;
                    break;
                case "YellowPlane3":
                    array.y3 = futureIndex;
                    break;
                case "YellowPlane4":
                    array.y4 = futureIndex;
                    break;
                case "GreenPlane1":
                    array.g1 = futureIndex;
                    break;
                case "GreenPlane2":
                    array.g2 = futureIndex;
                    break;
                case "GreenPlane3":
                    array.g3 = futureIndex;
                    break;
                case "GreenPlane4":
                    array.g4 = futureIndex;
                    break;
                case "BluePlane1":
                    array.b1 = futureIndex;
                    break;
                case "BluePlane2":
                    array.b2 = futureIndex;
                    break;
                case "BluePlane3":
                    array.b3 = futureIndex;
                    break;
                case "BluePlane4":
                    array.b4 = futureIndex;
                    break;

            }

            int a = 55 - index;
            endPos = futurePosition;
            speed = Vector3.Distance(o.transform.localPosition, endPos) / time;
            startObj = o;

            StartCoroutine(overIndex(o, positionArray, index, num_steps - a -a));

        }

    }


    IEnumerator disableTrigger(GameObject o)
    {
        yield return new WaitForSeconds(2.5f);
        o.GetComponent<Trigger>().enabled = false;
    }

    IEnumerator overIndex(GameObject o, Vector3[] positionArray, int index, int steps)
    {
        yield return new WaitForSeconds(2f);
        int presentIndex = index;
        //加上骰子点数之后的index
        int futureIndex = presentIndex - steps;
        //update index
        switch (o.name)
        {
            case "RedPlane1":
                array.r1 = futureIndex;
                break;
            case "RedPlane2":
                array.r2 = futureIndex;
                break;
            case "RedPlane3":
                array.r3 = futureIndex;
                break;
            case "RedPlane4":
                array.r4 = futureIndex;
                break;
            case "YellowPlane1":
                array.y1 = futureIndex;
                break;
            case "YellowPlane2":
                array.y2 = futureIndex;
                break;
            case "YellowPlane3":
                array.y3 = futureIndex;
                break;
            case "YellowPlane4":
                array.y4 = futureIndex;
                break;
            case "GreenPlane1":
                array.g1 = futureIndex;
                break;
            case "GreenPlane2":
                array.g2 = futureIndex;
                break;
            case "GreenPlane3":
                array.g3 = futureIndex;
                break;
            case "GreenPlane4":
                array.g4 = futureIndex;
                break;
            case "BluePlane1":
                array.b1 = futureIndex;
                break;
            case "BluePlane2":
                array.b2 = futureIndex;
                break;
            case "BluePlane3":
                array.b3 = futureIndex;
                break;
            case "BluePlane4":
                array.b4 = futureIndex;
                break;

        }

        Vector3 futurePosition = positionArray[futureIndex];

        endPos = futurePosition;
        speed = Vector3.Distance(o.transform.localPosition, endPos) / time;
        startObj = o;

    }

    IEnumerator win(GameObject go, Vector3 startingPos)
    {
        yield return new WaitForSeconds(2f);
        Destroy(go);
        Instantiate(crown, startingPos/5, Quaternion.identity, GameObject.Find("board").transform);
    }

    IEnumerator disableGravity(GameObject o)
    {
        yield return new WaitForSeconds(0.75f);
        o.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    /**public void setStartObj(GameObject o)
    {
        startObj = o;
    }
    public void setEndpos(Vector3 o)
    {
        endPos = o;
    }
    public void setSpeed(float o)
    {
        speed = o;
    }**/


}
