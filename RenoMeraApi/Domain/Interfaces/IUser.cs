﻿namespace RenoMeraApi.Domain.Interfaces
{
    public interface IUser
    {
        public int UserId { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

    }
}
