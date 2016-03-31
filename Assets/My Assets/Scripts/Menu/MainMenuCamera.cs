using UnityEngine;
using System.Collections;

public class MainMenuCamera : MonoBehaviour {

    private Transform target;
    private Quaternion xrot;

	// Use this for initialization
	void Start () {

        GameObject scene = GameObject.Find("streetEnviroment");

        target = scene.GetComponent<Transform>();



	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(target);
        transform.Rotate(25,0,0);

        transform.Translate(Vector3.right * 0.5f);

    }
}
