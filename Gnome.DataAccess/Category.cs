using System;
using System.Collections.Generic;

namespace Gnome.DataAccess
{
    public class Category
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public string Name { get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }

        public Category()
        {
            this.Children = new List<Category>();
        }
    }
}
