using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Item potion;
    public Item poison;

    private void Awake()
    {
        potion = new Item("Heal Potion", 3);
        potion.Name = "New Heal Potion";
        Debug.Log(potion.Name);
        poison = new Item("Death Poison", 2);
    }
}
