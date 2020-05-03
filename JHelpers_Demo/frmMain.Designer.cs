namespace JHelpers_Demo
{
	using Jeff.Jones.JHelpers;

	partial class frmMain
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

			ContextMgr.Instance.Dispose();

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpOperations = new System.Windows.Forms.GroupBox();
			this.lstOperations = new System.Windows.Forms.ListBox();
			this.grpOperationResults = new System.Windows.Forms.GroupBox();
			this.txtResults = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.grpOperations.SuspendLayout();
			this.grpOperationResults.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpOperations
			// 
			this.grpOperations.Controls.Add(this.lstOperations);
			this.grpOperations.Dock = System.Windows.Forms.DockStyle.Left;
			this.grpOperations.Location = new System.Drawing.Point(0, 0);
			this.grpOperations.Name = "grpOperations";
			this.grpOperations.Size = new System.Drawing.Size(747, 1405);
			this.grpOperations.TabIndex = 2;
			this.grpOperations.TabStop = false;
			this.grpOperations.Text = "JHelpers Operations";
			// 
			// lstOperations
			// 
			this.lstOperations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstOperations.FormattingEnabled = true;
			this.lstOperations.ItemHeight = 33;
			this.lstOperations.Location = new System.Drawing.Point(3, 36);
			this.lstOperations.Name = "lstOperations";
			this.lstOperations.Size = new System.Drawing.Size(741, 1366);
			this.lstOperations.TabIndex = 1;
			this.lstOperations.SelectedIndexChanged += new System.EventHandler(this.lstOperations_SelectedIndexChanged);
			// 
			// grpOperationResults
			// 
			this.grpOperationResults.Controls.Add(this.txtResults);
			this.grpOperationResults.Controls.Add(this.txtDescription);
			this.grpOperationResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpOperationResults.Location = new System.Drawing.Point(747, 0);
			this.grpOperationResults.Name = "grpOperationResults";
			this.grpOperationResults.Size = new System.Drawing.Size(1292, 1405);
			this.grpOperationResults.TabIndex = 3;
			this.grpOperationResults.TabStop = false;
			this.grpOperationResults.Text = "Operation Results";
			// 
			// txtResults
			// 
			this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtResults.Location = new System.Drawing.Point(3, 366);
			this.txtResults.Multiline = true;
			this.txtResults.Name = "txtResults";
			this.txtResults.ReadOnly = true;
			this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResults.Size = new System.Drawing.Size(1286, 1036);
			this.txtResults.TabIndex = 1;
			this.txtResults.Text = "Results:";
			// 
			// txtDescription
			// 
			this.txtDescription.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtDescription.Location = new System.Drawing.Point(3, 36);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(1286, 330);
			this.txtDescription.TabIndex = 0;
			this.txtDescription.Text = "Description:";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2039, 1405);
			this.Controls.Add(this.grpOperationResults);
			this.Controls.Add(this.grpOperations);
			this.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "JHelpers Demo";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.grpOperations.ResumeLayout(false);
			this.grpOperationResults.ResumeLayout(false);
			this.grpOperationResults.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstIPAddresses;
		private System.Windows.Forms.Label lblIPAddresses;
		private System.Windows.Forms.GroupBox grpOperations;
		private System.Windows.Forms.ListBox lstOperations;
		private System.Windows.Forms.GroupBox grpOperationResults;
		private System.Windows.Forms.TextBox txtResults;
		private System.Windows.Forms.TextBox txtDescription;
	}
}

