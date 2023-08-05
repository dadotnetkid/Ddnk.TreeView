using Ddnk.TreeViews.Models;

namespace Ddnk.Sample1.Models
{
    public class TreeViewSampleModel : ITreeView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NodeType NodeType { get; set; }
        public bool Collapse { get; set; }
        public int? ParentId { get; set; }
        public IList<ITreeView> Children { get; set; }
    }
}
