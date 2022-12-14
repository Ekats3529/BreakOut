using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class GamesBL : IGamesBL
    {

        private IGamesBL _dal;

        public GamesBL(IGamesDal dal)
        {
            //_dal = dal;
        }

        public SingleGame GetById(int id)
        {
            return _dal.GetById(id);
        }
    }
}
