using _10.Interface_p;
using static _10.Interface_p.Interface_p;

namespace _10.Interface_p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceTest interfaceTest = new InterfaceTest();
            interfaceTest.Test1();
            // player.Close(dungeon);		// error : Dungeon 는 IOpenable 인터페이스가 없음
        }
    }
}