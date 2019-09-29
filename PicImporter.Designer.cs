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
			this.FromSelBtn = new System.Windows.Forms.Button();
			this.SearchDCIMButton = new System.Windows.Forms.Button();
			this.DriveInfoLabel = new System.Windows.Forms.Label();
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
			this.AutoCreateFolder_PreviewLabel = new System.Windows.Forms.Label();
			this.DestSelBtn = new System.Windows.Forms.Button();
			this.FolderSelLabel = new System.Windows.Forms.Label();
			this.AutoCreateFolderCheckbox = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.AutoFolderConfigB = new System.Windows.Forms.Button();
			this.AutoCreateFolderPulldown = new System.Windows.Forms.ComboBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.DestFolderPulldown = new System.Windows.Forms.ComboBox();
			this.DestFolderTB = new System.Windows.Forms.TextBox();
			this.DestFolderLabel = new System.Windows.Forms.Label();
			this.MainFLP = new System.Windows.Forms.FlowLayoutPanel();
			this.StartButton = new System.Windows.Forms.Button();
			this.FromSelDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.DestSelDialog = new System.Windows.Forms.FolderBrowserDialog();
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
			this.FromBox.Controls.Add(this.FromSelBtn);
			this.FromBox.Controls.Add(this.SearchDCIMButton);
			this.FromBox.Controls.Add(this.DriveInfoLabel);
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
			// FromSelBtn
			// 
			this.FromSelBtn.Location = new System.Drawing.Point(452, 74);
			this.FromSelBtn.Name = "FromSelBtn";
			this.FromSelBtn.Size = new System.Drawing.Size(52, 23);
			this.FromSelBtn.TabIndex = 10;
			this.FromSelBtn.Text = "参照";
			this.FromSelBtn.UseVisualStyleBackColor = true;
			this.FromSelBtn.Click += new System.EventHandler(this.FromDriveSelBtn_Click);
			// 
			// SearchDCIMButton
			// 
			this.SearchDCIMButton.Location = new System.Drawing.Point(381, 43);
			this.SearchDCIMButton.Name = "SearchDCIMButton";
			this.SearchDCIMButton.Size = new System.Drawing.Size(123, 23);
			this.SearchDCIMButton.TabIndex = 9;
			this.SearchDCIMButton.Text = "DCIMフォルダ検索";
			this.SearchDCIMButton.UseVisualStyleBackColor = true;
			this.SearchDCIMButton.Click += new System.EventHandler(this.SearchDCIMButton_Click);
			// 
			// DriveInfoLabel
			// 
			this.DriveInfoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.DriveInfoLabel.Location = new System.Drawing.Point(3, 101);
			this.DriveInfoLabel.Name = "DriveInfoLabel";
			this.DriveInfoLabel.Size = new System.Drawing.Size(504, 18);
			this.DriveInfoLabel.TabIndex = 8;
			this.DriveInfoLabel.Text = "- ここに情報が表示されます -";
			this.DriveInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.FromDriveSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
			this.SearchDrvButton.Click += new System.EventHandler(this.SearchDrvButton_Click);
			// 
			// FromFolderTB
			// 
			this.FromFolderTB.Location = new System.Drawing.Point(128, 73);
			this.FromFolderTB.Name = "FromFolderTB";
			this.FromFolderTB.Size = new System.Drawing.Size(321, 25);
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
			this.groupBox2.Location = new System.Drawing.Point(3, 336);
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
			this.DestBox.Controls.Add(this.AutoCreateFolder_PreviewLabel);
			this.DestBox.Controls.Add(this.DestSelBtn);
			this.DestBox.Controls.Add(this.FolderSelLabel);
			this.DestBox.Controls.Add(this.AutoCreateFolderCheckbox);
			this.DestBox.Controls.Add(this.checkBox3);
			this.DestBox.Controls.Add(this.AutoFolderConfigB);
			this.DestBox.Controls.Add(this.AutoCreateFolderPulldown);
			this.DestBox.Controls.Add(this.checkBox2);
			this.DestBox.Controls.Add(this.DestFolderPulldown);
			this.DestBox.Controls.Add(this.DestFolderTB);
			this.DestBox.Controls.Add(this.DestFolderLabel);
			this.DestBox.Location = new System.Drawing.Point(3, 137);
			this.DestBox.Name = "DestBox";
			this.DestBox.Size = new System.Drawing.Size(545, 193);
			this.DestBox.TabIndex = 7;
			this.DestBox.TabStop = false;
			this.DestBox.Text = "保存先の設定";
			// 
			// AutoCreateFolder_PreviewLabel
			// 
			this.AutoCreateFolder_PreviewLabel.AutoSize = true;
			this.AutoCreateFolder_PreviewLabel.Enabled = false;
			this.AutoCreateFolder_PreviewLabel.Location = new System.Drawing.Point(9, 115);
			this.AutoCreateFolder_PreviewLabel.Name = "AutoCreateFolder_PreviewLabel";
			this.AutoCreateFolder_PreviewLabel.Size = new System.Drawing.Size(92, 18);
			this.AutoCreateFolder_PreviewLabel.TabIndex = 11;
			this.AutoCreateFolder_PreviewLabel.Text = "フォルダ名: ---";
			this.AutoCreateFolder_PreviewLabel.Visible = false;
			// 
			// DestSelBtn
			// 
			this.DestSelBtn.Location = new System.Drawing.Point(490, 17);
			this.DestSelBtn.Name = "DestSelBtn";
			this.DestSelBtn.Size = new System.Drawing.Size(49, 23);
			this.DestSelBtn.TabIndex = 10;
			this.DestSelBtn.Text = "参照";
			this.DestSelBtn.UseVisualStyleBackColor = true;
			this.DestSelBtn.Click += new System.EventHandler(this.DestSelBtn_Click);
			// 
			// FolderSelLabel
			// 
			this.FolderSelLabel.AutoSize = true;
			this.FolderSelLabel.Location = new System.Drawing.Point(269, 51);
			this.FolderSelLabel.Name = "FolderSelLabel";
			this.FolderSelLabel.Size = new System.Drawing.Size(92, 18);
			this.FolderSelLabel.TabIndex = 9;
			this.FolderSelLabel.Text = "フォルダ指定→";
			// 
			// AutoCreateFolderCheckbox
			// 
			this.AutoCreateFolderCheckbox.AutoSize = true;
			this.AutoCreateFolderCheckbox.Location = new System.Drawing.Point(9, 81);
			this.AutoCreateFolderCheckbox.Name = "AutoCreateFolderCheckbox";
			this.AutoCreateFolderCheckbox.Size = new System.Drawing.Size(159, 22);
			this.AutoCreateFolderCheckbox.TabIndex = 8;
			this.AutoCreateFolderCheckbox.Text = "フォルダを自動作成する";
			this.AutoCreateFolderCheckbox.UseVisualStyleBackColor = true;
			this.AutoCreateFolderCheckbox.CheckedChanged += new System.EventHandler(this.AutoCreateFolderCheckbox_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(195, 147);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(183, 22);
			this.checkBox3.TabIndex = 7;
			this.checkBox3.Text = "ファイル上書き時に確認する";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// AutoFolderConfigB
			// 
			this.AutoFolderConfigB.Enabled = false;
			this.AutoFolderConfigB.Location = new System.Drawing.Point(9, 50);
			this.AutoFolderConfigB.Name = "AutoFolderConfigB";
			this.AutoFolderConfigB.Size = new System.Drawing.Size(106, 23);
			this.AutoFolderConfigB.TabIndex = 6;
			this.AutoFolderConfigB.Text = "自動作成の設定";
			this.AutoFolderConfigB.UseVisualStyleBackColor = true;
			// 
			// AutoCreateFolderPulldown
			// 
			this.AutoCreateFolderPulldown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AutoCreateFolderPulldown.Enabled = false;
			this.AutoCreateFolderPulldown.FormattingEnabled = true;
			this.AutoCreateFolderPulldown.Items.AddRange(new object[] {
            "(フォルダの自動作成をしない)",
            "最も新しいファイルの日付",
            "最も古いファイルの日付"});
			this.AutoCreateFolderPulldown.Location = new System.Drawing.Point(174, 79);
			this.AutoCreateFolderPulldown.Name = "AutoCreateFolderPulldown";
			this.AutoCreateFolderPulldown.Size = new System.Drawing.Size(365, 26);
			this.AutoCreateFolderPulldown.TabIndex = 5;
			this.AutoCreateFolderPulldown.SelectionChangeCommitted += new System.EventHandler(this.AutoCreateFolderPulldown_SelectionChangeCommitted);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(6, 147);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(183, 22);
			this.checkBox2.TabIndex = 3;
			this.checkBox2.Text = "同名のファイルを上書きする";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// DestFolderPulldown
			// 
			this.DestFolderPulldown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DestFolderPulldown.Enabled = false;
			this.DestFolderPulldown.FormattingEnabled = true;
			this.DestFolderPulldown.Items.AddRange(new object[] {
            "(自動設定)",
            "「ピクチャ」フォルダ"});
			this.DestFolderPulldown.Location = new System.Drawing.Point(367, 47);
			this.DestFolderPulldown.Name = "DestFolderPulldown";
			this.DestFolderPulldown.Size = new System.Drawing.Size(172, 26);
			this.DestFolderPulldown.TabIndex = 2;
			this.DestFolderPulldown.SelectionChangeCommitted += new System.EventHandler(this.DestFolderPulldown_SelectionChangeCommitted);
			// 
			// DestFolderTB
			// 
			this.DestFolderTB.Location = new System.Drawing.Point(104, 16);
			this.DestFolderTB.Name = "DestFolderTB";
			this.DestFolderTB.Size = new System.Drawing.Size(380, 25);
			this.DestFolderTB.TabIndex = 1;
			// 
			// DestFolderLabel
			// 
			this.DestFolderLabel.AutoSize = true;
			this.DestFolderLabel.Location = new System.Drawing.Point(6, 21);
			this.DestFolderLabel.Name = "DestFolderLabel";
			this.DestFolderLabel.Size = new System.Drawing.Size(92, 18);
			this.DestFolderLabel.TabIndex = 0;
			this.DestFolderLabel.Text = "保存先フォルダ";
			// 
			// MainFLP
			// 
			this.MainFLP.AutoScroll = true;
			this.MainFLP.AutoSize = true;
			this.MainFLP.Controls.Add(this.FromBox);
			this.MainFLP.Controls.Add(this.DestBox);
			this.MainFLP.Controls.Add(this.groupBox2);
			this.MainFLP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainFLP.Location = new System.Drawing.Point(0, 24);
			this.MainFLP.Name = "MainFLP";
			this.MainFLP.Size = new System.Drawing.Size(582, 512);
			this.MainFLP.TabIndex = 8;
			// 
			// StartButton
			// 
			this.StartButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.StartButton.Font = new System.Drawing.Font("メイリオ", 12F);
			this.StartButton.Location = new System.Drawing.Point(0, 536);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(582, 46);
			this.StartButton.TabIndex = 8;
			this.StartButton.Text = "開始";
			this.StartButton.UseVisualStyleBackColor = true;
			// 
			// FromSelDialog
			// 
			this.FromSelDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// PicImporter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(582, 582);
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
		private System.Windows.Forms.Label DriveInfoLabel;
		private System.Windows.Forms.GroupBox DestBox;
		private System.Windows.Forms.Button AutoFolderConfigB;
		private System.Windows.Forms.ComboBox AutoCreateFolderPulldown;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.ComboBox DestFolderPulldown;
		private System.Windows.Forms.TextBox DestFolderTB;
		private System.Windows.Forms.Label DestFolderLabel;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.FlowLayoutPanel MainFLP;
		private System.Windows.Forms.Label FolderSelLabel;
		private System.Windows.Forms.CheckBox AutoCreateFolderCheckbox;
		private System.Windows.Forms.Button SearchDCIMButton;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button FromSelBtn;
		private System.Windows.Forms.FolderBrowserDialog FromSelDialog;
		private System.Windows.Forms.Button DestSelBtn;
		private System.Windows.Forms.FolderBrowserDialog DestSelDialog;
		private System.Windows.Forms.Label AutoCreateFolder_PreviewLabel;
	}
}

