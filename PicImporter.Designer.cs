namespace PicImporter
{
	partial class PicImporter
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.FromBox = new System.Windows.Forms.GroupBox();
			this.SearchDCIMButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.FromFolderLabel = new System.Windows.Forms.Label();
			this.FromDriveSel = new System.Windows.Forms.ComboBox();
			this.SearchDrvButton = new System.Windows.Forms.Button();
			this.FromFolderTB = new System.Windows.Forms.TextBox();
			this.FromDriveLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.FilterPanel = new System.Windows.Forms.Panel();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.FilterCheckButton = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.DestBox = new System.Windows.Forms.GroupBox();
			this.FolderSelLabel = new System.Windows.Forms.Label();
			this.AutoFolderCheckbox = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.AutoFolderConfigB = new System.Windows.Forms.Button();
			this.AutoFolderPulldown = new System.Windows.Forms.ComboBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.FolderselPulldown = new System.Windows.Forms.ComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.DestfolderLabel = new System.Windows.Forms.Label();
			this.MainFLP = new System.Windows.Forms.FlowLayoutPanel();
			this.StartButton = new System.Windows.Forms.Button();
			this.FromBox.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.FilterPanel.SuspendLayout();
			this.DestBox.SuspendLayout();
			this.MainFLP.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("メイリオ", 12F);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "PicImporter";
			// 
			// FromBox
			// 
			this.FromBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FromBox.AutoSize = true;
			this.FromBox.Controls.Add(this.SearchDCIMButton);
			this.FromBox.Controls.Add(this.label6);
			this.FromBox.Controls.Add(this.FromFolderLabel);
			this.FromBox.Controls.Add(this.FromDriveSel);
			this.FromBox.Controls.Add(this.SearchDrvButton);
			this.FromBox.Controls.Add(this.FromFolderTB);
			this.FromBox.Controls.Add(this.FromDriveLabel);
			this.FromBox.Location = new System.Drawing.Point(6, 6);
			this.FromBox.Margin = new System.Windows.Forms.Padding(6);
			this.FromBox.Name = "FromBox";
			this.FromBox.Size = new System.Drawing.Size(510, 122);
			this.FromBox.TabIndex = 3;
			this.FromBox.TabStop = false;
			this.FromBox.Text = "取り込み元の設定";
			// 
			// SearchDCIMButton
			// 
			this.SearchDCIMButton.Location = new System.Drawing.Point(381, 43);
			this.SearchDCIMButton.Name = "SearchDCIMButton";
			this.SearchDCIMButton.Size = new System.Drawing.Size(123, 23);
			this.SearchDCIMButton.TabIndex = 9;
			this.SearchDCIMButton.Text = "DCIMフォルダ検索";
			this.SearchDCIMButton.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label6.Location = new System.Drawing.Point(3, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(504, 18);
			this.label6.TabIndex = 8;
			this.label6.Text = "- ここに情報が表示されます -";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FromFolderLabel
			// 
			this.FromFolderLabel.AutoSize = true;
			this.FromFolderLabel.Location = new System.Drawing.Point(6, 76);
			this.FromFolderLabel.Name = "FromFolderLabel";
			this.FromFolderLabel.Size = new System.Drawing.Size(116, 18);
			this.FromFolderLabel.TabIndex = 7;
			this.FromFolderLabel.Text = "取り込み元フォルダ";
			// 
			// FromDriveSel
			// 
			this.FromDriveSel.FormattingEnabled = true;
			this.FromDriveSel.Location = new System.Drawing.Point(9, 43);
			this.FromDriveSel.Name = "FromDriveSel";
			this.FromDriveSel.Size = new System.Drawing.Size(254, 26);
			this.FromDriveSel.TabIndex = 6;
			this.FromDriveSel.SelectedIndexChanged += new System.EventHandler(this.FromDriveSel_SelectedIndexChanged);
			// 
			// SearchDrvButton
			// 
			this.SearchDrvButton.Location = new System.Drawing.Point(272, 43);
			this.SearchDrvButton.Name = "SearchDrvButton";
			this.SearchDrvButton.Size = new System.Drawing.Size(103, 23);
			this.SearchDrvButton.TabIndex = 5;
			this.SearchDrvButton.Text = "ドライブ再検索";
			this.SearchDrvButton.UseVisualStyleBackColor = true;
			// 
			// FromFolderTB
			// 
			this.FromFolderTB.Location = new System.Drawing.Point(128, 73);
			this.FromFolderTB.Name = "FromFolderTB";
			this.FromFolderTB.Size = new System.Drawing.Size(376, 25);
			this.FromFolderTB.TabIndex = 4;
			this.FromFolderTB.Text = "Path";
			// 
			// FromDriveLabel
			// 
			this.FromDriveLabel.AutoSize = true;
			this.FromDriveLabel.Location = new System.Drawing.Point(6, 21);
			this.FromDriveLabel.Name = "FromDriveLabel";
			this.FromDriveLabel.Size = new System.Drawing.Size(224, 18);
			this.FromDriveLabel.TabIndex = 3;
			this.FromDriveLabel.Text = "取り込み元のドライブを選んでください";
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSize = true;
			this.groupBox2.Controls.Add(this.FilterPanel);
			this.groupBox2.Controls.Add(this.FilterCheckButton);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(3, 295);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(529, 115);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "フィルタ設定";
			// 
			// FilterPanel
			// 
			this.FilterPanel.Controls.Add(this.dateTimePicker1);
			this.FilterPanel.Controls.Add(this.comboBox2);
			this.FilterPanel.Controls.Add(this.dateTimePicker2);
			this.FilterPanel.Location = new System.Drawing.Point(9, 45);
			this.FilterPanel.Name = "FilterPanel";
			this.FilterPanel.Size = new System.Drawing.Size(514, 46);
			this.FilterPanel.TabIndex = 8;
			this.FilterPanel.Visible = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(10, 3);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(144, 25);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "以降",
            "以前",
            "以外",
            "から ... まで",
            "から ... まで 以外"});
			this.comboBox2.Location = new System.Drawing.Point(160, 2);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(97, 26);
			this.comboBox2.TabIndex = 3;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(263, 3);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(156, 25);
			this.dateTimePicker2.TabIndex = 1;
			// 
			// FilterCheckButton
			// 
			this.FilterCheckButton.AutoSize = true;
			this.FilterCheckButton.Location = new System.Drawing.Point(387, 17);
			this.FilterCheckButton.Name = "FilterCheckButton";
			this.FilterCheckButton.Size = new System.Drawing.Size(123, 22);
			this.FilterCheckButton.TabIndex = 7;
			this.FilterCheckButton.Text = "フィルターを使う";
			this.FilterCheckButton.UseVisualStyleBackColor = true;
			this.FilterCheckButton.CheckedChanged += new System.EventHandler(this.FilterCheckButton_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "日付・サイズで絞り込む";
			// 
			// DestBox
			// 
			this.DestBox.AutoSize = true;
			this.DestBox.Controls.Add(this.FolderSelLabel);
			this.DestBox.Controls.Add(this.AutoFolderCheckbox);
			this.DestBox.Controls.Add(this.checkBox3);
			this.DestBox.Controls.Add(this.AutoFolderConfigB);
			this.DestBox.Controls.Add(this.AutoFolderPulldown);
			this.DestBox.Controls.Add(this.checkBox2);
			this.DestBox.Controls.Add(this.FolderselPulldown);
			this.DestBox.Controls.Add(this.textBox2);
			this.DestBox.Controls.Add(this.DestfolderLabel);
			this.DestBox.Location = new System.Drawing.Point(3, 137);
			this.DestBox.Name = "DestBox";
			this.DestBox.Size = new System.Drawing.Size(545, 152);
			this.DestBox.TabIndex = 7;
			this.DestBox.TabStop = false;
			this.DestBox.Text = "保存先の設定";
			// 
			// FolderSelLabel
			// 
			this.FolderSelLabel.AutoSize = true;
			this.FolderSelLabel.Location = new System.Drawing.Point(269, 47);
			this.FolderSelLabel.Name = "FolderSelLabel";
			this.FolderSelLabel.Size = new System.Drawing.Size(92, 18);
			this.FolderSelLabel.TabIndex = 9;
			this.FolderSelLabel.Text = "フォルダ指定→";
			// 
			// AutoFolderCheckbox
			// 
			this.AutoFolderCheckbox.AutoSize = true;
			this.AutoFolderCheckbox.Location = new System.Drawing.Point(9, 76);
			this.AutoFolderCheckbox.Name = "AutoFolderCheckbox";
			this.AutoFolderCheckbox.Size = new System.Drawing.Size(159, 22);
			this.AutoFolderCheckbox.TabIndex = 8;
			this.AutoFolderCheckbox.Text = "フォルダを自動作成する";
			this.AutoFolderCheckbox.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(195, 106);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(183, 22);
			this.checkBox3.TabIndex = 7;
			this.checkBox3.Text = "ファイル上書き時に確認する";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// AutoFolderConfigB
			// 
			this.AutoFolderConfigB.Enabled = false;
			this.AutoFolderConfigB.Location = new System.Drawing.Point(9, 46);
			this.AutoFolderConfigB.Name = "AutoFolderConfigB";
			this.AutoFolderConfigB.Size = new System.Drawing.Size(106, 23);
			this.AutoFolderConfigB.TabIndex = 6;
			this.AutoFolderConfigB.Text = "自動作成の設定";
			this.AutoFolderConfigB.UseVisualStyleBackColor = true;
			// 
			// AutoFolderPulldown
			// 
			this.AutoFolderPulldown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AutoFolderPulldown.FormattingEnabled = true;
			this.AutoFolderPulldown.Items.AddRange(new object[] {
            "(フォルダの自動作成をしない)",
            "最も新しいファイルの日付",
            "最も古いファイルの日付"});
			this.AutoFolderPulldown.Location = new System.Drawing.Point(174, 74);
			this.AutoFolderPulldown.Name = "AutoFolderPulldown";
			this.AutoFolderPulldown.Size = new System.Drawing.Size(365, 26);
			this.AutoFolderPulldown.TabIndex = 5;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(6, 106);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(183, 22);
			this.checkBox2.TabIndex = 3;
			this.checkBox2.Text = "同名のファイルを上書きする";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// FolderselPulldown
			// 
			this.FolderselPulldown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FolderselPulldown.FormattingEnabled = true;
			this.FolderselPulldown.Items.AddRange(new object[] {
            "(自動設定)",
            "「ピクチャ」フォルダ"});
			this.FolderselPulldown.Location = new System.Drawing.Point(367, 45);
			this.FolderselPulldown.Name = "FolderselPulldown";
			this.FolderselPulldown.Size = new System.Drawing.Size(172, 26);
			this.FolderselPulldown.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(104, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(435, 25);
			this.textBox2.TabIndex = 1;
			// 
			// DestfolderLabel
			// 
			this.DestfolderLabel.AutoSize = true;
			this.DestfolderLabel.Location = new System.Drawing.Point(6, 21);
			this.DestfolderLabel.Name = "DestfolderLabel";
			this.DestfolderLabel.Size = new System.Drawing.Size(92, 18);
			this.DestfolderLabel.TabIndex = 0;
			this.DestfolderLabel.Text = "保存先フォルダ";
			// 
			// MainFLP
			// 
			this.MainFLP.AutoScroll = true;
			this.MainFLP.AutoSize = true;
			this.MainFLP.Controls.Add(this.FromBox);
			this.MainFLP.Controls.Add(this.DestBox);
			this.MainFLP.Controls.Add(this.groupBox2);
			this.MainFLP.Dock = System.Windows.Forms.DockStyle.Top;
			this.MainFLP.Location = new System.Drawing.Point(0, 24);
			this.MainFLP.Name = "MainFLP";
			this.MainFLP.Size = new System.Drawing.Size(563, 413);
			this.MainFLP.TabIndex = 8;
			// 
			// StartButton
			// 
			this.StartButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.StartButton.Font = new System.Drawing.Font("メイリオ", 12F);
			this.StartButton.Location = new System.Drawing.Point(0, 438);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(563, 46);
			this.StartButton.TabIndex = 8;
			this.StartButton.Text = "開始";
			this.StartButton.UseVisualStyleBackColor = true;
			// 
			// PicImporter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(563, 484);
			this.Controls.Add(this.MainFLP);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.StartButton);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PicImporter";
			this.Text = "PicImporter";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.FromBox.ResumeLayout(false);
			this.FromBox.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.FilterPanel.ResumeLayout(false);
			this.DestBox.ResumeLayout(false);
			this.DestBox.PerformLayout();
			this.MainFLP.ResumeLayout(false);
			this.MainFLP.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox FromBox;
		private System.Windows.Forms.TextBox FromFolderTB;
		private System.Windows.Forms.Label FromDriveLabel;
		private System.Windows.Forms.Button SearchDrvButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox FromDriveSel;
		private System.Windows.Forms.Panel FilterPanel;
		private System.Windows.Forms.CheckBox FilterCheckButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label FromFolderLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox DestBox;
		private System.Windows.Forms.Button AutoFolderConfigB;
		private System.Windows.Forms.ComboBox AutoFolderPulldown;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.ComboBox FolderselPulldown;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label DestfolderLabel;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.FlowLayoutPanel MainFLP;
		private System.Windows.Forms.Label FolderSelLabel;
		private System.Windows.Forms.CheckBox AutoFolderCheckbox;
		private System.Windows.Forms.Button SearchDCIMButton;
		private System.Windows.Forms.Button StartButton;
	}
}

