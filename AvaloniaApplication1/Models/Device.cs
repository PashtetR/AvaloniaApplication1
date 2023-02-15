using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ObservableCollection<TagGroup> TagGroups { get; set; }

        public Device()
        {
            TagGroups = new ObservableCollection<TagGroup>() { new() { Id = 1, Name = "Group1" }, new() { Id = 2, Name = "Group2" } };
        }

    }
}
