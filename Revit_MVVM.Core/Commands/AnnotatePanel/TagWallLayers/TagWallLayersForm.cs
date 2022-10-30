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
        private LengthUnitType unitType = LengthUnitType.millimeter;
        private int decimals = 1;

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
            PopulateUnitTypeList();
            PopulateDecimalPlacesList();
        }

        private void cmbTextNoteElementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textTypeId = ((KeyValuePair<string, ElementId>)cmbTextNoteElementType.SelectedItem).Value;
        }

        private void cmbUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitType = (LengthUnitType)cmbUnitType.SelectedItem;
        }

        private void cmbDecimalPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimals = (int)cmbDecimalPlaces.SelectedItem;
        }

        public TagWallLayersCommandData GetInformaion()
        {
            var information = new TagWallLayersCommandData()
            {
                Function = chkFunction.Checked,
                Name = chkName.Checked,
                Thickness = chkThickness.Checked,
                TextTypeId = textTypeId,
                UnitType = unitType,
                Decimals = decimals,
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

        private void PopulateUnitTypeList()
        {
            cmbUnitType.DataSource = Enum.GetValues(typeof(LengthUnitType));
        }

        private void PopulateDecimalPlacesList()
        {
            var values = new List<int>() { 0, 1, 2, 3};

            var source = new BindingSource
            {
                DataSource = values,
            };

            cmbDecimalPlaces.DataSource = source.DataSource;
            cmbDecimalPlaces.SelectedItem = values[2];
        }

    }
}
