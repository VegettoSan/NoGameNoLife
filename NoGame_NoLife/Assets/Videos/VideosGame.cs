using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Fungus;

public class VideosGame : MonoBehaviour {

	public VideoClip[] Videos;
	VideoPlayer PlayerVideo;
	public Flowchart Ft;
	public GameObject Personajes;
	public float Tiempo;
	public float Incremento = 1f;

	void Start () {
		
		Tiempo = 0f;
		Incremento = 1f;
		PlayerVideo = GetComponent<VideoPlayer> ();
		PlayerVideo.playOnAwake = false;
		PlayerVideo.Stop ();
		DetenerVideo ();

	}
		
	void Update () {

		if (PlayerVideo.isPlaying) {

			Tiempo = 0f;

		}

		if (!PlayerVideo.isPlaying) {

			Tiempo += Time.deltaTime * Incremento;

			if (Tiempo >= 2f) {

				Personajes.SetActive (true);
				Ft.ExecuteBlock ("Inicio");
			}
		} 
	}

	public void PlayVideo1() {

		Personajes.SetActive (false);
		PlayerVideo.enabled = true;
		PlayerVideo.clip = Videos [0];
		PlayerVideo.Play ();

	}

	public void PlayVideo2() {

		Personajes.SetActive (false);
		PlayerVideo.enabled = true;
		PlayerVideo.clip = Videos [1];
		PlayerVideo.Play ();

	}
	public void PlayVideo3() {

		Personajes.SetActive (false);
		PlayerVideo.enabled = true;
		PlayerVideo.clip = Videos [2];
		PlayerVideo.Play ();

	}
	public void PlayVideo4() {

		Personajes.SetActive (false);
		PlayerVideo.enabled = true;
		PlayerVideo.clip = Videos [3];
		PlayerVideo.Play ();

	}
	public void PlayVideo5() {

		Personajes.SetActive (false);
		PlayerVideo.enabled = true;
		PlayerVideo.clip = Videos [4];
		PlayerVideo.Play ();

	}
	public void PlayVideo6() {

		Personajes.SetActive (false);
		PlayerVideo.enabled = true;
		PlayerVideo.clip = Videos [5];
		PlayerVideo.Play ();

	}
	public void PlayVideo7() {

		Personajes.SetActive (false);
		PlayerVideo.enabled = true;
		PlayerVideo.clip = Videos [6];
		PlayerVideo.Play ();

	}

	public void DetenerVideo() {

		PlayerVideo.enabled = false;
		PlayerVideo.Stop ();

	}
}
