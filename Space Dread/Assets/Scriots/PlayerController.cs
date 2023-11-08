using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private double temp;
    public TextMeshProUGUI countText;

    // Start is called before the first frame update
    void Start()
    {
        temp = 50;
        SetTempText();
    }

    // Update is called once per frame
    void Update()
    {
        temp += 0.001;
        SetTempText();
    }

    //Displays current temp
 void SetTempText() 
    {
        countText.text = "Temp: " + ((int)temp).ToString();

 if (temp >= 150)
        {
 // Display the lose text.
            //loseTextObject.SetActive(true);
        }
    }
}
