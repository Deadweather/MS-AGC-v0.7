using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class diffScript : MonoBehaviour {

    private GameObject settings;
    private Text currText;
    

	// Use this for initialization
	void Start () {
        settings = GameObject.Find("Settings");

        currText = this.gameObject.GetComponent<Text>();

        if (settings.GetComponent<settings>().diff == true && settings.GetComponent<settings>().lang == true) currText.text = "Normal";
        if (settings.GetComponent<settings>().diff == false && settings.GetComponent<settings>().lang == true) currText.text = "Hard";

        if (settings.GetComponent<settings>().diff == true && settings.GetComponent<settings>().lang == false) currText.text = "Normale";
        if (settings.GetComponent<settings>().diff == false && settings.GetComponent<settings>().lang == false) currText.text = "Difficile";
    }

    public void clickHandler()
    {
        if (settings.GetComponent<settings>().diff == true)
        {
            if (GameObject.Find("Settings").GetComponent<settings>().lang == true)
            {
                settings.GetComponent<settings>().diff = false;
                currText.text = "Hard";
                Debug.Log(settings.GetComponent<settings>().diff);
            }
            if (GameObject.Find("Settings").GetComponent<settings>().lang == false)
            {
                settings.GetComponent<settings>().diff = false;
                currText.text = "Difficile";
                Debug.Log(settings.GetComponent<settings>().diff);
            }
        }
        else
        {
            if (GameObject.Find("Settings").GetComponent<settings>().lang == true)
            {
                settings.GetComponent<settings>().diff = true;
                currText.text = "Normal";
                Debug.Log(settings.GetComponent<settings>().diff);
            }
            if (GameObject.Find("Settings").GetComponent<settings>().lang == false)
            {
                settings.GetComponent<settings>().diff = true;
                currText.text = "Normale";
                Debug.Log(settings.GetComponent<settings>().diff);
            }
        }
    }
}