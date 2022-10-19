using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoMapeo : MonoBehaviour
{
    public string Mapp, Intro = "";
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Intro + PlayerPrefs.GetString(Mapp, "---");
    }
}
