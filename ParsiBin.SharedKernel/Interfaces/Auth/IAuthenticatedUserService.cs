﻿namespace ParsiBin.SharedKernel.Interfaces.Auth
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
        public string Username { get; }
    }
}
