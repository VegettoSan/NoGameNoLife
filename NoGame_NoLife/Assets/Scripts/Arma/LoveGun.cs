using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveGun : MonoBehaviour
{
    public static LoveGun Instance;
    public Transform Origen, Camara;
    public float Balas = 1f, VelocidadBala = 3f;
    public Rigidbody Bala;
    public GameObject Muzzle;
    AudioSource Source;
    public AudioClip Disparo, SinBalas;

    NewPlayer Movimiento;
    void Start()
    {
        Source = GetComponent<AudioSource>();
        Movimiento = GetComponentInParent<NewPlayer>();
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Balas = Mathf.Clamp(Balas, 0, 1);
        MedidorBalas();

        if (Input.GetButtonDown(PlayerPrefs.GetString("GatilloR")))
        {
            Disparar();
        }

        if (Balas <= 0f)
        {
            Balas = 1;
        }
    }

    void MedidorBalas()
    {
        MedidorGunLove.Medi.Valor = Balas;
    }

    public void Disparar()
    {

        if (Balas > 0)
        {
            Movimiento.Apuntar();
            Balas -= 0.05f;
            Muzzle.SetActive(true);

            Source.PlayOneShot(Disparo);
            Rigidbody clone = Instantiate(Bala, Origen.position, Camara.rotation) as Rigidbody;
            clone.velocity = Camara.TransformDirection(Vector3.forward * VelocidadBala);
        }

        Invoke("FalseMuzzle", 0.1f);
    }

    public void FalseMuzzle()
    {
        Muzzle.SetActive(false);
    }
}
