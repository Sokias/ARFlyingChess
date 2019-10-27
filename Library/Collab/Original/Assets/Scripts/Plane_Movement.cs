using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
///using System.Timers;

public class Plane_Movement : MonoBehaviour
{

    float chessState;
    GameObject startObj;
    Vector3 endPos;
    ////Vector3 rotateVector;
    float time = 2f;
    float speed = 0;
    int[] special_smalljump = new int[12] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45 };

    // Use this for initialization
    void Start()
    {
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
        }

        //startObj.transform.LookAt(endPos);
        startObj.transform.forward = -(endPos - startObj.transform.position);
        Vector3 old_pos = startObj.transform.position;
        startObj.transform.localPosition = Vector3.MoveTowards(startObj.transform.localPosition, endPos, speed * Time.deltaTime);
        Vector3 new_pos = startObj.transform.position;

        if(new_pos != old_pos)
            startObj.transform.forward = new_pos - old_pos;
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
        yield return new WaitForSeconds(2.1f);
        if (checkifinArray(special_smalljump, index))
        {
            if (index == 17) number += 8;
            movePlane(o, array, index, number);
        }
    }

    void movePlane(GameObject o, Vector3[] positionArray, int index, int num_steps)
    {

        Debug.Log(index);

        //此时的位置在array中的index
        int presentIndex = index;
        //加上骰子点数之后的index
        int futureIndex = presentIndex + num_steps;
        Debug.Log(futureIndex);
        if (futureIndex < 56)
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

            endPos = futurePosition;
            speed = Vector3.Distance(o.transform.localPosition, endPos) / time;
            startObj = o;

        }
        else
        {
            Destroy(o);
        }

    }
}
