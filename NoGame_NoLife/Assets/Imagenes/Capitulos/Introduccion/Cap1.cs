using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cap1 : MonoBehaviour {

	Image Fondo;
	public Sprite[] spritesFondo;
	Animator Anim;
	public bool TimeBool;
	public float Tiempo = 0f;
	float Incremento = 1f;
	public float TimeMax;

	void Start () {

		Fondo = GetComponent<Image> ();
		Anim = GetComponent<Animator> ();
		
	}

	void Update () {

		if (!TimeBool) {

			Tiempo = 0f;
			Fondo.enabled = true;

		}

		if (TimeBool) {

			Fondo.enabled = false;
			Tiempo += Time.deltaTime * Incremento;

			if (Tiempo >= TimeMax) {

				TimeBool = false;
				Fondo.enabled = true;
			}
		}
	}

	public void ActImage() {

		Fondo.enabled = true;

	}

	public void DesImage() {

		Fondo.enabled = false;

	}

	public void Fondo1() {

		TimeBool = true;
		Anim.SetTrigger ("Pasar");
		Fondo.sprite = spritesFondo [0];

	}

	public void Fondo2() {

		TimeBool = true;
		Anim.SetTrigger ("Pasar");
		Fondo.sprite = spritesFondo [1];

	}

	public void Fondo3() {

		TimeBool = true;
		Anim.SetTrigger ("Pasar");
		Fondo.sprite = spritesFondo [2];

	}

	public void Fondo4() {

		TimeBool = true;
		Anim.SetTrigger ("Pasar");
		Fondo.sprite = spritesFondo [3];

	}
}
