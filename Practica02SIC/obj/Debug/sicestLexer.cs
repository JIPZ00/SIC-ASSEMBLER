﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\jesus\Desktop\Práctica 06 - Símbolos y Expresiones\Practica02SIC\sicest.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Practica02SIC {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class sicestLexer : Lexer {
	public const int
		START=1, INDICE=2, COMA=3, END=4, TIPOBYTE=5, TIPOWORD=6, RESB=7, RESW=8, 
		FINL=9, CODOP=10, RSUB=11, WS=12, CBYTE=13, XBYTE=14, NUMHEX=15, NUMHEXMIN=16, 
		NUM=17, ID=18;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"START", "INDICE", "COMA", "END", "TIPOBYTE", "TIPOWORD", "RESB", "RESW", 
		"FINL", "CODOP", "RSUB", "WS", "CBYTE", "XBYTE", "NUMHEX", "NUMHEXMIN", 
		"NUM", "ID"
	};


	public sicestLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'START'", "'X'", "','", "'END'", "'BYTE'", "'WORD'", "'RESB'", 
		"'RESW'", null, null, "'RSUB'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "START", "INDICE", "COMA", "END", "TIPOBYTE", "TIPOWORD", "RESB", 
		"RESW", "FINL", "CODOP", "RSUB", "WS", "CBYTE", "XBYTE", "NUMHEX", "NUMHEXMIN", 
		"NUM", "ID"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "sicest.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x14\xD0\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x3\x2\x3\x2\x3\x2\x3"+
		"\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b"+
		"\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x6\nK\n\n\r\n\xE\nL\x3\v\x3\v\x3\v"+
		"\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x5\v\x99\n\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x6\r\xA1\n\r\r\r\xE\r"+
		"\xA2\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x6\xE\xAA\n\xE\r\xE\xE\xE\xAB\x3\xE\x3"+
		"\xE\x3\xF\x3\xF\x3\xF\x6\xF\xB3\n\xF\r\xF\xE\xF\xB4\x3\xF\x3\xF\x3\x10"+
		"\x6\x10\xBA\n\x10\r\x10\xE\x10\xBB\x3\x10\x3\x10\x3\x11\x6\x11\xC1\n\x11"+
		"\r\x11\xE\x11\xC2\x3\x11\x3\x11\x3\x12\x6\x12\xC8\n\x12\r\x12\xE\x12\xC9"+
		"\x3\x13\x6\x13\xCD\n\x13\r\x13\xE\x13\xCE\x2\x2\x2\x14\x3\x2\x3\x5\x2"+
		"\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17"+
		"\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14"+
		"\x3\x2\n\x4\x2\v\v\"\"\x3\x2\x45\x45\x5\x2\x32;\x43\\\x63|\x3\x2ZZ\x4"+
		"\x2\x32;\x43H\x3\x2JJ\x3\x2jj\x3\x2\x32;\xEF\x2\x3\x3\x2\x2\x2\x2\x5\x3"+
		"\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2"+
		"\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15"+
		"\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2"+
		"\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2"+
		"\x2%\x3\x2\x2\x2\x3\'\x3\x2\x2\x2\x5-\x3\x2\x2\x2\a/\x3\x2\x2\x2\t\x31"+
		"\x3\x2\x2\x2\v\x35\x3\x2\x2\x2\r:\x3\x2\x2\x2\xF?\x3\x2\x2\x2\x11\x44"+
		"\x3\x2\x2\x2\x13J\x3\x2\x2\x2\x15\x98\x3\x2\x2\x2\x17\x9A\x3\x2\x2\x2"+
		"\x19\xA0\x3\x2\x2\x2\x1B\xA6\x3\x2\x2\x2\x1D\xAF\x3\x2\x2\x2\x1F\xB9\x3"+
		"\x2\x2\x2!\xC0\x3\x2\x2\x2#\xC7\x3\x2\x2\x2%\xCC\x3\x2\x2\x2\'(\aU\x2"+
		"\x2()\aV\x2\x2)*\a\x43\x2\x2*+\aT\x2\x2+,\aV\x2\x2,\x4\x3\x2\x2\x2-.\a"+
		"Z\x2\x2.\x6\x3\x2\x2\x2/\x30\a.\x2\x2\x30\b\x3\x2\x2\x2\x31\x32\aG\x2"+
		"\x2\x32\x33\aP\x2\x2\x33\x34\a\x46\x2\x2\x34\n\x3\x2\x2\x2\x35\x36\a\x44"+
		"\x2\x2\x36\x37\a[\x2\x2\x37\x38\aV\x2\x2\x38\x39\aG\x2\x2\x39\f\x3\x2"+
		"\x2\x2:;\aY\x2\x2;<\aQ\x2\x2<=\aT\x2\x2=>\a\x46\x2\x2>\xE\x3\x2\x2\x2"+
		"?@\aT\x2\x2@\x41\aG\x2\x2\x41\x42\aU\x2\x2\x42\x43\a\x44\x2\x2\x43\x10"+
		"\x3\x2\x2\x2\x44\x45\aT\x2\x2\x45\x46\aG\x2\x2\x46G\aU\x2\x2GH\aY\x2\x2"+
		"H\x12\x3\x2\x2\x2IK\a\f\x2\x2JI\x3\x2\x2\x2KL\x3\x2\x2\x2LJ\x3\x2\x2\x2"+
		"LM\x3\x2\x2\x2M\x14\x3\x2\x2\x2NO\a\x43\x2\x2OP\a\x46\x2\x2P\x99\a\x46"+
		"\x2\x2QR\a\x43\x2\x2RS\aP\x2\x2S\x99\a\x46\x2\x2TU\a\x45\x2\x2UV\aQ\x2"+
		"\x2VW\aO\x2\x2W\x99\aR\x2\x2XY\a\x46\x2\x2YZ\aK\x2\x2Z\x99\aX\x2\x2[\x99"+
		"\aL\x2\x2\\]\aL\x2\x2]^\aG\x2\x2^\x99\aS\x2\x2_`\aL\x2\x2`\x61\aI\x2\x2"+
		"\x61\x99\aV\x2\x2\x62\x63\aL\x2\x2\x63\x64\aN\x2\x2\x64\x99\aV\x2\x2\x65"+
		"\x66\aL\x2\x2\x66g\aU\x2\x2gh\aW\x2\x2h\x99\a\x44\x2\x2ij\aN\x2\x2jk\a"+
		"\x46\x2\x2k\x99\a\x43\x2\x2lm\aN\x2\x2mn\a\x46\x2\x2no\a\x45\x2\x2o\x99"+
		"\aJ\x2\x2pq\aN\x2\x2qr\a\x46\x2\x2r\x99\aN\x2\x2st\aN\x2\x2tu\a\x46\x2"+
		"\x2u\x99\aZ\x2\x2vw\aO\x2\x2wx\aW\x2\x2x\x99\aN\x2\x2yz\aQ\x2\x2z\x99"+
		"\aT\x2\x2{|\aT\x2\x2|\x99\a\x46\x2\x2}~\aU\x2\x2~\x7F\aV\x2\x2\x7F\x99"+
		"\a\x43\x2\x2\x80\x81\aU\x2\x2\x81\x82\aV\x2\x2\x82\x83\a\x45\x2\x2\x83"+
		"\x99\aJ\x2\x2\x84\x85\aU\x2\x2\x85\x86\aV\x2\x2\x86\x99\aN\x2\x2\x87\x88"+
		"\aU\x2\x2\x88\x89\aV\x2\x2\x89\x8A\aU\x2\x2\x8A\x99\aY\x2\x2\x8B\x8C\a"+
		"U\x2\x2\x8C\x8D\aV\x2\x2\x8D\x99\aZ\x2\x2\x8E\x8F\aU\x2\x2\x8F\x90\aW"+
		"\x2\x2\x90\x99\a\x44\x2\x2\x91\x92\aV\x2\x2\x92\x99\a\x46\x2\x2\x93\x94"+
		"\aV\x2\x2\x94\x95\aK\x2\x2\x95\x99\aZ\x2\x2\x96\x97\aY\x2\x2\x97\x99\a"+
		"\x46\x2\x2\x98N\x3\x2\x2\x2\x98Q\x3\x2\x2\x2\x98T\x3\x2\x2\x2\x98X\x3"+
		"\x2\x2\x2\x98[\x3\x2\x2\x2\x98\\\x3\x2\x2\x2\x98_\x3\x2\x2\x2\x98\x62"+
		"\x3\x2\x2\x2\x98\x65\x3\x2\x2\x2\x98i\x3\x2\x2\x2\x98l\x3\x2\x2\x2\x98"+
		"p\x3\x2\x2\x2\x98s\x3\x2\x2\x2\x98v\x3\x2\x2\x2\x98y\x3\x2\x2\x2\x98{"+
		"\x3\x2\x2\x2\x98}\x3\x2\x2\x2\x98\x80\x3\x2\x2\x2\x98\x84\x3\x2\x2\x2"+
		"\x98\x87\x3\x2\x2\x2\x98\x8B\x3\x2\x2\x2\x98\x8E\x3\x2\x2\x2\x98\x91\x3"+
		"\x2\x2\x2\x98\x93\x3\x2\x2\x2\x98\x96\x3\x2\x2\x2\x99\x16\x3\x2\x2\x2"+
		"\x9A\x9B\aT\x2\x2\x9B\x9C\aU\x2\x2\x9C\x9D\aW\x2\x2\x9D\x9E\a\x44\x2\x2"+
		"\x9E\x18\x3\x2\x2\x2\x9F\xA1\t\x2\x2\x2\xA0\x9F\x3\x2\x2\x2\xA1\xA2\x3"+
		"\x2\x2\x2\xA2\xA0\x3\x2\x2\x2\xA2\xA3\x3\x2\x2\x2\xA3\xA4\x3\x2\x2\x2"+
		"\xA4\xA5\b\r\x2\x2\xA5\x1A\x3\x2\x2\x2\xA6\xA7\t\x3\x2\x2\xA7\xA9\a)\x2"+
		"\x2\xA8\xAA\t\x4\x2\x2\xA9\xA8\x3\x2\x2\x2\xAA\xAB\x3\x2\x2\x2\xAB\xA9"+
		"\x3\x2\x2\x2\xAB\xAC\x3\x2\x2\x2\xAC\xAD\x3\x2\x2\x2\xAD\xAE\a)\x2\x2"+
		"\xAE\x1C\x3\x2\x2\x2\xAF\xB0\t\x5\x2\x2\xB0\xB2\a)\x2\x2\xB1\xB3\t\x4"+
		"\x2\x2\xB2\xB1\x3\x2\x2\x2\xB3\xB4\x3\x2\x2\x2\xB4\xB2\x3\x2\x2\x2\xB4"+
		"\xB5\x3\x2\x2\x2\xB5\xB6\x3\x2\x2\x2\xB6\xB7\a)\x2\x2\xB7\x1E\x3\x2\x2"+
		"\x2\xB8\xBA\t\x6\x2\x2\xB9\xB8\x3\x2\x2\x2\xBA\xBB\x3\x2\x2\x2\xBB\xB9"+
		"\x3\x2\x2\x2\xBB\xBC\x3\x2\x2\x2\xBC\xBD\x3\x2\x2\x2\xBD\xBE\t\a\x2\x2"+
		"\xBE \x3\x2\x2\x2\xBF\xC1\t\x6\x2\x2\xC0\xBF\x3\x2\x2\x2\xC1\xC2\x3\x2"+
		"\x2\x2\xC2\xC0\x3\x2\x2\x2\xC2\xC3\x3\x2\x2\x2\xC3\xC4\x3\x2\x2\x2\xC4"+
		"\xC5\t\b\x2\x2\xC5\"\x3\x2\x2\x2\xC6\xC8\t\t\x2\x2\xC7\xC6\x3\x2\x2\x2"+
		"\xC8\xC9\x3\x2\x2\x2\xC9\xC7\x3\x2\x2\x2\xC9\xCA\x3\x2\x2\x2\xCA$\x3\x2"+
		"\x2\x2\xCB\xCD\t\x4\x2\x2\xCC\xCB\x3\x2\x2\x2\xCD\xCE\x3\x2\x2\x2\xCE"+
		"\xCC\x3\x2\x2\x2\xCE\xCF\x3\x2\x2\x2\xCF&\x3\x2\x2\x2\f\x2L\x98\xA2\xAB"+
		"\xB4\xBB\xC2\xC9\xCE\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Practica02SIC