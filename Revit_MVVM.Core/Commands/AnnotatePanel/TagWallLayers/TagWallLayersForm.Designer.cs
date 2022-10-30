namespace Revit_MVVM.Core
{
    partial class TagWallLayersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkThickness = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.cmbTextNoteElementType = new System.Windows.Forms.ComboBox();
            this.chkFunction = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbUnitType = new System.Windows.Forms.ComboBox();
            this.lblUnitType = new System.Windows.Forms.Label();
            this.lblDecPlaces = new System.Windows.Forms.Label();
            this.cmbDecimalPlaces = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(100, 321);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(181, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkThickness);
            this.groupBox1.Controls.Add(this.chkName);
            this.groupBox1.Controls.Add(this.cmbTextNoteElementType);
            this.groupBox1.Controls.Add(this.chkFunction);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag Properties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text Type";
            // 
            // chkThickness
            // 
            this.chkThickness.AutoSize = true;
            this.chkThickness.Checked = true;
            this.chkThickness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkThickness.Location = new System.Drawing.Point(7, 66);
            this.chkThickness.Name = "chkThickness";
            this.chkThickness.Size = new System.Drawing.Size(75, 17);
            this.chkThickness.TabIndex = 3;
            this.chkThickness.Text = "Thickness";
            this.chkThickness.UseVisualStyleBackColor = true;
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Checked = true;
            this.chkName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkName.Location = new System.Drawing.Point(7, 43);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(54, 17);
            this.chkName.TabIndex = 2;
            this.chkName.Text = "Name";
            this.chkName.UseVisualStyleBackColor = true;
            // 
            // cmbTextNoteElementType
            // 
            this.cmbTextNoteElementType.FormattingEnabled = true;
            this.cmbTextNoteElementType.Location = new System.Drawing.Point(6, 127);
            this.cmbTextNoteElementType.Name = "cmbTextNoteElementType";
            this.cmbTextNoteElementType.Size = new System.Drawing.Size(231, 21);
            this.cmbTextNoteElementType.TabIndex = 1;
            this.cmbTextNoteElementType.SelectedIndexChanged += new System.EventHandler(this.cmbTextNoteElementType_SelectedIndexChanged);
            // 
            // chkFunction
            // 
            this.chkFunction.AutoSize = true;
            this.chkFunction.Checked = true;
            this.chkFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFunction.Location = new System.Drawing.Point(7, 20);
            this.chkFunction.Name = "chkFunction";
            this.chkFunction.Size = new System.Drawing.Size(67, 17);
            this.chkFunction.TabIndex = 0;
            this.chkFunction.Text = "Function";
            this.chkFunction.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDecPlaces);
            this.groupBox2.Controls.Add(this.cmbDecimalPlaces);
            this.groupBox2.Controls.Add(this.lblUnitType);
            this.groupBox2.Controls.Add(this.cmbUnitType);
            this.groupBox2.Location = new System.Drawing.Point(13, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Units";
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.Location = new System.Drawing.Point(6, 36);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(230, 21);
            this.cmbUnitType.TabIndex = 0;
            this.cmbUnitType.SelectedIndexChanged += new System.EventHandler(this.cmbUnitType_SelectedIndexChanged);
            // 
            // lblUnitType
            // 
            this.lblUnitType.AutoSize = true;
            this.lblUnitType.Location = new System.Drawing.Point(6, 20);
            this.lblUnitType.Name = "lblUnitType";
            this.lblUnitType.Size = new System.Drawing.Size(53, 13);
            this.lblUnitType.TabIndex = 1;
            this.lblUnitType.Text = "Unit Type";
            // 
            // lblDecPlaces
            // 
            this.lblDecPlaces.AutoSize = true;
            this.lblDecPlaces.Location = new System.Drawing.Point(5, 72);
            this.lblDecPlaces.Name = "lblDecPlaces";
            this.lblDecPlaces.Size = new System.Drawing.Size(80, 13);
            this.lblDecPlaces.TabIndex = 3;
            this.lblDecPlaces.Text = "Decimal Places";
            // 
            // cmbDecimalPlaces
            // 
            this.cmbDecimalPlaces.FormattingEnabled = true;
            this.cmbDecimalPlaces.Location = new System.Drawing.Point(5, 88);
            this.cmbDecimalPlaces.Name = "cmbDecimalPlaces";
            this.cmbDecimalPlaces.Size = new System.Drawing.Size(230, 21);
            this.cmbDecimalPlaces.TabIndex = 2;
            this.cmbDecimalPlaces.SelectedIndexChanged += new System.EventHandler(this.cmbDecimalPlaces_SelectedIndexChanged);
            // 
            // TagWallLayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(269, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximumSize = new System.Drawing.Size(285, 395);
            this.Name = "TagWallLayersForm";
            this.Text = "Tag Options";
            this.Load += new System.EventHandler(this.TagWallLayersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkThickness;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.ComboBox cmbTextNoteElementType;
        private System.Windows.Forms.CheckBox chkFunction;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDecPlaces;
        private System.Windows.Forms.ComboBox cmbDecimalPlaces;
        private System.Windows.Forms.Label lblUnitType;
        private System.Windows.Forms.ComboBox cmbUnitType;
    }
}