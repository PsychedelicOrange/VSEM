	AREA RESET,DATA,READONLY
	EXPORT __Vectors
__Vectors
	DCD 0x10001000
	DCD Reset_Handler
	ALIGN
	AREA mycode, CODE, READONLY
	ENTRY
	EXPORT Reset_Handler
Reset_Handler
; code here
	LDR R0,=SRC
	LDR R1,=0X19
	LDR R10,=0XA
BACK
	ADD R1,#23
	STR R1,[R0],#4
	SUBS R10,#1
	BNE BACK
	LDR R10,=0X5
	LDR R1,=SRC
	SUB R0,#4
BACK2
	LDR R2,[R1]
	LDR R3,[R0]
	STR R2,[R0],#-4
	STR R3,[R1],#4
	SUBS R10,#1
	BNE BACK2
STOP B STOP
N EQU 10
SHIFTS EQU 3
	AREA mydata, DATA, READWRITE
; reserve memory in RAM here
SRC DCD 0,0,0,0,0,0,0,0,0,0
	END