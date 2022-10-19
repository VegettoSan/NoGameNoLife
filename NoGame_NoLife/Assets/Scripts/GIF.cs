using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GIF : MonoBehaviour {

	public Sprite[] frames;
    public int fps = 10;

    void Update()
    {
        int index = (int)(Time.time * fps) % frames.Length;
        //GetComponent<RawImage>().texture = frames[index];
		GetComponent<Image>().sprite = frames[index];
    }
}
