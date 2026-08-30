// Build: a2900bb1f746ac605239f48de48c1dc4
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
