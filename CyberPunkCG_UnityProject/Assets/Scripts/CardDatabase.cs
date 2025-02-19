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

        CreateOperatorCard(0, "The Hacker", "This is The Hacker", UnityEngine.Random.Range(0, 10), "Hacks the enemy");
        CreateOperatorCard(1, "The DataAnalyst", "This is The DataAnalyst", UnityEngine.Random.Range(0, 10), "Analyzes data");
        CreateOperatorCard(2, "The Engineer", "This is The Engineer", UnityEngine.Random.Range(0, 10), "Builds stuff");
        CreateOperatorCard(3, "The Scientist", "This is The Scientist", UnityEngine.Random.Range(0, 10), "Does science");
        CreateOperatorCard(4, "The Medic", "This is The Medic", UnityEngine.Random.Range(0, 10), "Heals the team");
        CreateOperatorCard(5, "The Soldier", "This is The Soldier", UnityEngine.Random.Range(0, 10), "Fights the enemy");
        CreateOperatorCard(6, "The Sniper", "This is The Sniper", UnityEngine.Random.Range(0, 10), "Shoots the enemy");
    }

    private void CreateOperatorCard(int id, string name, string description, int cost, string ability)
    {
        GameObject cardObject = new GameObject(name);
        cardObject.transform.SetParent(this.transform);

        OperatorCard operatorCard = cardObject.AddComponent<OperatorCard>();
        operatorCard.InitializeOperatorCard(id, name, description, cost, ability);
        operatorCardList.Add(operatorCard);
    }
}
