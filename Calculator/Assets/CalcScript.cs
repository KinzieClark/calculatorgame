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
	public Text random2;
	public Text random3;
	public Text random4;
	public int[] values; 
	
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
	public void OnTriggerEnter (Collider random1) {
        Application.LoadLevel("GameOver");
    }
	public void NumberDestroy () {
		result.text = result.ToString();
		random1.text = random1.ToString();
		if (result == random1)
		{
			Destroy(random1.gameObject);
		}
	}
	public void DestroyNumbers () { //This is where I'm having trouble. Logically, this should work, but no dice so far
		foreach (int result in values)
		{
			Destroy(random1.gameObject);
		}
	}
}