using UnityEngine;

public class MeleeEnemy : Enemy
{
    [SerializeField]
    private int _weaponDurability;

    public void RepairWeapon()
    {
        Debug.Log("Enemy Repair Weapon");
    }

    public override void Attack()
    {
        Debug.Log("Melee Attack");
        base.Attack();
    }
}
