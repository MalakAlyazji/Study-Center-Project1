namespace StudyCenterPresentation
{
    partial class ctrlTeacherCardWithFilter
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
            this.ctrlTeacherCard1 = new StudyCenterPresentation.ctrlTeacherCard();
            this.SuspendLayout();
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.FilterEnabled = true;
            this.ctrlFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.Size = new System.Drawing.Size(787, 133);
            this.ctrlFilter1.TabIndex = 0;
            this.ctrlFilter1.OnSearchClick += new System.EventHandler<StudyCenterPresentation.ctrlFilter.SearchClickEventArgs>(this.ctrlFilter1_OnSearchClick);
            this.ctrlFilter1.OnAddClick += new System.EventHandler(this.ctrlFilter1_OnAddClick);
            // 
            // ctrlTeacherCard1
            // 
            this.ctrlTeacherCard1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ctrlTeacherCard1.Location = new System.Drawing.Point(0, 142);
            this.ctrlTeacherCard1.Name = "ctrlTeacherCard1";
            this.ctrlTeacherCard1.Size = new System.Drawing.Size(790, 538);
            this.ctrlTeacherCard1.TabIndex = 1;
            this.ctrlTeacherCard1.Load += new System.EventHandler(this.ctrlTeacherCard1_Load);
            // 
            // ctrlTeacherCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ctrlTeacherCard1);
            this.Controls.Add(this.ctrlFilter1);
            this.Name = "ctrlTeacherCardWithFilter";
            this.Size = new System.Drawing.Size(796, 683);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFilter ctrlFilter1;
        private ctrlTeacherCard ctrlTeacherCard1;
    }
}
