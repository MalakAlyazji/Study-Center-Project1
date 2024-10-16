namespace StudyCenterPresentation
{
    partial class ctrlStudentIfoFILTER
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
            this.ctrlFilter1 = new StudyCenterPresentation.ctrlFilter();
            this.ctrlstudentcard1 = new StudyCenterPresentation.ctrlstudentcard();
            this.SuspendLayout();
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.FilterEnabled = false;
            this.ctrlFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.Size = new System.Drawing.Size(768, 124);
            this.ctrlFilter1.TabIndex = 1;
            this.ctrlFilter1.OnSearchClick += new System.EventHandler<StudyCenterPresentation.ctrlFilter.SearchClickEventArgs>(this.ctrlFilter1_OnSearchClick);
            this.ctrlFilter1.OnAddClick += new System.EventHandler(this.ctrlFilter1_OnAddClick);
            this.ctrlFilter1.Load += new System.EventHandler(this.ctrlFilter1_Load);
            // 
            // ctrlstudentcard1
            // 
            this.ctrlstudentcard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlstudentcard1.Location = new System.Drawing.Point(3, 131);
            this.ctrlstudentcard1.Name = "ctrlstudentcard1";
            this.ctrlstudentcard1.Size = new System.Drawing.Size(768, 510);
            this.ctrlstudentcard1.TabIndex = 0;
            // 
            // ctrlStudentIfoFILTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ctrlFilter1);
            this.Controls.Add(this.ctrlstudentcard1);
            this.Name = "ctrlStudentIfoFILTER";
            this.Size = new System.Drawing.Size(778, 641);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlstudentcard ctrlstudentcard1;
        private ctrlFilter ctrlFilter1;
    }
}
