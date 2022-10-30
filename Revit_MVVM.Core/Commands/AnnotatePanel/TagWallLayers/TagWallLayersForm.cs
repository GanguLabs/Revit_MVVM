using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revit_MVVM.Core
{
    public partial class TagWallLayersForm : System.Windows.Forms.Form
    {
        private UIDocument uidoc = null;
        private ElementId textTypeId = null;
        public TagWallLayersForm(UIDocument uIDocument)
        {
            InitializeComponent();
            uidoc = uIDocument;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TagWallLayersForm_Load(object sender, EventArgs e)
        {
            PopulateTextNoteTypeList();
        }

        private void cmbTextNoteElementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textTypeId = ((KeyValuePair<string, ElementId>)cmbTextNoteElementType.SelectedItem).Value;
        }

        public TagWallLayersCommandData GetInformaion()
        {
            var information = new TagWallLayersCommandData()
            {
                Function = chkFunction.Checked,
                Name = chkName.Checked,
                Thickness = chkThickness.Checked,
                TextTypeId = textTypeId
            };

            return information;
        }

        private void PopulateTextNoteTypeList()
        {
            var doc = uidoc.Document;

            var allTextElementTypes = new FilteredElementCollector(doc).OfClass(typeof(TextElementType));

            var list = new List<KeyValuePair<string, ElementId>>();

            foreach (var item in allTextElementTypes)
            {
                list.Add(new KeyValuePair<string, ElementId>(item.Name, item.Id));
            }

            cmbTextNoteElementType.DataSource = null;
            cmbTextNoteElementType.DataSource = new BindingSource(list, null);

            cmbTextNoteElementType.DisplayMember = "Key";
            cmbTextNoteElementType.ValueMember = "Value";
        }

    }
}
