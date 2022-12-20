using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Interfaces
{
    public interface IGamesDal
    {
        SingleGame GetById(int id);
        SingleGame GetByUserId(int UserId);
        void AddGame(SingleGame game);
    }
}
