using UnityEngine;

public class OperatorCard : Card
{
    public string specialAbility;
    public int health = 12;
    public int attack = 0;

    public override void InitializeCard(int cardID, string name, string description, int cost)
    {
        base.InitializeCard(cardID, name, description, cost);
    }

    public void InitializeOperatorCard(int cardID, string name, string description, int cost, string ability, int attack, int health)
    {
        InitializeCard(cardID, name, description, cost);
        specialAbility = ability;
        this.health = health;
        this.attack = attack;
    }
}
