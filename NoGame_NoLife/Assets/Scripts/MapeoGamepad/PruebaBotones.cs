using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaBotones : MonoBehaviour
{
    string BotonAumentar, BotonDisminuir, PalancaIzqX, PalancaIzqY;
    float H, V;
    public float Velocidad = 3f;
    public bool InvertirX, InvertirY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BotonAumentar = MapearBotones.Mapeo.Star;
        BotonDisminuir = MapearBotones.Mapeo.Selec;
        PalancaIzqX = MapearBotones.Mapeo.PalancaIzqX;
        PalancaIzqY = MapearBotones.Mapeo.PalancaIzqY;

        switch (InvertirX)
        {
            case true:

                H = -Input.GetAxis(PalancaIzqX) * Time.deltaTime * Velocidad;

                break;

            case false:

                H = Input.GetAxis(PalancaIzqX) * Time.deltaTime * Velocidad;

                break;
        }

        switch (InvertirY)
        {
            case true:

                V = -Input.GetAxis(PalancaIzqY) * Time.deltaTime * Velocidad;

                break;

            case false:

                V = Input.GetAxis(PalancaIzqY) * Time.deltaTime * Velocidad;

                break;
        }

        if (Input.GetButtonDown(BotonAumentar))
        {
            Aumentar();
        }

        if (Input.GetButtonDown(BotonDisminuir))
        {
            Disminuir();
        }

        Mover();
    }

    void Mover()
    {
        transform.position += new Vector3(H, V, 0);
    }

    void Aumentar()
    {
        transform.localScale += new Vector3(1, 1, 1);
    }

    void Disminuir()
    {
        transform.localScale -= new Vector3(1, 1, 1);
    }
}
