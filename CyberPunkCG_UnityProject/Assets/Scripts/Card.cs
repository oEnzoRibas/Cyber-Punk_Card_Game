using UnityEngine;
using System.Collections;
[System.Serializable]

public class Card : MonoBehaviour
{
    public string cardID;
    public string cardName;
    public string cardDescription;
    public int cost;

    public virtual void InitializeCard(string id, string name, string description, int cost)
    {
        this.cardID = id;
        this.cardName = name;
        this.cardDescription = description;
        this.cost = cost;
    }

    public void createOperatorCard(){
        GameObject cardObject = new GameObject("OperatorCardHacker");
        OperatorCard operatorCardHacker = cardObject.AddComponent<OperatorCard>();
        operatorCardHacker.InitializeOperatorCard("OP001", "The Hacker", "This is The Hacker", 1, "Hacks the enemy");
        }

    
}
