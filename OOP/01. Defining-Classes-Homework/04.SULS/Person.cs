﻿using System;

internal class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 3)
            {
                throw new ArgumentException("First name can not be empty or less than 3 symbols!", "value");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 3)
            {
                throw new ArgumentException("Last name can not be empty or less than 3 symbols!", "value");
            }

            this.lastName = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            if (value < 18)
            {
                throw new ArgumentException("Age can not be less than 18!", "value");
            }

            this.age = value;
        }
    }
}