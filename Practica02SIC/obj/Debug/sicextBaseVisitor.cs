﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\jesus\Desktop\Practica02SIC\Practica02SIC\sicext.g4 by ANTLR 4.6.6

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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IsicextVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class sicextBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IsicextVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>InicioPrograma</c>
	/// labeled alternative in <see cref="sicextParser.programa"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInicioPrograma([NotNull] sicextParser.InicioProgramaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Etiqini</c>
	/// labeled alternative in <see cref="sicextParser.inicio"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEtiqini([NotNull] sicextParser.EtiqiniContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Prepos</c>
	/// labeled alternative in <see cref="sicextParser.inicio"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrepos([NotNull] sicextParser.PreposContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>EndID</c>
	/// labeled alternative in <see cref="sicextParser.entrada"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEndID([NotNull] sicextParser.EndIDContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>NoEndID</c>
	/// labeled alternative in <see cref="sicextParser.entrada"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNoEndID([NotNull] sicextParser.NoEndIDContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ErrorDobleByte</c>
	/// labeled alternative in <see cref="sicextParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitErrorDobleByte([NotNull] sicextParser.ErrorDobleByteContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ErrorDobleDirectiva</c>
	/// labeled alternative in <see cref="sicextParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitErrorDobleDirectiva([NotNull] sicextParser.ErrorDobleDirectivaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>EsBYTE</c>
	/// labeled alternative in <see cref="sicextParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEsBYTE([NotNull] sicextParser.EsBYTEContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>EsDirectiva</c>
	/// labeled alternative in <see cref="sicextParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEsDirectiva([NotNull] sicextParser.EsDirectivaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DIRWORD</c>
	/// labeled alternative in <see cref="sicextParser.tipodirectiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDIRWORD([NotNull] sicextParser.DIRWORDContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DIRRESB</c>
	/// labeled alternative in <see cref="sicextParser.tipodirectiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDIRRESB([NotNull] sicextParser.DIRRESBContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DIRRESW</c>
	/// labeled alternative in <see cref="sicextParser.tipodirectiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDIRRESW([NotNull] sicextParser.DIRRESWContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DIRBASE</c>
	/// labeled alternative in <see cref="sicextParser.tipodirectiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDIRBASE([NotNull] sicextParser.DIRBASEContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ExisteID</c>
	/// labeled alternative in <see cref="sicextParser.etiqueta"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExisteID([NotNull] sicextParser.ExisteIDContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>NoExisteID</c>
	/// labeled alternative in <see cref="sicextParser.etiqueta"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNoExisteID([NotNull] sicextParser.NoExisteIDContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DirNum</c>
	/// labeled alternative in <see cref="sicextParser.opdirectiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirNum([NotNull] sicextParser.DirNumContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DirNumHex</c>
	/// labeled alternative in <see cref="sicextParser.opdirectiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirNumHex([NotNull] sicextParser.DirNumHexContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DirConstCad</c>
	/// labeled alternative in <see cref="sicextParser.opdirectiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirConstCad([NotNull] sicextParser.DirConstCadContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>DirNumHexMin</c>
	/// labeled alternative in <see cref="sicextParser.opdirectiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirNumHexMin([NotNull] sicextParser.DirNumHexMinContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Numnormal</c>
	/// labeled alternative in <see cref="sicextParser.num"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumnormal([NotNull] sicextParser.NumnormalContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Numhex</c>
	/// labeled alternative in <see cref="sicextParser.num"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumhex([NotNull] sicextParser.NumhexContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Numhexmin</c>
	/// labeled alternative in <see cref="sicextParser.num"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumhexmin([NotNull] sicextParser.NumhexminContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>BYTECBYTE</c>
	/// labeled alternative in <see cref="sicextParser.byte"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBYTECBYTE([NotNull] sicextParser.BYTECBYTEContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>BYTEXBYTE</c>
	/// labeled alternative in <see cref="sicextParser.byte"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBYTEXBYTE([NotNull] sicextParser.BYTEXBYTEContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>EsFormato1</c>
	/// labeled alternative in <see cref="sicextParser.formato1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEsFormato1([NotNull] sicextParser.EsFormato1Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ERRORF1</c>
	/// labeled alternative in <see cref="sicextParser.formato1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitERRORF1([NotNull] sicextParser.ERRORF1Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ModoInmediato</c>
	/// labeled alternative in <see cref="sicextParser.modo"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitModoInmediato([NotNull] sicextParser.ModoInmediatoContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ModoIndirecto</c>
	/// labeled alternative in <see cref="sicextParser.modo"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitModoIndirecto([NotNull] sicextParser.ModoIndirectoContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ModoSimple</c>
	/// labeled alternative in <see cref="sicextParser.modo"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitModoSimple([NotNull] sicextParser.ModoSimpleContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2ADDR</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2ADDR([NotNull] sicextParser.Formato2ADDRContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2CLEAR</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2CLEAR([NotNull] sicextParser.Formato2CLEARContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2COMPR</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2COMPR([NotNull] sicextParser.Formato2COMPRContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2DIVR</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2DIVR([NotNull] sicextParser.Formato2DIVRContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2MULR</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2MULR([NotNull] sicextParser.Formato2MULRContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2RMO</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2RMO([NotNull] sicextParser.Formato2RMOContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2SHIFTL</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2SHIFTL([NotNull] sicextParser.Formato2SHIFTLContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2SHIFTR</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2SHIFTR([NotNull] sicextParser.Formato2SHIFTRContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2SUBR</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2SUBR([NotNull] sicextParser.Formato2SUBRContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2SVC</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2SVC([NotNull] sicextParser.Formato2SVCContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Formato2TIXR</c>
	/// labeled alternative in <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2TIXR([NotNull] sicextParser.Formato2TIXRContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>EsFormato3</c>
	/// labeled alternative in <see cref="sicextParser.formato3o4"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEsFormato3([NotNull] sicextParser.EsFormato3Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>EsFomato4</c>
	/// labeled alternative in <see cref="sicextParser.formato3o4"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEsFomato4([NotNull] sicextParser.EsFomato4Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>RSUBform3</c>
	/// labeled alternative in <see cref="sicextParser.formato3o4"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRSUBform3([NotNull] sicextParser.RSUBform3Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>RSUBform4</c>
	/// labeled alternative in <see cref="sicextParser.formato3o4"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRSUBform4([NotNull] sicextParser.RSUBform4Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ErrorRsub</c>
	/// labeled alternative in <see cref="sicextParser.formato3o4"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitErrorRsub([NotNull] sicextParser.ErrorRsubContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>EsIndexado</c>
	/// labeled alternative in <see cref="sicextParser.indexado"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEsIndexado([NotNull] sicextParser.EsIndexadoContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>NoEsIndexado</c>
	/// labeled alternative in <see cref="sicextParser.indexado"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNoEsIndexado([NotNull] sicextParser.NoEsIndexadoContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>RegresaReg</c>
	/// labeled alternative in <see cref="sicextParser.regox"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRegresaReg([NotNull] sicextParser.RegresaRegContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>RegresaX</c>
	/// labeled alternative in <see cref="sicextParser.regox"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRegresaX([NotNull] sicextParser.RegresaXContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.programa"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrograma([NotNull] sicextParser.ProgramaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.inicio"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInicio([NotNull] sicextParser.InicioContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.fin"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFin([NotNull] sicextParser.FinContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.entrada"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEntrada([NotNull] sicextParser.EntradaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.proposiciones"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProposiciones([NotNull] sicextParser.ProposicionesContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.proposicion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProposicion([NotNull] sicextParser.ProposicionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.directiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirectiva([NotNull] sicextParser.DirectivaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.tipodirectiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTipodirectiva([NotNull] sicextParser.TipodirectivaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.etiqueta"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEtiqueta([NotNull] sicextParser.EtiquetaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.opdirectiva"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpdirectiva([NotNull] sicextParser.OpdirectivaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.num"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNum([NotNull] sicextParser.NumContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.byte"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitByte([NotNull] sicextParser.ByteContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.formato"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato([NotNull] sicextParser.FormatoContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.formato1"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato1([NotNull] sicextParser.Formato1Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.modo"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitModo([NotNull] sicextParser.ModoContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.formato2"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato2([NotNull] sicextParser.Formato2Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.formato3o4"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormato3o4([NotNull] sicextParser.Formato3o4Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.indexado"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIndexado([NotNull] sicextParser.IndexadoContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="sicextParser.regox"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRegox([NotNull] sicextParser.RegoxContext context) { return VisitChildren(context); }
}
} // namespace Practica02SIC