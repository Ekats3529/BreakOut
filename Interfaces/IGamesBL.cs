using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IGamesBL
    {
        SingleGame GetById(int id);
    }
}
