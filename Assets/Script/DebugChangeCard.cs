using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChangeCard : MonoBehaviour {

    private CardFlipper flipper;
    private CardModel cardModel;
    private int cardIndex = 0;

    public GameObject card;

	void Awake() {
        cardModel = card.GetComponent<CardModel>();
        flipper = card.GetComponent<CardFlipper>();
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 28), "Hit me!"))
        {
            if(cardIndex >= cardModel.faces.Length)
            {
                cardIndex = 0;
                flipper.flipCard(cardModel.faces[cardModel.faces.Length-1 ], cardModel.cardBack, -1);
                //cardModel.toggleFace(false);
            }
            else
            {
                if(cardIndex > 0)
                {
                    flipper.flipCard(cardModel.faces[cardIndex - 1], cardModel.faces[cardIndex], cardIndex);
                }
                else
                {
                    flipper.flipCard(cardModel.cardBack, cardModel.faces[cardIndex], cardIndex);
                }
                //cardModel.cardIndex = cardIndex;
                //cardModel.toggleFace(true);
                //putting here ensures u dont skip a card in the deck
                cardIndex++;
            }
        }         
    }
	
}
