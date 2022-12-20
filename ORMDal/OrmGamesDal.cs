using Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMDal
{
    public class OrmGamesDal : IGamesDal
    {
        public Entities.SingleGame GetByUserId(int UserId)
        {
            var context = new DefaultDbContext();
            try
            {
                var game = context.Games.FirstOrDefault(item => item.UserId == UserId);
                if (game == null)
                {
                    return null;
                }
                return new Entities.SingleGame()
                {
                    Id = game.Id,
                    Score = game.Score,
                    PlayingDate = game.PlayingDate,
                    UserId = game.UserId
                };
            }
            finally
            {
                context.Dispose();
            }
        }

        public Entities.SingleGame GetById(int Id)
        {
            var context = new DefaultDbContext();
            try
            {
                var game = context.Games.FirstOrDefault(item => item.Id == Id);
                if (game == null)
                {
                    return null;
                }
                return new Entities.SingleGame()
                {
                    Id = game.Id,
                    Score = game.Score,
                    PlayingDate = game.PlayingDate,
                    UserId = game.UserId
                };
            }
            finally
            {
                context.Dispose();
            }
        }

        public void AddGame(Entities.SingleGame game)
        {
            var context = new DefaultDbContext();
            try
            {
                context.Games.Add(new SingleGame()
                {
                    Score = game.Score,
                    PlayingDate = game.PlayingDate,
                    UserId = game.UserId
                });
                context.SaveChanges();
            }
            finally
            {
                context.Dispose();
            }
        }
    }
}
