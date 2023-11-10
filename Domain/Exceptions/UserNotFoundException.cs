﻿using Domain.Exceptions.Base;

namespace Domain.Exceptions;

public class UserNotFoundException:NotFoundException
{
    public UserNotFoundException(string? message) : base(message)
    {
    }
}