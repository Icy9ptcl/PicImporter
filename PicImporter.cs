using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PicImporter {
	public partial class PicImporter : Form
	{
		//どうやらここらへんに色々変数を定義するスタイルが多いらしい。プチコンと違うんだなぁ(
		private DriveInfo[] DriveList;
		private int DataSizeDiv = 1024;
		private string[] DataSizeStrs = {
			"Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB"
		}; // たぶん、ここまで実装すれば足りると思う....。
		public PicImporter()
		{
			InitializeComponent();
		}

		private void FilterCheckButton_CheckedChanged(object sender, EventArgs e) {
			if (FilterCheckButton.Checked == true) {
				FilterPanel.Visible = true;
			} else {
				FilterPanel.Visible = false;
			}
		}

		private void FromDriveSel_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void Form1_Shown(object sender, EventArgs e) {
			LoadDriveList();
		}

		private void LoadDriveList() {
			var Drvs = System.IO.DriveInfo.GetDrives(); //ドライブ一覧
			var ErrDrvs = new List<string>(); //取得できなかったドライブの名前(またはドライブレター)

			FromDriveSel.Items.Clear(); //選べるドライブリスト、初期化

			DriveList = Drvs;
			foreach (var Drv in Drvs) {
				try {
					string St = String.Format("{0} - {1} ({2})", Drv.Name, Drv.DriveType, ConvertBytesToString(Drv.TotalSize, 2));
					FromDriveSel.Items.Add(St);
				} catch (Exception e) {
					// e はログに追加する？
					ErrDrvs.Add(Drv.Name);
				}
			}
			if (ErrDrvs.Count > 0) {
				string LabelStr = "";
				for (int DCnt = 0; DCnt < ErrDrvs.Count; DCnt++) {
					LabelStr += ErrDrvs[DCnt];
					if (DCnt < ErrDrvs.Count -1) {
						LabelStr += ",";
					}
				}
				LabelStr = "ドライブ " + LabelStr + " の情報を取得できませんでした。";
				DriveInfoLabel.Text = LabelStr;
			}
		}

		private string ConvertBytesToString(long Bytes,int DeciminalDigit) {
			double Bt = (double)Bytes;
			string Result;
			if (DeciminalDigit < 0) { //小数点以下-1桁とかいうへんなのは禁止
				throw new ArgumentOutOfRangeException("DeciminalDigit",DeciminalDigit,"小数点以下の桁数 DeciminalDigit は、0以上でなければなりません。");
			}
			int Uct;
			for (Uct = 0; Uct < DataSizeStrs.Length; Uct++) {
				if (Bt >= DataSizeDiv) {
					Bt = Bt / 1024;
				} else {
					break;
				}
			}
			// あらわざ
			int DecDistrict = Int32.Parse("1" + new string('0',DeciminalDigit));
			Result = ( Math.Floor(Bt * DecDistrict) / DecDistrict ).ToString() + DataSizeStrs[Uct];
			return Result;
		}

		private void SearchDrvButton_Click(object sender, EventArgs e) {
			DriveInfoLabel.Text = "再読み込み中...";
			SearchDrvButton.Enabled = false;
			LoadDriveList();
			SearchDrvButton.Enabled = true;
			DriveInfoLabel.Text = "";
		}

		private void SearchDCIMButton_Click(object sender, EventArgs e) {
			if (FromDriveSel.SelectedIndex == -1) {
				MessageBox.Show("取り込み元のドライブを選んでください。", "DCIMフォルダ検索 - エラー",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}

	}
}
