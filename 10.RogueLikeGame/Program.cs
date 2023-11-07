namespace _10.Interface_t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Dungeon dungeon = new Dungeon(true);
            BFSword bfsword = new BFSword();
            Box box = new Box(true, bfsword);
            Horse horse = new Horse();
            Car car = new Car(true);

            player.Enter(dungeon);
            player.Unlock(dungeon.door);
            player.Enter(dungeon);

            player.Open(box);
            player.Unlock(box);
            player.Open(box);

            player.GetOn(horse);
            player.GetOff(horse);
            player.Exit(dungeon);

            player.GetOn(car);
            player.Unlock(car);
            player.GetOn(car);
            player.GetOff(car);
        }

    }
}