using Microsoft.VisualBasic.FileIO;

namespace _12._Event_p
{
    internal class Program
    {

        public class Player
        {
            private int hp = 200;
            public event Action<int> OnHpChanged;       // event를 붙이면 '=' 대입연산자 사용 불가, '+=' 또는 '-='으로 접근 가능
            public event Action OnCoinGet;              // 또한 외부에서 함수처럼 사용하는 것을 방지한다.
            public void GetCoin()
            {
                Console.WriteLine("플레이어가 동전을 얻습니다.");
                if(OnCoinGet != null)
                {
                    OnCoinGet();
                }
            }

            public void TakeHit(int damage)
            {
                Console.WriteLine("{0}만큼 데미지를 받습니다.",damage);
                hp -= damage;
                if(OnHpChanged != null) 
                OnHpChanged(hp);
            }
        }

        public class UI
        {
            public void SetHP(int hp)
            {
                Console.WriteLine("플레이어 현재 체력 {0}", hp);
            }
            public void SetCoinUI()
            {
                Console.WriteLine("UI가 동전 갯수를 갱신합니다.");
            }
        }

        public class SFX
        {
            public void CoinSound()
            {
                Console.WriteLine("코인을 얻는 음악 재생");
            }
        }

        public class VFX
        {
            public void CoinEffect()
            {
                Console.WriteLine("반짝 거리는 효과");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            UI ui = new UI();
            SFX sfx = new SFX();
            VFX vfx = new VFX();

            player.OnCoinGet += ui.SetCoinUI;
            player.OnCoinGet += sfx.CoinSound;
            player.OnCoinGet += vfx.CoinEffect;

            player.GetCoin();
            player.GetCoin();
            player.GetCoin();

            player.OnCoinGet -= vfx.CoinEffect;

            player.GetCoin();
            
            player.OnHpChanged += ui.SetHP;
            player.TakeHit(10);
            player.TakeHit(10);
            player.TakeHit(10);
            player.TakeHit(10);
            player.TakeHit(10);
        }
    }
}