using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class BookstoreContext : BookstoreContextBase1
{
    private static object GetDebuggerDisplay()
    {
        throw new NotImplementedException();
    }
}
