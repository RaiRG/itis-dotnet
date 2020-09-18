﻿﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hw1
{
    class Calculator
    {
    public static int Calculate(string @operator, int a, int b)
        {
            var result = @operator switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                _ => throw new NotSupportedException()
            };
            return result;
        }
    }
}
