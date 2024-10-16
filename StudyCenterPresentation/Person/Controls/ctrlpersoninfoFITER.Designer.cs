namespace StudyCenterPresentation
{
    partial class ctrlpersoninfoFITER
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
            this.ctrlpersoninfo1 = new StudyCenterPresentation.ctrlpersoninfo();
            this.ctrlFilter1 = new StudyCenterPresentation.ctrlFilter();
            this.SuspendLayout();
            // 
            // ctrlpersoninfo1
            // 
            this.ctrlpersoninfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlpersoninfo1.Location = new System.Drawing.Point(0, 131);
            this.ctrlpersoninfo1.Name = "ctrlpersoninfo1";
            this.ctrlpersoninfo1.Size = new System.Drawing.Size(749, 298);
            this.ctrlpersoninfo1.TabIndex = 1;
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.FilterEnabled = false;
            this.ctrlFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.Size = new System.Drawing.Size(749, 116);
            this.ctrlFilter1.TabIndex = 0;
            this.ctrlFilter1.OnSearchClick += new System.EventHandler<StudyCenterPresentation.ctrlFilter.SearchClickEventArgs>(this.ctrlFilter1_OnSearchClick);
            this.ctrlFilter1.OnAddClick += new System.EventHandler(this.ctrlFilter1_OnAddClick);
            // 
            // ctrlpersoninfoFITER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ctrlpersoninfo1);
            this.Controls.Add(this.ctrlFilter1);
            this.Name = "ctrlpersoninfoFITER";
            this.Size = new System.Drawing.Size(749, 429);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFilter ctrlFilter1;
        private ctrlpersoninfo ctrlpersoninfo1;
    }
}
