using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicFondoAleatoria : MonoBehaviour {

	AudioSource Source;
	public AudioClip[] Songs;

	void Start () {
	
		Source = GetComponent<AudioSource> ();

	}

	void Update () {

		if (!Source.isPlaying) {

			NextSong ();

		}

		if (Source.volume <= 0f) {

			NextSong ();

		}
	}

	void NextSong () {

		int Clip = Random.Range (0, Songs.Length);

		Source.clip = Songs [Clip];
		Source.Play();

	}
}
