namespace _00.VietMul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameStart();
            while (!game.CheckGame())
            {
                game.GetCard(0);
                game.GetCard(2);
                game.ShowCard(0);
                game.ShowCard(2);
                Console.WriteLine("Your Money = " + game.player.GetMoney());
                game.Betting();
                game.GetCard(1);
                game.ShowCard(1);
                game.CheckWinner();
                Console.WriteLine("Your Money = " + game.player.GetMoney());
                Console.Clear();
            }
        }   
    }
}

//0.플레이어의 돈은 만원으로 시작한다..
//1. ◆, ♠, ♥, ♣ 의 문양을 가진 카드가 있다.
//2. 각각 13장이 있으며 1 = A, 11 = J, 12 = Q, 13 = K 로 표시한다.
//3. 두 장의 카드를 뽑아 확인한다.
//4. 세번째 카드를 뽑기 전에 배팅을 건다. (최소 금액 1000원이 있음)
//5. 세번째 카드가 두 장의 카드 사이의 숫자면 배팅 금액의 2배를 얻는다.
//6. 두 장의 카드 사이의 숫자가 아니라면 현재 금액에서 배팅금 차감한다 (같은 숫자인 경우에도 차감).
//7. 두 장의 카드의 숫자가 같거나 1밖에 차이가 안나더라도 최소 배팅금액은 걸어야 한다.
//8. 플레이어의 돈이 3만원이 넘으면 승리, 천원 아래면 게임오버

    
// **  추가사항
// 세 카드가 동일할 수 있는 경우를 생각 못함..
// 차라리 처음에 세개 카드를 이미 받은 상태로 1,3 카드만 보여주는 식으로 해서
// (예를 들면 배열로 카드를 받는다던가)
// 중복을 방지해야 할듯?