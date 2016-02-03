using EuMelhor.AppService.DTO;
using EuMelhor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.AppService.Convert
{
    public class UserConvert : IConvertBase<User, UserDto>
    {
        public UserDto ToDtoEntity(User origin, UserDto destiny)
        {
            destiny.CreateDate = origin.CreateDate;
            destiny.DeleteDate = origin.DeleteDate;
            destiny.FirstName = origin.FirstName;
            destiny.Gender = origin.Gender;
            destiny.Id = origin.Id;
            destiny.LastName = origin.LastName;
            destiny.Link = origin.Link;
            destiny.Locale = origin.Locale;
            destiny.Name = origin.Name;
            destiny.UpdateDate = origin.UpdateDate;
            destiny.UserName = origin.UserName;

            return destiny;
        }

        public User ToDomainEntity(UserDto origin, User destiny)
        {
            destiny.CreateDate = origin.CreateDate;
            destiny.DeleteDate = origin.DeleteDate;
            destiny.FirstName = origin.FirstName;
            destiny.Gender = origin.Gender;
            destiny.Id = origin.Id;
            destiny.LastName = origin.LastName;
            destiny.Link = origin.Link;
            destiny.Locale = origin.Locale;
            destiny.Name = origin.Name;
            destiny.UpdateDate = origin.UpdateDate;
            destiny.UserName = origin.UserName;

            return destiny;
        }
    }
}
