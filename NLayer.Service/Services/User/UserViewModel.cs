﻿using NLayer.Core.DTOs;

namespace NLayer.Service.Services.User;

public class UserViewModel : IBaseViewDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}