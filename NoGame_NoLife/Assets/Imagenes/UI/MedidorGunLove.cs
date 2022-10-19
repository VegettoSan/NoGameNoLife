using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedidorGunLove : MonoBehaviour
{
    public static MedidorGunLove Medi;
    Image Medidor;
    public float Valor;
    void Start()
    {
        Medidor = GetComponent<Image>();

        if (Medi == null)
        {
            Medi = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Valor = Mathf.Clamp(Valor, 0f, 1f);
        Medida();
    }

    public void Medida()
    {
        //float MedidorUwU = Mathf.Clamp(Valor, 0f, 1f);
        Medidor.fillAmount = Valor;
    }
}
