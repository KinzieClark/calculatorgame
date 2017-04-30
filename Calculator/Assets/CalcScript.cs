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
	float quotient;
	bool useInput2 = false;
	
	void Start () {
		
	}
	public void Addition () {
		number = int.Parse(input1.text) + int.Parse(input2.text);
		print(number);
		result.text = number.ToString();
	}
	public void Subtraction () {
		number = int.Parse(input1.text) - int.Parse(input2.text);
		print(number);
		result.text = number.ToString();
	}
	public void Division () {
		quotient = float.Parse(input1.text) / float.Parse(input2.text);
		print(quotient); 
		result.text = quotient.ToString();
	}
	public void Multiplication () {
		number = int.Parse(input1.text) * int.Parse(input2.text);
		print(number);
		result.text = number.ToString();
	}
	public void NumberButtons () {
		Text number= gameObject.GetComponentInChildren<Text>();
		print(number.text);
		if (useInput2 == false)
			{
				input1.text += number.text;
			}
		else {
				input2.text += number.text;
		}}
		}
	void Update () {
		
	}
}
