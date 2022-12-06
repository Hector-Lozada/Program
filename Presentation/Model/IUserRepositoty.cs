using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    public interface IUserRepositoty
    {
        bool AutenticateUser(NetworkCredential credential);
        void Add(UserModel userModel);
        void Remove(int id);
        void Editar(UserModel userModel);
        UserModel GetById(int id);
        UserModel GetByUsername(string username);
        IEnumerable<UserModel> GetAll();
        //...

    }
}
