namespace NonRecursiveFunctionalGrammarParser;

#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.

/// <summary>
/// The tree node.
/// </summary>
public sealed class TreeNode
{
    static int _counter = 0;
    static readonly object _counterLock = new();
    /// <summary>
    /// The ID.
    /// </summary>
    public int ID;
    /// <summary>
    /// Label.
    /// </summary>
    public string Label;
    /// <summary>
    /// The sub nodes.
    /// </summary>
    public readonly Dictionary<string, TreeNode> SubNodes = [];

    /// <summary>
    /// Gets a value indicating whether root.
    /// </summary>
    /// <value>A <see cref="bool"/></value>
    public bool IsRoot => Label == null;

    /// <summary>
    /// Initializes a new instance of the <see cref="TreeNode"/> class.
    /// </summary>
    public TreeNode() => Init();

    /// <summary>
    /// Initializes a new instance of the <see cref="TreeNode"/> class.
    /// </summary>
    /// <param name="label">The label.</param>
    public TreeNode(string label)
    {
        if (label == null)
            throw new Exception("label can't be null");
        Init();
        Label = label;
    }

    void Init()
    {
        lock (_counterLock)
        {
            ID = _counter;
            _counter++;
        }
    }

    /// <summary>
    /// Converts to the string.
    /// </summary>
    /// <returns>A <see cref="string"/></returns>
    public override string ToString() => $" {ID}:  {Label}  -> {string.Join(" ", SubNodes.Values.Select(x => x.Label))}";
}