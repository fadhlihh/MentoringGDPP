using UnityEngine;

public class ProjectileSkill : Skill
{
    private float _distance;

    public ProjectileSkill(string name, int mannaCost, float distance) : base(name, mannaCost)
    {
        this._distance = distance;
    }
}
