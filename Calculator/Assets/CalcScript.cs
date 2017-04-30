using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CalcScript : MonoBehaviour {

	public InputField input1;
	public InputField input2;
	public Text result;
	int number;
	
	// Use this for initialization
	void Start () {
		
	}
	public void Addition () {
		number = int.Parse(input1.text) + int.Parse(input2.text);
		print(number);
		result.text = number.ToString();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
