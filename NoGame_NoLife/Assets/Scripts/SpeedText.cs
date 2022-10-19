using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedText : MonoBehaviour {

	Fungus.Writer Texto;
	public Slider SliderText;

	void Start () {

		Texto = GetComponent<Fungus.Writer> ();

		SliderText.maxValue = 200f;
		SliderText.minValue = 5f;
		SliderText.value = PlayerPrefs.GetFloat ("SpeedText", 60f);
		
	}

	void Update () {

		Texto.writingSpeed = SliderText.value;

		PlayerPrefs.SetFloat ("SpeedText", SliderText.value);
		
	}
}
