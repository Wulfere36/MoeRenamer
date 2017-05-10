/*	Program: MoeRenamer
 *	Purpose: Rename multiple files using easy to understand controls
 *	Author: Morris Soulliere (Wulfere36)
 *	Copyright: 2017 - Morris Soulliere
 *	Icons: grabbed from shell32.dll and xyplorer
*/ 
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

		/// <summary>
		/// If the user clicked on the Number Files checkbox, then either enable the other fields
		/// or disable them, depending on if the checkbox is checked or not
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkNumberFiles_CheckedChanged(object sender, EventArgs e) {
			resetNumberFiles(chkNumberFiles.Checked);
		}

		/// <summary>
		/// If the user changed the selected item in New Position combobox, then either enable
		/// the other fields (if selection is now Other), or disable those fields
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// User can double-click the Source Folder textbox and get the folder select dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbSource_OnDoubleClick(object sender, EventArgs e) {
			fbd.ShowDialog();
			tbSource.Text = fbd.SelectedPath.ToString();
			toolTipRenamer.SetToolTip(tbSource, fbd.SelectedPath.ToString());
			tbDest.Text = tbSource.Text;
			toolTipRenamer.SetToolTip(tbDest, fbd.SelectedPath.ToString());
		}

		/// <summary>
		/// User clicks on the Get Files button, which will call the GetSourceFiles method
		/// in the MainClass class
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSourceFolder_Click(object sender, EventArgs e) {
			grdSource.Rows.Clear();
			lstDest.Items.Clear();
			MainClass.GetSourceFiles(grdSource, tbSource.Text, imageList1);
		}

		/// <summary>
		/// User has the option to change the destination folder (which automatically inherits the source
		/// folder's address) by click the Folder button beside the Destination text box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDestFolder_Click(object sender, EventArgs e) {
			fbd.ShowDialog();
			tbDest.Text = fbd.SelectedPath.ToString();
			toolTipRenamer.SetToolTip(tbDest, fbd.SelectedPath.ToString());
		}

		/// <summary>
		/// If the source folder textbox has changed content, then reset the tool tips and destination
		/// folder. May have to look at someway of preserving the destination folder entry if the
		/// user had originally set it themselves. Maybe a bool value.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbSource_TextChanged(object sender, EventArgs e) {
			toolTipRenamer.SetToolTip(tbSource, tbSource.Text);
			tbDest.Text = tbSource.Text;
			toolTipRenamer.SetToolTip(tbDest, tbDest.Text);
		}

		/// <summary>
		/// User wants to test the renaming procedure only, just to make sure that everything is going
		/// to come out the way they wanted. Will do everything the actual rename does but will not
		/// physically change the filename
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnTestRename_Click(object sender, EventArgs e) {
			_testOnly = true;
			renameFiles();
		}

		/// <summary>
		/// Will do the same thing as the test button, but at the end will physically change/move
		/// the file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRenameFiles_Click(object sender, EventArgs e) {
			_testOnly = false;
			renameFiles();
		}

		/// <summary>
		/// Main function. Starts the ball rolling. Sets up some variables, instantiates an Options object,
		/// loads all the data from the form into the object, then passes the four values to the ProcessFiles\
		/// method: source listview, destination listview, options object, _testOnly variable
		/// </summary>
		private void renameFiles() {

			// make sure there is something to process before going any further
			if (grdSource.Rows.Count > 0) {

				// default some values before collecting them from the form
				// need this in case the user removed some values. They are required for smooth\
				// functionality
				float startNum = 1;
				int padSize = 1;
				int insertStartPos = 1;
				int stringLength = 0;
				int exactPos = 0;

				// create the Options object and load it
				Options options = new Options();

				// START of Main Options panel
				// Get the information and store into the proper options fields
				// Using _formIsValidated as failsafe. There has to be at least one item below that makes it true
				// before it will do any renaming.
				if (txtOldText.Text!="") {
					// we can only load a replacement text field if we have original text to look for
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
					// we can only allow changing individual characters if we have original chars to search for
					_formIsValidated = true;
					options.MultipleChars = (txtOrigChars.Text.Length > 0 ? true : false);
					options.OrigChars = txtOrigChars.Text;
					options.ReplChars = txtReplChars.Text;
				}
				// END of Main Options panel

				// START of Prefix/Suffix panel
				if (radPrefix.Checked || radSuffix.Checked) {
					// only load the options fields if either radPrefix or radSuffix is selected
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
					// only load the options fields if radInsert, radRemove, or radMove have been checked
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
				// load all the values from the deault area of the form, plus ChgCase (should have put that in the
				// defaults section I guess)
				options.ChgCase = (radToLower.Checked ? 0 : radToUpper.Checked ? 1 : radToCamel.Checked ? 2 : -1);
				options.DefIncludeSeparator = chkIncludeSep.Checked;
				options.DefIgnoreExtension = chkIgnoreExtension.Checked;
				options.DefIgnoreCase = chkIgnoreCase.Checked;
				options.DefSeparator = txtDefaultSeparator.Text;
				options.DefDelimiter = txtDefaultDelimiter.Text;
				// END of Default Options panel

				// one final check before starting: the form has to be valid
				if (_formIsValidated) {
					options.SrcFolder = tbSource.Text;

					// if somehow the destination folder textbox is empty, then default it to the source folder
					if (tbDest.Text != "") {
						options.DstFolder = tbDest.Text;
					} else {
						options.DstFolder = tbSource.Text;
					}

					// Calls the ProcessFiles method and loops through every entry in the Source Listview
					MainClass.ProcessFiles(grdSource, lstDest, options, _testOnly, imageList1);

				} else {
					// form not validated. Right now it just means that there is nothing entered on the form
					// eventually it will reflect any data entry errors the user may have made
					MessageBox.Show("Nothing to do. Please select an option on the form", "Nothing To Do", MessageBoxButtons.OK);
				}

				// remove the options object. Want to make sure there are no artifacts in case we want to use it again right away
				options = null;

			} else {
				// user did select any files, so tell them that
				MessageBox.Show("There are no files listed in the source list view. Select some files first.", "No Files to Rename", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// When the user begins entering text into the new extension textbox, it will automatically check the box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtNewExtension_TextChanged(object sender, EventArgs e) {
			if (this.Text!="") {
				chkChangeExtension.Checked = true;
			}
		}

		/// <summary>
		/// Is the user changed their mind, then unchecking the new extension checkbox will remove the value from
		/// the checkbox. I put in the .Checked=false because it did not seem to catch on its own. Will research it
		/// later to figure out if there is a more elegant solution
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkChangeExtension_CheckedChanged(object sender, EventArgs e) {
			if (!chkChangeExtension.Checked) {
				txtNewExtension.Text = "";
				chkChangeExtension.Checked = false;
			}
				
		}

		/// <summary>
		/// User clicks the Clear button beside the change case options. This will ensure that all radio buttons have
		/// been deselected
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClearChangeCase_Click(object sender, EventArgs e) {
			radToCamel.Checked = false;
			radToLower.Checked = false;
			radToUpper.Checked = false;
		}

		/// <summary>
		/// User clicks the Clear button beside the Insert,Remove,Move options. This removes all radio button
		/// selections
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClearInsert_Click(object sender, EventArgs e) {
			radInsert.Checked = false;
			radRemove.Checked = false;
			radMove.Checked = false;

		}

		/// <summary>
		/// User clicks on one of the radInsert button, enable and disable the proper fields
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// User clicked on the radRemove button. Enable or disable the proper fields (slightly different from
		/// the insert function)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// User clicked on the radMove button. Enable or Disable the proper fields
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// User clicked on the radPrefix button, so enable or disable the proper fields
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void radPrefix_CheckedChanged(object sender, EventArgs e) {
			if (radPrefix.Checked) {
				lblNewTextSep.Enabled = true;
				txtNewTextSep.Enabled = true;
				chkNumberFiles.Enabled = true;
			} else {
				TurnOffPrefixSuffixPanel();
			}
		}

		/// <summary>
		/// User clicked on the radSuffix button, so enable or disable the proper fields
		/// It does the exact same thing as the radPrefix button, just not sure how to combine the
		/// two into one function. Suppose I can make another method that performs the actual functions,
		/// passing it the radio object selected
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void radSuffix_CheckedChanged(object sender, EventArgs e) {
			if (radSuffix.Checked) {
				lblNewTextSep.Enabled = true;
				txtNewTextSep.Enabled = true;
				chkNumberFiles.Enabled = true;
			} else {
				TurnOffPrefixSuffixPanel();
			}
		}

		/// <summary>
		/// User clicks on the clear button beside the Prefix, Suffix options. Make sure all radio buttons
		/// are unselected.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClearPrefixSuffix_Click(object sender, EventArgs e) {
			radPrefix.Checked = false;
			radSuffix.Checked = false;
			chkNumberFiles.Checked = false;

		}

		/// <summary>
		/// Initial attempt at combining the two Prefix,Suffix radiobutton events
		/// Basically disables all the fields
		/// </summary>
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

		/// <summary>
		/// Main form clearing method. Resets the form to the beginning values
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClear_Click(object sender, EventArgs e) {
			resetForm();
		}

		/// <summary>
		/// Just added this. Forgot to rename the button. Created a button beside the Source Folder textbox that
		/// will open the Browse Folders dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e) {
			fbd.ShowDialog();
			tbSource.Text = fbd.SelectedPath.ToString();
			toolTipRenamer.SetToolTip(tbSource, fbd.SelectedPath.ToString());
			tbDest.Text = tbSource.Text;
			toolTipRenamer.SetToolTip(tbDest, fbd.SelectedPath.ToString());
		}

		private void grdSource_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			richTextBox1.Text = grdSource.CurrentCell.Value.ToString();
			richTextBox1.Text = grdSource.CurrentRow.Cells[0].Value.ToString();

		}
	}
}
