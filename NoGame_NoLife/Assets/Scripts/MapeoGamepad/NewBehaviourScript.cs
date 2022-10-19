using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
	public Text text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// Mapeado de botones
		if (Input.GetButtonDown("B0"))
		{
			print("Has pulsado el boton B0");
			text.text = "Has pulsado el boton B0";
		}
		if (Input.GetButtonDown("B1"))
		{
			print("Has pulsado el boton B1");
			text.text = "Has pulsado el boton B1";
		}
		if (Input.GetButtonDown("B2"))
		{
			print("Has pulsado el boton B2");
			text.text = "Has pulsado el boton B2";
		}
		if (Input.GetButtonDown("B3"))
		{
			print("Has pulsado el boton B3");
			text.text = "Has pulsado el boton B3";
		}
		if (Input.GetButtonDown("B4"))
		{
			print("Has pulsado el boton B4");
			text.text = "Has pulsado el boton B4";
		}
		if (Input.GetButtonDown("B5"))
		{
			print("Has pulsado el boton B5");
			text.text = "Has pulsado el boton B5";
		}
		if (Input.GetButtonDown("B6"))
		{
			print("Has pulsado el boton B6");
			text.text = "Has pulsado el boton B6";
		}
		if (Input.GetButtonDown("B7"))
		{
			print("Has pulsado el boton B7");
			text.text = "Has pulsado el boton B7";
		}
		if (Input.GetButtonDown("B8"))
		{
			print("Has pulsado el boton B8");
			text.text = "Has pulsado el boton B8";
		}
		if (Input.GetButtonDown("B9"))
		{
			print("Has pulsado el boton B9");
			text.text = "Has pulsado el boton B9";
		}
		if (Input.GetButtonDown("B10"))
		{
			print("Has pulsado el boton B10");
			text.text = "Has pulsado el boton B10";
		}
		if (Input.GetButtonDown("B11"))
		{
			print("Has pulsado el boton B11");
			text.text = "Has pulsado el boton B11";
		}
		if (Input.GetButtonDown("B12"))
		{
			print("Has pulsado el boton B12");
			text.text = "Has pulsado el boton B12";
		}
		if (Input.GetButtonDown("B13"))
		{
			print("Has pulsado el boton B13");
			text.text = "Has pulsado el boton B13";
		}
		if (Input.GetButtonDown("B14"))
		{
			print("Has pulsado el boton B14");
			text.text = "Has pulsado el boton B14";
		}
		if (Input.GetButtonDown("B15"))
		{
			print("Has pulsado el boton B15");
			text.text = "Has pulsado el boton B15";
		}

		// Mapeado de palancas

		float analogico1 = Input.GetAxis("Joy1");
		float analogico2 = Input.GetAxis("Joy2");
		float analogico3 = Input.GetAxis("Joy3");
		float analogico4 = Input.GetAxis("Joy4");
		float analogico5 = Input.GetAxis ("Joy5");
		float analogico6 = Input.GetAxis ("Joy6");
		float analogico7 = Input.GetAxis ("Joy7");
		float analogico8 = Input.GetAxis ("Joy8");
		float analogico9 = Input.GetAxis("Joy9");
		float analogico10 = Input.GetAxis("Joy10");
		float analogico11 = Input.GetAxis("Joy11");
		float analogico12 = Input.GetAxis("Joy12");

		if (analogico1 != 0)
		{
			print("Valor Joy1 = " + analogico1);
			text.text = "Valor Joy1 = " + analogico1.ToString();
		}
		if (analogico2 != 0)
		{
			print("Valor Joy2 = " + analogico2);
			text.text = "Valor Joy2 = " + analogico2.ToString();
		}
		if (analogico3 != 0)
		{
			print("Valor Joy3 = " + analogico3);
			text.text = "Valor Joy3 = " + analogico3.ToString();
		}
		if (analogico4 != 0)
		{
			print("Valor Joy4 = " + analogico4);
			text.text = "Valor Joy4 = " + analogico4.ToString();
		}
		if (analogico5 != 0)
		{
			print("Valor Joy5 = " + analogico5);
			text.text = "Valor Joy5 = " + analogico5.ToString();
		}
		if (analogico6 != 0)
		{
			print("Valor Joy6 = " + analogico6);
			text.text = "Valor Joy6 = " + analogico6.ToString();
		}
		if (analogico7 != 0)
		{
			print("Valor Joy7 = " + analogico7);
			text.text = "Valor Joy7 = " + analogico7.ToString();
		}
		if (analogico8 != 0)
		{
			print("Valor Joy8 = " + analogico8);
			text.text = "Valor Joy8 = " + analogico8.ToString();
		}
		if (analogico9 != 0)
		{
			print("Valor Joy9 = " + analogico9);
			text.text = "Valor Joy9 = " + analogico9.ToString();
		}
		if (analogico10 != 0)
		{
			print("Valor Joy10 = " + analogico10);
			text.text = "Valor Joy10 = " + analogico10.ToString();
		}
		if (analogico11 != 0)
		{
			print("Valor Joy11 = " + analogico11);
			text.text = "Valor Joy11 = " + analogico11.ToString();
		}
		if (analogico12 != 0)
		{
			print("Valor Joy12 = " + analogico12);
			text.text = "Valor Joy12 = " + analogico12.ToString();
		}
	}
}
