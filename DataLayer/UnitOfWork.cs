using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer.Internals;

namespace DataLayer
{
    public class UnitOfWork
    {
        private PublicMediaContext _context = new PublicMediaContext();
        public Repository<User> UserRepository { get; private set; }
        public Repository<Music> MusicRepository { get; private set; }

        public UnitOfWork()
        {
            UserRepository = new Repository<User>(_context);
            MusicRepository = new Repository<Music>(_context);
        }
        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
