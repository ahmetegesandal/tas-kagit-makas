using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        

        static void TasGoster(string tur)
        {
            string[] rock = {
            "    _______    ",
            "---'   ____)   ",
            "      (_____)  ",
            "      (_____)  ",
            "      (____)   ",
            "---.__(___)    "
            };

            for (int i = 0; i < rock.Length; i++)
            {
                if (tur == "insan")
                {
                    Console.WriteLine(rock[i]);
                } else if (tur == "bot")
                {
                    Console.WriteLine(rock[i]);
                }
                
            }
        }

        static void KagitGoster(string tur)
        {
            string[] paper = {
            "     _______       ",
            "---'    ____)____  ",
            "           ______) ",
            "          _______) ",
            "         _______)  ",
            "---.__________)    "
            };

            for (int i = 0; i < paper.Length; i++)
            {
                if (tur == "insan")
                {
                    Console.WriteLine(paper[i]);
                }
                else if (tur == "bot")
                {
                    Console.WriteLine(paper[i]);
                }
            }
        }

        static void MakasGoster(string tur)
        {
            string[] scissors = {
            "    _______       ",
            "---'   ____)____  ",
            "          ______) ",
            "       __________)",
            "      (____)      ",
            "---.__(___)       "
            };

            for (int i = 0; i < scissors.Length; i++)
            {
                if (tur == "insan")
                {
                    Console.WriteLine(scissors[i]);
                }
                else if (tur == "bot")
                {
                    Console.WriteLine(scissors[i]);
                }
            }
        }
        static void BilgiEkraniYaz()
        {
            string[] rock = {
            "    _______    ",
            "---'   ____)   ",
            "      (_____)  ",
            "      (_____)  ",
            "      (____)   ",
            "---.__(___)    "
            };

            string[] paper = {
            "     _______       ",
            "---'    ____)____  ",
            "           ______) ",
            "          _______) ",
            "         _______)  ",
            "---.__________)    "
            };

            string[] scissors = {
            "    _______       ",
            "---'   ____)____  ",
            "          ______) ",
            "       __________)",
            "      (____)      ",
            "---.__(___)       "
            };


            for (int i = 0; i < rock.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(rock[i] + "    " + paper[i] + "    " + scissors[i]);
                Console.ResetColor(); 
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Taş Kağıt Makas Oyunu ===");
            Console.WriteLine("Taş İçin: 1 | Kağıt İçin: 2 | Makas İçin: 3");
            Console.Write("Seçiminizi Yapın: ");
            Console.ResetColor();
        }

        static void kontrolEtİnsan(string secim)
        {
            if (secim == "1")
            {
                Console.WriteLine("Siz taş seçtiniz.");
                TasGoster("insan");
            }
            else if(secim == "2")
            {
                Console.WriteLine("Siz kağıt seçtiniz.");
                KagitGoster("insan");
            }
            else if (secim == "3")
            {
                Console.WriteLine("Siz makas seçtiniz.");
                MakasGoster("insan");
            }
        }

        static void kontrolEtBot(int randomSecim)
        {
            if (randomSecim == 1)
            {
                Console.WriteLine("Bot taş seçti.");
                TasGoster("bot");
            }
            else if (randomSecim == 2)
            {
                Console.WriteLine("Bot kağıt seçti.");
                KagitGoster("bot");
            }
            else if (randomSecim == 3)
            {
                Console.WriteLine("Bot makas seçti.");
                MakasGoster("bot");
            }
        }

        static void oyunTekrarDegerBilgi()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Tekrar Oynamak İçin: t  | Çıkış İçin: c");
            Console.Write("Seç: ");
            

        }

        static string oyunTekrarDegerAl()
        {
            string sec = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------");
            Console.ResetColor();
            return sec;
        }
        static bool oyunTekrari(string sec)
        {
            if (sec == "t")
            {
                return true;
            } else
            {
                return false;
            }
        }


        
        static void Main(string[] args)
        {
            Random random = new Random();
            

            
            bool devam = true;

            

            while (devam)
            {
                int randomSecim = random.Next(1, 3);
                BilgiEkraniYaz();
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":

                        kontrolEtİnsan(secim);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("------------------------------------------------------------");
                        Console.ResetColor();
                        kontrolEtBot(randomSecim);


                        if (randomSecim == 1 && secim == "1")
                        {
                            Console.WriteLine("Berabere kaldınız.");
                        } else if (randomSecim == 2)
                        {
                            Console.WriteLine("Kaybettiniz.");
                        } else if (randomSecim == 3)
                        {
                            Console.WriteLine("Kazandınız.");
                        }

                        oyunTekrarDegerBilgi();
                        devam = oyunTekrari(oyunTekrarDegerAl());

                    break;
                    case "2":
                        kontrolEtİnsan(secim);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("------------------------------------------------------------");
                        Console.ResetColor();
                        kontrolEtBot(randomSecim);


                        if (randomSecim == 2 && secim == "2")
                        {
                            Console.WriteLine("Berabere kaldınız.");
                        }
                        else if (randomSecim == 1)
                        {
                            Console.WriteLine("Kazandınız.");
                        }
                        else if (randomSecim == 3)
                        {
                            Console.WriteLine("Kaybettiniz.");
                        }

                        oyunTekrarDegerBilgi();
                        devam = oyunTekrari(oyunTekrarDegerAl());
               

                        break;
                    case "3":
                        kontrolEtİnsan(secim);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("------------------------------------------------------------");
                        Console.ResetColor();
                        kontrolEtBot(randomSecim);


                        if (randomSecim == 3 && secim == "3")
                        {
                            Console.WriteLine("Berabere kaldınız.");
                        }
                        else if (randomSecim == 2)
                        {
                            Console.WriteLine("Kazandınız.");
                        }
                        else if (randomSecim == 1)
                        {
                            Console.WriteLine("Kaybettiniz.");
                        }

                        oyunTekrarDegerBilgi();
                        devam = oyunTekrari(oyunTekrarDegerAl());

                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim tekrar dene!");
                    break;
                }
            }

            


            Console.ReadKey();
        }


    }
}
