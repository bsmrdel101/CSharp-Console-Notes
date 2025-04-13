class Food : ItemData
{
  public int hunger;

  public Food(string name, int hunger) : base(name)
  {
    this.hunger = hunger;
  }
}
