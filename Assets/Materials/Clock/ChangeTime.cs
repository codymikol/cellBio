using UnityEngine;
using System.Collections;

public class ChangeTime : MonoBehaviour {

	public OtherSlider sliderScript;
	public GameObject other;
	public Sprite number1;
	public Sprite number2;
	public Sprite number3;
	public Sprite number4;
	public Sprite number5;
	public Sprite number6;
	public Sprite number7;
	public Sprite number8;
	public Sprite number9;
	public Sprite number0;
	public GameObject TenHour;
	public GameObject OneHour;
	public GameObject TenMinute;
	public GameObject OneMinute;
	public Material Digit1;
	private SpriteRenderer spriteRenderer; 

	private float time;
	// Use this for initialization
	void Start () {
		spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = number0;
		spriteRenderer = TenHour.GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = number0;
		spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = number0;
		spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = number0;

	}
	
	// Update is called once per frame
	void Update () {
		sliderScript = other.gameObject.GetComponent<OtherSlider>();
		time = sliderScript.getTime ();
		setTime ();
	}
	void setTime(){
		if (time == 90) {
			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number1;
			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number3;
		} else if (time == 0) {
			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
			spriteRenderer = TenHour.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
		} else if (time == 180) {
			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number3;
			spriteRenderer = TenHour.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
		} else if (time == 270) {
			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number4;
			spriteRenderer = TenHour.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number3;
			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
		} else if (time == 360) {
			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number6;
			spriteRenderer = TenHour.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = number0;
		}

	}
//	void setTime()
//	{
//
//		int num = Mathf.FloorToInt(time);
//		int ones = num % 10;
//		int tens = num % 100 - ones;
//		int hundreds = num % 1000 - tens - ones;
//		int thousands = num % 10000 - hundreds - tens - ones;
//
//		//first digit
//		if (thousands == 0 ) {
//			spriteRenderer = TenHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number0;
//		}
//		else if(thousands == 1000)
//		{
//			spriteRenderer = TenHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number1;
//		}
//
//		//second digit
//		if (hundreds == 0) {
//			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number0;
//		} else if (hundreds == 100) {
//			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number1;
//		} else if (hundreds == 200) {
//			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number2;
//		} else if (hundreds == 300) {
//			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number3;
//		} else if (hundreds == 400) {
//			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number4;
//		} else if (hundreds == 500) {
//			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number5;
//		} else if (hundreds == 600) {
//			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number6;
//		} else if (hundreds == 700) {
//			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number7;
//		} else if (hundreds == 800) {
//			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number8;
//		} else if (hundreds == 900) {
//			spriteRenderer = OneHour.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number9;
//		}
//
//		//third digit
//		if (tens == 0) {
//			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number0;
//		} else if (tens == 10) {
//			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number1;
//		} else if (tens == 20) {
//			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number2;
//		} else if (tens == 30) {
//			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number3;
//		} else if (tens == 40) {
//			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number4;
//		} else if (tens == 50) {
//			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number5;
//		} else if (tens == 60) {
//			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number6;
//		} else if (tens == 70) {
//			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number7;
//		} else if (tens == 80) {
//			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number8;
//		} else if (tens == 90) {
//			spriteRenderer = TenMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number9;
//		}
//
//		//fourth digit
//		if (ones == 0) {
//			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number0;
//		} else if (ones == 1) {
//			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number1;
//		} else if (ones == 2) {
//			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number2;
//		} else if (ones == 3) {
//			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number3;
//		} else if (ones == 40) {
//			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number4;
//		} else if (ones == 5) {
//			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number5;
//		} else if (ones == 6) {
//			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number6;
//		} else if (ones == 7) {
//			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number7;
//		} else if (ones == 8) {
//			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number8;
//		} else if (ones == 9) {
//			spriteRenderer = OneMinute.GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = number9;
//		}
//
//
//	}

}
