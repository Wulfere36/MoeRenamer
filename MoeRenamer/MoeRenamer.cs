using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoeRenamer {
	public partial class MoeRenamer : Form {

		FolderBrowserDialog fbd = new FolderBrowserDialog();
		ToolTip toolTip = new ToolTip();
		bool _testOnly = true;
		protected string _sourceFolder = "";
		protected string _destFolder = "";
		bool _formIsValidated = false;

		public MoeRenamer() {
			InitializeComponent();
		}

		private void chkNumberFiles_CheckedChanged(object sender, EventArgs e) {
			resetNumberFiles(chkNumberFiles.Checked);
		}

		private void cmbNewPosition_SelectedIndexChanged(object sender, EventArgs e) {
			string value = cmbNewPosition.SelectedItem.ToString();
			if (value=="Other") {
				lblExactPosition.Enabled = true;
				txtExactPos.Enabled = true;
			} else {
				lblExactPosition.Enabled = false;
				txtExactPos.Enabled = false;
			}
		}

		private void tbSource_OnDoubleClick(object sender, EventArgs e) {
			fbd.ShowDialog();
			tbSource.Text = fbd.SelectedPath.ToString();
			toolTipRenamer.SetToolTip(tbSource, fbd.SelectedPath.ToString());
			tbDest.Text = tbSource.Text;
			toolTipRenamer.SetToolTip(tbDest, fbd.SelectedPath.ToString());
		}

		private void btnSourceFolder_Click(object sender, EventArgs e) {
			lstSource.Items.Clear();
			MainClass.GetSourceFiles(lstSource, tbSource.Text);
		}

		private void btnDestFolder_Click(object sender, EventArgs e) {
			fbd.ShowDialog();
			tbDest.Text = fbd.SelectedPath.ToString();
			toolTipRenamer.SetToolTip(tbDest, fbd.SelectedPath.ToString());
		}

		private void tbSource_TextChanged(object sender, EventArgs e) {
			toolTipRenamer.SetToolTip(tbSource, tbSource.Text);
			tbDest.Text = tbSource.Text;
			toolTipRenamer.SetToolTip(tbDest, tbDest.Text);
		}

		private void btnTestRename_Click(object sender, EventArgs e) {
			_testOnly = true;
			renameFiles();
		}

		private void btnRenameFiles_Click(object sender, EventArgs e) {
			_testOnly = false;
			renameFiles();
		}

		private void renameFiles() {
			//_sourceFolder = tbSource.Text;
			//_destFolder = tbDest.Text;

			if (lstSource.Items.Count > 0) {

				// default the starting number for numbering files
				float startNum = 1;
				int padSize = 1;
				int insertStartPos = 1;
				int stringLength = 0;
				int exactPos = 0;

				// create an Options object, load it, and send it the MainClass method
				Options options = new Options();

				// START of Main Options panel
				if (txtOldText.Text!="") {
					_formIsValidated = true;
					options.OriginalText = txtOldText.Text;
					options.ReplacementText = txtNewText.Text;
				}
				if (chkChangeExtension.Checked) {
					_formIsValidated = true;
					options.ChgExtension = chkChangeExtension.Checked;
					options.NewExtension = txtNewExtension.Text;
				}
				if (chkDelDupSpace.Checked) {
					_formIsValidated = true;
					options.DelDupeSpace = chkDelDupSpace.Checked;
				}
				if (txtOrigChars.Text != "") {
					_formIsValidated = true;
					options.MultipleChars = (txtOrigChars.Text.Length > 0 ? true : false);
					options.OrigChars = txtOrigChars.Text;
					options.ReplChars = txtReplChars.Text;
				}
				// END of Main Options panel

				// START of Prefix/Suffix panel
				if (radPrefix.Checked || radSuffix.Checked) {
					_formIsValidated = true;
					options.PrefixFiles = (radPrefix.Checked ? true : radSuffix.Checked ? true : false);
					options.PrefixSuffix = (radPrefix.Checked ? 0 : radSuffix.Checked ? 1 : -1);
					options.NumberFiles = (chkNumberFiles.Checked ? true : false);
					options.NumberStart = startNum;
					options.PaddingSize = padSize;
					options.PaddingChar = txtPadChar.Text;
					if (options.PaddingChar.Length > 1) {
						options.PaddingChar = options.PaddingChar.Substring(0, 1);
					}
					options.NewTextSep = txtNewTextSep.Text;
					options.RandomizeNumbering = (chkRandomize.Checked ? true : false);
					// if we can successfully parse these textboxes to a number, then use it, else we use the defaults
					if (float.TryParse(txtStartNumber.Text, out startNum)) {
						options.NumberStart = startNum;
					}
					if (int.TryParse(txtPadSize.Text, out padSize)) {
						options.PaddingSize = padSize;
					}
				}
				// END of Prefix/Suffix panel

				// START of Insert/Remove/Move panel
				if (radInsert.Checked || radRemove.Checked || radMove.Checked) {
					_formIsValidated = true;
					options.InsertRemoveMove = (radInsert.Checked ? 0 : radRemove.Checked ? 1 : radMove.Checked ? 2 : -1);
					options.InsertRemoveMoveText = txtInsRemText.Text;
					if (int.TryParse(txtStartPos.Text, out insertStartPos)) {
						options.StartingPosition = insertStartPos;
					}
					if (int.TryParse(txtLength.Text, out stringLength)) {
						options.StringLength = stringLength;
					}
					options.NewTextPosition = cmbNewPosition.Text;
					if (int.TryParse(txtExactPos.Text, out exactPos)) {
						options.NewExactPosition = exactPos;
					}
				}
				// END of Insert/Remove/Move panel

				// START of Default Options panel
				options.ChgCase = (radToLower.Checked ? 0 : radToUpper.Checked ? 1 : radToCamel.Checked ? 2 : -1);
				options.DefIncludeSeparator = chkIncludeSep.Checked;
				options.DefIgnoreExtension = chkIgnoreExtension.Checked;
				options.DefIgnoreCase = chkIgnoreCase.Checked;
				options.DefSeparator = txtDefaultSeparator.Text;
				options.DefDelimiter = txtDefaultDelimiter.Text;
				// END of Default Options panel

				// one final check before starting: source folder needs to be there and the form has to be valid
				if (_formIsValidated) {
					options.SrcFolder = tbSource.Text;
					if (tbDest.Text != "") {
						options.DstFolder = tbDest.Text;
					} else {
						options.DstFolder = tbSource.Text;
					}
					MainClass.ProcessFiles(lstSource, lstDest, options, _testOnly);
				} else {
					MessageBox.Show("Nothing to do. Please select an option on the form", "Nothing To Do", MessageBoxButtons.OK);
				}
				options = null;

			} else {
				MessageBox.Show("There are no files listed in the source list view. Select some files first.", "No Files to Rename", MessageBoxButtons.OK);
			}
		}

		private void txtNewExtension_TextChanged(object sender, EventArgs e) {
			if (this.Text!="") {
				chkChangeExtension.Checked = true;
			}
		}

		private void chkChangeExtension_CheckedChanged(object sender, EventArgs e) {
			if (!chkChangeExtension.Checked) {
				txtNewExtension.Text = "";
				chkChangeExtension.Checked = false;
			}
				
		}

		private void lstSource_SelectedIndexChanged(object sender, EventArgs e) {
			if (lstSource.SelectedItems.Count > 0) {
				var item = lstSource.SelectedItems[0];
				richTextBox1.Text = item.Text;
			}

		}

		private void btnClearChangeCase_Click(object sender, EventArgs e) {
			radToCamel.Checked = false;
			radToLower.Checked = false;
			radToUpper.Checked = false;
		}


		private void btnClearInsert_Click(object sender, EventArgs e) {
			radInsert.Checked = false;
			radRemove.Checked = false;
			radMove.Checked = false;

		}

		private void radInsert_CheckedChanged(object sender, EventArgs e) {
			if (radInsert.Checked) {
				lblInsRemText.Enabled = true;
				txtInsRemText.Enabled = true;
				lblTextPosition.Enabled = true;
				cmbNewPosition.Enabled = true;
			} else {
				lblInsRemText.Enabled = false;
				txtInsRemText.Enabled = false;
				lblTextPosition.Enabled = false;
				cmbNewPosition.Enabled = false;
			}
		}

		private void radRemove_CheckedChanged(object sender, EventArgs e) {
			if (radRemove.Checked) {
				lblInsRemText.Enabled = true;
				txtInsRemText.Enabled = true;
				lblStartPos.Enabled = true;
				txtStartPos.Enabled = true;
				lblLength.Enabled = true;
				txtLength.Enabled = true;
				//lblTextPosition.Enabled = true;
				//cmbNewPosition.Enabled = true;
			} else {
				lblInsRemText.Enabled = false;
				txtInsRemText.Enabled = false;
				lblStartPos.Enabled = false;
				txtStartPos.Enabled = false;
				lblLength.Enabled = false;
				txtLength.Enabled = false;
				//lblTextPosition.Enabled = false;
				//cmbNewPosition.Enabled = false;
			}
		}

		private void radMove_CheckedChanged(object sender, EventArgs e) {
			if (radMove.Checked) {
				lblInsRemText.Enabled = true;
				txtInsRemText.Enabled = true;
				lblStartPos.Enabled = true;
				txtStartPos.Enabled = true;
				lblLength.Enabled = true;
				txtLength.Enabled = true;
				lblTextPosition.Enabled = true;
				cmbNewPosition.Enabled = true;
			} else {
				lblInsRemText.Enabled = false;
				txtInsRemText.Enabled = false;
				lblStartPos.Enabled = false;
				txtStartPos.Enabled = false;
				lblLength.Enabled = false;
				txtLength.Enabled = false;
				lblTextPosition.Enabled = false;
				cmbNewPosition.Enabled = false;
				lblExactPosition.Enabled = false;
				txtExactPos.Enabled = false;
			}
		}

		private void radPrefix_CheckedChanged(object sender, EventArgs e) {
			if (radPrefix.Checked) {
				lblNewTextSep.Enabled = true;
				txtNewTextSep.Enabled = true;
				chkNumberFiles.Enabled = true;
			} else {
				TurnOffPrefixSuffixPanel();
			}
		}

		private void radSuffix_CheckedChanged(object sender, EventArgs e) {
			if (radSuffix.Checked) {
				lblNewTextSep.Enabled = true;
				txtNewTextSep.Enabled = true;
				chkNumberFiles.Enabled = true;
			} else {
				TurnOffPrefixSuffixPanel();
			}
		}

		private void btnClearPrefixSuffix_Click(object sender, EventArgs e) {
			radPrefix.Checked = false;
			radSuffix.Checked = false;
			chkNumberFiles.Checked = false;

		}

		private void TurnOffPrefixSuffixPanel() {
			lblNewTextSep.Enabled = false;
			txtNewTextSep.Enabled = false;
			chkNumberFiles.Enabled = false;
			chkRandomize.Enabled = false;
			lblStartNumber.Enabled = false;
			txtStartNumber.Enabled = false;
			lblPadSize.Enabled = false;
			txtPadSize.Enabled = false;
			lblPadChar.Enabled = false;
			txtPadChar.Enabled = false;
		}

		private void btnClear_Click(object sender, EventArgs e) {
			resetForm();
		}

		private void button1_Click(object sender, EventArgs e) {
			fbd.ShowDialog();
			tbSource.Text = fbd.SelectedPath.ToString();
			toolTipRenamer.SetToolTip(tbSource, fbd.SelectedPath.ToString());
			tbDest.Text = tbSource.Text;
			toolTipRenamer.SetToolTip(tbDest, fbd.SelectedPath.ToString());
		}
	}
}
