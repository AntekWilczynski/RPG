using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Zenon";
            CurrentPlayer.CharacterClass = "Knight";
            CurrentPlayer.Gold = 1000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Level = 1;

        }
    }
}
