using System;
using System.Collections.Generic;
using System.IO;
//using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicImporter {
	public partial class PicImporter : Form {
		//どうやらここらへんに色々変数を定義するスタイルが多いらしい。プチコンと違うんだなぁ(
		private List<DriveInfo> DriveList = new List<DriveInfo>();
		private int DataSizeDiv = 1024;
		private string[] DataSizeStrs = {
			"Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB"
		}; // たぶん、ここまで実装すれば足りると思う....。
		private Dictionary<string, string> AutoFolderData = new Dictionary<string, string>(); //表示名,パス
		private Dictionary<AutoCreateMode, string> AutoCreateNames = new Dictionary<AutoCreateMode, string> {
			{ AutoCreateMode.NewestFile, "一番新しいファイルの日付" },
			{ AutoCreateMode.OldestFile, "一番古いファイルの日付" }
		}; //enum、表示名

		enum AutoCreateMode {
			NewestFile = 0,
			OldestFile = 1
		}

		public PicImporter() {
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
			InitDestFolderPullDown();
			InitAutoCreateFolderPullDown();
		}

		private void LoadDriveList() {
			var Drvs = System.IO.DriveInfo.GetDrives(); //ドライブ一覧
			var ErrDrvs = new List<string>(); //取得できなかったドライブの名前(またはドライブレター)
			FromDriveSel.Items.Clear(); //選べるドライブリスト、初期化

			foreach (var Drv in Drvs) {
				try {
					string St = String.Format("{0} - {1} ({2})", Drv.Name, Drv.DriveType, ConvertBytesToString(Drv.TotalSize, 2));
					FromDriveSel.Items.Add(St);
					DriveList.Add(Drv);
				} catch (Exception DrvRead_e) {
					// e はログに追加する？
					ErrDrvs.Add(Drv.Name);
					Console.WriteLine(Drv.Name + " Failed to load(" + DrvRead_e.GetType().ToString() + ")");
				}
			}
			if (ErrDrvs.Count > 0) {
				string LabelStr = "";
				for (int DCnt = 0; DCnt < ErrDrvs.Count; DCnt++) {
					LabelStr += ErrDrvs[DCnt];
					if (DCnt < ErrDrvs.Count - 1) {
						LabelStr += ",";
					}
				}
				LabelStr = "ドライブ " + LabelStr + " の情報を取得できませんでした。";
				DriveInfoLabel.Text = LabelStr;
			}
		}

		private void InitDestFolderPullDown() {
			DestFolderPulldown.Items.Clear();
			//「ピクチャ」フォルダ。
			string Path = null;

			AutoFolderData.Add("(なし)", null);

			try {
				Path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				AutoFolderData.Add("「ピクチャ」フォルダ", Path);
			} catch {
				// むりっぽい
			}

			foreach (var DisplayName in AutoFolderData.Keys) {
				DestFolderPulldown.Items.Add(DisplayName.ToString());
			}

			if (DestFolderPulldown.Items.Count > 0) {
				DestFolderPulldown.Enabled = true;
			}
		}

		private void InitAutoCreateFolderPullDown() {
			AutoCreateFolderPulldown.Items.Clear();
			foreach (var Name in AutoCreateNames) {
				AutoCreateFolderPulldown.Items.Add(Name.Key);
			}
		}

		private string ConvertBytesToString(long Bytes, int DeciminalDigit) {
			double Bt = (double)Bytes;
			string Result;
			if (DeciminalDigit < 0) { //小数点以下-1桁とかいうへんなのは禁止
				throw new ArgumentOutOfRangeException("DeciminalDigit", DeciminalDigit, "小数点以下の桁数 DeciminalDigit は、0以上でなければなりません。");
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
			int DecDistrict = Int32.Parse("1" + new string('0', DeciminalDigit));
			Result = ( Math.Floor(Bt * DecDistrict) / DecDistrict ).ToString() + DataSizeStrs[Uct];
			return Result;
		}

		private void SearchDrvButton_Click(object sender, EventArgs e) {
			DriveInfoLabel.Text = "再読み込み中...";
			FromFolderTB.Text = "";
			SearchDrvButton.Enabled = false;
			LoadDriveList();
			SearchDrvButton.Enabled = true;
			DriveInfoLabel.Text = "";
		}

		private void SearchDCIMButton_Click(object sender, EventArgs e) {
			if (FromDriveSel.SelectedIndex == -1) {
				MessageBox.Show("取り込み元のドライブを選んでください。", "DCIMフォルダ検索 - エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			//TODO: here
			// ほとんどのパターンでは /DCIM/があるはずなんだけど....。

			string SearchPath = (string)DriveList[FromDriveSel.SelectedIndex].Name;

			// 検索するフォルダ名。
			string[] PrioSearchStr = new string[] {
				"DCIM", "Picture", "Pictures"
			};
			try {
				var SubFolders = System.IO.Directory.GetDirectories(SearchPath, "*", SearchOption.TopDirectoryOnly);
				//		var SubFolders = System.IO.Directory.EnumerateDirectories(SearchPath, "*", SearchOption.TopDirectoryOnly);
				string ReadFolder = null;
				foreach (string SearchStr in PrioSearchStr) {
					if (IsArrayContains(SubFolders, SearchPath + SearchStr) > -1) {
						ReadFolder = SearchPath + SearchStr;
						break;
					}
				}
				if (ReadFolder != null) {
					FromFolderTB.Text = ReadFolder;
					DriveInfoLabel.Text = "フォルダ " + ReadFolder + " を検出しました。";
				} else {
					DriveInfoLabel.Text = "画像フォルダが見つかりません。手動で入力してください。";
				}
			} catch (Exception DrvSch_e) {
				DriveInfoLabel.Text = "エラー : " + DrvSch_e.Message;
				Console.WriteLine("Error while searching pictures folder: " + DrvSch_e.GetType().ToString());
			}
		}


		/// <summary>
		/// Target の配列において、一番最初に見つかった Key のインデックスを返します。
		/// 見つからなかった場合、 -1 が返ります。
		/// </summary>
		/// <param name="Target">検索元の配列。</param>
		/// <param name="Key">検索するオブジェクト。</param>
		/// <returns>Target における、Key のインデックス。見つからない場合、-1</returns>
		private int IsArrayContains(Array Target, object Key) {
			for (int i = 0; i < Target.Length; i++) {
				if (Target.GetValue(i).Equals(Key)) {
					return i;
				}
			}
			return -1;
		}

		private void FromDriveSelBtn_Click(object sender, EventArgs e) {
			if (FromSelDialog.ShowDialog() == DialogResult.OK) {
				FromFolderTB.Text = FromSelDialog.SelectedPath;
			}
		}

		private void DestFolderPulldown_SelectionChangeCommitted(object sender, EventArgs e) {
			DestFolderTB.Text = AutoFolderData[DestFolderPulldown.Text];
		}

		private async void AutoCreateFolderPulldown_SelectionChangeCommitted(object sender, EventArgs e) {
			var Mode = (AutoCreateMode)Enum.ToObject(
					typeof(AutoCreateMode),
					AutoCreateFolderPulldown.SelectedIndex
				);
			AutoCreateFolder_PreviewLabel.Text = "自動設定しています...";
			string ErrorMsg = null;
			Task<string> SearchTask = Task.Factory.StartNew<string>(() => {
				try {
					int Time = System.Environment.TickCount;
					string Name = AutoCreateFolder_GetName(FromFolderTB.Text, Mode);
					Console.WriteLine("Search done in " + ( System.Environment.TickCount - Time ).ToString() + " ms");
					return Name;
				} catch (Exception exp) {
					Console.WriteLine("Search failed.");
					Console.WriteLine(String.Format("{0} : {1}\n{2}",exp.ToString(),exp.Message,exp.StackTrace));
					if (exp.Message != "") {
						ErrorMsg = exp.Message;
					} else {
						ErrorMsg = exp.ToString();
					}
					return null;
				}
			});
			string Path = await SearchTask;
			if (Path != null) {
				AutoCreateFolder_PreviewLabel.Visible = true;
				AutoCreateFolder_PreviewLabel.Enabled = true;
				AutoCreateFolder_PreviewLabel.Text = Path;
			} else {
				AutoCreateFolder_PreviewLabel.Visible = true;
				AutoCreateFolder_PreviewLabel.Enabled = true;
				if (ErrorMsg != null) {
					AutoCreateFolder_PreviewLabel.Text = "自動設定できません";
				} else {
					AutoCreateFolder_PreviewLabel.Text = "自動設定できません( " + ErrorMsg + " )";
				}
			}
			//t.Wait();
		}

		string AutoCreateFolder_GetName(string Path, AutoCreateMode Mode) {
			if (!System.IO.Directory.Exists(Path)) {
				throw new FileNotFoundException("フォルダ " + Path + " が見つからないか、アクセスできません。");
			}
			string MatchFileName = LookForFile(Path, Mode, 5);
			string DesignedName = null; //フォルダの名前
			if (MatchFileName != null) {
				switch (Mode) {
					case AutoCreateMode.NewestFile:
					case AutoCreateMode.OldestFile: {
						DesignedName = File.GetLastWriteTime(MatchFileName).ToString("yyyy-MM-dd");
						break;
					}
				}
			} 
			return DesignedName;

			string LookForFile(string FromPath, AutoCreateMode SchMode, int Depth, object SchData = null) {

				var Files = System.IO.Directory.GetFiles(FromPath);
				string Result = null;

				if (SchData == null) { //一番最初の検索
					switch (SchMode) {
						case AutoCreateMode.NewestFile: {
							SchData = (object)DateTime.MinValue;
							break;
						}
						case AutoCreateMode.OldestFile: {
							SchData = (object)DateTime.MaxValue;
							break;
						}
					}
				}

				//処理状況
				//Console.WriteLine(String.Format("{0} -- {1}", FromPath, ( (DateTime)SchData ).ToString()));

				foreach (var FileName in Files) {
					switch (SchMode) {
						case AutoCreateMode.NewestFile: {
							var FileT = File.GetLastWriteTime(FileName);
							var CompT = (DateTime)SchData;
							if (FileT > CompT) {
								SchData = (object)FileT;
								Result = FileName;
							}
							break;
						}

						case AutoCreateMode.OldestFile: {
							var FileT = File.GetLastWriteTime(FileName);
							var CompT = (DateTime)SchData;
							if (FileT < CompT) {
								SchData = (object)FileT;
								Result = FileName;
							}
							break;
						}
					}
				}

				if (Depth > 1) {
					var Folders = System.IO.Directory.GetDirectories(FromPath);
					foreach (var FolderName in Folders) {
						string MatchPath = LookForFile(FolderName, SchMode, Depth - 1,SchData);
						if (MatchPath != null) {
							switch (SchMode) {
								case AutoCreateMode.NewestFile: {
									var FileT = File.GetLastWriteTime(MatchPath);
									var CompT = (DateTime)SchData;
									if (FileT > CompT) {
										SchData = (object)FileT;
										Result = MatchPath;
									}
									break;
								}

								case AutoCreateMode.OldestFile: {
									var FileT = File.GetLastWriteTime(MatchPath);
									var CompT = (DateTime)SchData;
									if (FileT < CompT) {
										SchData = (object)FileT;
										Result = MatchPath;
									}
									break;
								}
							}
						}
					}
				}
				return Result;
			}
		}

		//Console.WriteLine(Path);
		private void AutoCreateFolderCheckbox_CheckedChanged(object sender, EventArgs e) {
			AutoCreateFolderPulldown.Enabled = AutoCreateFolderCheckbox.Checked;
		}

		private void DestSelBtn_Click(object sender, EventArgs e) {
			DestSelDialog.ShowDialog();
		}
	}
}
