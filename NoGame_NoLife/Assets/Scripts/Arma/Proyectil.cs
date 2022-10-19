using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public GameObject Corazones;
    void Start()
    {
        
    }

    void Update()
    {
        Destroy(this.gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Punto"))
        {
            LoveGun.Instance.Balas += 0.05f * 2f;
            Destroy(this.gameObject);
        }

        Instantiate(Corazones, transform.position, transform.rotation);
    }
}
