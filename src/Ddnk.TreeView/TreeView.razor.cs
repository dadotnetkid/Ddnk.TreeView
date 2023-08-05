using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ddnk.TreeViews.Models;
using Microsoft.AspNetCore.Components;

namespace Ddnk.TreeViews
{
    public partial class TreeView<T> where T : ITreeView
    {
        [Parameter] public IList<T> DataSource { get; set; }= new List<T>();
    }
}
