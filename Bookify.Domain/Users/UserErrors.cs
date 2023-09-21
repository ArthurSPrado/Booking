﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Users;

public static class UserErrors
{
    public static Error UserNotFound = new(
        "User.Found",
        "The user with the specified identifier was not found");

    public static Error InvalidCredentials = new(
        "User.InvalidCredentials",
        "The provided credentials were invalid");
}