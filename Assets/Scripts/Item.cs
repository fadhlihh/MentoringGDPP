using UnityEngine;

public class Item
{
    private string _name;
    private int _quantity;

    // Property
    public string Name
    {
        get => _name;
        set
        {
            _name = value.ToUpper();
        }
    }
    public int Quantity { get { return _quantity; } set { _quantity = value; } }

    public Item(string name, int quantity)
    {
        this._name = name;
        this._quantity = quantity;
    }

    public Item()
    {

    }

    public void Use()
    {
        _quantity -= 1;
        Debug.Log($"Player use {_name}, Quantity:{_quantity}");
    }

    public void Use(int consumeCount)
    {
        _quantity -= consumeCount;
        Debug.Log($"Player use {_name}, Quantity:{_quantity}");
    }
}
