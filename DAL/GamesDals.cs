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
        };

        public SingleGame GetById(int id)
        {
            return games.FirstOrDefault(item => item.Id == id);
        }


        public SingleGame GetByUserId(int UserId)
        {
            return games.FirstOrDefault(item => item.UserId == UserId);
        }

        public void AddGame(SingleGame game)
        {
            games.Add(game);
        }

    }
}
