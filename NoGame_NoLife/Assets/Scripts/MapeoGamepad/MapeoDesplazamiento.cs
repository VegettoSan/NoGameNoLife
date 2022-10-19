using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MapeoDesplazamiento : MonoBehaviour
{
    StandaloneInputModule InputModule;
    void Start()
    {
        InputModule = GetComponent<StandaloneInputModule>();
    }

    // Update is called once per frame
    void Update()
    {
        Chance();
    }

    public void Chance()
    {
        InputModule.horizontalAxis = PlayerPrefs.GetString("MovimientoX", "Axis1");
        InputModule.verticalAxis = PlayerPrefs.GetString("MovimientoY", "Axis2");
        InputModule.submitButton = PlayerPrefs.GetString("A", "B0");
        InputModule.cancelButton = PlayerPrefs.GetString("B", "B1");
    }
}
