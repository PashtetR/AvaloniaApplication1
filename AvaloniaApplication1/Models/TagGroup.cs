using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1.Models
{
    public class TagGroup
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ObservableCollection<Tag> Tags { get; set; }


        public TagGroup()
        {
            Tags = new ObservableCollection<Tag>() { new() { Id = 1, Name = "Tag1",  Alias = "Tag1Alias" }, new() { Id = 2, Name = "Tag2", Alias = "Tag2Alias" } };
        }


    }
}
