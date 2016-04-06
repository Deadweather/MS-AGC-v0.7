using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class settings : MonoBehaviour {

    [SerializeField] public bool diff;
    [SerializeField] public bool music;
    [SerializeField] public bool lang;


    private static settings instance = null;

    public static settings Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

	// Use this for initialization
	void Start () {
        diff = true;
        music = true;
        lang = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
