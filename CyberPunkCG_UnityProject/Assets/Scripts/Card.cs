using UnityEngine;
using System.Collections;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int cardID;
    public string cardName;
    public string cardDescription;
    public int cost;

    public virtual void InitializeCard(int id, string name, string description, int cost)
    {
        this.cardID = id;
        this.cardName = name;
        this.cardDescription = description;
        this.cost = cost;
    }
    
}
