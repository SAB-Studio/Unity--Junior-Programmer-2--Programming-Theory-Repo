using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ShapeDatas : Shape// INHERITANCE
{
    public string name { get; private set; }// = "Sphere";// ENCAPSULATION
    public string color { get; private set; }// ENCAPSULATION

    public override void DisplayText()// POLYMORPHISM // ABSTRACTION
    {
        
        name = gameObject.name;
        nameText.text = name;

        if (gameObject.name == "Cube")
        {
            color = "Red";
        }
        else if (gameObject.name == "Sphere")
        {
            color = "Green";
        }

        else if (gameObject.name == "Capsule")
        {
            color = "Blue";
        }
        colorText.text = color;

        Vector3 offset = new Vector3(0, 3, 0);
        infoPopup.transform.position = gameObject.transform.position + offset;
    }
}