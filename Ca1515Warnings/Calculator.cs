﻿namespace Ca1515Warnings;

public class Calculator
{
    public double Value { get; private set; }

    public void Reset()
    {
        Value = 0;
    }

    public void Add(double a)
    {
        Value += a;
    }
}