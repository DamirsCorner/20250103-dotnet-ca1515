﻿namespace Ca1515Warnings;

internal sealed class Calculator
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
