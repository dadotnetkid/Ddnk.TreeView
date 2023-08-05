using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ddnk.TreeViews.Models;
using Microsoft.AspNetCore.Components;

namespace Ddnk.TreeViews
{
    public partial class TreeViewNode<T> where T : ITreeView
    {
        [Parameter] public T? Node { get; set; }
        [Parameter] public int Level { get; set; }
        private bool IsRender = false;
        private void Collapse()
        {
            if (Node.NodeType == NodeType.Folder && Node.Children != null && Node.Children.Any() && !Node.Collapse)
            {
                Node.Collapse = !Node.Collapse;
            }
            StateHasChanged();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                if (Node.NodeType == NodeType.Folder && Node.Children != null && Node.Children.Any())
                {
                    Level += 1;
                }
            }
        }
    }
}
