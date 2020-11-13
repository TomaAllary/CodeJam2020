namespace TheThingAboutTheSimpsons {
    partial class MainForm {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleLb = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.aboutUsBtn = new System.Windows.Forms.Label();
            this.ourMissionBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLb
            // 
            this.TitleLb.AutoSize = true;
            this.TitleLb.BackColor = System.Drawing.Color.Transparent;
            this.TitleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLb.ForeColor = System.Drawing.Color.DarkOrange;
            this.TitleLb.Location = new System.Drawing.Point(262, 75);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(450, 63);
            this.TitleLb.TabIndex = 0;
            this.TitleLb.Text = "Did They d\'OH it?";
            // 
            // textInput
            // 
            this.textInput.BackColor = System.Drawing.SystemColors.Window;
            this.textInput.Location = new System.Drawing.Point(347, 153);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(259, 130);
            this.textInput.TabIndex = 1;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(347, 289);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(259, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "search";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // aboutUsBtn
            // 
            this.aboutUsBtn.AutoSize = true;
            this.aboutUsBtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutUsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.aboutUsBtn.Location = new System.Drawing.Point(12, 548);
            this.aboutUsBtn.Name = "aboutUsBtn";
            this.aboutUsBtn.Size = new System.Drawing.Size(68, 17);
            this.aboutUsBtn.TabIndex = 7;
            this.aboutUsBtn.Text = "About US";
            // 
            // ourMissionBtn
            // 
            this.ourMissionBtn.AutoSize = true;
            this.ourMissionBtn.BackColor = System.Drawing.Color.Transparent;
            this.ourMissionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourMissionBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.ourMissionBtn.Location = new System.Drawing.Point(858, 548);
            this.ourMissionBtn.Name = "ourMissionBtn";
            this.ourMissionBtn.Size = new System.Drawing.Size(83, 17);
            this.ourMissionBtn.TabIndex = 8;
            this.ourMissionBtn.Text = "Our Mission";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "No similar episode";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ourMissionBtn);
            this.Controls.Add(this.aboutUsBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.TitleLb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label aboutUsBtn;
        private System.Windows.Forms.Label ourMissionBtn;
        private System.Windows.Forms.Label label1;
    }
}

