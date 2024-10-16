namespace StudyCenterPresentation
{
    partial class ctrlClassCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlClassInfo1 = new StudyCenterPresentation.ctrlClassInfo();
            this.ctrlFilter1 = new StudyCenterPresentation.ctrlFilter();
            this.SuspendLayout();
            // 
            // ctrlClassInfo1
            // 
            this.ctrlClassInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlClassInfo1.Location = new System.Drawing.Point(3, 142);
            this.ctrlClassInfo1.Name = "ctrlClassInfo1";
            this.ctrlClassInfo1.Size = new System.Drawing.Size(789, 238);
            this.ctrlClassInfo1.TabIndex = 0;
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.FilterEnabled = false;
            this.ctrlFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.Size = new System.Drawing.Size(781, 133);
            this.ctrlFilter1.TabIndex = 1;
            this.ctrlFilter1.OnSearchClick += new System.EventHandler<StudyCenterPresentation.ctrlFilter.SearchClickEventArgs>(this.ctrlFilter1_OnSearchClick);
            this.ctrlFilter1.OnAddClick += new System.EventHandler(this.ctrlFilter1_OnAddClick);
            // 
            // ctrlClassCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ctrlFilter1);
            this.Controls.Add(this.ctrlClassInfo1);
            this.Name = "ctrlClassCardWithFilter";
            this.Size = new System.Drawing.Size(789, 378);
            this.Load += new System.EventHandler(this.ctrlClassCardWithFilter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlClassInfo ctrlClassInfo1;
        private ctrlFilter ctrlFilter1;
    }
}
