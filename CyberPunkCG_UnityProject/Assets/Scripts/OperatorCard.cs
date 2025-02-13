using UnityEngine;

public class OperatorCard : Card
{
    public string specialAbility;
    public int health;
    public int attack;


    public override void InitializeCard(string id, string name, string description, int cost)
    {
        base.InitializeCard(id, name, description, cost);
    }
    public void InitializeOperatorCard(string id, string name, string description, int cost, string ability)
    {
        InitializeCard(id, name, description, cost);
        this.specialAbility = ability;
    }


}
