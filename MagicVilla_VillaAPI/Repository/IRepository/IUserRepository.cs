﻿using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTO;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUSer(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
