using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour {

	public float TiempoDestruir;
	float Tiempo;
	float Incremento;

	void Start () {

		Tiempo = 0f;
		Incremento = 1f;
		
	}

	void Update () {

		Tiempo += Time.deltaTime * Incremento;

		if (Tiempo >= TiempoDestruir) {

			Destroy (gameObject);

		}
	}
}
