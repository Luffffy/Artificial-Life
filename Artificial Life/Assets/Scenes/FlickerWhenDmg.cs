using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FlickerWhenDmg : MonoBehaviour {
    public float spriteBlinkingTimer = 0.0f;
    public float spriteBlinkingMiniDuration = 0.01f;
    public float spriteBlinkingTotalTimer = 0.0f;
    public float spriteBlinkingTotalDuration = 1.0f;
    public bool startBlinking = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //StartBlinkingEffect();
        }
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
       // if()
        {
            startBlinking = true;
        }
    }
    private void SpriteBlinkingEffect()
    {
        spriteBlinkingTotalTimer += Time.deltaTime;
        if(spriteBlinkingTotalTimer >= spriteBlinkingTotalDuration)
        {
            startBlinking = false;
            spriteBlinkingTotalTimer = 0.0f;
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;//according to sprite
            return;
        }
        spriteBlinkingTimer += Time.deltaTime;
        if(spriteBlinkingTimer >= spriteBlinkingMiniDuration)
        {
            spriteBlinkingTimer = 0.0f;
            if (this.gameObject.GetComponent<SpriteRenderer>().enabled == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;//changes according to our game
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().enabled = true;//changes according to our game
            }
        }
    }
}
