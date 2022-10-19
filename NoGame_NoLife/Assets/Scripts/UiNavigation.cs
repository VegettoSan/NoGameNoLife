using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiNavigation : MonoBehaviour
{
    public Toggle tg;
    public GameObject Obj;
    public Button One,Two;
    void Start()
    {
        
    }

    
    void Update()
    {
        ChangeNavigation();
    }

    public void PrimerBoton(GameObject FirstObject)
    {
        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(FirstObject);
    }

    public void ChangeNavigation()
    {
        if (tg != null)
        {
            if (Obj.activeSelf == false)
            {
                Navigation navigation = tg.navigation;

                navigation.selectOnRight = Two;

                tg.navigation = navigation;
            }
            else if (Obj.activeSelf == true)
            {
                Navigation navigation = tg.navigation;

                navigation.selectOnRight = One;

                tg.navigation = navigation;
            }
        }
    }
}
