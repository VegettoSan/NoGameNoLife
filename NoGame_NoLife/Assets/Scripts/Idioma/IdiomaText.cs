using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdiomaText : MonoBehaviour {

	public string Español;
	public string Ingles;
	public string Japones;

	Text Texto;

	int NIdioma;

	// Use this for initialization
	void Start () {

		NIdioma = PlayerPrefs.GetInt ("Idioma", 1);
		Texto = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		NIdioma = PlayerPrefs.GetInt ("Idioma", 1);

		if (NIdioma == 1) {

			Texto.text = Español;

		}

		if (NIdioma == 2) {

			Texto.text = Ingles;

		}

		if (NIdioma == 3) {

			Texto.text = Japones;

		}
		
	}
}
