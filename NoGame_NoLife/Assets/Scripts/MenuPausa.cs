using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour {

	public GameObject Menu;

	void Start () {

		Menu.SetActive (false);
		Time.timeScale = 1;
		
	}


	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Cambio ();
		}
	}

	void Cambio() {

		if(Time.timeScale == 1)
			pausar();

		else if(Time.timeScale == 0)
			Continuar();

	}

	public void pausar ()
	{
		Menu.SetActive(true);
		Time.timeScale = 0f;

	}

	public void Continuar ()
	{
		Menu.SetActive(false);
		Time.timeScale = 1f;

	}
}
