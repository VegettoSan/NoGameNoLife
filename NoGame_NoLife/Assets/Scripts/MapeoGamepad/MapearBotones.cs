using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapearBotones : MonoBehaviour
{
    public static MapearBotones Mapeo;

    public string GatilloR, GatilloL, PBR,
        Star, PBL, A, RB, Y,
        X, B, LB, Selec;

	public string PalancaIzqX, PalancaIzqY, PalancaDerX, PalancaDerY, PadH, PadV;

	public bool _PalancaIzqX, _PalancaIzqY, _PalancaDerX, _PalancaDerY, _PadH, _PadV;

	public bool _GatilloR, _GatilloL, _PBR,
        _Star, _PBL, _A, _RB, _Y,
        _X, _B, _LB, _Selec;

	public bool Axis;

	private void Awake()
    {
        Mapeo = MapearBotones.Mapeo;
        if (Mapeo != null)
        {
            Destroy(this.gameObject);
        }else if (Mapeo == null)
        {
            Mapeo = this;
        }
    }
    void Start()
    {
		Resetear();
	}

    // Update is called once per frame
    void Update()
    {
		float analogico1 = Input.GetAxis("Axis1");
		float analogico2 = Input.GetAxis("Axis2");
		float analogico3 = Input.GetAxis("Axis3");
		float analogico4 = Input.GetAxis("Axis4");
		float analogico5 = Input.GetAxis("Axis5");
		float analogico6 = Input.GetAxis("Axis6");
		float analogico7 = Input.GetAxis("Axis7");
		float analogico8 = Input.GetAxis("Axis8");
		float analogico9 = Input.GetAxis("Axis9");
		float analogico10 = Input.GetAxis("Axis10");
		float analogico11 = Input.GetAxis("Axis11");
		float analogico12 = Input.GetAxis("Axis12");

		if (_PadH)
        {
			Save();
			if (analogico1 != 0)
			{
				PadH = "Axis1";
				//FalseAllBool();
			}
			if (analogico2 != 0)
			{
				PadH = "Axis2";
				//FalseAllBool();
			}
			if (analogico3 != 0)
			{
				PadH = "Axis3";
				//FalseAllBool();
			}
			if (analogico4 != 0)
			{
				PadH = "Axis4";
				//FalseAllBool();
			}
			if (analogico5 != 0)
			{
				PadH = "Axis5";
				//FalseAllBool();
			}
			if (analogico6 != 0)
			{
				PadH = "Axis6";
				//FalseAllBool();
			}
			if (analogico7 != 0)
			{
				PadH = "Axis7";
				//FalseAllBool();
			}
			if (analogico8 != 0)
			{
				PadH = "Axis8";
				//FalseAllBool();
			}
			if (analogico9 != 0)
			{
				PadH = "Axis9";
				//FalseAllBool();
			}
			if (analogico10 != 0)
			{
				PadH = "Axis10";
				//FalseAllBool();
			}
			if (analogico11 != 0)
			{
				PadH = "Axis11";
				//FalseAllBool();
			}
			if (analogico12 != 0)
			{
				PadH = "Axis12";
				//FalseAllBool();
			}
		}

		if (_PadV)
		{
			Save();
			if (analogico1 != 0)
			{
				PadV = "Axis1";
				//FalseAllBool();
			}
			if (analogico2 != 0)
			{
				PadV = "Axis2";
				//FalseAllBool();
			}
			if (analogico3 != 0)
			{
				PadV = "Axis3";
				//FalseAllBool();
			}
			if (analogico4 != 0)
			{
				PadV = "Axis4";
				//FalseAllBool();
			}
			if (analogico5 != 0)
			{
				PadV = "Axis5";
				//FalseAllBool();
			}
			if (analogico6 != 0)
			{
				PadV = "Axis6";
				//FalseAllBool();
			}
			if (analogico7 != 0)
			{
				PadV = "Axis7";
				//FalseAllBool();
			}
			if (analogico8 != 0)
			{
				PadV = "Axis8";
				//FalseAllBool();
			}
			if (analogico9 != 0)
			{
				PadV = "Axis9";
				//FalseAllBool();
			}
			if (analogico10 != 0)
			{
				PadV = "Axis10";
				//FalseAllBool();
			}
			if (analogico11 != 0)
			{
				PadV = "Axis11";
				//FalseAllBool();
			}
			if (analogico12 != 0)
			{
				PadV = "Axis12";
				//FalseAllBool();
			}
		}

		if (_PalancaDerX)
		{
			Save();
			if (analogico1 != 0)
			{
				PalancaDerX = "Axis1";
				//FalseAllBool();
			}
			if (analogico2 != 0)
			{
				PalancaDerX = "Axis2";
				//FalseAllBool();
			}
			if (analogico3 != 0)
			{
				PalancaDerX = "Axis3";
				//FalseAllBool();
			}
			if (analogico4 != 0)
			{
				PalancaDerX = "Axis4";
				//FalseAllBool();
			}
			if (analogico5 != 0)
			{
				PalancaDerX = "Axis5";
				//FalseAllBool();
			}
			if (analogico6 != 0)
			{
				PalancaDerX = "Axis6";
				//FalseAllBool();
			}
			if (analogico7 != 0)
			{
				PalancaDerX = "Axis7";
				//FalseAllBool();
			}
			if (analogico8 != 0)
			{
				PalancaDerX = "Axis8";
				//FalseAllBool();
			}
			if (analogico9 != 0)
			{
				PalancaDerX = "Axis9";
				//FalseAllBool();
			}
			if (analogico10 != 0)
			{
				PalancaDerX = "Axis10";
				//FalseAllBool();
			}
			if (analogico11 != 0)
			{
				PalancaDerX = "Axis11";
				//FalseAllBool();
			}
			if (analogico12 != 0)
			{
				PalancaDerX = "Axis12";
				//FalseAllBool();
			}
		}

		if (_PalancaDerY)
		{
			Save();
			if (analogico1 != 0)
			{
				PalancaDerY = "Axis1";
				//FalseAllBool();
			}
			if (analogico2 != 0)
			{
				PalancaDerY = "Axis2";
				//FalseAllBool();
			}
			if (analogico3 != 0)
			{
				PalancaDerY = "Axis3";
				//FalseAllBool();
			}
			if (analogico4 != 0)
			{
				PalancaDerY = "Axis4";
				//FalseAllBool();
			}
			if (analogico5 != 0)
			{
				PalancaDerY = "Axis5";
				//FalseAllBool();
			}
			if (analogico6 != 0)
			{
				PalancaDerY = "Axis6";
				//FalseAllBool();
			}
			if (analogico7 != 0)
			{
				PalancaDerY = "Axis7";
				//FalseAllBool();
			}
			if (analogico8 != 0)
			{
				PalancaDerY = "Axis8";
				//FalseAllBool();
			}
			if (analogico9 != 0)
			{
				PalancaDerY = "Axis9";
				//FalseAllBool();
			}
			if (analogico10 != 0)
			{
				PalancaDerY = "Axis10";
				//FalseAllBool();
			}
			if (analogico11 != 0)
			{
				PalancaDerY = "Axis11";
				//FalseAllBool();
			}
			if (analogico12 != 0)
			{
				PalancaDerY = "Axis12";
				//FalseAllBool();
			}
		}

		if (_PalancaIzqX)
		{
			Save();
			if (analogico1 != 0)
			{
				PalancaIzqX = "Axis1";
				//FalseAllBool();
			}
			if (analogico2 != 0)
			{
				PalancaIzqX = "Axis2";
				//FalseAllBool();
			}
			if (analogico3 != 0)
			{
				PalancaIzqX = "Axis3";
				//FalseAllBool();
			}
			if (analogico4 != 0)
			{
				PalancaIzqX = "Axis4";
				//FalseAllBool();
			}
			if (analogico5 != 0)
			{
				PalancaIzqX = "Axis5";
				//FalseAllBool();
			}
			if (analogico6 != 0)
			{
				PalancaIzqX = "Axis6";
				//FalseAllBool();
			}
			if (analogico7 != 0)
			{
				PalancaIzqX = "Axis7";
				//FalseAllBool();
			}
			if (analogico8 != 0)
			{
				PalancaIzqX = "Axis8";
				//FalseAllBool();
			}
			if (analogico9 != 0)
			{
				PalancaIzqX = "Axis9";
				//FalseAllBool();
			}
			if (analogico10 != 0)
			{
				PalancaIzqX = "Axis10";
				//FalseAllBool();
			}
			if (analogico11 != 0)
			{
				PalancaIzqX = "Axis11";
				//FalseAllBool();
			}
			if (analogico12 != 0)
			{
				PalancaIzqX = "Axis12";
				//FalseAllBool();
			}
		}

		if (_PalancaIzqY)
		{
			Save();
			if (analogico1 != 0)
			{
				PalancaIzqY = "Axis1";
				//FalseAllBool();
			}
			if (analogico2 != 0)
			{
				PalancaIzqY = "Axis2";
				//FalseAllBool();
			}
			if (analogico3 != 0)
			{
				PalancaIzqY = "Axis3";
				//FalseAllBool();
			}
			if (analogico4 != 0)
			{
				PalancaIzqY = "Axis4";
				//FalseAllBool();
			}
			if (analogico5 != 0)
			{
				PalancaIzqY = "Axis5";
				//FalseAllBool();
			}
			if (analogico6 != 0)
			{
				PalancaIzqY = "Axis6";
				//FalseAllBool();
			}
			if (analogico7 != 0)
			{
				PalancaIzqY = "Axis7";
				//FalseAllBool();
			}
			if (analogico8 != 0)
			{
				PalancaIzqY = "Axis8";
				//FalseAllBool();
			}
			if (analogico9 != 0)
			{
				PalancaIzqY = "Axis9";
				//FalseAllBool();
			}
			if (analogico10 != 0)
			{
				PalancaIzqY = "Axis10";
				//FalseAllBool();
			}
			if (analogico11 != 0)
			{
				PalancaIzqY = "Axis11";
				//FalseAllBool();
			}
			if (analogico12 != 0)
			{
				PalancaIzqY = "Axis12";
				//FalseAllBool();
			}
		}

		if (_A)
        {
			Save();
			if (Input.GetButtonDown("B0"))
			{
				A = "B0";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B1"))
			{
				A = "B1";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B2"))
			{
				A = "B2";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B3"))
			{
				A = "B3";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B4"))
			{
				A = "B4";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B5"))
			{
				A = "B5";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B6"))
			{
				A = "B6";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B7"))
			{
				A = "B7";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B8"))
			{
				A = "B8";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B9"))
			{
				A = "B9";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B10"))
			{
				A = "B10";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B11"))
			{
				A = "B11";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B12"))
			{
				A = "B12";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B13"))
			{
				A = "B13";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B14"))
			{
				A = "B14";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B15"))
			{
				A = "B15";
				//FalseAllBool();
			}
		}

		if (_X)
		{
			Save();
			if (Input.GetButtonDown("B0"))
			{
				X = "B0";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B1"))
			{
				X = "B1";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B2"))
			{
				X = "B2";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B3"))
			{
				X = "B3";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B4"))
			{
				X = "B4";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B5"))
			{
				X = "B5";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B6"))
			{
				X = "B6";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B7"))
			{
				X = "B7";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B8"))
			{
				X = "B8";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B9"))
			{
				X = "B9";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B10"))
			{
				X = "B10";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B11"))
			{
				X = "B11";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B12"))
			{
				X = "B12";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B13"))
			{
				X = "B13";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B14"))
			{
				X = "B14";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B15"))
			{
				X = "B15";
				//FalseAllBool();
			}
		}

		if (_B)
		{
			Save();
			if (Input.GetButtonDown("B0"))
			{
				B = "B0";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B1"))
			{
				B = "B1";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B2"))
			{
				B = "B2";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B3"))
			{
				B = "B3";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B4"))
			{
				B = "B4";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B5"))
			{
				B = "B5";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B6"))
			{
				B = "B6";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B7"))
			{
				B = "B7";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B8"))
			{
				B = "B8";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B9"))
			{
				B = "B9";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B10"))
			{
				B = "B10";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B11"))
			{
				B = "B11";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B12"))
			{
				B = "B12";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B13"))
			{
				B = "B13";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B14"))
			{
				B = "B14";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B15"))
			{
				B = "B15";
				//FalseAllBool();
			}
		}

		if (_GatilloR)
		{
			Save();
			switch (Axis)
            {
				case false:

					if (Input.GetButtonDown("B0"))
					{
						GatilloR = "B0";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B1"))
					{
						GatilloR = "B1";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B2"))
					{
						GatilloR = "B2";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B3"))
					{
						GatilloR = "B3";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B4"))
					{
						GatilloR = "B4";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B5"))
					{
						GatilloR = "B5";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B6"))
					{
						GatilloR = "B6";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B7"))
					{
						GatilloR = "B7";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B8"))
					{
						GatilloR = "B8";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B9"))
					{
						GatilloR = "B9";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B10"))
					{
						GatilloR = "B10";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B11"))
					{
						GatilloR = "B11";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B12"))
					{
						GatilloR = "B12";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B13"))
					{
						GatilloR = "B13";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B14"))
					{
						GatilloR = "B14";
						//FalseAllBool();
					}
					if (Input.GetButtonDown("B15"))
					{
						GatilloR = "B15";
						//FalseAllBool();
					}

					break;

				case true:

					if (analogico1 != 0)
					{
						GatilloR = "Axis1";
						//FalseAllBool();
					}
					if (analogico2 != 0)
					{
						GatilloR = "Axis2";
						//FalseAllBool();
					}
					if (analogico3 != 0)
					{
						GatilloR = "Axis3";
						//FalseAllBool();
					}
					if (analogico4 != 0)
					{
						GatilloR = "Axis4";
						//FalseAllBool();
					}
					if (analogico5 != 0)
					{
						GatilloR = "Axis5";
						//FalseAllBool();
					}
					if (analogico6 != 0)
					{
						GatilloR = "Axis6";
						//FalseAllBool();
					}
					if (analogico7 != 0)
					{
						GatilloR = "Axis7";
						//FalseAllBool();
					}
					if (analogico8 != 0)
					{
						GatilloR = "Axis8";
						//FalseAllBool();
					}
					if (analogico9 != 0)
					{
						GatilloR = "Axis9";
						//FalseAllBool();
					}
					if (analogico10 != 0)
					{
						GatilloR = "Axis10";
						//FalseAllBool();
					}
					if (analogico11 != 0)
					{
						GatilloR = "Axis11";
						//FalseAllBool();
					}
					if (analogico12 != 0)
					{
						GatilloR = "Axis12";
						//FalseAllBool();
					}

					break;
            }
		}

		if (_Y)
		{
			Save();
			if (Input.GetButtonDown("B0"))
			{
				Y = "B0";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B1"))
			{
				Y = "B1";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B2"))
			{
				Y = "B2";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B3"))
			{
				Y = "B3";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B4"))
			{
				Y = "B4";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B5"))
			{
				Y = "B5";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B6"))
			{
				Y = "B6";
				//FalseAllBool();
			}
			if (Input.GetButtonDown("B7"))
			{
				Y = "B7";
				
			}
			if (Input.GetButtonDown("B8"))
			{
				Y = "B8";
				
			}
			if (Input.GetButtonDown("B9"))
			{
				Y = "B9";
				
			}
			if (Input.GetButtonDown("B10"))
			{
				Y = "B10";
				
			}
			if (Input.GetButtonDown("B11"))
			{
				Y = "B11";
				
			}
			if (Input.GetButtonDown("B12"))
			{
				Y = "B12";
				
			}
			if (Input.GetButtonDown("B13"))
			{
				Y = "B13";
				
			}
			if (Input.GetButtonDown("B14"))
			{
				Y = "B14";
				
			}
			if (Input.GetButtonDown("B15"))
			{
				Y = "B15";
				
			}
		}

		if (_GatilloL)
		{
			Save();
			switch (Axis)
            {
				case false:

					if (Input.GetButtonDown("B0"))
					{
						GatilloL = "B0";
						;
					}
					if (Input.GetButtonDown("B1"))
					{
						GatilloL = "B1";
						
					}
					if (Input.GetButtonDown("B2"))
					{
						GatilloL = "B2";
						
					}
					if (Input.GetButtonDown("B3"))
					{
						GatilloL = "B3";
						
					}
					if (Input.GetButtonDown("B4"))
					{
						GatilloL = "B4";
						
					}
					if (Input.GetButtonDown("B5"))
					{
						GatilloL = "B5";
						
					}
					if (Input.GetButtonDown("B6"))
					{
						GatilloL = "B6";
						
					}
					if (Input.GetButtonDown("B7"))
					{
						GatilloL = "B7";
						
					}
					if (Input.GetButtonDown("B8"))
					{
						GatilloL = "B8";
						
					}
					if (Input.GetButtonDown("B9"))
					{
						GatilloL = "B9";
						
					}
					if (Input.GetButtonDown("B10"))
					{
						GatilloL = "B10";
						
					}
					if (Input.GetButtonDown("B11"))
					{
						GatilloL = "B11";
						
					}
					if (Input.GetButtonDown("B12"))
					{
						GatilloL = "B12";
						
					}
					if (Input.GetButtonDown("B13"))
					{
						GatilloL = "B13";
						
					}
					if (Input.GetButtonDown("B14"))
					{
						GatilloL = "B14";
						
					}
					if (Input.GetButtonDown("B15"))
					{
						GatilloL = "B15";
						
					}

					break;

				case true:

					if (analogico1 != 0)
					{
						GatilloL = "Axis1";
						
					}
					if (analogico2 != 0)
					{
						GatilloL = "Axis2";
						
					}
					if (analogico3 != 0)
					{
						GatilloL = "Axis3";
						
					}
					if (analogico4 != 0)
					{
						GatilloL = "Axis4";
						
					}
					if (analogico5 != 0)
					{
						GatilloL = "Axis5";
						
					}
					if (analogico6 != 0)
					{
						GatilloL = "Axis6";
						
					}
					if (analogico7 != 0)
					{
						GatilloL = "Axis7";
						
					}
					if (analogico8 != 0)
					{
						GatilloL = "Axis8";
						
					}
					if (analogico9 != 0)
					{
						GatilloL = "Axis9";
						
					}
					if (analogico10 != 0)
					{
						GatilloL = "Axis10";
						
					}
					if (analogico11 != 0)
					{
						GatilloL = "Axis11";
						
					}
					if (analogico12 != 0)
					{
						GatilloL = "Axis12";
						
					}

					break;
            }
		}

		if (_LB)
		{
			Save();
			if (Input.GetButtonDown("B0"))
			{
				LB = "B0";
				
			}
			if (Input.GetButtonDown("B1"))
			{
				LB = "B1";
				
			}
			if (Input.GetButtonDown("B2"))
			{
				LB = "B2";
				
			}
			if (Input.GetButtonDown("B3"))
			{
				LB = "B3";
				
			}
			if (Input.GetButtonDown("B4"))
			{
				LB = "B4";
				
			}
			if (Input.GetButtonDown("B5"))
			{
				LB = "B5";
				
			}
			if (Input.GetButtonDown("B6"))
			{
				LB = "B6";
				
			}
			if (Input.GetButtonDown("B7"))
			{
				LB = "B7";
				
			}
			if (Input.GetButtonDown("B8"))
			{
				LB = "B8";
				
			}
			if (Input.GetButtonDown("B9"))
			{
				LB = "B9";
				
			}
			if (Input.GetButtonDown("B10"))
			{
				LB = "B10";
				
			}
			if (Input.GetButtonDown("B11"))
			{
				LB = "B11";
				
			}
			if (Input.GetButtonDown("B12"))
			{
				LB = "B12";
				
			}
			if (Input.GetButtonDown("B13"))
			{
				LB = "B13";
				
			}
			if (Input.GetButtonDown("B14"))
			{
				LB = "B14";
				
			}
			if (Input.GetButtonDown("B15"))
			{
				LB = "B15";
				
			}
		}

		if (_RB)
		{
			Save();
			if (Input.GetButtonDown("B0"))
			{
				RB = "B0";
				
			}
			if (Input.GetButtonDown("B1"))
			{
				RB = "B1";
				
			}
			if (Input.GetButtonDown("B2"))
			{
				RB = "B2";
				
			}
			if (Input.GetButtonDown("B3"))
			{
				RB = "B3";
				
			}
			if (Input.GetButtonDown("B4"))
			{
				RB = "B4";
				
			}
			if (Input.GetButtonDown("B5"))
			{
				RB = "B5";
				
			}
			if (Input.GetButtonDown("B6"))
			{
				RB = "B6";
				
			}
			if (Input.GetButtonDown("B7"))
			{
				RB = "B7";
				
			}
			if (Input.GetButtonDown("B8"))
			{
				RB = "B8";
				
			}
			if (Input.GetButtonDown("B9"))
			{
				RB = "B9";
				
			}
			if (Input.GetButtonDown("B10"))
			{
				RB = "B10";
				
			}
			if (Input.GetButtonDown("B11"))
			{
				RB = "B11";
				
			}
			if (Input.GetButtonDown("B12"))
			{
				RB = "B12";
				
			}
			if (Input.GetButtonDown("B13"))
			{
				RB = "B13";
				
			}
			if (Input.GetButtonDown("B14"))
			{
				RB = "B14";
				
			}
			if (Input.GetButtonDown("B15"))
			{
				RB = "B15";
				
			}
		}

		if (_PBL)
		{
			Save();
			if (Input.GetButtonDown("B0"))
			{
				PBL = "B0";
				
			}
			if (Input.GetButtonDown("B1"))
			{
				PBL = "B1";
				
			}
			if (Input.GetButtonDown("B2"))
			{
				PBL = "B2";
				
			}
			if (Input.GetButtonDown("B3"))
			{
				PBL = "B3";
				
			}
			if (Input.GetButtonDown("B4"))
			{
				PBL = "B4";
				
			}
			if (Input.GetButtonDown("B5"))
			{
				PBL = "B5";
				
			}
			if (Input.GetButtonDown("B6"))
			{
				PBL = "B6";
				
			}
			if (Input.GetButtonDown("B7"))
			{
				PBL = "B7";
				
			}
			if (Input.GetButtonDown("B8"))
			{
				PBL = "B8";
				
			}
			if (Input.GetButtonDown("B9"))
			{
				PBL = "B9";
				
			}
			if (Input.GetButtonDown("B10"))
			{
				PBL = "B10";
				
			}
			if (Input.GetButtonDown("B11"))
			{
				PBL = "B11";
				
			}
			if (Input.GetButtonDown("B12"))
			{
				PBL = "B12";
				
			}
			if (Input.GetButtonDown("B13"))
			{
				PBL = "B13";
				
			}
			if (Input.GetButtonDown("B14"))
			{
				PBL = "B14";
				
			}
			if (Input.GetButtonDown("B15"))
			{
				PBL = "B15";
				
			}
		}

		if (_PBR)
		{
			Save();
			if (Input.GetButtonDown("B0"))
			{
				PBR = "B0";
				
			}
			if (Input.GetButtonDown("B1"))
			{
				PBR = "B1";
				
			}
			if (Input.GetButtonDown("B2"))
			{
				PBR = "B2";
				
			}
			if (Input.GetButtonDown("B3"))
			{
				PBR = "B3";
				
			}
			if (Input.GetButtonDown("B4"))
			{
				PBR = "B4";
				
			}
			if (Input.GetButtonDown("B5"))
			{
				PBR = "B5";
				
			}
			if (Input.GetButtonDown("B6"))
			{
				PBR = "B6";
			
			}
			if (Input.GetButtonDown("B7"))
			{
				PBR = "B7";
				
			}
			if (Input.GetButtonDown("B8"))
			{
				PBR = "B8";
				
			}
			if (Input.GetButtonDown("B9"))
			{
				PBR = "B9";
				
			}
			if (Input.GetButtonDown("B10"))
			{
				PBR = "B10";
				
			}
			if (Input.GetButtonDown("B11"))
			{
				PBR = "B11";
				
			}
			if (Input.GetButtonDown("B12"))
			{
				PBR = "B12";
				
			}
			if (Input.GetButtonDown("B13"))
			{
				PBR = "B13";
				
			}
			if (Input.GetButtonDown("B14"))
			{
				PBR = "B14";
				
			}
			if (Input.GetButtonDown("B15"))
			{
				PBR = "B15";
				
			}
		}

		if (_Star)
		{
			Save();
			if (Input.GetButtonDown("B0"))
			{
				Star = "B0";
				
			}
			if (Input.GetButtonDown("B1"))
			{
				Star = "B1";
				
			}
			if (Input.GetButtonDown("B2"))
			{
				Star = "B2";
				
			}
			if (Input.GetButtonDown("B3"))
			{
				Star = "B3";
				
			}
			if (Input.GetButtonDown("B4"))
			{
				Star = "B4";
				
			}
			if (Input.GetButtonDown("B5"))
			{
				Star = "B5";
				
			}
			if (Input.GetButtonDown("B6"))
			{
				Star = "B6";
				
			}
			if (Input.GetButtonDown("B7"))
			{
				Star = "B7";
				
			}
			if (Input.GetButtonDown("B8"))
			{
				Star = "B8";
				
			}
			if (Input.GetButtonDown("B9"))
			{
				Star = "B9";
				
			}
			if (Input.GetButtonDown("B10"))
			{
				Star = "B10";
				
			}
			if (Input.GetButtonDown("B11"))
			{
				Star = "B11";
				
			}
			if (Input.GetButtonDown("B12"))
			{
				Star = "B12";
				
			}
			if (Input.GetButtonDown("B13"))
			{
				Star = "B13";
				
			}
			if (Input.GetButtonDown("B14"))
			{
				Star = "B14";
				
			}
			if (Input.GetButtonDown("B15"))
			{
				Star = "B15";
				
			}
		}

		if (_Selec)
		{
			Save();
			if (Input.GetButtonDown("B0"))
			{
				Selec = "B0";
				
			}
			if (Input.GetButtonDown("B1"))
			{
				Selec = "B1";
				
			}
			if (Input.GetButtonDown("B2"))
			{
				Selec = "B2";
				
			}
			if (Input.GetButtonDown("B3"))
			{
				Selec = "B3";
				
			}
			if (Input.GetButtonDown("B4"))
			{
				Selec = "B4";
				
			}
			if (Input.GetButtonDown("B5"))
			{
				Selec = "B5";
				
			}
			if (Input.GetButtonDown("B6"))
			{
				Selec = "B6";
				
			}
			if (Input.GetButtonDown("B7"))
			{
				Selec = "B7";
				
			}
			if (Input.GetButtonDown("B8"))
			{
				Selec = "B8";
				
			}
			if (Input.GetButtonDown("B9"))
			{
				Selec = "B9";
				
			}
			if (Input.GetButtonDown("B10"))
			{
				Selec = "B10";
				
			}
			if (Input.GetButtonDown("B11"))
			{
				Selec = "B11";
				
			}
			if (Input.GetButtonDown("B12"))
			{
				Selec = "B12";
				
			}
			if (Input.GetButtonDown("B13"))
			{
				Selec = "B13";
				
			}
			if (Input.GetButtonDown("B14"))
			{
				Selec = "B14";
				
			}
			if (Input.GetButtonDown("B15"))
			{
				Selec = "B15";
				
			}
		}
	}

	public void FalseAllBool()
	{
		_A = false;
		
		_X = false;
		
		_B = false;
		
		_Y = false;
		
		_LB = false;
		
		_RB = false;
		
		_PBL = false;

		_PBR = false;
		
		_Star = false;
		
		_Selec = false;
		
		_GatilloL = false;
		
		_GatilloR = false;

		_PadH = false;

		_PadV = false;

		_PalancaDerX = false;

		_PalancaDerY = false;

		_PalancaIzqX = false;

		_PalancaIzqY = false;


		Axis = false;
		Save();
	}

	public void Save()
    {
		
		PlayerPrefs.SetString("GatilloR", GatilloR);
		
		PlayerPrefs.SetString("GatilloL", GatilloL);
		
		PlayerPrefs.SetString("A", A);
		
		PlayerPrefs.SetString("X", X);
		
		PlayerPrefs.SetString("B", B);
		
		PlayerPrefs.SetString("Y", Y);
		
		PlayerPrefs.SetString("LB", LB);
		
		PlayerPrefs.SetString("RB", RB);
		
		PlayerPrefs.SetString("PBL", PBL);
		
		PlayerPrefs.SetString("PBR", PBR);
		
		PlayerPrefs.SetString("Start", Star);
		
		PlayerPrefs.SetString("Select", Selec);

		PlayerPrefs.SetString("PadH", PadH);

		PlayerPrefs.SetString("PadV", PadV);

		PlayerPrefs.SetString("MovimientoX", PalancaIzqX);

		PlayerPrefs.SetString("MovimientoY", PalancaIzqY);

		PlayerPrefs.SetString("VistaX", PalancaDerX);

		PlayerPrefs.SetString("VistaY", PalancaDerY);
	}

    public void Resetear()
    {
		GatilloL = PlayerPrefs.GetString("GatilloL", "B10");
		GatilloR = PlayerPrefs.GetString("GatilloR", "B11");
		A = PlayerPrefs.GetString("A", "B0");
		X = PlayerPrefs.GetString("X", "B1");
		B = PlayerPrefs.GetString("B", "B2");
		Y = PlayerPrefs.GetString("Y", "B3");
		LB = PlayerPrefs.GetString("LB", "B4");
		RB = PlayerPrefs.GetString("RB", "B5");
		PBL = PlayerPrefs.GetString("PBL", "B6");
		PBR = PlayerPrefs.GetString("PBR", "B7");
		Star = PlayerPrefs.GetString("Start", "B8");
		Selec = PlayerPrefs.GetString("Select", "B9");
		PalancaDerX = PlayerPrefs.GetString("VistaX", "Axis3");
		PalancaDerY = PlayerPrefs.GetString("VistaY", "Axis4");
		PalancaIzqX = PlayerPrefs.GetString("MovimientoX", "Axis1");
		PalancaIzqY = PlayerPrefs.GetString("MovimientoY", "Axis2");
		PadH = PlayerPrefs.GetString("PadH", "Axis5");
		PadV = PlayerPrefs.GetString("PadV", "Axis6");
	}

	public void PalancaLX()
	{
		_PalancaIzqX = true;
	}

	public void PalancaLY()
	{
		_PalancaIzqY = true;
	}

	public void PalancaRX()
	{
		_PalancaDerX = true;
	}

	public void PalancaRY()
	{
		_PalancaDerY = true;
	}

	public void PadX()
	{
		_PadH = true;
	}

	public void PadY()
	{
		_PadV = true;
	}

	public void TriggerR()
    {
		_GatilloR = true;
    }

	public void TriggerL()
	{
		_GatilloL = true;
	}

	public void ButtonA()
	{
		_A = true;
	}

	public void ButtonX()
	{
		_X = true;
	}

	public void ButtonB()
	{
		_B = true;
	}

	public void ButtonY()
	{
		_Y = true;
	}

	public void ButtonLB()
	{
		_LB = true;
	}

	public void ButtonRB()
	{
		_RB = true;
	}

	public void ButtonPBL()
	{
		_PBL = true;
	}

	public void ButtonPBR()
	{
		_PBR = true;
	}

	public void Inicio()
	{
		_Star = true;
	}

	public void Select()
	{
		_Selec = true;
	}

	public void Axiss (bool value)
    {
		Axis = value;
    }
}
