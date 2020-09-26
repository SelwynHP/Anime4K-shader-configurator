﻿namespace shader_configurator.GUI
{
    partial class ControlManagement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxBinding1 = new System.Windows.Forms.ComboBox();
            this.listBoxControls = new System.Windows.Forms.ListBox();
            this.comboBoxBinding2 = new System.Windows.Forms.ComboBox();
            this.comboBoxCommand = new System.Windows.Forms.ComboBox();
            this.textBoxBindings = new System.Windows.Forms.TextBox();
            this.buttonSetBinding = new System.Windows.Forms.Button();
            this.comboBoxShader = new System.Windows.Forms.ComboBox();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.buttonUnsetBinding = new System.Windows.Forms.Button();
            this.buttonUnsetShader = new System.Windows.Forms.Button();
            this.buttonSetShader = new System.Windows.Forms.Button();
            this.textBoxBinding3 = new System.Windows.Forms.TextBox();
            this.listBoxShaders = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxShaders);
            this.tabPage1.Controls.Add(this.textBoxBinding3);
            this.tabPage1.Controls.Add(this.buttonUnsetShader);
            this.tabPage1.Controls.Add(this.buttonSetShader);
            this.tabPage1.Controls.Add(this.buttonUnsetBinding);
            this.tabPage1.Controls.Add(this.textBoxPreview);
            this.tabPage1.Controls.Add(this.comboBoxShader);
            this.tabPage1.Controls.Add(this.buttonSetBinding);
            this.tabPage1.Controls.Add(this.textBoxBindings);
            this.tabPage1.Controls.Add(this.comboBoxCommand);
            this.tabPage1.Controls.Add(this.comboBoxBinding2);
            this.tabPage1.Controls.Add(this.listBoxControls);
            this.tabPage1.Controls.Add(this.comboBoxBinding1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxBinding1
            // 
            this.comboBoxBinding1.FormattingEnabled = true;
            this.comboBoxBinding1.Location = new System.Drawing.Point(56, 31);
            this.comboBoxBinding1.Name = "comboBoxBinding1";
            this.comboBoxBinding1.Size = new System.Drawing.Size(71, 21);
            this.comboBoxBinding1.TabIndex = 0;
            // 
            // listBoxControls
            // 
            this.listBoxControls.FormattingEnabled = true;
            this.listBoxControls.Location = new System.Drawing.Point(56, 179);
            this.listBoxControls.Name = "listBoxControls";
            this.listBoxControls.Size = new System.Drawing.Size(582, 121);
            this.listBoxControls.TabIndex = 3;
            // 
            // comboBoxBinding2
            // 
            this.comboBoxBinding2.FormattingEnabled = true;
            this.comboBoxBinding2.Location = new System.Drawing.Point(133, 31);
            this.comboBoxBinding2.Name = "comboBoxBinding2";
            this.comboBoxBinding2.Size = new System.Drawing.Size(71, 21);
            this.comboBoxBinding2.TabIndex = 4;
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(287, 31);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(112, 21);
            this.comboBoxCommand.TabIndex = 6;
            // 
            // textBoxBindings
            // 
            this.textBoxBindings.Location = new System.Drawing.Point(56, 90);
            this.textBoxBindings.Multiline = true;
            this.textBoxBindings.Name = "textBoxBindings";
            this.textBoxBindings.Size = new System.Drawing.Size(225, 58);
            this.textBoxBindings.TabIndex = 7;
            this.textBoxBindings.TextChanged += new System.EventHandler(this.textBoxBindings_TextChanged);
            // 
            // buttonSetBinding
            // 
            this.buttonSetBinding.Location = new System.Drawing.Point(56, 58);
            this.buttonSetBinding.Name = "buttonSetBinding";
            this.buttonSetBinding.Size = new System.Drawing.Size(107, 23);
            this.buttonSetBinding.TabIndex = 8;
            this.buttonSetBinding.Text = "Set Binding";
            this.buttonSetBinding.UseVisualStyleBackColor = true;
            this.buttonSetBinding.Click += new System.EventHandler(this.buttonSetBinding_Click);
            // 
            // comboBoxShader
            // 
            this.comboBoxShader.FormattingEnabled = true;
            this.comboBoxShader.Location = new System.Drawing.Point(405, 31);
            this.comboBoxShader.Name = "comboBoxShader";
            this.comboBoxShader.Size = new System.Drawing.Size(233, 21);
            this.comboBoxShader.TabIndex = 9;
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Location = new System.Drawing.Point(56, 154);
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.Size = new System.Drawing.Size(582, 20);
            this.textBoxPreview.TabIndex = 12;
            // 
            // buttonUnsetBinding
            // 
            this.buttonUnsetBinding.Location = new System.Drawing.Point(174, 58);
            this.buttonUnsetBinding.Name = "buttonUnsetBinding";
            this.buttonUnsetBinding.Size = new System.Drawing.Size(107, 23);
            this.buttonUnsetBinding.TabIndex = 13;
            this.buttonUnsetBinding.Text = "Unset Binding";
            this.buttonUnsetBinding.UseVisualStyleBackColor = true;
            this.buttonUnsetBinding.Click += new System.EventHandler(this.buttonUnsetBinding_Click);
            // 
            // buttonUnsetShader
            // 
            this.buttonUnsetShader.Location = new System.Drawing.Point(523, 58);
            this.buttonUnsetShader.Name = "buttonUnsetShader";
            this.buttonUnsetShader.Size = new System.Drawing.Size(107, 23);
            this.buttonUnsetShader.TabIndex = 15;
            this.buttonUnsetShader.Text = "Unset Shader";
            this.buttonUnsetShader.UseVisualStyleBackColor = true;
            this.buttonUnsetShader.Click += new System.EventHandler(this.buttonUnsetShader_Click);
            // 
            // buttonSetShader
            // 
            this.buttonSetShader.Location = new System.Drawing.Point(405, 58);
            this.buttonSetShader.Name = "buttonSetShader";
            this.buttonSetShader.Size = new System.Drawing.Size(107, 23);
            this.buttonSetShader.TabIndex = 14;
            this.buttonSetShader.Text = "Set Shader";
            this.buttonSetShader.UseVisualStyleBackColor = true;
            this.buttonSetShader.Click += new System.EventHandler(this.buttonSetShader_Click);
            // 
            // textBoxBinding3
            // 
            this.textBoxBinding3.Location = new System.Drawing.Point(210, 32);
            this.textBoxBinding3.Name = "textBoxBinding3";
            this.textBoxBinding3.Size = new System.Drawing.Size(71, 20);
            this.textBoxBinding3.TabIndex = 16;
            // 
            // listBoxShaders
            // 
            this.listBoxShaders.FormattingEnabled = true;
            this.listBoxShaders.Location = new System.Drawing.Point(405, 90);
            this.listBoxShaders.Name = "listBoxShaders";
            this.listBoxShaders.Size = new System.Drawing.Size(225, 56);
            this.listBoxShaders.TabIndex = 17;
            this.listBoxShaders.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.listBoxShaders_ControlAdded);
            // 
            // ControlManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 367);
            this.Controls.Add(this.tabControl1);
            this.Name = "ControlManagement";
            this.Text = "ControlManagement";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonUnsetShader;
        private System.Windows.Forms.Button buttonSetShader;
        private System.Windows.Forms.Button buttonUnsetBinding;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.ComboBox comboBoxShader;
        private System.Windows.Forms.Button buttonSetBinding;
        private System.Windows.Forms.TextBox textBoxBindings;
        private System.Windows.Forms.ComboBox comboBoxCommand;
        private System.Windows.Forms.ComboBox comboBoxBinding2;
        private System.Windows.Forms.ListBox listBoxControls;
        private System.Windows.Forms.ComboBox comboBoxBinding1;
        private System.Windows.Forms.TextBox textBoxBinding3;
        private System.Windows.Forms.ListBox listBoxShaders;
    }
}