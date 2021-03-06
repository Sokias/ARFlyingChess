﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    //MAP_DATA
    public static Vector3[] blueArray = new Vector3[56] {
        new Vector3(-3.2f,.5f,-7f),
        new Vector3(-3.5f,.5f,-6f),
        new Vector3(-3.5f,.5f,-5f),
        new Vector3(-3.2f,.5f,-4f),
        new Vector3(-3.8f,.5f,-3.2f),
        new Vector3(-5f,.5f,-3.5f),
        new Vector3(-6f,.5f,-3.5f),
        new Vector3(-7f,.5f,-3f),
        new Vector3(-7.5f,.5f,-2f),
        new Vector3(-7.5f,.5f,-1f),
        new Vector3(-7.5f,.5f,-0f),
        new Vector3(-7.5f,.5f,1f),
        new Vector3(-7.5f,.5f,2f),
        new Vector3(-7f,.5f,3f),
        new Vector3(-6f,.5f,3.5f),
        new Vector3(-5f,.5f,3.5f),
        new Vector3(-4f,.5f,3.2f),
        new Vector3(-3.2f,.5f,3.8f),
        new Vector3(-3.5f,.5f,5f),
        new Vector3(-3.5f,.5f,6f),
        new Vector3(-3.2f,.5f,7f),
        new Vector3(-2f,.5f,7.5f),
        new Vector3(-1f,.5f,7.5f),
        new Vector3(0f,.5f,7.5f),
        new Vector3(1f,.5f,7.5f),
        new Vector3(2f,.5f,7.5f),
        new Vector3(3.2f,.5f,7f),
        new Vector3(3.5f,.5f,6f),
        new Vector3(3.5f,.5f,5f),
        new Vector3(3.2f,.5f,4f),
        new Vector3(3.8f,.5f,3.2f),
        new Vector3(5f,.5f,3.5f),
        new Vector3(6f,.5f,3.5f),
        new Vector3(7f,.5f,3f),
        new Vector3(7.5f,.5f,2f),
        new Vector3(7.5f,.5f,1f),
        new Vector3(7.5f,.5f,0f),
        new Vector3(7.5f,.5f,-1f),
        new Vector3(7.5f,.5f,-2f),
        new Vector3(7f,.5f,-3f),
        new Vector3(6f,.5f,-3.5f),
        new Vector3(5f,.5f,-3.5f),
        new Vector3(3.8f,.5f,-3.2f),
        new Vector3(3.2f,.5f,-4f),
        new Vector3(3.5f,.5f,-5f),
        new Vector3(3.5f,.5f,-6f),
        new Vector3(3.2f,.5f,-7f),
        new Vector3(2f,.5f,-7.5f),
        new Vector3(1f,.5f,-7.5f),
        new Vector3(0f,.5f,-7.5f),
        new Vector3(0f,.5f,-6f),
        new Vector3(0f,.5f,-5f),
        new Vector3(0f,.5f,-4f),
        new Vector3(0f,.5f,-3f),
        new Vector3(0f,.5f,-2f),
        new Vector3(0f,.5f,-1f),

    };
    public static Vector3[] yellowArray = new Vector3[56] {
        new Vector3(7f,0.5f,-3f),
new Vector3(6f,0.5f,-3.5f),
new Vector3(5f,0.5f,-3.5f),
new Vector3(3.8f,0.5f,-3.2f),
new Vector3(3.2f,0.5f,-4f),
new Vector3(3.5f,0.5f,-5f),
new Vector3(3.5f,0.5f,-6f),
new Vector3(3.2f,0.5f,-7f),
new Vector3(2f,0.5f,-7.5f),
new Vector3(1f,0.5f,-7.5f),
new Vector3(0f,0.5f,-7.5f),
new Vector3(-1f,0.5f,-7.5f),
new Vector3(-2f,0.5f,-7.5f),
new Vector3(-3.2f,0.5f,-7f),
new Vector3(-3.5f,0.5f,-6f),
new Vector3(-3.5f,0.5f,-5f),
new Vector3(-3.2f,0.5f,-4f),
new Vector3(-3.8f,0.5f,-3.2f),
new Vector3(-5f,0.5f,-3.5f),
new Vector3(-6f,0.5f,-3.5f),
new Vector3(-7f,0.5f,-3f),
new Vector3(-7.5f,0.5f,-2f),
new Vector3(-7.5f,0.5f,-1f),
new Vector3(-7.5f,0.5f,0f),
new Vector3(-7.5f,0.5f,1f),
new Vector3(-7.5f,0.5f,2f),
new Vector3(-7f,0.5f,3f),
new Vector3(-6f,0.5f,3.5f),
new Vector3(-5f,0.5f,3.5f),
new Vector3(-4f,0.5f,3.2f),
new Vector3(-3.2f,0.5f,3.8f),
new Vector3(-3.5f,0.5f,5f),
new Vector3(-3.5f,0.5f,6f),
new Vector3(-3.2f,0.5f,7f),
new Vector3(-2f,0.5f,7.5f),
new Vector3(-1f,0.5f,7.5f),
new Vector3(0f,0.5f,7.5f),
new Vector3(1f,0.5f,7.5f),
new Vector3(2f,0.5f,7.5f),
new Vector3(3.2f,0.5f,7f),
new Vector3(3.5f,0.5f,6f),
new Vector3(3.5f,0.5f,5f),
new Vector3(3.2f,0.5f,4f),
new Vector3(3.8f,0.5f,3.2f),
new Vector3(5f,0.5f,3.5f),
new Vector3(6f,0.5f,3.5f),
new Vector3(7f,0.5f,3f),
new Vector3(7.5f,0.5f,2f),
new Vector3(7.5f,0.5f,1f),
new Vector3(7.5f,0.5f,0f),
new Vector3(6f,0.5f,0f),
new Vector3(5f,0.5f,0f),
new Vector3(4f,0.5f,0f),
new Vector3(3f,0.5f,0f),
new Vector3(2f,0.5f,0f),
new Vector3(1f,0.5f,0f),
    };
    public static Vector3[] redArray = new Vector3[56] {
        new Vector3(3.2f,.5f,7f),
        new Vector3(3.5f,.5f,6f),
        new Vector3(3.5f,.5f,5f),
        new Vector3(3.2f,.5f,4f),
        new Vector3(3.8f,.5f,3.2f),
        new Vector3(5f,.5f,3.5f),
        new Vector3(6f,.5f,3.5f),
        new Vector3(7f,.5f,3f),
        new Vector3(7.5f,.5f,2f),
        new Vector3(7.5f,.5f,1f),
        new Vector3(7.5f,.5f,0f),
        new Vector3(7.5f,.5f,-1f),
        new Vector3(7.5f,.5f,-2f),
        new Vector3(7f,.5f,-3f),
        new Vector3(6f,.5f,-3.5f),
        new Vector3(5f,.5f,-3.5f),
        new Vector3(4f,.5f,-3.2f),
        new Vector3(3.2f,.5f,-3.8f),
        new Vector3(3.5f,.5f,-5f),
        new Vector3(3.5f,.5f,-6f),
        new Vector3(3.2f,.5f,-7f),
        new Vector3(2f,.5f,-7.5f),
        new Vector3(1f,.5f,-7.5f),
        new Vector3(0f,.5f,-7.5f),
        new Vector3(-1f,.5f,-7.5f),
        new Vector3(-2f,.5f,-7.5f),
        new Vector3(-3.2f,.5f,-7f),
        new Vector3(-3.5f,.5f,-6f),
        new Vector3(-3.5f,.5f,-5f),
        new Vector3(-3.2f,.5f,-4f),
        new Vector3(-3.8f,.5f,-3.2f),
        new Vector3(-5f,.5f,-3.5f),
        new Vector3(-6f,.5f,-3.5f),
        new Vector3(-7f,.5f,-3f),
        new Vector3(-7.5f,.5f,-2f),
        new Vector3(-7.5f,.5f,-1f),
        new Vector3(-7.5f,.5f,-0f),
        new Vector3(-7.5f,.5f,1f),
        new Vector3(-7.5f,.5f,2f),
        new Vector3(-7f,.5f,3f),
        new Vector3(-6f,.5f,3.5f),
        new Vector3(-5f,.5f,3.5f),
        new Vector3(-3.8f,.5f,3.2f),
        new Vector3(-3.2f,.5f,4f),
        new Vector3(-3.5f,.5f,5f),
        new Vector3(-3.5f,.5f,6f),
        new Vector3(-3.2f,.5f,7f),
        new Vector3(-2f,.5f,7.5f),
        new Vector3(-1f,.5f,7.5f),
        new Vector3(0f,.5f,7.5f),
        new Vector3(0f,.5f,6f),
        new Vector3(0f,.5f,5f),
        new Vector3(0f,.5f,4f),
        new Vector3(0f,.5f,3f),
        new Vector3(0f,.5f,2f),
        new Vector3(0f,.5f,1f),

    };
    public static Vector3[] greenArray = new Vector3[56] {
new Vector3(-7f,0.5f,3f),
new Vector3(-6f,0.5f,3.5f),
new Vector3(-5f,0.5f,3.5f),
new Vector3(-3.8f,0.5f,3.2f),
new Vector3(-3.2f,0.5f,4f),
new Vector3(-3.5f,0.5f,5f),
new Vector3(-3.5f,0.5f,6f),
new Vector3(-3.2f,0.5f,7f),
new Vector3(-2f,0.5f,7.5f),
new Vector3(-1f,0.5f,7.5f),
new Vector3(-0f,0.5f,7.5f),
new Vector3(1f,0.5f,7.5f),
new Vector3(2f,0.5f,7.5f),
new Vector3(3.2f,0.5f,7f),
new Vector3(3.5f,0.5f,6f),
new Vector3(3.5f,0.5f,5f),
new Vector3(3.2f,0.5f,4f),
new Vector3(3.8f,0.5f,3.2f),
new Vector3(5f,0.5f,3.5f),
new Vector3(6f,0.5f,3.5f),
new Vector3(7f,0.5f,3f),
new Vector3(7.5f,0.5f,2f),
new Vector3(7.5f,0.5f,1f),
new Vector3(7.5f,0.5f,-0f),
new Vector3(7.5f,0.5f,-1f),
new Vector3(7.5f,0.5f,-2f),
new Vector3(7f,0.5f,-3f),
new Vector3(6f,0.5f,-3.5f),
new Vector3(5f,0.5f,-3.5f),
new Vector3(4f,0.5f,-3.2f),
new Vector3(3.2f,0.5f,-3.8f),
new Vector3(3.5f,0.5f,-5f),
new Vector3(3.5f,0.5f,-6f),
new Vector3(3.2f,0.5f,-7f),
new Vector3(2f,0.5f,-7.5f),
new Vector3(1f,0.5f,-7.5f),
new Vector3(-0f,0.5f,-7.5f),
new Vector3(-1f,0.5f,-7.5f),
new Vector3(-2f,0.5f,-7.5f),
new Vector3(-3.2f,0.5f,-7f),
new Vector3(-3.5f,0.5f,-6f),
new Vector3(-3.5f,0.5f,-5f),
new Vector3(-3.2f,0.5f,-4f),
new Vector3(-3.8f,0.5f,-3.2f),
new Vector3(-5f,0.5f,-3.5f),
new Vector3(-6f,0.5f,-3.5f),
new Vector3(-7f,0.5f,-3f),
new Vector3(-7.5f,0.5f,-2f),
new Vector3(-7.5f,0.5f,-1f),
new Vector3(-7.5f,0.5f,-0f),
new Vector3(-6f,0.5f,-0f),
new Vector3(-5f,0.5f,-0f),
new Vector3(-4f,0.5f,-0f),
new Vector3(-3f,0.5f,-0f),
new Vector3(-2f,0.5f,-0f),
new Vector3(-1f,0.5f,-0f),

    };

    //记录上一个index，以便算出下一个index。
    public static int r1 = -1, r2 = -1, r3 = -1, r4 = -1;
    public static int g1 = -1, g2 = -1, g3 = -1, g4 = -1;
    public static int b1 = -1, b2 = -1, b3 = -1, b4 = -1;
    public static int y1 = -1, y2 = -1, y3 = -1, y4 = -1;

    //各个棋子的起始位置
    public static Vector3 startPosR1 = new Vector3(6f, 0.7f,7f);
    public static Vector3 startPosR2 = new Vector3(6f, 0.7f, 6f);
    public static Vector3 startPosR3 = new Vector3(7f, 0.7f, 7f);
    public static Vector3 startPosR4 = new Vector3(7f, 0.7f, 6f);

    public static Vector3 startPosG1 = new Vector3(-7f, 0.7f, 6f);
    public static Vector3 startPosG2 = new Vector3(-6f, 0.7f, 6f);
    public static Vector3 startPosG3 = new Vector3(-7f, 0.7f, 7f);
    public static Vector3 startPosG4 = new Vector3(-6f, 0.7f, 7f);

    public static Vector3 startPosB1 = new Vector3(-6f, 0.7f, -7f);
    public static Vector3 startPosB2 = new Vector3(-6f, 0.7f, -6f);
    public static Vector3 startPosB3 = new Vector3(-7f, 0.7f, -7f);
    public static Vector3 startPosB4 = new Vector3(-7f, 0.7f, -6f);

    public static Vector3 startPosY1 = new Vector3(7f, 0.7f, -6f);
    public static Vector3 startPosY2 = new Vector3(6f, 0.7f, -6f);
    public static Vector3 startPosY3 = new Vector3(7f, 0.7f, -7f);
    public static Vector3 startPosY4 = new Vector3(6f, 0.7f, -7f);

}
