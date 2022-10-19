using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarMenu : MonoBehaviour {

	public GameObject PanelEfecto;

	void Start () {

		Time.timeScale = 1f;
		Instantiate (PanelEfecto, transform.position, transform.rotation);
		Debug.Log ("Instancio");

	}

	void Update () {
		
	}
}
