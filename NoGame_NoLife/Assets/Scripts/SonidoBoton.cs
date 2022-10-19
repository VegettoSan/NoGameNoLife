using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBoton : MonoBehaviour {

	public AudioSource Source;
	public AudioClip Clip;

	void Start () {
		
	}

	void Update () {
		
	}

	public void Sonido() {

		Source.PlayOneShot (Clip);

	}
}
