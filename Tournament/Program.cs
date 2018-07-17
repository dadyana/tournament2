using System;

namespace Tournament
{
    class Program
    {
        class Play
        {

            public void RpsTournamentWinner(string[][][][] tournament)
            {

                string[][] winners = new string[2][];
                for (int i = 0; i < tournament.Length; i++)
                {

                    winners[i] = match(tournament[i]);
                }



                play(winners);

            }

            public string[] match(String[][][] players)
            {

                string[][] winners = new string[players.Length][];
                for (int i = 0; i < players.Length; i++)
                {
                    string[][] strings = players[i];
                    if (strings.Length > 2)
                    {
                        throw new System.ArgumentException("WrongNumberOfPlayersError");
                    }
                    winners[i] = play(strings);

                }

                return play(winners);

            }

            public String[] play(string[][] players)
            {
                string[] player1 = players[0];
                string[] player2 = players[1];
                VerifyCaracter(player1[1].ToCharArray()[0]);
                VerifyCaracter(player2[1].ToCharArray()[0]);
                if (player1[1] == player2[1])
                {
                    return player1;
                }

                if (VerifyPlay(player1[1].ToCharArray()[0], player2[1].ToCharArray()[0]))
                {
                    Console.WriteLine(player1[0] + " " + player1[1]);
                    return player1;
                }
                else
                {
                    Console.WriteLine(player2[0] + " " + player2[1]);
                    return player2;
                }
            }


            public bool VerifyPlay(char p1, char p2)
            {
                if (char.ToUpperInvariant(p1) == 'R' && char.ToUpperInvariant(p2) == 'S')
                {
                    return true;
                }
                else
                {
                    if (char.ToUpperInvariant(p1) == 'S' && char.ToUpperInvariant(p2) == 'P')
                    {
                        return true;
                    }
                    else if (char.ToUpperInvariant(p1) == 'P' && char.ToUpperInvariant(p2) == 'R')
                    {
                        return true;
                    }

                    return false;
                }

            }


            private void VerifyCaracter(char c)
            {
                switch (c)
                {
                    case 'R':
                    case 'r':
                    case 'S':
                    case 's':
                    case 'P':
                    case 'p':
                        break;
                    default:
                        throw new System.ArgumentException("NoSuchStrategyError");
                }


            }

        }


        static void Main(string[] args)
        {


            string[][][][] tournament =
                {
                    new string [][][]
                    {
                        new string[][]
                        {
                            new string[] { "Armando", "P" },
                            new string[] { "Dave", "S" }
                        },
                        new string[][]
                        {
                            new string[]{ "Richard", "R" },
                            new string[] { "Michael", "S" }
                        }
                    },

                    new string[][][]{

                        new  string[][]
                        {
                             new string[] { "Allen", "S" },
                             new string[] { "Omer", "P" }
                        },

                        new  string[][]
                        {
                              new string[]  { "David E", "R" },
                              new string[]  { "Richard X", "P" }
                        }

                    }
                };

            Play p = new Play();
            p.RpsTournamentWinner(tournament);

        }
    }

}
