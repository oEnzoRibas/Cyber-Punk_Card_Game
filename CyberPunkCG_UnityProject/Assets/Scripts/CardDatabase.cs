using UnityEngine;
using System.Collections.Generic;
using Unity.Mathematics;

public class CardDatabase : MonoBehaviour
{
    public static List<OperatorCard> operatorCardList = new List<OperatorCard>();

    void Awake()
    {
        if (operatorCardList == null)
            operatorCardList = new List<OperatorCard>();

        CreateOperatorCard(0, "The Hacker", "This is The Hacker", UnityEngine.Random.Range(0, 10), "Hacks the enemy", 10, 10);
        CreateOperatorCard(1, "The DataAnalyst", "This is The DataAnalyst", UnityEngine.Random.Range(0, 10), "Analyzes data", 23, 21);
        CreateOperatorCard(2, "The Engineer", "This is The Engineer", UnityEngine.Random.Range(0, 10), "Builds stuff", 3, 2);
        CreateOperatorCard(3, "The Scientist", "This is The Scientist", UnityEngine.Random.Range(0, 10), "Does science", 24, 23);
        CreateOperatorCard(4, "The Medic", "This is The Medic", UnityEngine.Random.Range(0, 10), "Heals the team", 20, 12);
        CreateOperatorCard(5, "The Soldier", "This is The Soldier", UnityEngine.Random.Range(0, 10), "Fights the enemy", 22 ,45);
        CreateOperatorCard(6, "The Sniper", "This is The Sniper", UnityEngine.Random.Range(0, 10), "Shoots the enemy", 23, 60);
    }

    private void CreateOperatorCard(int id, string name, string description, int cost, string ability, int attack, int health)
    {
        GameObject cardObject = new GameObject(name);
        cardObject.transform.SetParent(this.transform);

        OperatorCard operatorCard = cardObject.AddComponent<OperatorCard>();
        operatorCard.InitializeOperatorCard(id, name, description, cost, ability,  attack,  health);
        operatorCardList.Add(operatorCard);
    }
}
