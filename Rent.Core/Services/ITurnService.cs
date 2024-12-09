using Rent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core.Services
{
    public interface ITurnService
    {
        public IEnumerable<Turn> GetList();
        public Turn GetOneTurn(int id);
        public Turn AddOneTurn(Turn turn);

        public Turn UpdateOneTurn(int id, Turn turn);
        public void RemoveTurn(int id);
    }
}
