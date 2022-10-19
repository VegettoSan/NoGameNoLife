using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Video : MonoBehaviour {

	public VideoPlayer VideoOpening;
	public GameObject FadedDesaparecer;
	public GameObject FadedAparecer;
	public GameObject Botonskip;
	public float Tiempo;
	public float Incremento;

	public GameObject BarraCarga;

	public float TimError = 0f;
	public float IncreError = 1f;

	public bool Aparecer;
	public bool Desaparecer;

	// Use this for initialization
	void Start () {

		Tiempo = 0f;
		Incremento = 1f;
		Botonskip.SetActive (false);
		VideoOpening.playOnAwake = false;
		FadedDesaparecer.SetActive (false);
		FadedAparecer.SetActive (false);
		BarraCarga.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {

		Tiempo += Time.deltaTime * Incremento;

		if (Tiempo >= 14f) {

			Botonskip.SetActive (true);

		}
			
		if (Aparecer) {

			FadedAparecer.SetActive (true);
			VideoOpening.enabled = false;
			Botonskip.SetActive (false);

		}
		if (Desaparecer) {

			FadedDesaparecer.SetActive (true);

		}

		if (!VideoOpening.isPlaying) {

			TimError += Time.deltaTime * IncreError;

			if (TimError >= 0.5f) {

				//FadedDesaparecer.SetActive (true);
				Desaparecer = true;
		
			}

			if (TimError >= 2f) {

				//FadedAparecer.SetActive (true);
				Aparecer = true;
				BarraCarga.SetActive (true);

			}
		} else {

			TimError = 0f;

		}
	}
}
