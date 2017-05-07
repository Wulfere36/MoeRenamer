﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoeRenamer {
	class MainClass {

		protected static OpenFileDialog ofd = new OpenFileDialog();
		protected static Options opt = new Options();
		protected static TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
		protected static string[] origChars;
		protected static string[] replChars;
		protected static bool trueMulti = false;
		protected static bool normReplace = false;
		protected static bool chgExt = false;
		protected static bool addPrefix = false;
		protected static string fileRoot = "";
		protected static string fileExt = "";
		protected static bool doRenameFile = false; // false means do everything BUT the physical renaming
		protected static float currentNumber = 1;   // in case user wants to number files
		protected static Random rand = new Random(DateTime.Now.Millisecond);
		protected static int nextRandomNumber = 0;
		protected static int totalSourceItems = 0;
		protected static List<int> fileNumbers = new List<int>();
		protected static int curArrayIndex = 0;     // keeps track of where we are in fileNumbers array
		protected static string newFileName = "";
		protected static bool _renameSucceeded = false;

		static public void GetSourceFiles(ListView lstSource, string sourceFolder) {
			try {
				lstSource.Items.Clear();
				if (sourceFolder != "") {
					ofd.InitialDirectory = sourceFolder;
					ofd.Multiselect = true;
					ofd.ShowDialog();
					string[] selectedFiles = ofd.SafeFileNames;
					for (int x=0; x<selectedFiles.Length; x++) {
						ListViewItem lvi = new ListViewItem(selectedFiles[x]);
						lstSource.Items.Add(lvi);
						// lstSource.Items.Add(selectedFiles[x]);
					}
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		static public void ProcessFiles(ListView lstSource, ListView lstDest, Options options, bool testOnly) {
			opt = options;
			trueMulti = false;
			chgExt = false;
			addPrefix = false;
			normReplace = false;
			currentNumber = 1;
			totalSourceItems = lstSource.Items.Count;

			lstDest.Items.Clear();

			// build the array of file numbers in case we need it later
			for(int y=1; y<=totalSourceItems; y++) {
				fileNumbers.Add(y);
			}
			// and randomize it if the user selected that option
			if (options.RandomizeNumbering) {
				RandomizeArray();
			}

			// need to set some stuff up before going into the loops
			// is there a normal replacement to do first
			if (opt.OriginalText!=null) {
				normReplace = true;
			}

			// change the extension?
			if (opt.ChgExtension) {
				chgExt = true;
			}

			// is it a multi-char replacement?
			if (opt.MultipleChars) {
				origChars = opt.OrigChars.Select(x => new string(x, 1)).ToArray();
				if (opt.ReplChars.Length == opt.OrigChars.Length) {
					replChars = opt.ReplChars.Select(x => new string(x, 1)).ToArray();
					trueMulti = true;
				}
			}

			if (opt.PrefixFiles) {
				addPrefix = true;
			}

			if (opt.NumberStart>1) {
				currentNumber = opt.NumberStart;
			}

			foreach(ListViewItem itemRow in lstSource.Items) {
				//lstDest.Items.Add( RenameFile(listItem.Text, opt.OriginalText, opt.ReplacementText) );
				nextRandomNumber = rand.Next(1, totalSourceItems+1);
				newFileName = RenameFile(itemRow.SubItems[0].Text);

				ListViewItem lvi = new ListViewItem(newFileName);
				lstDest.Items.Add(lvi);

				if (!testOnly) {
					// perform the actual rename
					_renameSucceeded = doPhysicalRename(itemRow.SubItems[0].Text, newFileName);
					if (_renameSucceeded) {
						itemRow.SubItems[0].Text = newFileName;
					}
				}
			}

		}

		/// <summary>
		/// Main renaming method. Will handle all the different panels and call the appropriate functions
		/// Returns the final file name
		/// </summary>
		/// <param name="oldFile"></param>
		/// <returns></returns>
		static private string RenameFile(string oldFile) {

			// need to separate the root file name from the LAST extension 
			// (in case there are multiple extensions, only care about the last one)
			int endTagStartPosition = oldFile.LastIndexOf(".");
			if (endTagStartPosition >= 0) {
				fileRoot = oldFile.Substring(0, endTagStartPosition);
				fileExt = oldFile.Substring(endTagStartPosition+1);
				oldFile = fileRoot;
			}

			// if user checked Ignore Extension default, then put the two pieces back together
			// then anything they replace will be for the entire file string
			if (opt.DefIgnoreExtension && fileExt!="") {
				oldFile = fileRoot + "." + fileExt;
			}

			// will need to do the insert/remove/move first because it deals with exact positioning
			// chances are user will be using the current filename to figure out this positioning
			if (opt.InsertRemoveMove>-1) {
				oldFile = InsertRemoveMove(oldFile);
			}

			// do the normal replace next
			if (normReplace) {
				oldFile = oldFile.Replace(opt.OriginalText, opt.ReplacementText);
			}

			// try the multi-char replacement if applicable
			if (opt.MultipleChars) {
				oldFile = ReplaceMultiChars(oldFile);
			}

			// see if the case needs to be changed
			if (opt.ChgCase > -1) {
				oldFile = ChangeStringCase(oldFile);
			}

			// see if the user wants to remove duplicate spaces
			if (opt.DelDupeSpace) {
				oldFile = DeleteDuplicateSpaces(oldFile);
			}

			// if the fileExt was separate from the root, put it back on
			if (!opt.DefIgnoreExtension && fileExt!="") {
				oldFile += "." + fileExt;
			}

			// if user wants to change the extension we can do that now
			if (chgExt) {
				oldFile = ChangeExtension(oldFile);
			}

			// if user wants to add prefix/suffix
			if (addPrefix) {
				oldFile = AddPrefixSuffix(oldFile);
			}
			return oldFile;
		}

		static private string ReplaceMultiChars(string oldFile) {
			// loop through the original char array and replace as required
			for (int x=0; x<origChars.Length; x++) {
				if (trueMulti)
					oldFile = oldFile.Replace(origChars[x], replChars[x]);
				else
					oldFile = oldFile.Replace(origChars[x], opt.ReplChars);
			}
			return oldFile;
		}

		static private string ChangeStringCase(string oldFile) {
			switch (opt.ChgCase) {
				case 0:
					oldFile = textInfo.ToLower(oldFile);
					break;
				case 1:
					oldFile = textInfo.ToUpper(oldFile);
					break;
				case 2:
					oldFile = textInfo.ToTitleCase(oldFile);
					break;
			}
			return oldFile;
		}

		static private string DeleteDuplicateSpaces(string oldFile) {
			// this can be tricky. Have to figure out how to iterate the string multiple times
			// in order to be sure all duplicate spaces are removed
			while (oldFile.Contains("  ")) {
				oldFile = oldFile.Replace("  ", " ");
			}
			return oldFile;
		}

		static private string ChangeExtension(string oldFile) {
			int endTagStartPosition = oldFile.LastIndexOf(".");
			if (endTagStartPosition >= 0)
				fileRoot = oldFile.Substring(0, endTagStartPosition);
			oldFile = fileRoot + "." + opt.NewExtension;
			return oldFile;
		}

		static private string AddPrefixSuffix(string oldFile) {
			string newPrefix = "";

			if (opt.NumberFiles) {
				newPrefix = BuildNumberString(opt.PaddingChar, opt.PaddingSize);
			} else {
				newPrefix = opt.NewTextSep;
			}

			if (opt.PrefixSuffix==0) {
				if (opt.DefIncludeSeparator) {
					oldFile = newPrefix + " " + opt.DefSeparator + " " + oldFile;
				} else {
					oldFile = newPrefix + oldFile;
				}
			} else if (opt.PrefixSuffix==1) {
				if (opt.DefIncludeSeparator) {
					oldFile = oldFile + " " + opt.DefSeparator + " " + newPrefix;
				} else {
					oldFile = oldFile + newPrefix;
				}
			}
			return oldFile;
		}

		static private string BuildNumberString(string padChar, int padSize) {
			string theNumber = fileNumbers[curArrayIndex].ToString();
			curArrayIndex++;
			return theNumber.PadLeft(padSize, char.Parse(padChar));
		}

		static private void RandomizeArray() {
			for ( int n = fileNumbers.Count - 1; n > 0; --n) {
				int k = rand.Next(n + 1);
				int temp = fileNumbers[n];
				fileNumbers[n] = fileNumbers[k];
				fileNumbers[k] = temp;
			}
		}

		static private string InsertRemoveMove(string oldFile) {
			// we're here so let's figure out exactly what we're doing
			switch (opt.InsertRemoveMove) {
				case 0:
					oldFile = InsertText(oldFile);
					break;
				case 1:
					oldFile = RemoveText(oldFile);
					break;
				case 2:
					oldFile = MoveText(oldFile);
					break;
			}
			return oldFile;

		}

		static private string InsertText(string oldFile) {
			if (opt.InsertRemoveMoveText=="") {
				return oldFile;
			}
			if (opt.NewTextPosition != "") {
				switch (opt.NewTextPosition) {
					case "Beginning":
						oldFile = opt.InsertRemoveMoveText + oldFile;
						break;
					case "End":
						oldFile = oldFile + opt.InsertRemoveMoveText;
						break;
					case "Other":
						if (opt.NewExactPosition>0) {
							oldFile = oldFile.Insert(opt.NewExactPosition-1, opt.InsertRemoveMoveText);
						}
						break;
				}
			}
			return oldFile;
		}

		static private string RemoveText(string oldFile) {
			string removeText = opt.InsertRemoveMoveText;
			int originalLength = oldFile.Length;
			int startPos = opt.StartingPosition;
			int stringLength = opt.StringLength;

			if (opt.InsertRemoveMoveText != "") {
				oldFile = oldFile.Replace(opt.InsertRemoveMoveText,"");
			} else {
				if (startPos > 0 && startPos < originalLength) {
					if (stringLength>0) {
						if (originalLength <= startPos+stringLength) {
							oldFile = oldFile.Remove(opt.StartingPosition - 1);
						} else {
							oldFile = oldFile.Remove(opt.StartingPosition - 1, opt.StringLength);
						}
					}
				}
			}
			return oldFile;
		}

		static private string MoveText(string oldFile) {
			// get the text that needs to be moved
			string moveText = opt.InsertRemoveMoveText;
			int oldFileLength = oldFile.Length;
			int newPos = opt.NewExactPosition;

			if (opt.StartingPosition>0 && opt.StringLength<1) {
				return oldFile;
			}
			if (opt.StartingPosition>0) {
				moveText = oldFile.Substring(opt.StartingPosition - 1, opt.StringLength);
			}

			int stringLength = moveText.Length;

			// if there is an exact position then calculate its new position after removing the text
			// but only if the exact position is AFTER the starting position
			switch (opt.NewTextPosition) {
				case "Beginning":
					newPos = 1;
					break;
				case "End":
					newPos = oldFileLength - stringLength + 1;
					break;
				case "Other":
					if (newPos > 0 && opt.StartingPosition < newPos) {
						newPos = newPos - stringLength;
					}
					if (newPos < 1) {
						newPos = 1;
					}
					break;
			}

			// remove the old text first
			oldFile = oldFile.Replace(moveText, "");

			// get the new length and make sure the positioning is not over that value
			int newFileLength = oldFile.Length;
			if (newPos > newFileLength) {
				newPos = newFileLength + 1;
			}

			// insert the text in the new position
			oldFile = oldFile.Insert(newPos-1, moveText);

			return oldFile;
		}

		static private bool doPhysicalRename(string oldFile, string newFile) {
			string sourceFile = Path.Combine(opt.SrcFolder,oldFile);
			if (opt.DstFolder=="") {
				opt.DstFolder = opt.SrcFolder;
			}
			string destFile = Path.Combine(opt.DstFolder, newFile);
			if (!File.Exists(destFile)) {
				File.Move(sourceFile, destFile);
				return true;
			} else {
				return false;
			}
		}
	}
}