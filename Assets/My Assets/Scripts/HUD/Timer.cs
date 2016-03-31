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

        Text.text = "Time: " + TimeLeft;

        TimeLeft -= Time.deltaTime;

        if (TimeLeft < 0.0f)
        {
            SceneManager.LoadScene(5);
        }
    }
}
