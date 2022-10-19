using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour {

	public AudioSource Source;
	public VideoPlayer Video;

	bool Actvar;

	void Start () {

	}

	void Update () {

		if (Actvar) {

			Source.volume -= Time.deltaTime * 1f;

		}

		if (Source.volume <= 0f) {

			Video.Pause ();

		}

		if (Input.GetButtonDown(PlayerPrefs.GetString("X")))
        {
			ActivarBool();

		}

	}

	public void ActivarBool () {

		Actvar = true;
		
	}
}
