﻿namespace AspNetCoreAPI.Registration.dto
{
    public class UserRegistrationResponseDto
    {
        public bool IsSuccessfulRegistration { get; set; }
        public IEnumerable<string>? Errors { get; set; }
    }
}
