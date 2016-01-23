using EuMelhor.AppService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuMelhor.AppService.DTO;
using EuMelhor.Domain.Interfaces;

namespace EuMelhor.AppService.Entities
{
    public class UserAppService : IUserAppService
    {
        private IUserRepository UserRepository;

        public UserAppService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public List<UserDto> GetAll()
        {
            var items = UserRepository.GetAll();
            UserDto user;
            var userDtoList = new List<UserDto>();

            foreach (var item in items)
            {
                user = new UserDto();
                user.FirstName = item.FirstName;
                user.LastName = item.Lastname;
                user.Name = item.Name;
                user.Link = item.Link;
                user.UserName = item.UserName;

                userDtoList.Add(user);
            }

            return userDtoList;
        }

        public UserDto GetUser(Guid key)
        {
            var user = UserRepository.GetById(key);
            return new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.Lastname,
                Name = user.Name,
                Link = user.Link,
                UserName = user.UserName
            };
        }
    }
}
