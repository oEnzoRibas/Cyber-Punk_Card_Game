using UnityEngine;
using System.Collections.Generic;

public class NewEmptyCSharpScript : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();


    void Awake()
    {

        GameObject cardObject = new GameObject("OperatorCardHacker");
        OperatorCard operatorCardHacker = cardObject.AddComponent<OperatorCard>();
        operatorCardHacker.InitializeOperatorCard("OP001", "The Hacker", "This is The Hacker", 1, "Hacks the enemy");
        cardList.Add(operatorCardHacker);

        GameObject cardDataAnalyst = new GameObject("OperatorCardHacker");
        OperatorCard operatorCardDataAnalyst = cardObject.AddComponent<OperatorCard>();
        operatorCardHacker.InitializeOperatorCard("OP001", "The DataAnalyst", "This is The DataAnalyst", 1, "Hacks the enemy");
        cardList.Add(operatorCardDataAnalyst);

    }
}
