using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ConcreteStrategyOne : IStrategy
    {
        public int math(int a, int b, int c)
        {
            return a * b + c;
        }
    }
    public class ConcreteStrategyTwo : IStrategy
    {
        public int math(int a, int b, int c)
        {
            return a / b - c;
        }
    }
    public class ConcreteStrategyThree : IStrategy
    {
        public int math(int a, int b, int c)
        {
            return a - b + c;
        }
    }
    public class Context
    {
        public IStrategy ConcreteStrategy { get; set; }
        public Context(IStrategy _strategy)
        {
            ConcreteStrategy = _strategy;
        }

        public void ExecuteAlgorithm(int A, int B, int C)
        {
            ConcreteStrategy.math(A, B, C);
        }
    }
}
