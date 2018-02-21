using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel : MonoBehaviour {

    SpriteRenderer spriteRenderer; //sprite renderer object

    public Sprite[] faces; //an array to hold each sprite
    public Sprite cardBack; //will be the card back variable in order to start flipping cards

    public int cardIndex; //index for faces array to draw the card

    public void toggleFace(bool showFace)
    {
        if(showFace)
        {
            // show the card face
            spriteRenderer.sprite = faces[cardIndex];
        }
        else
        {
            // show the card back
            spriteRenderer.sprite = cardBack;
        }
    }

    //overridden for your each pieces
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
