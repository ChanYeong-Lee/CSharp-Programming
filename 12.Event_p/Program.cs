using _12._Event.Basic;

namespace _12._Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            SFX sfx = new SFX();
            VFX vfx = new VFX();
            UI ui = new UI();

            // 이벤트에 반응할 함수 추가
            player.OnGetCoin += sfx.CoinSound;
            player.OnGetCoin += ui.CoinUI;

            player.GetCoin();
            // 플레이어가 코인을 얻음
            // 코인을 얻는 음악 재생
            // UI에 코인수를 갱신

            // 이벤트 방식으로 코드수정없이 코인획득시 기능을 추가 가능
            player.OnGetCoin += vfx.CoinEffect;

            player.GetCoin();
            // 플레이어가 코인을 얻음
            // 코인을 얻는 음악 재생
            // 반짝거리는 효과
            // UI에 코인수를 갱신

            // 이벤트 방식으로 코드수정없이 코인획득시 기능을 제거 가능
            player.OnGetCoin -= sfx.CoinSound;

            player.GetCoin();
            // 플레이어가 코인을 얻음
            // 반짝거리는 효과
            // UI에 코인수를 갱신
        }
    }
}