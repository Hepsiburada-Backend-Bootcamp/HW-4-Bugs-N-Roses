using AutoMapper;
using Bugs_N_Roses.Application.Models.UserModels;
using Bugs_N_Roses.Domain.Entities;
using Bugs_N_Roses.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugs_N_Roses.Application.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public bool Add(UserCreateDTO userCreateDTO)
        {
            var user = _mapper.Map<User>(userCreateDTO);

            if (user == null)
            {
                throw new ApplicationException("User dont be added.");
            }
            else
            {
                _userRepository.Add(user);
                return true;
            }


        }

        public bool Delete(int id)
        {
            _userRepository.Delete(id);
            return true;
        }

        public List<UserDTO> GetAll()
        {
            var users = _userRepository.GetAll();
            var dtos = _mapper.Map<List<UserDTO>>(users);
            return dtos;
            /*
            if (dtos == null)
            {
                throw new ApplicationException("Users dont found.");
            }
            else
            {
                return dtos;
            }
            */
        }

        public UserDTO GetById(int id)
        {
            var user = _userRepository.Get(id);
            var mappedUser = _mapper.Map<UserDTO>(user);

            if (mappedUser == null)
            {
                throw new ApplicationException("User dont found.");
            }
            else
            {
                return mappedUser;
            }
        }

        public bool Update(UserUpdateDTO userUpdateDTO, int id)
        {
            var mappedUser = _mapper.Map<User>(userUpdateDTO);
            var updatedUser = _userRepository.Get(id);

            updatedUser.FirstName = mappedUser.FirstName;
            updatedUser.LastName = mappedUser.LastName;
            updatedUser.PhoneNumber = mappedUser.PhoneNumber;
            updatedUser.Email = mappedUser.Email;
            updatedUser.Adress = mappedUser.Adress;
            updatedUser.IsActive = mappedUser.IsActive;
            _userRepository.Update(updatedUser);
            return true;
        }
    }
}
