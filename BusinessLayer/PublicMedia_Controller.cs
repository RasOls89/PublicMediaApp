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
    public class PublicMedia_Controller
    {
        public static readonly PublicMedia_Controller Instance = new PublicMedia_Controller();
        public UserController UserControllers { get; }

        public UnitOfWork Context { get; }

        public PublicMedia_Controller()
        {
            Context = new UnitOfWork();
            UserControllers = new UserController();
        }

        public void Save() => Context.Complete();
    }
}
