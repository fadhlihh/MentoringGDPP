using UnityEngine;

public class Skill
{
    private string _name;
    private int _mannaCost;

    public Skill(string name, int mannaCost)
    {
        this._name = name;
        this._mannaCost = mannaCost;
    }

    public void CastSkill()
    {
        Debug.Log($"Player Cast Skill {_name}, {_mannaCost}");
    }
}
