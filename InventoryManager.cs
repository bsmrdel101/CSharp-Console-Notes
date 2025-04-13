class InventoryManager
{
  private List<Item> _inventory = [];

  public void AddItem(ItemData itemData, int qty = 1)
  {
    Item item = new Item(itemData, qty);
    _inventory.Add(item);
  }

  public void RemoveItem(ItemData itemData, int qty = 1)
  {
    // Item? item = _inventory.Find((Item inventoryItem) => inventoryItem.data == itemData);
    Item? item = null;
    for (int i = 0; i < _inventory.Count; i++)
    {
      if (itemData == _inventory[i].data)
      {
        item = _inventory[i];
        break;
      }
    }
    if (item == null) return;

    if (item.qty - qty <= 0)
    {
      _inventory.Remove(item);
    } else
    {
      item.qty -= qty;
    }
  }

  public bool HasItem(ItemData item)
  {
    // return _inventory.Exists((Item inventoryItem) => inventoryItem.data == item);

    for (int i = 0; i < _inventory.Count; i++)
    {
      if (item == _inventory[i].data) return true;
    }
    return false;
  }

  public void Display()
  {
    Console.WriteLine("INVENTORY");

    // int count = _inventory.Sum((Item item) => item.qty);
    int count = 0;
    for (int i = 0; i < _inventory.Count; i++)
    {
      count += _inventory[i].qty;
    }
    Console.WriteLine($"Number of items: {count}");

    foreach (Item item in _inventory)
    {
      Console.WriteLine($"- {item.data.name} ({item.qty})");
    }
  }
}
