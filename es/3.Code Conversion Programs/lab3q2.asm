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
	LDR R0,=BCD
	LDR R0,[R0]
	AND R1,R0,#0x0F
	AND R2,R0,#0xF0
	LSR R2,#4
	LDR R4,=0xA
	MLA R2,R2,R4,R1
	LDR R3,=RES
	STR R2,[R3]
STOP B STOP
BCD DCD 0X34
	AREA MYDATA,DATA, READWRITE
RES DCD 0
	END