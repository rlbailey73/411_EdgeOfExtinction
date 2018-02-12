//WILL DETERMINE WHICH DECK IS PICKED AND WILL DISPLAY THE CARDS ABSED ON THAT DECK

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickDeck : MonoBehaviour {

    public int cr = 0; //clarion river deck
    public int anp = 1; //allagheny national park deck
    public int ah = 2; //appalachian homestead deck
    public int pb = 3; //peat bogs deck

    public int chosenDeck = -1; //set to -1 to determine if there are any issues

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //sets the deck chosen
    public void SetDeck(int deck)
    {
        chosenDeck = deck;
    }

    //Determines which deck is selected
    public void ChosenDeck()
    {

    }
}
