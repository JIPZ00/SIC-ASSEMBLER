grammar sicest;

programa
	: inicio proposiciones fin #InicioPrograma
;

inicio
	: etiqueta START num FINL #Etiqini
	| proposicion #Prepos
;

fin
	: END entrada EOF
	| END entrada 
;

entrada
	: ID #EndID
|	#NoEndID
;
proposiciones
	: proposiciones proposicion
	| proposicion
;

proposicion
	: instruccion FINL
	| directiva FINL 

;

instruccion
	:CODOP CODOP opinstruccion #ErrorCodOp
	|RSUB RSUB #ErrorRsub
	| etiqueta CODOP opinstruccion #Instrnormal
	| etiqueta RSUB  #Instrrsub
;

directiva
	: 
		TIPOBYTE TIPOBYTE byte #ErrorDobleByte
		| tipodirectiva tipodirectiva opdirectiva #ErrorDobleDirectiva
	   |etiqueta TIPOBYTE byte #EsBYTE
	   |etiqueta tipodirectiva opdirectiva  #EsDirectiva
	   //|etiqueta tiposimbolo #EsSimbolo
	   ;

/*tiposimbolo
	:
		SIMBOLO #SIMBO
		| EQU #ETICEQU
		| EQU #ETICORG
;*/

tipodirectiva
	: 
	 TIPOWORD #DIRWORD
	| RESB  #DIRRESB
	| RESW #DIRRESW
;

etiqueta
	:ID #ExisteID
	| #NoExisteID
;

opinstruccion
	: ID indexado #ExisteOpInstruccion
	| #NoexisteOpInstruccion
;

indexado
	: COMA INDICE #EsIndexado
	| #NoEsIndexado
;	

opdirectiva
	: NUM #DirNum
	| NUMHEX #DirNumHex
	| ID #DirConstCad
	|NUMHEXMIN #DirNumHexMin
;

num
	:NUM #Numnormal
	 | NUMHEX #Numhex
	 |NUMHEXMIN#Numhexmin
	 ;

byte
	:
		CBYTE #BYTECBYTE
		|XBYTE #BYTEXBYTE
		;


START  : 'START';
INDICE : 'X';
COMA : ',';
END: 'END';
TIPOBYTE: 'BYTE';
TIPOWORD: 'WORD';
RESB: 'RESB';
RESW:	 'RESW';
FINL: '\n'+;
CODOP: ('ADD'|'AND'|'COMP'|'DIV'|'J'|'JEQ'|'JGT'|'JLT'|'JSUB'|'LDA'|	
		'LDCH'|'LDL'|'LDX'|'MUL'|'OR'|'RD'|'STA'|'STCH'|'STL'|'STSW'|
		'STX'|'SUB'|'TD'|'TIX'|'WD');
RSUB: 'RSUB';
WS: [ \t]+ -> skip;
CBYTE : [C]'\''[0-9A-Za-z]+'\'';
XBYTE : [X]'\''[0-9A-Za-z]+'\'';

NUMHEX : [0-9A-F]+[H];
NUMHEXMIN :[0-9A-F]+[h];
NUM    : [0-9]+;
//EQU: 'EQU1';
//ORG:'ORG';



ID:		//secuencia de caracteres alfabeticos
			[a-zA-Z0-9]+
			;
