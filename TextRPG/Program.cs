namespace TextRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄       ▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄      \r\n▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌     ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌     \r\n ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀  ▐░▌   ▐░▌  ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀      \r\n     ▐░▌     ▐░▌            ▐░▌ ▐░▌       ▐░▌     ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌               \r\n     ▐░▌     ▐░█▄▄▄▄▄▄▄▄▄    ▐░▐░▌        ▐░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌ ▄▄▄▄▄▄▄▄      \r\n     ▐░▌     ▐░░░░░░░░░░░▌    ▐░▌         ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌▐░░░░░░░░▌     \r\n     ▐░▌     ▐░█▀▀▀▀▀▀▀▀▀    ▐░▌░▌        ▐░▌     ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌ ▀▀▀▀▀▀█░▌     \r\n     ▐░▌     ▐░▌            ▐░▌ ▐░▌       ▐░▌     ▐░▌     ▐░▌  ▐░▌          ▐░▌       ▐░▌     \r\n     ▐░▌     ▐░█▄▄▄▄▄▄▄▄▄  ▐░▌   ▐░▌      ▐░▌     ▐░▌      ▐░▌ ▐░▌          ▐░█▄▄▄▄▄▄▄█░▌     \r\n     ▐░▌     ▐░░░░░░░░░░░▌▐░▌     ▐░▌     ▐░▌     ▐░▌       ▐░▌▐░▌          ▐░░░░░░░░░░░▌     \r\n      ▀       ▀▀▀▀▀▀▀▀▀▀▀  ▀       ▀       ▀       ▀         ▀  ▀            ▀▀▀▀▀▀▀▀▀▀▀      \r\n                                                                                           ");
            Console.WriteLine("Text RPG게임에 오신것을 환영합니다.");
            Console.WriteLine("던전에 들어가기전 행동을 선택 할 수 있습니다.\n");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 게임 종료\n");
            Console.Write("선택: ");
            string choice = Console.ReadLine();


            while (true)
            {
                switch (choice)
                {
                    case "1":
                        status();
                        break;
                    case "2":
                        inventory();
                        break;
                    case "3":
                        //shop();
                        break;
                    case "4":
                        Console.WriteLine("게임을 종료합니다.");
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        Console.Write(">> ");
                        choice = Console.ReadLine();
                        break;

                }
                break;
            }
        }


        static void status()
        {
            string level = "01";
            string job = "전사";
            int offense = 10;
            int defense = 5;
            int health = 100;
            int Gold = 1500;

            Console.WriteLine("\n**********************************************");
            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");
            Console.WriteLine("Lv.{0}", level);
            Console.WriteLine("나 ({0})", job);
            Console.WriteLine("공격력: {0}", offense);
            Console.WriteLine("방어력: {0}", defense);
            Console.WriteLine("체  력: {0}", health);
            Console.WriteLine("Gold : {0}\n", Gold);

            Console.WriteLine("0. 나가기 \n");

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            string choice = Console.ReadLine();


            while (true)
            {
                switch (choice)
                {
                    case "0":
                        Main(null);
                        break;

                    default:

                        Console.WriteLine("잘못된 선택입니다.");
                        Console.Write(">> ");
                        choice = Console.ReadLine();
                        break;
                }
                break;
            }
        }
        static void inventory()
        {
            
            Console.WriteLine("\n**********************************************");
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");
            Console.WriteLine("\n1. 장착관리");
            Console.WriteLine("0. 나가기\n");
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            string choice = Console.ReadLine();

            while (true)
            {
                switch (choice)
                {
                    case "1":
                        status();
                        break;
                    case "2":
                        inventory();
                        break;
                    case "3":
                        //shop();
                        break;

                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        Console.Write(">> ");
                        choice = Console.ReadLine();
                        break;
                }
                break;
            }
        }
    }
}
