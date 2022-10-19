using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour {

	AudioSource Source;
	public AudioClip clip;
	Button boton;

	// Use this for initialization
	void Start () {

		boton = GetComponent<Button> ();
		boton.onClick.AddListener (Sonido);
		Source = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Sonido() {

		Source.clip = clip;
		Source.PlayOneShot (clip);

	}
}
