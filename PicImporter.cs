using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PicImporter {
	public partial class PicImporter : Form
	{
		//どうやらここらへんに色々変数を定義するスタイルが多いらしい。プチコンと違うんだなぁ(
		private List<DriveInfo> DriveList;


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

		private void LoadDriveList()
		{
			//https://dobon.net/vb/dotnet/file/driveinfo.html
			var Drvs = System.IO.DriveInfo.GetDrives();
			DrvList = null;
			foreach (var Drv in Drvs)
			{
				string St = String.Format("{0} - {1}",Drv.Name,Drv.DriveType.ToString());
				FromDriveSel.Items.Add(St);
			}
		}
	}
}
