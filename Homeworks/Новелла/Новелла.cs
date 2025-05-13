using System;

namespace CyberpunkNovel
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("=== КИБЕРПАНК-ДЕТЕКТИВ 2089 ===");
            Console.WriteLine("Разработка: MinorityKillaPashok");
            Console.WriteLine("Сделано: Павлом");
            Console.WriteLine("Нажмите любую клавишу чтобы начать...");
            Console.ReadKey();
            StartNovel();
        }

        static void StartNovel()
        {
            Console.Clear();
            Console.WriteLine("Вы - хакер по кличке 'Призрак'.");
            Console.WriteLine("Неоновый город Нью-Токио 2089 года. Корпорации правят миром.");
            Console.WriteLine("После ночного взлома серверов корпорации 'Аркас' вы обнаруживаете странный файл...");
            Console.WriteLine("\nНажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();
            Game();
        }

        static void Game()
        {
            try
            {
                Console.WriteLine("Ваш нейроинтерфейс показывает:");
                Console.WriteLine(">>> ФАЙЛ ЗАШИФРОВАН. УРОВЕНЬ ДОСТУПА: ОМЕГА <<<");
                Console.WriteLine("\nВаши действия:");
                Console.WriteLine("1. Попытаться взломать шифр (риск обнаружения)");
                Console.WriteLine("2. Удалить файл (слишком опасно)");
                Console.WriteLine("3. Продать данные на черном рынке");
                Console.WriteLine("4. Связаться с контактом из сопротивления");
                Console.WriteLine("5. Оставить файл на потом");

                int choice1 = Convert.ToInt32(Console.ReadLine());

                if (choice1 == 1)
                {
                    Console.WriteLine("\nВы активируете свой квантовый дешифратор...");
                    Console.WriteLine("Взлом успешен! Это чертежи проекта 'Феникс' - нового оружия массового поражения.");

                    Console.WriteLine("\nВаши действия:");
                    Console.WriteLine("1. Слить данные в сеть");
                    Console.WriteLine("2. Шантажировать корпорацию");
                    Console.WriteLine("3. Найти ученого, создавшего оружие");
                    Console.WriteLine("4. Уничтожить доказательства");
                    Console.WriteLine("5. Сделать копию для себя");

                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 == 1)
                    {
                        Console.WriteLine("\nДанные ушли в сеть. Город взорвался протестами.");
                        Console.WriteLine("Корпорация объявила вас террористом №1.");
                        GameData.Ending = "КОНЦОВКА: ПРАВДА ВЫШЛА\nВы раскрыли заговор, но теперь вас разыскивают все корпорации.";
                    }
                    else if (choice2 == 2)
                    {
                        Console.WriteLine("\nВы потребовали 10 миллионов криптовалюты.");
                        Console.WriteLine("Корпорация согласилась, но это была ловушка...");
                        GameData.Ending = "КОНЦОВКА: ДЕНЬГИ ИЛИ ЖИЗНЬ\nВы почти сорвали куш, но киллеры нашли вас через 3 дня.";
                    }
                    else if (choice2 == 3)
                    {
                        Console.WriteLine("\nВы нашли доктора Чен - создателя оружия.");
                        Console.WriteLine("Вместе вы уничтожили лабораторию с чертежами.");
                        GameData.Ending = "КОНЦОВКА: ГЕРОИ ТЕНЕЙ\nПроект остановлен, но теперь за вами охотятся обе стороны.";
                    }
                    else if (choice2 == 4)
                    {
                        Console.WriteLine("\nВы стерли все следы. Кажется, вам повезло...");
                        Console.WriteLine("Но через месяц город потрясла серия странных взрывов.");
                        GameData.Ending = "КОНЦОВКА: НЕВЕДЕНИЕ БЛАГО\nВы спасли себя, но не смогли спасти других.";
                    }
                    else if (choice2 == 5)
                    {
                        Console.WriteLine("\nВы сохранили копию 'на всякий случай'.");
                        Console.WriteLine("Через неделю к вам пришли люди в черном...");
                        GameData.Ending = "КОНЦОВКА: ЛИШНЕЕ ЗНАНИЕ\nНекоторые тайны лучше не знать.";
                    }

                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    Final();
                }
                else if (choice1 == 2)
                {
                    Console.WriteLine("\nВы уничтожили файл. Лучше не связываться с такими вещами...");
                    Console.WriteLine("Но той же ночью ваш друг исчез при странных обстоятельствах.");
                    GameData.Ending = "КОНЦОВКА: СЛЕПОЙ СМОТРИТЕЛЬ\nВы закрыли глаза на правду, но правда нашла вас.";
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    Final();
                }
                else if (choice1 == 3)
                {
                    Console.WriteLine("\nВы связались с брокером по кличке 'Спрут'.");
                    Console.WriteLine("\nОн предлагает:");
                    Console.WriteLine("1. Продать за криптовалюту (быстро, но мало)");
                    Console.WriteLine("2. Обменять на кибернетический апгрейд");
                    Console.WriteLine("3. Получить новую личность и исчезнуть");

                    int choice3 = Convert.ToInt32(Console.ReadLine());

                    if (choice3 == 1)
                    {
                        Console.WriteLine("\nВы получили 5000 крипто-кредитов.");
                        Console.WriteLine("Через месяц началась корпоративная война...");
                        GameData.Ending = "КОНЦОВКА: КОРОТКАЯ ВЫГОДА\nВы получили свои грязные деньги, но какой ценой?";
                    }
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("\nТеперь у вас глаза с тепловизором и рука-пулемет!");
                        Console.WriteLine("Но файл оказался в руках криминального синдиката...");
                        GameData.Ending = "КОНЦОВКА: КИБЕР-НАЕМНИК\nВы стали сильнее, но мир стал опаснее.";
                    }
                    else if (choice3 == 3)
                    {
                        Console.WriteLine("\nВы исчезли. Новый город, новая жизнь...");
                        Console.WriteLine("Но кошмары о проекте 'Феникс' преследуют вас.");
                        GameData.Ending = "КОНЦОВКА: БЕГСТВО\nВы сбежали, но правду нельзя спрятать навсегда.";
                    }

                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    Final();
                }
                else if (choice1 == 4)
                {
                    Console.WriteLine("\nВы связались с сопротивлением 'Неоновая лига'.");
                    Console.WriteLine("\nОни предлагают:");
                    Console.WriteLine("1. Присоединиться к их борьбе");
                    Console.WriteLine("2. Воспользоваться их защитой");
                    Console.WriteLine("3. Дать им файл и уйти");

                    int choice4 = Convert.ToInt32(Console.ReadLine());

                    if (choice4 == 1)
                    {
                        Console.WriteLine("\nВы стали частью сопротивления.");
                        Console.WriteLine("Через год ваше имя стало легендой подполья.");
                        GameData.Ending = "КОНЦОВКА: РЕВОЛЮЦИОНЕР\nВы выбрали сторону, но война только начинается...";
                    }
                    else if (choice4 == 2)
                    {
                        Console.WriteLine("\nОбещали защиту, но предали вас ради файла.");
                        Console.WriteLine("Теперь вы в бегах без друзей и ресурсов.");
                        GameData.Ending = "КОНЦОВКА: ДОВЕРЧИВЫЙ\nВ этом мире нет друзей - только интересы.";
                    }
                    else if (choice4 == 3)
                    {
                        Console.WriteLine("\nВы передали файл и исчезли.");
                        Console.WriteLine("Через неделю корпорация разгромила штаб сопротивления...");
                        GameData.Ending = "КОНЦОВКА: НЕЙТРАЛИТЕТ\nВы остались в стороне, но война пришла без вас.";
                    }

                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    Final();
                }
                else if (choice1 == 5)
                {
                    Console.WriteLine("\nВы отложили файл 'на потом'.");
                    Console.WriteLine("На следующее утро ваше убежище было взломано...");
                    GameData.Ending = "КОНЦОВКА: ОПОЗДАВШИЙ\nКто-то уже знал о файле и нашел вас первым.";
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    Final();
                }
                else
                {
                    Console.WriteLine("\nНеопределенность - худший выбор в нашем мире...");
                    GameData.Ending = "КОНЦОВКА: НЕРЕШИТЕЛЬНЫЙ\nВы замерли, а мир вокруг продолжал рушиться.";
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    Final();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("ОШИБКА НЕЙРОИНТЕРФЕЙСА:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nНажмите любую клавишу для перезагрузки...");
                Console.ReadKey();
                Restart();
            }
        }

        static void Final()
        {
            Console.Clear();
            Console.WriteLine(GameData.Ending);
            Console.WriteLine("\n====================");
            Console.WriteLine("1. Начать заново");
            Console.WriteLine("Любая другая клавиша - выход");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Restart();
                }
                else
                {
                    Console.WriteLine("\nДо встречи в темных уголках нейросети...");
                }
            }
            catch
            {
                Console.WriteLine("\nСессия завершена. Хакер всегда выходит сухим из воды...");
            }
        }

        static void Restart()
        {
            Console.Clear();
            StartNovel();
        }
    }

    static class GameData
    {
        public static string Ending;
    }
}