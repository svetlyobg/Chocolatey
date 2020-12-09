
namespace Chocolatey
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGetExecPolicy = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnSetExecPolicy = new System.Windows.Forms.Button();
            this.btnSetExecPolByPass = new System.Windows.Forms.Button();
            this.btnChocoListLO = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnUpgradeOutdated = new System.Windows.Forms.Button();
            this.btnListOutdated = new System.Windows.Forms.Button();
            this.bntInstallNoAV = new System.Windows.Forms.Button();
            this.btnLightInstall = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetExecPolicy
            // 
            this.btnGetExecPolicy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGetExecPolicy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetExecPolicy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGetExecPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetExecPolicy.Location = new System.Drawing.Point(12, 37);
            this.btnGetExecPolicy.Name = "btnGetExecPolicy";
            this.btnGetExecPolicy.Size = new System.Drawing.Size(174, 30);
            this.btnGetExecPolicy.TabIndex = 0;
            this.btnGetExecPolicy.Text = "GetExecPolicy";
            this.btnGetExecPolicy.UseVisualStyleBackColor = false;
            this.btnGetExecPolicy.Click += new System.EventHandler(this.btnPowerShell_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtMsg.Location = new System.Drawing.Point(12, 185);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(894, 509);
            this.txtMsg.TabIndex = 1;
            // 
            // btnSetExecPolicy
            // 
            this.btnSetExecPolicy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSetExecPolicy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetExecPolicy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSetExecPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetExecPolicy.Location = new System.Drawing.Point(192, 37);
            this.btnSetExecPolicy.Name = "btnSetExecPolicy";
            this.btnSetExecPolicy.Size = new System.Drawing.Size(174, 30);
            this.btnSetExecPolicy.TabIndex = 2;
            this.btnSetExecPolicy.Text = "SetExecPolicy AllSigned";
            this.btnSetExecPolicy.UseVisualStyleBackColor = false;
            this.btnSetExecPolicy.Click += new System.EventHandler(this.btnSetExecPolicy_Click);
            // 
            // btnSetExecPolByPass
            // 
            this.btnSetExecPolByPass.BackColor = System.Drawing.Color.Tomato;
            this.btnSetExecPolByPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetExecPolByPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSetExecPolByPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetExecPolByPass.Location = new System.Drawing.Point(366, 23);
            this.btnSetExecPolByPass.Name = "btnSetExecPolByPass";
            this.btnSetExecPolByPass.Size = new System.Drawing.Size(174, 30);
            this.btnSetExecPolByPass.TabIndex = 3;
            this.btnSetExecPolByPass.Text = "SetExecPolicy ByPass";
            this.btnSetExecPolByPass.UseVisualStyleBackColor = false;
            this.btnSetExecPolByPass.Click += new System.EventHandler(this.btnSetExecPolByPass_Click);
            // 
            // btnChocoListLO
            // 
            this.btnChocoListLO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChocoListLO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChocoListLO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChocoListLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChocoListLO.Location = new System.Drawing.Point(12, 132);
            this.btnChocoListLO.Name = "btnChocoListLO";
            this.btnChocoListLO.Size = new System.Drawing.Size(174, 29);
            this.btnChocoListLO.TabIndex = 4;
            this.btnChocoListLO.Text = "Choco List Local Only";
            this.btnChocoListLO.UseVisualStyleBackColor = false;
            this.btnChocoListLO.Click += new System.EventHandler(this.btnChocoListLO_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.BackColor = System.Drawing.Color.Tomato;
            this.btnListAll.Cursor = System.Windows.Forms.Cursors.No;
            this.btnListAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAll.Location = new System.Drawing.Point(372, 132);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(174, 29);
            this.btnListAll.TabIndex = 5;
            this.btnListAll.Text = "List All Packages";
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // btnUpgradeOutdated
            // 
            this.btnUpgradeOutdated.BackColor = System.Drawing.Color.Lime;
            this.btnUpgradeOutdated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpgradeOutdated.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpgradeOutdated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpgradeOutdated.Location = new System.Drawing.Point(767, 133);
            this.btnUpgradeOutdated.Name = "btnUpgradeOutdated";
            this.btnUpgradeOutdated.Size = new System.Drawing.Size(174, 29);
            this.btnUpgradeOutdated.TabIndex = 6;
            this.btnUpgradeOutdated.Text = "Upgrade Outdated";
            this.btnUpgradeOutdated.UseVisualStyleBackColor = false;
            this.btnUpgradeOutdated.Click += new System.EventHandler(this.btnListOutdated_Click);
            // 
            // btnListOutdated
            // 
            this.btnListOutdated.BackColor = System.Drawing.Color.Khaki;
            this.btnListOutdated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListOutdated.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnListOutdated.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnListOutdated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListOutdated.Location = new System.Drawing.Point(587, 131);
            this.btnListOutdated.Name = "btnListOutdated";
            this.btnListOutdated.Size = new System.Drawing.Size(174, 30);
            this.btnListOutdated.TabIndex = 7;
            this.btnListOutdated.Text = "List Outdated";
            this.btnListOutdated.UseVisualStyleBackColor = false;
            this.btnListOutdated.Click += new System.EventHandler(this.btnListOutdated_Click_1);
            // 
            // bntInstallNoAV
            // 
            this.bntInstallNoAV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntInstallNoAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntInstallNoAV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bntInstallNoAV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntInstallNoAV.Location = new System.Drawing.Point(6, 24);
            this.bntInstallNoAV.Name = "bntInstallNoAV";
            this.bntInstallNoAV.Size = new System.Drawing.Size(174, 29);
            this.bntInstallNoAV.TabIndex = 8;
            this.bntInstallNoAV.Text = "Install (no AV)";
            this.bntInstallNoAV.UseVisualStyleBackColor = false;
            this.bntInstallNoAV.Click += new System.EventHandler(this.bntInstallNoAV_Click);
            // 
            // btnLightInstall
            // 
            this.btnLightInstall.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLightInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLightInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightInstall.Location = new System.Drawing.Point(186, 25);
            this.btnLightInstall.Name = "btnLightInstall";
            this.btnLightInstall.Size = new System.Drawing.Size(174, 28);
            this.btnLightInstall.TabIndex = 9;
            this.btnLightInstall.Text = "Light Install (with AV)";
            this.btnLightInstall.UseVisualStyleBackColor = false;
            this.btnLightInstall.Click += new System.EventHandler(this.btnLightInstall_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.BackColor = System.Drawing.Color.RosyBrown;
            this.btnForm2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnForm2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnForm2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForm2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnForm2.Location = new System.Drawing.Point(931, 185);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(201, 314);
            this.btnForm2.TabIndex = 10;
            this.btnForm2.Text = "Install packages ->";
            this.btnForm2.UseVisualStyleBackColor = false;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnSetExecPolByPass);
            this.groupBox1.Location = new System.Drawing.Point(6, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Policies";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.bntInstallNoAV);
            this.groupBox2.Controls.Add(this.btnLightInstall);
            this.groupBox2.Location = new System.Drawing.Point(581, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Install Chocolatey";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1246, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nasko, Gena, Svet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1356, 706);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnListOutdated);
            this.Controls.Add(this.btnUpgradeOutdated);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnChocoListLO);
            this.Controls.Add(this.btnSetExecPolicy);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnGetExecPolicy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chocolatey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetExecPolicy;
        public System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSetExecPolicy;
        private System.Windows.Forms.Button btnSetExecPolByPass;
        private System.Windows.Forms.Button btnChocoListLO;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnUpgradeOutdated;
        private System.Windows.Forms.Button btnListOutdated;
        private System.Windows.Forms.Button bntInstallNoAV;
        private System.Windows.Forms.Button btnLightInstall;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

