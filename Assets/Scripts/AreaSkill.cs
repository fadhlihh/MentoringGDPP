using UnityEngine;

public class AreaSkill : Skill
{
    private float _radius;

    public AreaSkill(string name, int mannaCost, float radius) : base(name, mannaCost)
    {
        this._radius = radius;
    }
}
