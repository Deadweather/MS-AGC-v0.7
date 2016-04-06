using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class frenchController : MonoBehaviour {

    private Text text;
    public string engText;
    public string frText;

	// Use this for initialization
	void Start () {
        text = this.gameObject.GetComponent<Text>();

        if (GameObject.Find("Settings").GetComponent<settings>().lang == false)
        {
            text.text = frText;
        }
        else
        {
            text.text = engText;
        }
	}
}
