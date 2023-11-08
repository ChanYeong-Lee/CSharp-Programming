namespace _12.Event_t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();
            HPBar hpBar = new HPBar();

            player.OnHpChanged += hpBar.ShowHPBar;
            monster.OnHpChanged += hpBar.ShowHPBar;
        }
    }
}