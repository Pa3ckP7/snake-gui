using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_gui
{
    public enum Match_Result 
    {
        Draw,
        P1Wins,
        P2Wins,
        Unknown
    }
    
    class Settings2p
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Score2 { get; set; }
        public static int StartingLength { get; set; }
        public static bool GameOver { get; set; }
        public static Directions direction { get; set; }
        public static Directions direction2 { get; set; }
        public static Match_Result match_Result { get; set; }
        public Settings2p()
        {
            Width = 16;
            Height = 16;
            Speed = 16;
            StartingLength = 5;
            GameOver = false;
            direction = Directions.Left;
            direction2 = Directions.Right;
            Score = 0;
            Score2 = 0;
            match_Result = Match_Result.Unknown;
            
        }
    }
}
