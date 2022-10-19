using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarOpening : MonoBehaviour {

	public AudioSource Source;
	//public GameObject Panel;
	public GIF Giff;


	void Start () {

		Giff.enabled = false;

	}

	void Update () {

		if (Source.isPlaying) {

			//Panel.SetActive (true);
			Giff.enabled = true;

		}
		
	}
}
