using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace DynamicsTableAssociations
{
    public partial class MainForm : Form
    {
        List<Table> tableList;
        List<TableFieldAssociation> tableFieldAssociations;
        List<List<TableFieldAssociation>> solutions;
        bool initialSearched;
        bool destSearched;
        string initTable;
        string destTable;

        int _SEARCH_LAYER;

        public MainForm()
        {
            InitializeComponent();
            LoadFiles();
            LoadTableLists();
            ResizeListViewColumns();

            initialSearched = false;
            destSearched = false;

            initTable = "";
            destTable = "";

            solutions = new List<List<TableFieldAssociation>>();

            _SEARCH_LAYER = 5;
            cb_SearchLayers.SelectedIndex = 0;
        }

        public void LoadFiles()
        {
            string tableFile = File.ReadAllText("tables.json");
            string tableFieldAssociationFile = File.ReadAllText("tablefieldassociations.json");

            tableList = (JsonSerializer.Deserialize<List<Table>>(tableFile)).OrderBy(t => t.Name).ToList();
            tableFieldAssociations = JsonSerializer.Deserialize<List<TableFieldAssociation>>(tableFieldAssociationFile);
        }

        public void LoadTableLists()
        {
            foreach(var table in tableList)
            {
                ListViewItem initialItem = new ListViewItem(new[] { table.Name });
                ListViewItem destItem = new ListViewItem(new[] { table.Name });

                lv_initial.Items.Add(initialItem);
                lv_dest.Items.Add(destItem);
            }
        }

        private void ResizeListViewColumns()
        {
            foreach (ColumnHeader column in lv_initial.Columns)
            {
                column.Width = -2;
            }

            foreach (ColumnHeader column in lv_dest.Columns)
            {
                column.Width = -2;
            }
        }

        private void tbInitial_TextChanged(object sender, EventArgs e)
        {
            if(tb_initial.Text.Length >= 3)
            {
                lv_initial.Items.Clear();
                IEnumerable<Table> searchedTables = tableList.Where(t => t.Name.ToLower().Contains(tb_initial.Text.ToLower()));
                foreach(var table in searchedTables)
                {
                    ListViewItem initialItem = new ListViewItem(new[] { table.Name });
                    lv_initial.Items.Add(initialItem);
                }
                initialSearched = true;
                ResizeListViewColumns();
            }
            else
            {
                if (initialSearched)
                {
                    lv_initial.Items.Clear();
                    foreach (var table in tableList)
                    {
                        ListViewItem initialItem = new ListViewItem(new[] { table.Name });
                        lv_initial.Items.Add(initialItem);
                    }
                    initialSearched = false;
                    ResizeListViewColumns();
                }
            }
        }

        private void tbDest_TextChanged(object sender, EventArgs e)
        {
            if (tb_dest.Text.Length >= 3)
            {
                lv_dest.Items.Clear();
                IEnumerable<Table> searchedTables = tableList.Where(t => t.Name.ToLower().Contains(tb_dest.Text.ToLower()));
                foreach (var table in searchedTables)
                {
                    ListViewItem destItem = new ListViewItem(new[] { table.Name });
                    lv_dest.Items.Add(destItem);
                }
                destSearched = true;
                ResizeListViewColumns();
            }
            else
            {
                if (destSearched)
                {
                    lv_dest.Items.Clear();
                    foreach (var table in tableList)
                    {
                        ListViewItem destItem = new ListViewItem(new[] { table.Name });
                        lv_dest.Items.Add(destItem);
                    }
                    destSearched = false;
                    ResizeListViewColumns();
                }
            }
        }

        private void lvInitial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_initial.SelectedItems.Count > 0 && lv_dest.SelectedItems.Count > 0)
                btn_analyze.Enabled = true;
        }

        private void lvDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_initial.SelectedItems.Count > 0 && lv_dest.SelectedItems.Count > 0)
                btn_analyze.Enabled = true;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            LoadingForm lf = new LoadingForm();
            try
            {
                lf.Show();
                lf.Refresh();

                lv_output.Items.Clear();
                solutions = new List<List<TableFieldAssociation>>();
                initTable = lv_initial.SelectedItems[0].Text;
                destTable = lv_dest.SelectedItems[0].Text;
                if (initTable == destTable)
                {
                    ListViewItem noItems = new ListViewItem(new[] { "Same Table", "Selected For", "Initial &", "Destination" });
                    lv_output.Items.Add(noItems);
                }
                else
                {
                    TableHierarchy th = new TableHierarchy()
                    {
                        TableName = initTable,
                        Layer = 1
                    };

                    int searchLayer = int.Parse(cb_SearchLayers.SelectedItem.ToString());
                    _SEARCH_LAYER = searchLayer + 1;

                    FindTableAssociations(th);
                    if (solutions.Any())
                    {
                        int i = 2;
                        while (i <= _SEARCH_LAYER)
                        {
                            List<List<TableFieldAssociation>> sortedSolutions = solutions.Where(l => l.Count() == i).OrderBy(x => x.First().ChildTableName).ToList();
                            if (sortedSolutions.Any())
                            {
                                foreach (var solution in sortedSolutions)
                                {
                                    foreach (var entry in solution)
                                    {
                                        ListViewItem item = new ListViewItem(new[] { entry.ParentTableName, entry.ParentFieldName, entry.ChildTableName, entry.ChildFieldName });
                                        lv_output.Items.Add(item);
                                    }

                                    ListViewItem seperator = new ListViewItem(new[] { "--", "--", "--", "--" });
                                    lv_output.Items.Add(seperator);
                                }
                            }
                            i++;
                        }
                    }
                    else
                    {
                        ListViewItem noItems = new ListViewItem(new[] { "No", "Solution", "Found", "!!!" });
                        lv_output.Items.Add(noItems);
                    }
                }

                lf.Close();
            }
            catch(Exception ex)
            {
                lf.Close();
                MessageBox.Show(ex.Message + " - \n" + ex.StackTrace, "Error Analyzing Table Relations", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindTableAssociations(TableHierarchy tableHierarchy)
        {
            //Remove layers from ParentTableFieldAssociations that did not find a solution
            while (tableHierarchy.ParentTableFieldAssociations.Count >= tableHierarchy.Layer)
                tableHierarchy.ParentTableFieldAssociations.RemoveAt(tableHierarchy.ParentTableFieldAssociations.Count - 1);

            bool foundSolution = false;
            if(tableHierarchy.Layer < _SEARCH_LAYER)
            {
                //Find all child tables that have relations to parent
                var childTableFields = tableFieldAssociations.Where(ta => string.Equals(ta.ParentTableName, tableHierarchy.TableName, StringComparison.CurrentCultureIgnoreCase)).ToList();
                foreach (var childTableFieldAssociation in childTableFields)
                {
                    //Remove layers from ParentTableFieldAssociations that did not find a solution
                    while (tableHierarchy.ParentTableFieldAssociations.Count >= tableHierarchy.Layer)
                        tableHierarchy.ParentTableFieldAssociations.RemoveAt(tableHierarchy.ParentTableFieldAssociations.Count - 1);

                    if (string.Equals(childTableFieldAssociation.ChildTableName, destTable, StringComparison.CurrentCultureIgnoreCase))
                    {
                        List<TableFieldAssociation> tableFields = new List<TableFieldAssociation>();
                        tableFields.AddRange(tableHierarchy.ParentTableFieldAssociations);
                        tableFields.Add(childTableFieldAssociation);
                        solutions.Add(tableFields);
                        foundSolution = true;
                    }

                    if (!foundSolution)
                    {
                        //Create a new object to pass to next iteration
                        TableHierarchy childTableHierarchy = new TableHierarchy()
                        {
                            TableName = childTableFieldAssociation.ChildTableName,
                            Layer = (tableHierarchy.Layer + 1),
                            ParentTableFieldAssociations = tableHierarchy.ParentTableFieldAssociations
                        };

                        if (string.Equals(childTableFieldAssociation.ParentTableName, initTable, StringComparison.CurrentCultureIgnoreCase))
                            childTableHierarchy.ParentTableFieldAssociations = new List<TableFieldAssociation>();

                        //Logic to stop cycles where a->b, b->a or a->b, b->c, c->a
                        if(!childTableHierarchy.ParentTableFieldAssociations.Any(pfa => string.Equals(pfa.ParentTableName, childTableHierarchy.TableName, StringComparison.CurrentCultureIgnoreCase)))
                        {
                            childTableHierarchy.ParentTableFieldAssociations.Add(childTableFieldAssociation);
                            FindTableAssociations(childTableHierarchy);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
