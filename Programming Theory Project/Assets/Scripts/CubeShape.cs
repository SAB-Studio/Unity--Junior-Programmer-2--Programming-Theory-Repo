using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CubeShape : Shape
{
    public string name { get; private set; } = "Cube";
    public string color { get; private set; } = "Red";

    public override void DisplayText()
    {
        nameText.text = name;
        colorText.text = color;

        Vector3 offset = new Vector3(0, 3, 0);
        infoPopup.transform.position = gameObject.transform.position + offset;
    }
}
