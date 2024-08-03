using Bolsover.GearCalculator.Dictionary;

namespace Bolsover.GearCalculator.Parameters;

public interface IGearParameter
{
    string Name { get; set; }
    string Description { get; set; }
    double Value { get; set; }
    string LatexSymbol { get; set; }
    string LatexFormula { get; set; }
    double Calculate(GearDataDictionary dataDictionary);
}