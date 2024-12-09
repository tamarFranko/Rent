using Rent.Core.Entities;
using Rent.Core.Repositories;
using Rent.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Service
{
    public class TurnService : ITurnService
    {
        private readonly ITurnRepository _TurnRepository;

        public TurnService(ITurnRepository TurnRepository)
        {
            _TurnRepository = TurnRepository;
        }

        public IEnumerable<Turn> GetList()
        {
            return _TurnRepository.GetAll();
        }
        public Turn GetOneTurn(int id)
        {
            return _TurnRepository.GetById(id);
        }
        public Turn AddOneTurn(Turn turn)
        {
           return _TurnRepository.AddTurn(turn);
        }

        public Turn UpdateOneTurn(int id, Turn turn)
        {
            return _TurnRepository.UpdateTurn(id, turn);
        }
        public void RemoveTurn(int id)
        {
            _TurnRepository.DeleteTurn(id);
        }
    }
}
