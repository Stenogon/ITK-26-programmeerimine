
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

class Program
{
    const int W = 39;
    const int H = 20;
    const int PLAYER_Y = 16;

    static Random rng = new Random();
    static int bank = 0;
    static int highScore = 0;
    static int engineLevel = 1;

    class Object
    {
        public int Lane;
        public int Y;
        public char Type;

        public Object(int lane, int y, char type)
        {
            Lane = lane;
            Y = y;
            Type = type;
        }
    }

    static void Main()
    {
        Console.Title = "CMD RACING 2.0";
        Console.CursorVisible = false;

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine("  ===================================");
            Console.WriteLine("       C M D   R A C I N G");
            Console.WriteLine("              2.0");
            Console.WriteLine("  ===================================");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("       [1] START RACE");
            Console.WriteLine("       [2] GARAGE");
            Console.WriteLine("       [3] HOW TO PLAY");
            Console.WriteLine("       [4] QUIT");
            Console.WriteLine();
            Console.WriteLine("       MONEY: $" + bank);
            Console.WriteLine("       ENGINE LEVEL: " + engineLevel);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n       SELECT: ");

            ConsoleKey key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                Race();

            if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                Garage();

            if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
                Instructions();

            if (key == ConsoleKey.D4 || key == ConsoleKey.NumPad4)
                running = false;
        }

        Console.Clear();
        Console.CursorVisible = true;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Thanks for playing CMD Racing!");
        Console.ResetColor();
    }

    static void Instructions()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("========== HOW TO PLAY ==========");
        Console.WriteLine();
        Console.WriteLine("LEFT / A    - Steer left");
        Console.WriteLine("RIGHT / D   - Steer right");
        Console.WriteLine("SPACE       - Nitro boost");
        Console.WriteLine("ESC         - Return to menu");
        Console.WriteLine();
        Console.WriteLine("Collect $ coins.");
        Console.WriteLine("Avoid enemy cars!");
        Console.WriteLine("Watch out for police!");
        Console.WriteLine("Don't run out of lives.");
        Console.WriteLine();
        Console.WriteLine("Press any key...");

        Console.ReadKey(true);
    }

    static void Garage()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("========== GARAGE ==========");
        Console.WriteLine();
        Console.WriteLine("Your money: $" + bank);
        Console.WriteLine("Engine level: " + engineLevel);
        Console.WriteLine();

        int price = engineLevel * 30;

        Console.WriteLine("ENGINE UPGRADE");
        Console.WriteLine("Price: $" + price);
        Console.WriteLine("Improves your racing speed.");
        Console.WriteLine();

        Console.WriteLine("Press U to buy upgrade.");
        Console.WriteLine("Press ESC to return.");

        while (true)
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.Escape)
                break;

            if (key == ConsoleKey.U)
            {
                if (bank >= price && engineLevel < 10)
                {
                    bank -= price;
                    engineLevel++;

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("UPGRADE PURCHASED!");
                    Console.WriteLine("Engine level: " + engineLevel);
                    Console.WriteLine("Press any key...");
                    Console.ReadKey(true);
                    break;
                }
                else
                {
                    Console.Beep(300, 150);
                }
            }
        }
    }

    static void Race()
    {
        int[] lanes = { 9, 19, 29 };

        int player = 1;
        int score = 0;
        int money = 0;
        int lives = 3;
        int nitro = 100;
        int nitroTime = 0;
        int frame = 0;
        int spawn = 0;
        int coinSpawn = 0;
        int policeTimer = 0;
        int damageTimer = 0;

        bool policeActive = false;
        bool paused = false;
        bool crashed = false;

        List<Object> objects = new List<Object>();

        Console.Clear();

        while (!crashed)
        {
            // INPUT

            while (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.LeftArrow || key == ConsoleKey.A)
                    player = Math.Max(0, player - 1);

                if (key == ConsoleKey.RightArrow || key == ConsoleKey.D)
                    player = Math.Min(2, player + 1);

                if (key == ConsoleKey.Spacebar && nitro > 0)
                {
                    nitroTime = 12;
                }

                if (key == ConsoleKey.P)
                    paused = !paused;

                if (key == ConsoleKey.Escape)
                    return;
            }

            if (paused)
            {
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("              PAUSED              ");
                Thread.Sleep(100);
                continue;
            }

            // NITRO

            bool boosting = nitroTime > 0 && nitro > 0;

            if (boosting)
            {
                nitro -= 3;
                nitroTime--;
            }
            else
            {
                nitro = Math.Min(100, nitro + 1);
                nitroTime = 0;
            }

            // POLICE

            if (score > 100)
            {
                policeActive = true;
            }

            if (policeActive)
            {
                policeTimer++;

                if (policeTimer > 20)
                {
                    objects.Add(new Object(rng.Next(3), 0, 'P'));
                    policeTimer = 0;
                }
            }

            // SPAWN TRAFFIC

            spawn--;

            if (spawn <= 0)
            {
                objects.Add(new Object(rng.Next(3), 0, 'E'));
                spawn = Math.Max(3, 11 - score / 100);
            }

            // SPAWN COINS

            coinSpawn--;

            if (coinSpawn <= 0)
            {
                objects.Add(new Object(rng.Next(3), 0, '$'));
                coinSpawn = rng.Next(5, 10);
            }

            // MOVE OBJECTS

            for (int i = objects.Count - 1; i >= 0; i--)
            {
                Object obj = objects[i];

                obj.Y += boosting ? 2 : 1;

                if (obj.Y == PLAYER_Y && obj.Lane == player)
                {
                    if (obj.Type == '$')
                    {
                        money += 10;
                        nitro = Math.Min(100, nitro + 10);
                        objects.RemoveAt(i);
                        continue;
                    }

                    if ((obj.Type == 'E' || obj.Type == 'P')
                        && damageTimer <= 0)
                    {
                        lives--;
                        damageTimer = 10;
                        Console.Beep(200, 100);

                        objects.RemoveAt(i);

                        if (lives <= 0)
                            crashed = true;

                        continue;
                    }
                }

                if (obj.Y >= H)
                    objects.RemoveAt(i);
            }

            if (damageTimer > 0)
                damageTimer--;

            if (crashed)
                break;

            // SCORE

            score += boosting ? 2 : 1;

            // DRAW TRACK

            char[,] board = new char[H, W];

            for (int y = 0; y < H; y++)
            {
                for (int x = 0; x < W; x++)
                    board[y, x] = ' ';

                board[y, 4] = '|';
                board[y, 34] = '|';

                if ((y + frame) % 4 < 2)
                {
                    board[y, 14] = '|';
                    board[y, 24] = '|';
                }
            }

            // PLAYER

            int px = lanes[player];

            board[PLAYER_Y, px - 1] = '[';
            board[PLAYER_Y, px] = 'A';
            board[PLAYER_Y, px + 1] = ']';

            // OBJECTS

            foreach (Object obj in objects)
            {
                if (obj.Y < 0 || obj.Y >= H)
                    continue;

                int x = lanes[obj.Lane];

                if (obj.Type == 'E')
                {
                    board[obj.Y, x - 1] = '[';
                    board[obj.Y, x] = 'X';
                    board[obj.Y, x + 1] = ']';
                }
                else if (obj.Type == 'P')
                {
                    board[obj.Y, x - 1] = '[';
                    board[obj.Y, x] = 'P';
                    board[obj.Y, x + 1] = ']';
                }
                else
                {
                    board[obj.Y, x] = '$';
                }
            }

            // DISPLAY

            Console.SetCursorPosition(0, 0);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("          CMD RACING 2.0          ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" SCORE: " + score +
                "   MONEY: $" + money +
                "   LIVES: " + lives + "   ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" NITRO: [" +
                new string('#', nitro / 10) +
                new string('-', 10 - nitro / 10) + "]");

            Console.WriteLine();

            for (int y = 0; y < H; y++)
            {
                for (int x = 0; x < W; x++)
                {
                    char c = board[y, x];

                    if (c == 'A')
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (c == 'X')
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (c == 'P')
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    else if (c == '$')
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else if (c == '|')
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    else
                        Console.ForegroundColor = ConsoleColor.Gray;

                    Console.Write(c);
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(" A/D: STEER  SPACE: NITRO  P: PAUSE ");
            Console.WriteLine(" ESC: MENU");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" Engine level: " + engineLevel);

            frame++;

            int delay = Math.Max(
                35,
                110 - score / 15 - engineLevel * 3
            );

            if (boosting)
                delay = Math.Max(25, delay - 30);

            Thread.Sleep(delay);
        }

        // GAME OVER

        bank += money;
        highScore = Math.Max(highScore, score);

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine();
        Console.WriteLine("===================================");
        Console.WriteLine("             GAME OVER");
        Console.WriteLine("===================================");

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine();
        Console.WriteLine(" FINAL SCORE: " + score);
        Console.WriteLine(" HIGH SCORE: " + highScore);
        Console.WriteLine(" COINS EARNED: $" + money);
        Console.WriteLine(" TOTAL MONEY: $" + bank);
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" PRESS R TO RACE AGAIN");
        Console.WriteLine(" PRESS M TO MAIN MENU");

        while (true)
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.R)
            {
                Race();
                return;
            }

            if (key == ConsoleKey.M || key == ConsoleKey.Escape)
                return;
        }
    }
}
