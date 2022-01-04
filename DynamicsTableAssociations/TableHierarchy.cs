using System.Collections.Generic;

namespace DynamicsTableAssociations
{
    public class TableHierarchy
    {
        public int Layer { get; set; }
        public string TableName { get; set; }
        public List<TableFieldAssociation> ParentTableFieldAssociations { get; set; }

        public TableHierarchy()
        {
            ParentTableFieldAssociations = new List<TableFieldAssociation>();
        }
    }
}
