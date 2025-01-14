﻿namespace PhoneBookApp;

internal class Validation
{
    public static bool IsNameValid(string? stringInput)
    {
        if (string.IsNullOrEmpty(stringInput) || stringInput.Length > 50)
        {
            return false;
        }

        foreach (char c in stringInput)
        {
            if (!Char.IsLetter(c) && c != ' ')
                return false;
        }

        return true;
    }

    public static bool IsPhoneNumberValid(string? stringInput)
    {
        if (string.IsNullOrEmpty(stringInput) || stringInput.Length > 14 || stringInput.Length < 10)
        {
            return false;
        }

        foreach (char c in stringInput)
        {
            if (!Char.IsNumber(c) && c != '+' && c != '-' && c != '(' && c != ')' && c != '.')
                return false;
        }

        return true;
    }


    public static bool IsIdValid(string? stringInput)
    {
        if (String.IsNullOrEmpty(stringInput))
        {
            return false;
        }

        foreach (char c in stringInput)
        {
            if (!Char.IsDigit(c) && c != ' ')
                return false;
        }

        return true;
    }
}  
