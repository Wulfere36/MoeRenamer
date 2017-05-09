/*	File: Validators.cs
 *	Purpose: First attempt at including validation controls on the form. Don't like this solution though.
 *	Author: Morris Soulliere (Wulfere36)
 *	Copyright: 2017 - Morris Soulliere
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoeRenamer {

	partial class MoeRenamer {

		private void txtLength_Validating(object sender, CancelEventArgs e) {
			string errorMsg;
			if (int.Parse(txtStartPos.Text) > 0 && int.Parse(txtLength.Text) < 1) {
				// Cancel the event and select the text to be corrected by the user.
				errorMsg = "You need to enter a length if you have a start position";
				e.Cancel = true;
				txtLength.Select(0, txtLength.Text.Length);

				// Set the ErrorProvider error with the text to display. 
				this.errorProvider1.SetError(txtLength, errorMsg);
			}
		}

		private void txtLength_Validated(object sender, EventArgs e) {
			errorProvider1.SetError(txtLength, "");
		}

		/// <summary>
		/// Will reset the form portion only. The left side will remain intact
		/// </summary>
		private void resetForm() {
			_formIsValidated = false;
			resetMainPart();
			resetPrefixSuffix();
			resetNumberFiles(false);
			resetInsertRemoveMove();
			resetDefaults();

			resetNumberFiles(false);
			resetNewPosition();
		}

		private void resetMainPart() {
			txtOldText.Text = "";
			txtNewText.Text = "";
			chkChangeExtension.Checked = false;
			txtNewExtension.Text = "";
			chkDelDupSpace.Checked = false;
			txtOrigChars.Text = "";
			txtReplChars.Text = "";
		}

		private void resetPrefixSuffix() {
			radPrefix.Checked = false;
			radSuffix.Checked = false;
			txtNewTextSep.Text = "";
			chkNumberFiles.Checked = false;
			chkRandomize.Checked = false;
			txtStartNumber.Text = "1";
			txtPadSize.Text = "4";
			txtPadChar.Text = "0";
			resetNumberFiles(false);
		}

		private void resetInsertRemoveMove() {
			radInsert.Checked = false;
			radRemove.Checked = false;
			radMove.Checked = false;
			txtInsRemText.Text = "";
			txtStartPos.Text = "0";
			txtLength.Text = "0";
			txtExactPos.Text = "0";
			cmbNewPosition.ResetText();
			lblExactPosition.Enabled = false;
			txtExactPos.Enabled = false;
		}

		private void resetDefaults() {
			radToLower.Checked = false;
			radToUpper.Checked = false;
			radToCamel.Checked = false;
			chkIncludeSep.Checked = true;
			chkIgnoreExtension.Checked = false;
			chkIgnoreCase.Checked = false;
			txtDefaultSeparator.Text = "-";
			txtDefaultDelimiter.Text = "^";

		}

		/// <summary>
		/// only gets called when the user clicks on Number Files checkbox or when resetting the entire form
		/// </summary>
		/// <param name="chkOn"></param>
		private void resetNumberFiles(bool chkOn) {
			if (chkOn) {
				chkRandomize.Enabled = true;
				lblStartNumber.Enabled = true;
				txtStartNumber.Enabled = true;
				lblPadSize.Enabled = true;
				txtPadSize.Enabled = true;
				lblPadChar.Enabled = true;
				txtPadChar.Enabled = true;
			} else {
				chkRandomize.Enabled = false;
				lblStartNumber.Enabled = false;
				txtStartNumber.Enabled = false;
				lblPadSize.Enabled = false;
				txtPadSize.Enabled = false;
				lblPadChar.Enabled = false;
				txtPadChar.Enabled = false;
			}
		}

		private void resetNewPosition() {
			cmbNewPosition.ResetText();
		}
	}
}
