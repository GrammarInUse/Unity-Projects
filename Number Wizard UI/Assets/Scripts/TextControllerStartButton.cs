﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControllerStartButton : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "";
	}

	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetKeyDown (KeyCode.Alpha1))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Alpha2))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Alpha3))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Alpha4))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Alpha5))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Alpha6))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Keypad1))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Keypad2))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Keypad3))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Keypad4))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Keypad5))
			Destroy(gameObject);
		else if (Input.GetKeyDown (KeyCode.Keypad6))
			Destroy(gameObject);
		*/
		if (Input.GetKeyDown (KeyCode.Alpha1))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Alpha2))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Alpha3))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Alpha4))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Alpha5))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Alpha6))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Keypad1))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Keypad2))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Keypad3))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Keypad4))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Keypad5))
			text.text = "Start";
		else if (Input.GetKeyDown (KeyCode.Keypad6))
			text.text = "Start";

	}

}
