namespace InterviewTask
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbLocals = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnExecute = new DevExpress.XtraEditors.SimpleButton();
            this.cmbStartDate = new DevExpress.XtraEditors.DateEdit();
            this.cmbEndDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLocals.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEndDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(221, 1);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(729, 574);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.FixedLine.BackColor = System.Drawing.Color.SlateGray;
            this.gridView.Appearance.FixedLine.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView.Appearance.FixedLine.Options.UseForeColor = true;
            this.gridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.SlateGray;
            this.gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // cmbLocals
            // 
            this.cmbLocals.EditValue = "Lokal:";
            this.cmbLocals.Location = new System.Drawing.Point(12, 12);
            this.cmbLocals.Name = "cmbLocals";
            this.cmbLocals.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.SlateGray;
            this.cmbLocals.Properties.AdvancedModeOptions.ShiftedLabelAppearance.BackColor = System.Drawing.Color.SlateGray;
            this.cmbLocals.Properties.AdvancedModeOptions.ShiftedLabelAppearance.Options.UseBackColor = true;
            this.cmbLocals.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cmbLocals.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmbLocals.Properties.Appearance.Options.UseBackColor = true;
            this.cmbLocals.Properties.Appearance.Options.UseForeColor = true;
            this.cmbLocals.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.White;
            this.cmbLocals.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black;
            this.cmbLocals.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.cmbLocals.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.cmbLocals.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLocals.Size = new System.Drawing.Size(188, 22);
            this.cmbLocals.TabIndex = 1;
            this.cmbLocals.SelectedIndexChanged += new System.EventHandler(this.cmbLocals_SelectedIndexChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Appearance.BackColor = System.Drawing.Color.SlateGray;
            this.btnExecute.Appearance.Options.UseBackColor = true;
            this.btnExecute.Location = new System.Drawing.Point(12, 539);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(118, 36);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Zatwierdź";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cmbStartDate
            // 
            this.cmbStartDate.EditValue = "Od: ";
            this.cmbStartDate.Location = new System.Drawing.Point(12, 40);
            this.cmbStartDate.Name = "cmbStartDate";
            this.cmbStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbStartDate.Properties.MaskSettings.Set("mask", "yyyy-MM-dd");
            this.cmbStartDate.Size = new System.Drawing.Size(188, 22);
            this.cmbStartDate.TabIndex = 5;
            this.cmbStartDate.EditValueChanged += new System.EventHandler(this.cmbStartDate_EditValueChanged);
            // 
            // cmbEndDate
            // 
            this.cmbEndDate.EditValue = "Do: ";
            this.cmbEndDate.Location = new System.Drawing.Point(12, 68);
            this.cmbEndDate.Name = "cmbEndDate";
            this.cmbEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEndDate.Properties.MaskSettings.Set("mask", "yyyy-MM-dd");
            this.cmbEndDate.Size = new System.Drawing.Size(188, 22);
            this.cmbEndDate.TabIndex = 6;
            this.cmbEndDate.EditValueChanged += new System.EventHandler(this.cmbEndDate_EditValueChanged);
            // 
            // MainView
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 587);
            this.Controls.Add(this.cmbEndDate);
            this.Controls.Add(this.cmbStartDate);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cmbLocals);
            this.Controls.Add(this.gridControl);
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "Raport";
            this.TransparencyKey = System.Drawing.SystemColors.Info;
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLocals.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEndDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.ComboBoxEdit cmbLocals;
        private DevExpress.XtraEditors.SimpleButton btnExecute;
        private DevExpress.XtraEditors.DateEdit cmbStartDate;
        private DevExpress.XtraEditors.DateEdit cmbEndDate;
    }
}

