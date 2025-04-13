class Player
{
  public string playerName { get; private set; }
  public int maxHp { get; private set; }
  public int hp { get; private set; }
  private string _status = "Healthy";
  private ItemData? _equippedItem;
  public InventoryManager inventory { get; private set; }

  public Player(string name, int maxHp)
  {
    playerName = name;
    this.maxHp = maxHp;
    hp = maxHp;
    inventory = new InventoryManager();
  }

  public void Damage(int dmg)
  {
    hp -= dmg;
    if (hp <= 0)
    {
      hp = 0;
      _status = "Dead";
    } else if (hp <= maxHp / 2)
    {
      _status = "Critical";
    } else if (hp < maxHp)
    {
      _status = "Wounded";
    }
  }

  public string GetStatus()
  {
    string itemStatus = GetItemStatus();
    return $"[{playerName}] Health: {hp}/{maxHp}, {_status}{itemStatus}";
  }

  private string GetItemStatus()
  {
    if (_equippedItem is Weapon weapon)
    {
      return $", Item: {weapon.name} ({weapon.damage} {weapon.damageType})";
    } else if (_equippedItem is Food food)
    {
      return $", Item: {food.name} ({food.hunger} food)";
    }
    return "";
  }

  public void EquipItem(ItemData item)
  {
    if (!inventory.HasItem(item)) return;
    _equippedItem = item;
  }
}
