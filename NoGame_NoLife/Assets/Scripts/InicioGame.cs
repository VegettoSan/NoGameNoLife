using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class InicioGame : MonoBehaviour {

	public GameObject Texto;
	public Video Opening;
	public VideoPlayer VideoOpening;
	public RawImage ImageRaw;
	public float Tiempo;
	public float Incremento;

	void Start () {

		Time.timeScale = 1f;
		Tiempo = 0f;
		Incremento = 1f;
		Texto.SetActive (false);
		VideoOpening.enabled = false;
		Opening.enabled = false;
		ImageRaw.enabled = false;
		VideoOpening.playOnAwake = false;
		VideoOpening.Stop ();

	}

	void Update () {

		Tiempo += Time.deltaTime * Incremento;

		if (Tiempo >= 1f) {

			Texto.SetActive (true);

		}

		if (Tiempo >= 6f) {

			Opening.enabled = true;
			VideoOpening.enabled = true;
			VideoOpening.Play ();
			Texto.SetActive (false);
			ImageRaw.enabled = true;
			Destroy (this.gameObject);

		}
	}
}
