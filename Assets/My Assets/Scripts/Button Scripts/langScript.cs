using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class langScript : MonoBehaviour
{

    private GameObject settings;
    private Text currText;


    // Use this for initialization
    void Start()
    {
        settings = GameObject.Find("Settings");

        currText = this.gameObject.GetComponent<Text>();

        if (settings.GetComponent<settings>().lang == true) currText.text = "English";
        if (settings.GetComponent<settings>().lang == false) currText.text = "French";
    }

    public void clickHandler()
    {
        if (settings.GetComponent<settings>().lang == true)
        {
            settings.GetComponent<settings>().lang = false;
            currText.text = "French";
            Debug.Log(settings.GetComponent<settings>().lang);

            GameObject.Find("difficultyText").GetComponent<Text>().text = "Difficulté";
            GameObject.Find("musicText").GetComponent<Text>().text = "Musique";
            GameObject.Find("languageText").GetComponent<Text>().text = "Français";
            GameObject.Find("backButton").GetComponent<Text>().text = "Précédent";

            // settings button
            if (GameObject.Find("Settings").GetComponent<settings>().diff == true)
            {
                GameObject.Find("diffButton").GetComponent<Text>().text = "Normale";
            }
            if (GameObject.Find("Settings").GetComponent<settings>().diff == false)
            {
                GameObject.Find("diffButton").GetComponent<Text>().text = "Difficile";
            }

            // music button
            if (GameObject.Find("Settings").GetComponent<settings>().music == true)
            {
                GameObject.Find("musicButton").GetComponent<Text>().text = "Oui";
            }
            if (GameObject.Find("Settings").GetComponent<settings>().music == false)
            {
                GameObject.Find("musicButton").GetComponent<Text>().text = "Non";
            }
        }
        else
        {
            if (settings.GetComponent<settings>().lang == false)
            {
                settings.GetComponent<settings>().lang = true;
                currText.text = "English";
                Debug.Log(settings.GetComponent<settings>().lang);

                GameObject.Find("difficultyText").GetComponent<Text>().text = "Difficulty";
                GameObject.Find("musicText").GetComponent<Text>().text = "Music";
                GameObject.Find("languageText").GetComponent<Text>().text = "Language";
                GameObject.Find("backButton").GetComponent<Text>().text = "Back";

                // settings button
                if (GameObject.Find("Settings").GetComponent<settings>().diff == true)
                {
                    GameObject.Find("diffButton").GetComponent<Text>().text = "Normal";
                }
                if (GameObject.Find("Settings").GetComponent<settings>().diff == false)
                {
                    GameObject.Find("diffButton").GetComponent<Text>().text = "Hard";
                }

                // music button
                if (GameObject.Find("Settings").GetComponent<settings>().music == true)
                {
                    GameObject.Find("musicButton").GetComponent<Text>().text = "On";
                }
                if (GameObject.Find("Settings").GetComponent<settings>().music == false)
                {
                    GameObject.Find("musicButton").GetComponent<Text>().text = "Off";
                }
            }
        }
    }
}
