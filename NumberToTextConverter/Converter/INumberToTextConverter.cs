using System;
using System.Threading.Tasks;

namespace NumberToTextConverter
{
    public interface INumberToTextConverter : IDisposable
    {
        string ChangeAmountToText(int amount);

        string CalculateOperation(int amount);
    }
}