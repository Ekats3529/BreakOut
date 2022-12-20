using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IGamesBL
    {
        SingleGame GetById(int id);
        SingleGame GetByUserId(int UserId);
        void AddGame(SingleGame game);
    }
}
