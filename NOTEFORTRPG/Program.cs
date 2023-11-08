namespace NOTEFORTRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            FireBall fireball = new FireBall();
            PrayForAttack pfa = new PrayForAttack();
            ItemUseCommand itemuseCMD=new ItemUseCommand();
            SkillCommand fireballCMD = new SkillCommand(fireball);
            SkillCommand fireballCMD2 = new SkillCommand(fireball);
            SkillCommand pfaCMD = new SkillCommand(pfa);
            SelectedCommand selectedCommand = new SelectedCommand();
            selectedCommand.AddCommand(0, fireballCMD);
            selectedCommand.AddCommand(1, pfaCMD);
            selectedCommand.AddCommand(2, itemuseCMD);
            selectedCommand.AddCommand(3, fireballCMD2);
            selectedCommand.SortCommand();
            selectedCommand.Execute();
        }
    }
}