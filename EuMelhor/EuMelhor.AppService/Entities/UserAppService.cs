using EuMelhor.AppService.Interfaces;
using System;
using System.Collections.Generic;
using EuMelhor.AppService.DTO;
using EuMelhor.Infrastructure.Data.Repositories;
using EuMelhor.Domain.Entities;

namespace EuMelhor.AppService.Entities
{
    public class UserAppService : IUserAppService
    {
        private UserRepository _userRepository;

        public UserAppService()
        {
            _userRepository = new UserRepository();
        }

        public bool CreateUser(UserDto newUser)
        {
            try
            {
                User user = new User()
                {
                    FirstName = newUser.FirstName,
                    LastName = newUser.LastName,
                    Gender = newUser.Gender,
                    Name = newUser.Name,
                    Locale = newUser.Locale,
                    Link = newUser.Link
                };

                _userRepository.Save(user);
                return true;
                
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public void Delete(UserDto entity)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetAll()
        {
            var items = _userRepository.GetAll();
            UserDto user;
            var userDtoList = new List<UserDto>();

            foreach (var item in items)
            {
                user = new UserDto();
                user.FirstName = item.FirstName;
                user.LastName = item.LastName;
                user.Name = item.Name;
                user.Link = item.Link;
                user.UserName = item.UserName;
                user.Gender = item.Gender;

                userDtoList.Add(user);
            }

            return userDtoList;
        }

        public UserDto GetUser(Guid key)
        {
            var user = _userRepository.GetById(key);
            return new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Name = user.Name,
                Link = user.Link,
                UserName = user.UserName
            };
        }

        public bool Update(UserDto entity)
        {
            try
            {
                User user = new User()
                {
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Name = entity.Name,
                    Link = entity.Link,
                    UserName = entity.UserName
                };
                _userRepository.Save(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool IUserAppService.Delete(UserDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
