using Rent.Core.Entities;
using Rent.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Data.Repositories
{
    public class TurnRepository : ITurnRepository
    {
        public readonly DataContext _context;

        public TurnRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Turn> GetAll()
        {
            return _context.Turns;//לסדר אילוצים
        }

        public Turn? GetById(int id)
        { 
            return _context.Turns.Find(id);
        }

        public Turn AddTurn(Turn turn)
        {
            _context.Turns.Add(turn);
            _context.SaveChanges();
            return turn;
        }
        public Turn? UpdateTurn(int id, Turn turn)
        {
            var t = _context.Turns.Find(id);
            if (t != null)
            {
                t.Clinic = turn.Clinic;
                t.StartHour = turn.StartHour;
                t.EndHour = turn.EndHour;
                t.Day = turn.Day;
                t.DateStart = turn.DateStart;
                t.DateEnd = turn.DateEnd;
                t.Tenant = turn.Tenant;
                _context.SaveChanges();
            }
            return turn;
        }
        public void DeleteTurn(int id)
        {
            var t = _context.Turns.Find(id);
            _context.Turns.Remove(t);
            _context.SaveChanges();
        }
    }
}
