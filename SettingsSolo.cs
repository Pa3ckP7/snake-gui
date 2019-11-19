using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_gui
{
    public enum Directions 
    {
        None,
        Up,
        Left,
        Down,
        Right
    };
    class SettingsSolo
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int StartingLength { get; set; }
        public static bool GameOver { get; set; }
        public static Directions direction { get; set; }
        public SettingsSolo() 
        {
            Width = 16;
            Height = 16;
            Speed = 16;
            StartingLength = 5;
            GameOver = false;
            direction = Directions.None;
        }
    }
}
