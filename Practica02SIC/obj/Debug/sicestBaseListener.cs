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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IsicestListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class sicestBaseListener : IsicestListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>InicioPrograma</c>
	/// labeled alternative in <see cref="sicestParser.programa"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInicioPrograma([NotNull] sicestParser.InicioProgramaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>InicioPrograma</c>
	/// labeled alternative in <see cref="sicestParser.programa"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInicioPrograma([NotNull] sicestParser.InicioProgramaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Etiqini</c>
	/// labeled alternative in <see cref="sicestParser.inicio"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEtiqini([NotNull] sicestParser.EtiqiniContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Etiqini</c>
	/// labeled alternative in <see cref="sicestParser.inicio"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEtiqini([NotNull] sicestParser.EtiqiniContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Prepos</c>
	/// labeled alternative in <see cref="sicestParser.inicio"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrepos([NotNull] sicestParser.PreposContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Prepos</c>
	/// labeled alternative in <see cref="sicestParser.inicio"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrepos([NotNull] sicestParser.PreposContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>EndID</c>
	/// labeled alternative in <see cref="sicestParser.entrada"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEndID([NotNull] sicestParser.EndIDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>EndID</c>
	/// labeled alternative in <see cref="sicestParser.entrada"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEndID([NotNull] sicestParser.EndIDContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>NoEndID</c>
	/// labeled alternative in <see cref="sicestParser.entrada"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoEndID([NotNull] sicestParser.NoEndIDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NoEndID</c>
	/// labeled alternative in <see cref="sicestParser.entrada"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoEndID([NotNull] sicestParser.NoEndIDContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ErrorCodOp</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterErrorCodOp([NotNull] sicestParser.ErrorCodOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ErrorCodOp</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitErrorCodOp([NotNull] sicestParser.ErrorCodOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ErrorRsub</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterErrorRsub([NotNull] sicestParser.ErrorRsubContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ErrorRsub</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitErrorRsub([NotNull] sicestParser.ErrorRsubContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Instrnormal</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstrnormal([NotNull] sicestParser.InstrnormalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Instrnormal</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstrnormal([NotNull] sicestParser.InstrnormalContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Instrrsub</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstrrsub([NotNull] sicestParser.InstrrsubContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Instrrsub</c>
	/// labeled alternative in <see cref="sicestParser.instruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstrrsub([NotNull] sicestParser.InstrrsubContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ErrorDobleByte</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterErrorDobleByte([NotNull] sicestParser.ErrorDobleByteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ErrorDobleByte</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitErrorDobleByte([NotNull] sicestParser.ErrorDobleByteContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ErrorDobleDirectiva</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterErrorDobleDirectiva([NotNull] sicestParser.ErrorDobleDirectivaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ErrorDobleDirectiva</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitErrorDobleDirectiva([NotNull] sicestParser.ErrorDobleDirectivaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>EsBYTE</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEsBYTE([NotNull] sicestParser.EsBYTEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>EsBYTE</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEsBYTE([NotNull] sicestParser.EsBYTEContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>EsDirectiva</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEsDirectiva([NotNull] sicestParser.EsDirectivaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>EsDirectiva</c>
	/// labeled alternative in <see cref="sicestParser.directiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEsDirectiva([NotNull] sicestParser.EsDirectivaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DIRWORD</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDIRWORD([NotNull] sicestParser.DIRWORDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DIRWORD</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDIRWORD([NotNull] sicestParser.DIRWORDContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DIRRESB</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDIRRESB([NotNull] sicestParser.DIRRESBContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DIRRESB</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDIRRESB([NotNull] sicestParser.DIRRESBContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DIRRESW</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDIRRESW([NotNull] sicestParser.DIRRESWContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DIRRESW</c>
	/// labeled alternative in <see cref="sicestParser.tipodirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDIRRESW([NotNull] sicestParser.DIRRESWContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExisteID</c>
	/// labeled alternative in <see cref="sicestParser.etiqueta"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExisteID([NotNull] sicestParser.ExisteIDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExisteID</c>
	/// labeled alternative in <see cref="sicestParser.etiqueta"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExisteID([NotNull] sicestParser.ExisteIDContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>NoExisteID</c>
	/// labeled alternative in <see cref="sicestParser.etiqueta"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoExisteID([NotNull] sicestParser.NoExisteIDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NoExisteID</c>
	/// labeled alternative in <see cref="sicestParser.etiqueta"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoExisteID([NotNull] sicestParser.NoExisteIDContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExisteOpInstruccion</c>
	/// labeled alternative in <see cref="sicestParser.opinstruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExisteOpInstruccion([NotNull] sicestParser.ExisteOpInstruccionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExisteOpInstruccion</c>
	/// labeled alternative in <see cref="sicestParser.opinstruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExisteOpInstruccion([NotNull] sicestParser.ExisteOpInstruccionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>NoexisteOpInstruccion</c>
	/// labeled alternative in <see cref="sicestParser.opinstruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoexisteOpInstruccion([NotNull] sicestParser.NoexisteOpInstruccionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NoexisteOpInstruccion</c>
	/// labeled alternative in <see cref="sicestParser.opinstruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoexisteOpInstruccion([NotNull] sicestParser.NoexisteOpInstruccionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>EsIndexado</c>
	/// labeled alternative in <see cref="sicestParser.indexado"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEsIndexado([NotNull] sicestParser.EsIndexadoContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>EsIndexado</c>
	/// labeled alternative in <see cref="sicestParser.indexado"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEsIndexado([NotNull] sicestParser.EsIndexadoContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>NoEsIndexado</c>
	/// labeled alternative in <see cref="sicestParser.indexado"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoEsIndexado([NotNull] sicestParser.NoEsIndexadoContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NoEsIndexado</c>
	/// labeled alternative in <see cref="sicestParser.indexado"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoEsIndexado([NotNull] sicestParser.NoEsIndexadoContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DirNum</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirNum([NotNull] sicestParser.DirNumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DirNum</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirNum([NotNull] sicestParser.DirNumContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DirNumHex</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirNumHex([NotNull] sicestParser.DirNumHexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DirNumHex</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirNumHex([NotNull] sicestParser.DirNumHexContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DirConstCad</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirConstCad([NotNull] sicestParser.DirConstCadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DirConstCad</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirConstCad([NotNull] sicestParser.DirConstCadContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>DirNumHexMin</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirNumHexMin([NotNull] sicestParser.DirNumHexMinContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DirNumHexMin</c>
	/// labeled alternative in <see cref="sicestParser.opdirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirNumHexMin([NotNull] sicestParser.DirNumHexMinContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Numnormal</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumnormal([NotNull] sicestParser.NumnormalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Numnormal</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumnormal([NotNull] sicestParser.NumnormalContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Numhex</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumhex([NotNull] sicestParser.NumhexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Numhex</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumhex([NotNull] sicestParser.NumhexContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>Numhexmin</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumhexmin([NotNull] sicestParser.NumhexminContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Numhexmin</c>
	/// labeled alternative in <see cref="sicestParser.num"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumhexmin([NotNull] sicestParser.NumhexminContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>BYTECBYTE</c>
	/// labeled alternative in <see cref="sicestParser.byte"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBYTECBYTE([NotNull] sicestParser.BYTECBYTEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BYTECBYTE</c>
	/// labeled alternative in <see cref="sicestParser.byte"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBYTECBYTE([NotNull] sicestParser.BYTECBYTEContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>BYTEXBYTE</c>
	/// labeled alternative in <see cref="sicestParser.byte"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBYTEXBYTE([NotNull] sicestParser.BYTEXBYTEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BYTEXBYTE</c>
	/// labeled alternative in <see cref="sicestParser.byte"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBYTEXBYTE([NotNull] sicestParser.BYTEXBYTEContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.programa"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrograma([NotNull] sicestParser.ProgramaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.programa"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrograma([NotNull] sicestParser.ProgramaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.inicio"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInicio([NotNull] sicestParser.InicioContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.inicio"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInicio([NotNull] sicestParser.InicioContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.fin"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFin([NotNull] sicestParser.FinContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.fin"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFin([NotNull] sicestParser.FinContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.entrada"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEntrada([NotNull] sicestParser.EntradaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.entrada"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEntrada([NotNull] sicestParser.EntradaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.proposiciones"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProposiciones([NotNull] sicestParser.ProposicionesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.proposiciones"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProposiciones([NotNull] sicestParser.ProposicionesContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.proposicion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProposicion([NotNull] sicestParser.ProposicionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.proposicion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProposicion([NotNull] sicestParser.ProposicionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.instruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstruccion([NotNull] sicestParser.InstruccionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.instruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstruccion([NotNull] sicestParser.InstruccionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.directiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirectiva([NotNull] sicestParser.DirectivaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.directiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirectiva([NotNull] sicestParser.DirectivaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.tipodirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTipodirectiva([NotNull] sicestParser.TipodirectivaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.tipodirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTipodirectiva([NotNull] sicestParser.TipodirectivaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.etiqueta"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEtiqueta([NotNull] sicestParser.EtiquetaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.etiqueta"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEtiqueta([NotNull] sicestParser.EtiquetaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.opinstruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpinstruccion([NotNull] sicestParser.OpinstruccionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.opinstruccion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpinstruccion([NotNull] sicestParser.OpinstruccionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.indexado"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexado([NotNull] sicestParser.IndexadoContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.indexado"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexado([NotNull] sicestParser.IndexadoContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.opdirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpdirectiva([NotNull] sicestParser.OpdirectivaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.opdirectiva"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpdirectiva([NotNull] sicestParser.OpdirectivaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.num"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNum([NotNull] sicestParser.NumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.num"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNum([NotNull] sicestParser.NumContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="sicestParser.byte"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterByte([NotNull] sicestParser.ByteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="sicestParser.byte"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitByte([NotNull] sicestParser.ByteContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Practica02SIC
