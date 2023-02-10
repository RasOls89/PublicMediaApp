using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    /// <summary>
    /// Data controller
    /// </summary>
    public class PublicMediaController
    {
        public static readonly PublicMediaController Instance = new PublicMediaController();
        public UserController UserControllers { get; }

        public UnitOfWork Context { get; }

        public PublicMediaController()
        {
            Context = new UnitOfWork();
            UserControllers = new UserController();
        }

        //public void Save() => Context.Complete();
    }
}
