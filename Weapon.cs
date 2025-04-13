enum DamageType
{
  Piercing,
  Slashing,
  Bludgeoning
}

class Weapon : ItemData
{
  public int damage { get; private set; }
  public DamageType damageType { get; private set; }

  public Weapon(string name, int dmg, DamageType damageType) : base(name)
  {
    damage = dmg;
    this.damageType = damageType;
  }
}
