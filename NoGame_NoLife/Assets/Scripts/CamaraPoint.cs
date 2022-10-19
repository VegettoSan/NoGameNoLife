using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPoint : MonoBehaviour
{
    public float Distancia = 100f;
    public Transform Point, Zero;
    public LayerMask Layers;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PointView();
    }

    void PointView()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.forward, out Hit, Distancia, Layers))
        {
            Debug.DrawLine(transform.position, Hit.point * Distancia);
            Point.position = Hit.point;
        }
    }
}
