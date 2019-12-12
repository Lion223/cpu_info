namespace CPUInfo
{
    partial class CPUInfoUC
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertiesListView = new MetroFramework.Controls.MetroListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // propertiesListView
            // 
            this.propertiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.valueHeader});
            this.propertiesListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.propertiesListView.FullRowSelect = true;
            this.propertiesListView.GridLines = true;
            this.propertiesListView.Location = new System.Drawing.Point(19, 58);
            this.propertiesListView.Name = "propertiesListView";
            this.propertiesListView.OwnerDraw = true;
            this.propertiesListView.Size = new System.Drawing.Size(572, 496);
            this.propertiesListView.Style = MetroFramework.MetroColorStyle.Red;
            this.propertiesListView.TabIndex = 0;
            this.propertiesListView.UseCompatibleStateImageBehavior = false;
            this.propertiesListView.UseSelectable = true;
            this.propertiesListView.View = System.Windows.Forms.View.Details;
            this.propertiesListView.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 250;
            // 
            // valueHeader
            // 
            this.valueHeader.Text = "Value";
            this.valueHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueHeader.Width = 310;
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.formLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.formLabel.Location = new System.Drawing.Point(19, 19);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(176, 25);
            this.formLabel.TabIndex = 9;
            this.formLabel.Text = "CPU Characteristics";
            // 
            // generalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.propertiesListView);
            this.Name = "generalInfo";
            this.Size = new System.Drawing.Size(610, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView propertiesListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader valueHeader;
        private MetroFramework.Controls.MetroLabel formLabel;
    }
}
