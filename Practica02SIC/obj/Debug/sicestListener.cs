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
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="sicestParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IsicestListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>InicioPrograma</c>
	/// labeled alternative in <see cref="sicestParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInicioPrograma([NotNull] sicestParser.InicioProgramaContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>InicioPrograma</c>
	/// labeled alternative in <see cref="sicestParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInicioPrograma([NotNull] sicestParser.InicioProgramaContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Etiqini</c>
	/// labeled alternative in <see cref="sicestParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEtiqini([NotNull] sicestParser.EtiqiniContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Etiqini</c>
	/// labeled alternative in <see cref="sicestParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEtiqini([NotNull] sicestParser.EtiqiniContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Prepos</c>
	/// labeled alternative in <see cref="sicestParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrepos([NotNull] sicestParser.PreposContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Prepos</c>
	/// labeled alternative in <see cref="sicestParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrepos([NotNull] sicestParser.PreposContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>EndID</c>
	/// labeled alternative in <see cref="sicestParser.entrada"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndID([NotNull] sicestParser.EndIDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>EndID</c>
	/// labeled alternative in <see cref="sicestParser.entrada"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndID([NotNull] sicestParser.EndIDContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>NoEndID</c>
	/// labeled alternative in <see cref="sicestParser.entrada"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoEndID([NotNull] sicestParser.NoEndIDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NoEndID</c>
	/// labeled alternative in <see cref="sicestParser.entrada"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoEndID([NotNull] sicestParser.NoEndIDContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ErrorCodOp</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterErrorCodOp([NotNull] sicestParser.ErrorCodOpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ErrorCodOp</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitErrorCodOp([NotNull] sicestParser.ErrorCodOpContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ErrorRsub</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterErrorRsub([NotNull] sicestParser.ErrorRsubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ErrorRsub</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitErrorRsub([NotNull] sicestParser.ErrorRsubContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Instrnormal</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstrnormal([NotNull] sicestParser.InstrnormalContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Instrnormal</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstrnormal([NotNull] sicestParser.InstrnormalContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Instrrsub</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstrrsub([NotNull] sicestParser.InstrrsubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Instrrsub</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstrrsub([NotNull] sicestParser.InstrrsubContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ErrorDobleByte</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterErrorDobleByte([NotNull] sicestParser.ErrorDobleByteContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ErrorDobleByte</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitErrorDobleByte([NotNull] sicestParser.ErrorDobleByteContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ErrorDobleDirectiva</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterErrorDobleDirectiva([NotNull] sicestParser.ErrorDobleDirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ErrorDobleDirectiva</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitErrorDobleDirectiva([NotNull] sicestParser.ErrorDobleDirectivaContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>EsBYTE</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEsBYTE([NotNull] sicestParser.EsBYTEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>EsBYTE</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEsBYTE([NotNull] sicestParser.EsBYTEContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>EsDirectiva</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEsDirectiva([NotNull] sicestParser.EsDirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>EsDirectiva</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEsDirectiva([NotNull] sicestParser.EsDirectivaContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DIRWORD</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDIRWORD([NotNull] sicestParser.DIRWORDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DIRWORD</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDIRWORD([NotNull] sicestParser.DIRWORDContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DIRRESB</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDIRRESB([NotNull] sicestParser.DIRRESBContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DIRRESB</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDIRRESB([NotNull] sicestParser.DIRRESBContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DIRRESW</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDIRRESW([NotNull] sicestParser.DIRRESWContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DIRRESW</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDIRRESW([NotNull] sicestParser.DIRRESWContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExisteID</c>
	/// labeled alternative in <see cref="sicestParser.etiqueta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExisteID([NotNull] sicestParser.ExisteIDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExisteID</c>
	/// labeled alternative in <see cref="sicestParser.etiqueta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExisteID([NotNull] sicestParser.ExisteIDContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>NoExisteID</c>
	/// labeled alternative in <see cref="sicestParser.etiqueta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoExisteID([NotNull] sicestParser.NoExisteIDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NoExisteID</c>
	/// labeled alternative in <see cref="sicestParser.etiqueta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoExisteID([NotNull] sicestParser.NoExisteIDContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExisteOpInstruccion</c>
	/// labeled alternative in <see cref="sicestParser.opinstruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExisteOpInstruccion([NotNull] sicestParser.ExisteOpInstruccionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExisteOpInstruccion</c>
	/// labeled alternative in <see cref="sicestParser.opinstruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExisteOpInstruccion([NotNull] sicestParser.ExisteOpInstruccionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>NoexisteOpInstruccion</c>
	/// labeled alternative in <see cref="sicestParser.opinstruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoexisteOpInstruccion([NotNull] sicestParser.NoexisteOpInstruccionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NoexisteOpInstruccion</c>
	/// labeled alternative in <see cref="sicestParser.opinstruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoexisteOpInstruccion([NotNull] sicestParser.NoexisteOpInstruccionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>EsIndexado</c>
	/// labeled alternative in <see cref="sicestParser.indexado"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEsIndexado([NotNull] sicestParser.EsIndexadoContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>EsIndexado</c>
	/// labeled alternative in <see cref="sicestParser.indexado"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEsIndexado([NotNull] sicestParser.EsIndexadoContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>NoEsIndexado</c>
	/// labeled alternative in <see cref="sicestParser.indexado"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoEsIndexado([NotNull] sicestParser.NoEsIndexadoContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NoEsIndexado</c>
	/// labeled alternative in <see cref="sicestParser.indexado"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoEsIndexado([NotNull] sicestParser.NoEsIndexadoContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DirNum</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirNum([NotNull] sicestParser.DirNumContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DirNum</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirNum([NotNull] sicestParser.DirNumContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DirNumHex</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirNumHex([NotNull] sicestParser.DirNumHexContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DirNumHex</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirNumHex([NotNull] sicestParser.DirNumHexContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DirConstCad</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirConstCad([NotNull] sicestParser.DirConstCadContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DirConstCad</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirConstCad([NotNull] sicestParser.DirConstCadContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DirNumHexMin</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirNumHexMin([NotNull] sicestParser.DirNumHexMinContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DirNumHexMin</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirNumHexMin([NotNull] sicestParser.DirNumHexMinContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Numnormal</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumnormal([NotNull] sicestParser.NumnormalContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Numnormal</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumnormal([NotNull] sicestParser.NumnormalContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Numhex</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumhex([NotNull] sicestParser.NumhexContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Numhex</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumhex([NotNull] sicestParser.NumhexContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Numhexmin</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumhexmin([NotNull] sicestParser.NumhexminContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Numhexmin</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumhexmin([NotNull] sicestParser.NumhexminContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>BYTECBYTE</c>
	/// labeled alternative in <see cref="sicestParser.byte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBYTECBYTE([NotNull] sicestParser.BYTECBYTEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BYTECBYTE</c>
	/// labeled alternative in <see cref="sicestParser.byte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBYTECBYTE([NotNull] sicestParser.BYTECBYTEContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>BYTEXBYTE</c>
	/// labeled alternative in <see cref="sicestParser.byte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBYTEXBYTE([NotNull] sicestParser.BYTEXBYTEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BYTEXBYTE</c>
	/// labeled alternative in <see cref="sicestParser.byte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBYTEXBYTE([NotNull] sicestParser.BYTEXBYTEContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrograma([NotNull] sicestParser.ProgramaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.programa"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrograma([NotNull] sicestParser.ProgramaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInicio([NotNull] sicestParser.InicioContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.inicio"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInicio([NotNull] sicestParser.InicioContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFin([NotNull] sicestParser.FinContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.fin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFin([NotNull] sicestParser.FinContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.entrada"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntrada([NotNull] sicestParser.EntradaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.entrada"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntrada([NotNull] sicestParser.EntradaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.proposiciones"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProposiciones([NotNull] sicestParser.ProposicionesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.proposiciones"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProposiciones([NotNull] sicestParser.ProposicionesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProposicion([NotNull] sicestParser.ProposicionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.proposicion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProposicion([NotNull] sicestParser.ProposicionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstruccion([NotNull] sicestParser.InstruccionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.instruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstruccion([NotNull] sicestParser.InstruccionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirectiva([NotNull] sicestParser.DirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.directiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirectiva([NotNull] sicestParser.DirectivaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipodirectiva([NotNull] sicestParser.TipodirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.tipodirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipodirectiva([NotNull] sicestParser.TipodirectivaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.etiqueta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEtiqueta([NotNull] sicestParser.EtiquetaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.etiqueta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEtiqueta([NotNull] sicestParser.EtiquetaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.opinstruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpinstruccion([NotNull] sicestParser.OpinstruccionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.opinstruccion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpinstruccion([NotNull] sicestParser.OpinstruccionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.indexado"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexado([NotNull] sicestParser.IndexadoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.indexado"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexado([NotNull] sicestParser.IndexadoContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpdirectiva([NotNull] sicestParser.OpdirectivaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.opdirectiva"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpdirectiva([NotNull] sicestParser.OpdirectivaContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNum([NotNull] sicestParser.NumContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNum([NotNull] sicestParser.NumContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.byte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterByte([NotNull] sicestParser.ByteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.byte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitByte([NotNull] sicestParser.ByteContext context);
}
} // namespace Practica02SIC