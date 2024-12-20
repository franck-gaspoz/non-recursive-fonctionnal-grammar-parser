using AnsiVtConsole.NetCore.Component.Console;

namespace NonRecursiveFunctionalGrammarParser;

/// <summary>
/// The syntactic block.
/// </summary>
public sealed class SyntacticBlock
{
    /// <summary>
    /// The text.
    /// </summary>
    public string Text;

    /// <summary>
    /// The index.
    /// </summary>
    public int Index;

    /// <summary>
    /// The syntactic rule.
    /// </summary>
    public TreePath? SyntacticRule;

    /// <summary>
    /// Is selected.
    /// </summary>
    public bool IsSelected;

    /// <summary>
    /// Is ANSI sequence.
    /// </summary>
    public bool IsANSISequence;

    /// <summary>
    /// Initializes a new instance of the <see cref="SyntacticBlock"/> class.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <param name="syntacticRule">The syntactic rule.</param>
    /// <param name="text">The text.</param>
    /// <param name="isSelected">If true, is selected.</param>
    /// <param name="isANSISequence">If true, is ANSI sequence.</param>
    public SyntacticBlock(
        int index,
        TreePath? syntacticRule,
        string text,
        bool isSelected = false,
        bool isANSISequence = true)
    {
        Index = index;
        SyntacticRule = syntacticRule;
        Text = text;
        IsSelected = isSelected;
        IsANSISequence = isANSISequence;
    }

    /// <summary>
    /// Converts to the string.
    /// </summary>
    /// <returns>A <see cref="string"/></returns>
    public override string ToString() => $"{Index}->{Index + Text.Length - 1} : \"{ASCII.GetNonPrintablesCodesAsLabel(Text, false)}\"  ==  {SyntacticRule}";
}