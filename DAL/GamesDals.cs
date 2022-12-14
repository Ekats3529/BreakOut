using System;
using Entities;
using Interfaces;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class GamesDal : IGamesDal
    {
        private List<SingleGame> games = new List<SingleGame>() {
            new SingleGame() { Id = 1, PlayingDate = new DateTime(2022, 12, 12), UserId = 1, Score = 0},
            new SingleGame() { Id = 2, PlayingDate = new DateTime(2022, 12, 12), UserId = 2, Score = 100}
        };

        public SingleGame GetById(int id)
        {
            return games.FirstOrDefault(item => item.Id == id);
        }
    }
}
