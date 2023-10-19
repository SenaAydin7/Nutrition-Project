using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserDetailsManager : IUserDetailsService
    {
        IUserDetailDal _userdetailDal;

        public UserDetailsManager(IUserDetailDal userdetailDal)
        {
            _userdetailDal = userdetailDal;
        }

        public UserDetail GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserDetail> GetList()
        {
            throw new NotImplementedException();
        }


        public void UserDetailAdd(UserDetail userDetail)
        {
            _userdetailDal.Insert(userDetail);
        }

        public void UserDetailDelete(UserDetail userDetail)
        {
            _userdetailDal.Delete(userDetail);
        }

        public void UserDetailUpdate(UserDetail userDetail)
        {
            _userdetailDal.Update(userDetail);
        }

        public List<UserDetailDTO> GetUserDetails(int id)
        {
            return new List<UserDetailDTO> (_userdetailDal.GetUserDetails(id));
        }
    }
}
