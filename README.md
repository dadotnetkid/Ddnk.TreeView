# Ddnk.TreeView

```
@page "/"
@using Ddnk.TreeViews
@using Ddnk.Sample1.Models
@using Ddnk.TreeViews.Models

<TreeView T="TreeViewSampleModel" DataSource="dataSource" />

@code
{
    List<TreeViewSampleModel> dataSource = new List<TreeViewSampleModel>();

    protected override void OnInitialized()
    {
        dataSource.Add(new TreeViewSampleModel()
            {
                Id = 1,
                Name = "File",
                NodeType = NodeType.File
            });
        dataSource.Add(new TreeViewSampleModel()
            {
                Id = 2,
                Name = "Node 1",
                NodeType = NodeType.Folder,
                Children = new List<ITreeView>()
                {
                    new TreeViewSampleModel()
                    {
                        Id=3,
                        Name = "Node level2",
                        NodeType = NodeType.Folder,
                        Children = new List<ITreeView>()
                        {
                            new TreeViewSampleModel()
                            {
                                Id=4,
                                Name = "Children"
                            }
                        }
                    
                    }
                }
            });
    }
}

```
