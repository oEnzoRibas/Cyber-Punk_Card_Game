    using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class DisplayCard : MonoBehaviour
{
    public List <OperatorCard> displayCardList = new List<OperatorCard>();
    public int displayId;
    public int cardID, health, attack, cost;
    public string cardName, cardDescription, specialAbility;
    public Text cardIDText, cardNameText, cardDescriptionText, costText, specialAbilityText, healthText, attackText;


        void Start()
{
    if (CardDatabase.operatorCardList.Count > displayId && displayId >= 0)
    {
        displayCardList.Add(CardDatabase.operatorCardList[displayId]);
    }
    else
    {
        Debug.LogError("Display ID fora do intervalo da lista de cards.");
    }
}


    void Update()
    {
        // When implementing on Unity, if you dont atribute the text variable to an text object in the scene, it will return an error

        cardName = displayCardList[0].cardName;
        cardID = displayCardList[0].cardID;
        cardDescription = displayCardList[0].cardDescription;
        cost = displayCardList[0].cost;
        specialAbility = displayCardList[0].specialAbility;
        health = displayCardList[0].health;
        attack = displayCardList[0].attack;

        cardNameText.text = "" + cardName;
        // cardIDText.text = "" + cardID;
        cardDescriptionText.text = " " + cardDescription;
        costText.text = " " + cost;
        specialAbilityText.text = "" + specialAbility;
        healthText.text = " " + health;
        attackText.text = " " + attack;

    }
    }