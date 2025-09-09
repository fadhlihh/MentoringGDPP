using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    protected string _name;
    [SerializeField]
    protected int _healthPoint;

    public void Move()
    {
        Debug.Log("Move Enemy");
    }

    public virtual void Attack()
    {
        Debug.Log("Enemy Attack");
    }

    private void Start()
    {
        Attack();
    }
}
