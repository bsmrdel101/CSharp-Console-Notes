Console.Clear();

// Player list
List<Player> players = [];
players.Add(new Player("Player 1", 100));
players.Add(new Player("Player 2", 100));

// Create item data
ItemData sword = new Weapon("Sword", 10, DamageType.Slashing);
ItemData dagger = new Weapon("Dagger", 5, DamageType.Piercing);
ItemData bread = new Food("Bread", 6);

// Add items to inventory
players[0].inventory.AddItem(sword);
players[0].inventory.AddItem(bread, 8);
players[1].inventory.AddItem(dagger);
players[0].inventory.RemoveItem(bread, 2);

// Equip items
players[0].EquipItem(sword);
players[1].EquipItem(dagger);

// Display game status
foreach (Player player in players)
{
  Console.WriteLine(player.GetStatus());
  Console.WriteLine("");
  player.inventory.Display();
  Console.WriteLine("\n==================\n");
}
