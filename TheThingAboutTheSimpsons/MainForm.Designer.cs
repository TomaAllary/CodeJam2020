﻿namespace TheThingAboutTheSimpsons {
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.aboutUsBtn = new System.Windows.Forms.Label();
            this.ourMissionBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textInput.Location = new System.Drawing.Point(15, 99);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(344, 155);
            this.textInput.TabIndex = 1;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitBtn.Location = new System.Drawing.Point(60, 272);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(259, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "search";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // aboutUsBtn
            // 
            this.aboutUsBtn.AutoSize = true;
            this.aboutUsBtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutUsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.aboutUsBtn.Location = new System.Drawing.Point(820, 505);
            this.aboutUsBtn.Name = "aboutUsBtn";
            this.aboutUsBtn.Size = new System.Drawing.Size(97, 25);
            this.aboutUsBtn.TabIndex = 7;
            this.aboutUsBtn.Text = "About US";
            this.aboutUsBtn.Click += new System.EventHandler(this.aboutUsBtn_Click);
            // 
            // ourMissionBtn
            // 
            this.ourMissionBtn.AutoSize = true;
            this.ourMissionBtn.BackColor = System.Drawing.Color.Transparent;
            this.ourMissionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourMissionBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.ourMissionBtn.Location = new System.Drawing.Point(800, 547);
            this.ourMissionBtn.Name = "ourMissionBtn";
            this.ourMissionBtn.Size = new System.Drawing.Size(117, 25);
            this.ourMissionBtn.TabIndex = 8;
            this.ourMissionBtn.Text = "Our Mission";
            this.ourMissionBtn.Click += new System.EventHandler(this.ourMissionBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "No similar episode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ourMissionBtn);
            this.Controls.Add(this.aboutUsBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.textInput);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "simpsonComparator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label aboutUsBtn;
        private System.Windows.Forms.Label ourMissionBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

