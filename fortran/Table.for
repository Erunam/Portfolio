	SUBROUTINE TABLE(pocz,kon,steps,nx)
C	---------------------------------------------------------
C	Procedura podaje kolejne wartoœci zmiennych w sposób:
C		0	0	...	0	0
C		0	0	...	0	1
C		0	0	...	0	2
C		.	.		.	.
C		.	.		.	.
C		.	.		.	.
C		0	0	...	0	n
C		0	0	...	1	0
C		0	0	...	1	1
C		0	0	...	1	2
C		.	.		.	.
C		.	.		.	.
C		.	.		.	.
C		0	0	...	n	n
C		0	1	...	0	0
C		0	1	...	0	1 itd.
C	 pocz(nx) - wektor poczatkowych wartoœci zmiennych
C	  kon(nx) - wektor koñcowych wartoœci zmiennych
C	steps(nx) - wektor zmiany wartoœci zmiennych
C		   nx - liczba zmiennych
C	---------------------------------------------------------
	DOUBLE PRECISION pocz(nx),kon(nx),steps(nx),tab(nx)

	DO I=1,nx
		tab(I)=pocz(I)
	END DO

	wsk=nx
	DO WHILE ( pocz(1) .LE. kon(1) )
			DO I=nx,2,-1
				IF ( pocz(I) .GE. kon(I)) THEN
					pocz(I)=tab(I)
					wsk=i
					pocz(wsk-1)=pocz(wsk-1)+steps(wsk-1)
				IF ( wsk .EQ. nx) pocz(nx)=pocz(nx)-steps(nx)
				END IF
			END DO
		pocz(nx)=pocz(nx)+steps(nx)
	END DO
	
	END