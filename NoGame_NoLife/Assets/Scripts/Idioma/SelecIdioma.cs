using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecIdioma : MonoBehaviour {

	public int NIdioma;


	// Use this for initialization
	void Start () {
		
		NIdioma = PlayerPrefs.GetInt ("Idioma", 1);

	}
	
	// Update is called once per frame
	void Update () {

		//PlayerPrefs.SetInt ("Idioma", NIdioma);

	}

	public void Español() {

		NIdioma = 1;
		PlayerPrefs.SetInt ("Idioma", NIdioma);

	}

	public void Ingles() {

		NIdioma = 2;
		PlayerPrefs.SetInt ("Idioma", NIdioma);

	}

	public void Japones() {

		NIdioma = 3;
		PlayerPrefs.SetInt ("Idioma", NIdioma);

	}
}
