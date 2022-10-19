using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MapeadoJoystickCompleto : MonoBehaviour {

	public Text text;

	void Update () {
		// Mapeado de botones
		if (Input.GetButtonDown ("A")) {
			print ("Has pulsado el boton A");
			text.text = "Has pulsado el boton A";
		}
		if (Input.GetButtonDown ("B")) {
			print ("Has pulsado el boton B");
			text.text = "Has pulsado el boton B";
		}
		if (Input.GetButtonDown ("X")) {
			print ("Has pulsado el boton X");
			text.text = "Has pulsado el boton X";
		}
		if (Input.GetButtonDown ("Y")) {
			print ("Has pulsado el boton Y");
			text.text = "Has pulsado el boton Y";
		}
		if (Input.GetButtonDown ("LB")) {
			print ("Has pulsado el boton LB");
			text.text = "Has pulsado el boton LB";
		}
		if (Input.GetButtonDown ("RB")) {
			print ("Has pulsado el boton RB");
			text.text = "Has pulsado el boton RB";
		}
		if (Input.GetButtonDown ("Select")) {
			print ("Has pulsado el boton Select");
			text.text = "Has pulsado el boton Select";
		}
		if (Input.GetButtonDown ("Start")) {
			print ("Has pulsado el boton Start");
			text.text = "Has pulsado el boton Start";
		}
		if (Input.GetButtonDown ("Boton8")) {
			print ("Has pulsado el boton 8");
			text.text = "Has pulsado el boton 8";
		}
		if (Input.GetButtonDown ("Boton9")) {
			print ("Has pulsado el boton 9");
			text.text = "Has pulsado el boton 9";
		}
		if (Input.GetButtonDown ("Boton10")) {
			print ("Has pulsado el boton 10");
		}
		if (Input.GetButtonDown ("Boton11")) {
			print ("Has pulsado el boton 11");
		}
		if (Input.GetButtonDown ("Boton12")) {
			print ("Has pulsado el boton 12");
		}

		// Mapeado de palancas

		float analogico1 = Input.GetAxis ("IzqX");
		float analogico2 = Input.GetAxis ("IzqY");
		float analogico3 = Input.GetAxis ("DerY");
		float analogico4 = Input.GetAxis ("DerX");
		float digitalX = Input.GetAxis ("D-Horizontal");
		float digitalY = Input.GetAxis ("D-Vertical");
		float Gatillos = Input.GetAxis ("Gatillos");

		//print ("Analogico1" + ("  ") + analogico1);

		if (analogico1 != 0) {
			print ("Valor palanca Izquierda X = " + analogico1);
			text.text = "Valor palanca Izquierda X = " + analogico1.ToString();
		}
		if (analogico2 != 0) {

		print ("Valor palanca Izquierda Y = " + analogico2);
			text.text = "Valor palanca Izquierda Y = " + analogico2.ToString();
		}
		if (analogico3 != 0) {
			print ("Valor palanca Derecha Y = " + analogico3);
			text.text = "Valor palanca Derecha Y = " + analogico3.ToString();
		}
		if (analogico4 != 0) {
			print ("Valor palanca Derecha X = " + analogico4);
			text.text = "Valor palanca Derecha X = " + analogico4.ToString();
		}
		if (digitalX != 0) {
			print ("Valor D-Pad X = " + digitalX);
			text.text = "Valor D-Pad X = " + digitalX.ToString();
		}
		if (digitalY != 0) {
			print ("Valor D-Pad Y = " + digitalY);
			text.text = "Valor D-Pad Y = " + digitalY.ToString();
		}
		if (Gatillos != 0)
		{
			print("Valor Gatillos = " + Gatillos);
			text.text = "Valor Gatillos = " + Gatillos.ToString();
		}





	}
}

