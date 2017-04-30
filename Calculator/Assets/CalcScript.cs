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
	int random;
	public Text random1;
	
	void Start () {
		random = Random.Range(1,10);
		random1.text = random.ToString();
		print(random);
	}
	public void Addition () {
		gameObject.GetComponent<Button>().interactable = false;
		number = int.Parse(input1.text) + int.Parse(input2.text);
		print(number);
		result.text = number.ToString();
	}
	public void Subtraction () {
		gameObject.GetComponent<Button>().interactable = false;
		number = int.Parse(input1.text) - int.Parse(input2.text);
		print(number);
		result.text = number.ToString();
	}
	public void Division () {
		gameObject.GetComponent<Button>().interactable = false;
		quotient = float.Parse(input1.text) / float.Parse(input2.text);
		print(quotient); 
		result.text = quotient.ToString();
	}
	public void Multiplication () {
		gameObject.GetComponent<Button>().interactable = false;
		number = int.Parse(input1.text) * int.Parse(input2.text);
		print(number);
		result.text = number.ToString();
	}
	public void NumberButtons () {
		gameObject.GetComponent<Button>().interactable = false;
		Text number= gameObject.GetComponentInChildren<Text>();
		print(number.text);
		if (useInput2 == false)
			{
				input1.text += number.text;
			}
		else {
				input2.text += number.text;
		}}
	void Update () {
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			useInput2 = true;
		}
	}
	void OnTriggerEnter (Collider random1) {
        Destroy(random1.gameObject);
    }
}