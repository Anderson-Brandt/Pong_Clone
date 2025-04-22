using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text goalLeftTxt;
    public Text goalRightTxt;

    public int pointLeft;
    public int pointRight;

    public static Points points;
    // Start is called before the first frame update
    void Start()
    {
        points = this;
    }

    public void AddLeftPoints()
    {
        pointLeft++;
        goalLeftTxt.text = pointLeft.ToString();
    }

    public void AddRightPoints()
    {
        pointRight++;
        goalRightTxt.text = pointRight.ToString();
    }

}
