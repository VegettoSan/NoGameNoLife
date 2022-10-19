using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipIntro : MonoBehaviour {

	public float Tiempo;
	public float Incremento;
	public GameObject BotonSkip;

	void Start () {

		Tiempo = 0f;
		BotonSkip.SetActive (false);
		
	}

	void Update () {

		Tiempo += Time.deltaTime * Incremento;

		if (Tiempo >= 14f) {

			BotonSkip.SetActive (true);

		}

		if (Tiempo >= 89f) {

			//Application.LoadLevel ("Menu");
			SceneManager.LoadScene ("Menu");

		}
	}
}
