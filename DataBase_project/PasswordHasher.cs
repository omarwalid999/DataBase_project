using BCrypt.Net;
using System;

class PasswordHelper
{
    public static string HashPassword(string plainPassword)
    {
        return BCrypt.Net.BCrypt.HashPassword(plainPassword);
    }

    public static bool VerifyPassword(string plainPassword, string hashedPassword)
    {
        try
        {
            // Check if the hashedPassword starts with a valid BCrypt identifier
            if (!hashedPassword.StartsWith("$2a$") && !hashedPassword.StartsWith("$2b$") && !hashedPassword.StartsWith("$2y$"))
            {
                throw new FormatException("Stored hash is not in a valid BCrypt format.");
            }

            return BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);
        }
        catch (SaltParseException ex)
        {
            Console.WriteLine($"BCrypt SaltParseException: {ex.Message}");
            return false;
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format Exception: {ex.Message}");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error during password verification: {ex.Message}");
            return false;
        }
    }
}
