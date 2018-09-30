using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpriteScript : MonoBehaviour {

    public float fadeSpeed = 1f;
    public float fadeTime = 1f;
    public bool fadeIn = true;
    public float fade;
    public SpriteRenderer text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (fadeIn)
        {
            float Fade = Mathf.SmoothDamp(0f, 1f, ref fadeSpeed, fadeTime);
            text.color = new Color(1f, 1f, 1f, Fade);
        }
        if(!fadeIn)
        {
            float Fade = Mathf.SmoothDamp(1, 0f, ref fadeSpeed, fadeTime);
            text.color = new Color(1f, 1f, 1f, Fade);
        }
	}
}
