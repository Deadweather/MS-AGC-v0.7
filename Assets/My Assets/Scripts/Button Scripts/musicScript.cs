using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class musicScript : MonoBehaviour
{

    private GameObject settings;
    private Text currText;


    // Use this for initialization
    void Start()
    {
        settings = GameObject.Find("Settings");

        currText = this.gameObject.GetComponent<Text>();

        if (settings.GetComponent<settings>().music == true) currText.text = "On";
        if (settings.GetComponent<settings>().music == false) currText.text = "Off";
    }

    public void clickHandler()
    {
        if (settings.GetComponent<settings>().music == true)
        {
            if (GameObject.Find("Settings").GetComponent<settings>().lang == true)
            {
                settings.GetComponent<settings>().music = false;
                currText.text = "Off";
                Debug.Log(settings.GetComponent<settings>().music);
            }
            if (GameObject.Find("Settings").GetComponent<settings>().lang == false)
            {
                settings.GetComponent<settings>().music = false;
                currText.text = "Non";
                Debug.Log(settings.GetComponent<settings>().music);
            }
        }
        else
        {
            if (GameObject.Find("Settings").GetComponent<settings>().lang == true)
            {
                settings.GetComponent<settings>().music = true;
                currText.text = "On";
                Debug.Log(settings.GetComponent<settings>().music);
            }
            if (GameObject.Find("Settings").GetComponent<settings>().lang == false)
            {
                settings.GetComponent<settings>().music = true;
                currText.text = "Oui";
                Debug.Log(settings.GetComponent<settings>().music);
            }
        }
    }
}
