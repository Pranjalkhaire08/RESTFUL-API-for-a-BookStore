using System.Diagnostics;

[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
internal class BookstoreContextBase1
{
    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}