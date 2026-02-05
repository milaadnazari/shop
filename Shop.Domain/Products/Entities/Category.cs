using Shop.Domain.Common.Bases;
using Shop.Domain.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Products.Entities
{
    public class Category:BaseEntity
    {
        private readonly List<Category> _children = new();
        private readonly List<Product> _products = new();
        public IReadOnlyCollection<Product> Products { get; set; }
        public string Name { get; private set; }
        public int? ParentId { get; private set; }
        public Category? Parent { get; private set; }
        public IReadOnlyCollection<Category> Children => _children;
        private Category() { }
        public Category(string name, int? parentId = null)
        {
            ChangeName(name);
            ParentId = parentId;
        }
        public void ChangeName(string name) => Name = name;
        public void AddChild(Category child)
        {
            if (child.Id == Id)
                throw new DomainException("Category cannot be parent of itself");

            child.ParentId = Id;
            _children.Add(child);
        }

    }
}
