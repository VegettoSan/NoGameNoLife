using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RamdomFondo : MonoBehaviour {

	public Sprite[] Fondos;
	Image Fondo;
	Animator AnimFondo;
	public Text TextTiempo;
	public GameObject BotonCambio;
	public GameObject BotonCambioTime;
	//public GameObject FadedEfecto;
	public Toggle Togle;
	public Button[] BotonesFondos;

	float Incremento;
	float Tiempo;
	public float TiempoPasar;

	int Ncambio;
	int Nfondo;

	// Use this for initialization
	void Start () {

		Tiempo = 0f;
		Incremento = 1f;

		Ncambio = PlayerPrefs.GetInt ("Fondo", 1);
		Nfondo = PlayerPrefs.GetInt ("FondoFull", 1);
		TiempoPasar = PlayerPrefs.GetFloat ("TiempoPasar", 30f);
		BotonCambio.SetActive (false);
		Fondo = GetComponent<Image> ();
		AnimFondo = GetComponent<Animator> ();

		BotonesFondos [0].onClick.AddListener (Fondo1);
		BotonesFondos [1].onClick.AddListener (Fondo2);
		BotonesFondos [2].onClick.AddListener (Fondo3);
		BotonesFondos [3].onClick.AddListener (Fondo4);
		BotonesFondos [4].onClick.AddListener (Fondo5);
		BotonesFondos [5].onClick.AddListener (Fondo6);
		BotonesFondos [6].onClick.AddListener (Fondo7);
		BotonesFondos [7].onClick.AddListener (Fondo8);

		if (Nfondo == 1) {

			Fondo1 ();

		}

		if (Nfondo == 2) {

			Fondo2 ();

		}

		if (Nfondo == 3) {

			Fondo3 ();

		}

		if (Nfondo == 4) {

			Fondo4 ();

		}

		if (Nfondo == 5)
		{

			Fondo5();

		}

		if (Nfondo == 6)
		{

			Fondo6();

		}

		if (Nfondo == 7)
		{

			Fondo7();

		}

		if (Nfondo == 8)
		{

			Fondo8();

		}


		if (Ncambio == 0) {

			Togle.isOn = false;

		} else if (Ncambio == 1) {

			Togle.isOn = true;

			if (Togle.isOn == true) {

				RandomFondos ();

			}

		}
	}
	
	// Update is called once per frame
	void Update () {

		PlayerPrefs.SetInt ("Fondo", Ncambio);
		PlayerPrefs.SetInt ("FondoFull", Nfondo);

		PlayerPrefs.SetFloat ("TiempoPasar", TiempoPasar);
		TextTiempo.text = TiempoPasar.ToString () + ("s");

		if (Togle.isOn == true) {

			Tiempo += Time.deltaTime * Incremento;

			if (Tiempo >= TiempoPasar) {

				AnimFondo.SetBool ("Aparecer", false);
				AnimFondo.SetBool ("Desaparecer", true);
				RandomFondos ();
				//Tiempo = 0f;

			}
			BotonCambio.SetActive (false);
			BotonCambioTime.SetActive (true);
			Ncambio = 1;

		} else {

			BotonCambio.SetActive (true);
			BotonCambioTime.SetActive (false);
			Ncambio = 0;

		}

		if (TiempoPasar >= 30f) {

			TiempoPasar = 30f;

		}

		if (TiempoPasar <= 3f) {

			TiempoPasar = 3f;

		}
	}

	void RandomFondos () {

		if (Tiempo >= TiempoPasar + 1f) {

			AnimFondo.SetBool ("Aparecer", true);
			AnimFondo.SetBool ("Desaparecer", false);
			int Img = Random.Range (0, Fondos.Length);
			Fondo.sprite = Fondos [Img];
			Nfondo = Img;
			Tiempo = 0f;
		}
	}

	public void AumentarTime() {

		TiempoPasar++;
		Tiempo = 0f;

	}

	public void DisminuirTime() {

		TiempoPasar--;
		Tiempo = 0f;

	}

	public void Fondo1(){

		Fondo.sprite = Fondos [0];
		Nfondo = 1;

	}

	public void Fondo2(){

		Fondo.sprite = Fondos [1];
		Nfondo = 2;

	}

	public void Fondo3(){

		Fondo.sprite = Fondos [2];
		Nfondo = 3;

	}

	public void Fondo4(){

		Fondo.sprite = Fondos [3];
		Nfondo = 4;

	}

	public void Fondo5()
	{

		Fondo.sprite = Fondos[4];
		Nfondo = 5;

	}

	public void Fondo6()
	{

		Fondo.sprite = Fondos[5];
		Nfondo = 6;

	}

	public void Fondo7()
	{

		Fondo.sprite = Fondos[6];
		Nfondo = 7;

	}

	public void Fondo8()
	{

		Fondo.sprite = Fondos[7];
		Nfondo = 8;

	}
}
