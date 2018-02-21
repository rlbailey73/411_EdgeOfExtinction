using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFlipper : MonoBehaviour {

    //come from the gameobject
    private SpriteRenderer spriteRenderer;
    private CardModel model;

    // starts from full size to 0 so not vis to 1 again to see back without 
    //having an actual two sided card
    public AnimationCurve scaleCurve; 
    public float duration = 0.5f;

    //just gets components we need later on
    //awake: like a constructor but in unity constructors can be called
    //multiple times which can cause a lot of issues with the code
    //being initialized improperly
    //use Awake or Start
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        model = GetComponent<CardModel>();
    }

    public void flipCard(Sprite startImage, Sprite endImage, int cardIndex)
    {
        StopCoroutine(Flip(startImage, endImage, cardIndex));
        //actually executes the coroutine
        StartCoroutine(Flip(startImage, endImage, cardIndex));
    }

    //essentially does the flipping of the card here
    //calls scale values to get the 'side' of the card
    IEnumerator Flip(Sprite startImage, Sprite endImage, int cardIndex)
    {
        spriteRenderer.sprite = startImage;

        float time = 0f;
        while(time <= 1f)
        {
            float scale = scaleCurve.Evaluate(time); //scales size of card
            time = time + Time.deltaTime / duration; //take delta time / dur and add to time

            Vector3 localScale = transform.localScale;
            localScale.x = scale; //scales along the x axis to help simulate the 
            //card flip animation, kinda makes it squish

            transform.localScale = localScale;

            if(time >= 0.5f)
            {
                spriteRenderer.sprite = endImage;
            }

            yield return new WaitForFixedUpdate(); //returns a fixed update from enum class
        }

        if(cardIndex == -1)
        {
            model.toggleFace(false);
        }
        else
        {
            model.cardIndex = cardIndex;
            model.toggleFace(true);
        }
    }
}
