namespace NonRecursiveFunctionalGrammarParser;

#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.

/// <summary>
/// rule
/// </summary>
public sealed class Rule : List<string>
{
    static int _counter = 0;
    static readonly object _counterLock = new();
    /// <summary>
    /// The ID.
    /// </summary>
    public int ID;

    /// <summary>
    /// The tree path.
    /// </summary>
    public TreePath TreePath;

    /// <summary>
    /// Gets the key.
    /// </summary>
    /// <value>A <see cref="string"/></value>
    public string Key => TreePath.Key;

    /// <summary>
    /// Initializes a new instance of the <see cref="Rule"/> class.
    /// </summary>
    public Rule() => Init();

    /// <summary>
    /// Initializes a new instance of the <see cref="Rule"/> class.
    /// </summary>
    /// <param name="range">The range.</param>
    public Rule(IEnumerable<string> range) : base(range) => Init();

    void Init()
    {
        TreePath = new TreePath(this, -1);
        lock (_counterLock)
        {
            ID = _counter;
            _counter++;
        }
    }
}