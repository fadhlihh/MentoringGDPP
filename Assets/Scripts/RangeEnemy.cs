using UnityEngine;

public class RangeEnemy : Enemy
{
    [SerializeField]
    private int _ammunition;

    public void Reload()
    {
        Debug.Log("Enemy Reload");
    }

    public override void Attack()
    {
        Debug.Log("Range Attack");
    }
}
