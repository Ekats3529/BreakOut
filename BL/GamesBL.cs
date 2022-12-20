using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class GamesBL : IGamesBL
    {

        private readonly IGamesDal _dal;

        public GamesBL(IGamesDal dal)
        {
            _dal = dal;
        }

        public SingleGame GetById(int id)
        {
            return _dal.GetById(id);
        }

        public SingleGame GetByUserId(int id)
        {
            return _dal.GetByUserId(id);
        }


        public void AddGame(SingleGame game)
        {
            _dal.AddGame(game);
        }
    }
}
