using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPiedraPapelTijera : MonoBehaviour {

	public Animator AnimBotones;
	public Animator Anim;

	void Start () {
		
	}

	void Update () {
		
	}

	public void Play() {

		AnimBotones.SetBool ("FX", true);
		Anim.SetBool ("FX", true);

	}
}
