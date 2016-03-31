﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{
	public void loadlevel (string name)
	{
		Debug.Log ("level requested for:" + name);
		Application.LoadLevel (name);
	}
	public void QuitRequest()
	{
		Debug.Log ("I want to quit!");
		Application.Quit ();
	}
}