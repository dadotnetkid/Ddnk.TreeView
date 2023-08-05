namespace Ddnk.TreeViews.Models;

public interface ITreeView
{
    int Id { get; set; }
    string Name { get; set; }
    NodeType NodeType { get; set; }
    bool Collapse { get; set; }
    public IList<ITreeView>? Children { get; set; }
}