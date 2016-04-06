using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text Text;

    float TimeLeft = 60.0f;

    Text text;

    void awake()
    {

        text = GetComponent<Text>();

        TimeLeft = 60.0f;
    }


    void Update()
    {

        if (GameObject.Find("Settings").GetComponent<settings>().lang == true)
        {
            Text.text = "Time: " + TimeLeft;
        }
        else
        {
            Text.text = "Temps: " + TimeLeft;
        }

        TimeLeft -= Time.deltaTime;

        if (TimeLeft < 0.0f)
        {
            SceneManager.LoadScene(5);
        }
    }
}
