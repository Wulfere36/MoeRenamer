using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoeRenamer {
	class Options {
		string _originalText;		// original text or text to remove
		string _replacementText;	// replace text or text to insert
		string _separator;			// separator to be used for prefix/suffix operations (if different then default)
		string _paddingChar;		// character to use if padding required - usually 0 for number type prefix/suffix
		string _defSeparator;		// will use this value if _separator not supplied - defaults to -
		string _defDelimiter;       // used to build a delimited string - defaults to ^
		string _origChars;          // list of original characters to be replaced
		string _replChars;          // list of replacement characters (if any)
		string _newExtension;       // new extension to replace the old one
		string _newTextSep;         // if adding a prefix/suffix, this is the text/sep to use
		string _insertRemoveMoveText; // text that's to be inserted/removed/moved
		string _newTextPosition;    // beginning, end or other of insert/remove/move
		string _srcFolder;
		string _dstFolder;

		int _chgCase;				// 0 - lowercase, 1 - uppercase, 2 - camelcase
		int _prefixSuffix;			// 0 - prefix, 1 - suffix, -1 - nothing
		int _paddingSize;			// how many characters to pad the prefix/suffix to
		int _insertRemoveMove;		// 0 - insert, 1 - remove, 2 - move
		int _startingPosition;		// where to begin the insert or move, if textbox empty, then beginning of substring to remove/move
		int _stringLength;			// if textbox empty, then length of substring to remove/move
		int _newExactPosition;      // character position where to insert/move to

		float _numberStart;         // where to start the numbering for prefix/suffix - default will be 1.0

		bool _chgExtension;			// is this an extension change only
		bool _delDupeSpace;         // delete duplicate spaces while renaming
		bool _multipleChars;		// there are multiple characters to be changed
		bool _prefixFiles;          // files are to be prefixed/suffixed
		bool _numberFiles;			// the prefix/suffix will be a autoincrement number
		bool _randomizeNumbering;	// randomize the numbering scheme
		bool _defIncludeSeparator;	// include a sparator by default when prefixing/suffixing
		bool _defIgnoreExtension;	// ignore the extension when renaming files
		bool _defIgnoreCase;        // ignore case when renaming files

		public string OriginalText { get {return _originalText;} set {_originalText = value;} }

		public string ReplacementText { get {return _replacementText;} set {_replacementText = value;} }

		public string Separator { get {return _separator;} set {_separator = value;} }

		public string PaddingChar { get {return _paddingChar;} set {_paddingChar = value;} }

		public string NewTextPosition { get {return _newTextPosition;} set {_newTextPosition = value;} }

		public string DefSeparator { get {return _defSeparator;} set {_defSeparator = value;} }

		public string DefDelimiter { get {return _defDelimiter;} set {_defDelimiter = value;} }

		public string OrigChars { get { return _origChars; } set { _origChars = value; } }

		public string ReplChars { get { return _replChars; } set { _replChars = value; } }

		public string NewExtension { get { return _newExtension; } set { _newExtension = value; } }

		public string NewTextSep { get { return _newTextSep; } set { _newTextSep = value; } }

		public string InsertRemoveMoveText { get { return _insertRemoveMoveText; } set { _insertRemoveMoveText = value; } }
		public string SrcFolder { get { return _srcFolder; } set { _srcFolder = value; } }
		public string DstFolder { get { return _dstFolder; } set { _dstFolder = value; } }

		public int ChgCase { get {return _chgCase;} set {_chgCase = value;} }

		public int PrefixSuffix { get {return _prefixSuffix;} set {_prefixSuffix = value;} }

		public int PaddingSize { get {return _paddingSize;} set {_paddingSize = value;} }

		public float NumberStart { get {return _numberStart;} set {_numberStart = value;} }

		public int InsertRemoveMove { get {return _insertRemoveMove;} set {_insertRemoveMove = value;} }

		public int StartingPosition { get {return _startingPosition;} set {_startingPosition = value;} }

		public int StringLength { get {return _stringLength;} set {_stringLength = value;} }

		public int NewExactPosition { get {return _newExactPosition;} set {_newExactPosition = value;} }

		public bool ChgExtension { get {return _chgExtension;} set {_chgExtension = value;} }

		public bool DelDupeSpace { get {return _delDupeSpace;} set {_delDupeSpace = value;} }

		public bool MultipleChars { get {return _multipleChars;} set {_multipleChars = value;} }

		public bool PrefixFiles { get {return _prefixFiles; } set { _prefixFiles = value;} }

		public bool NumberFiles { get { return _numberFiles; } set { _numberFiles = value; } }

		public bool RandomizeNumbering { get {return _randomizeNumbering;} set {_randomizeNumbering = value;} }

		public bool DefIncludeSeparator { get {return _defIncludeSeparator;} set {_defIncludeSeparator = value;} }

		public bool DefIgnoreExtension { get {return _defIgnoreExtension;} set {_defIgnoreExtension = value;} }

		public bool DefIgnoreCase { get {return _defIgnoreCase;} set {_defIgnoreCase = value;} }
	}
}
