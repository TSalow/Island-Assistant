﻿using UnityEngine;
using System.Collections;
 [ExecuteInEditMode]
public class MainGUI : MonoBehaviour {

	void OnGUI()
	{
		GUILayout.BeginHorizontal ();
		GUILayout.Label ("Hello world!");
		GUILayout.EndHorizontal ();
	}
}