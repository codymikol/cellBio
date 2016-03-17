using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OtherSlider : MonoBehaviour {
	public float hSliderValue = 0.0f;
	public Slider mainSlider;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		hSliderValue = mainSlider.value;
	}
	void OnGUI() {
		//hSliderValue = GUI.HorizontalSlider(new Rect(100,50,Screen.width * .6f, Screen.height), hSliderValue, 0,360);
	}
	public float getTime()
	{
		if (hSliderValue > 0 && hSliderValue < 90) {
			hSliderValue = 90;
		} else if (hSliderValue > 90 && hSliderValue < 180) {
			hSliderValue = 180;
		} else if (hSliderValue > 180 && hSliderValue < 270) {
			hSliderValue = 270;
		}
		else if (hSliderValue > 270 && hSliderValue < 360) {
			hSliderValue = 360;
		}



		hSliderValue = Mathf.RoundToInt(hSliderValue);
		return hSliderValue;
	}
}
