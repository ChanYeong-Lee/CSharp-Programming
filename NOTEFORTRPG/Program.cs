namespace NOTEFORTRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Skill fireball = new FireBall();
            fireball.Use();
        }
    }
}