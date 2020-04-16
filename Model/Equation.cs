using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExcersize.Model
{

  public enum Operation
  {
    Addition,
    Substruction,
    Multipling,
    Dividing
  }

  public class Equation
  {
    private Dictionary<Operation, string> operations = new Dictionary<Operation, string>()
    {
      { Operation.Addition,"+" },
      { Operation.Substruction,"-" },
      { Operation.Multipling,"*" },
      { Operation.Dividing,"/" }
    };

    public int Num1 { get; set; }
    public int Num2 { get; set; }

    public Operation Operation { get; set; }

    public int Result
    {
      get
      {
        return Operation switch
        {
          Operation.Addition => Num1 + Num2,
          Operation.Substruction => Num1 - Num2,
          Operation.Multipling => Num1 * Num2,
          Operation.Dividing => Num1 / Num2,
          _ => throw new InvalidOperationException($"Invalid operation:{Operation} for equation"),
        };
      }
    }

    public Equation(int num1, int num2, Operation operation)
    {
      Num1 = num1;
      Num2 = num2;
      Operation = operation;
    }

    public override string ToString()
    {
      return $"{Num1} {operations[Operation]} {Num2} =";
    }
  }
}
