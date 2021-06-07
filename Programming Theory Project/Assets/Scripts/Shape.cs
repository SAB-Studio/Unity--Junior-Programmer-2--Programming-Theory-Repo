using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public abstract class Shape : MonoBehaviour
{
    public GameObject infoPopup;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI colorText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            infoPopup.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        infoPopup.SetActive(true);
        DisplayText();
    }

    public virtual void DisplayText()
    {
        nameText.text = "";
        colorText.text = "";
        infoPopup.transform.position = transform.position;
    }
}
