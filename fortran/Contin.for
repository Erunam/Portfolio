	SUBROUTINE CONTIN(x0,p,dp,pk,n)
C	-----------------------------------------------------------------
C	Procedura wyznacza przebieg funkcji Xi=f(p) metod� kontynuacji
C		x0 - startowe wsp�rz�dne wektora X0=f(p0)
C		p  - pocz�tkowa warto�� parametru p
C		pk - ko�cowa warto�� parametru p
C		dp - krok 
C	Wymagania: procedury DERIVED,INVERSE
C	UWAGA1: Procedura otwiera pliki o jednostce pomi�dzy 101 a 100+n 
C		i nazwach ANSI od kodu 65 do 65+n.Korzysta z etykiety 2000
C	UWAGA2:	Nale�y pami�ta� aby w podprocedurze FUNKCJA parametr p
C		widoczny w metodzie kontynuacji traktowa� i wpisywa� do
C 		definicji funkcji jako element wektora x(l) gdzie l=n+1
C		(dla 3 zmiennych piszemy p jako x(4))
C	-----------------------------------------------------------------
	DOUBLE PRECISION x0(n),x(n+1),jc(n,n+1),j_1(n,n),r(n),p,dp,pk
	DOUBLE PRECISION sm(n)
	CHARACTER*1 input
C	-----Utworzenie plik�w dla wynik�w-----
	DO I=1,n
		x(I)=x0(I)
		input=CHAR(64+I)
		OPEN(unit=100+I,file=input)
	END DO
C	---------------------------------------
	DO WHILE (p .LE. pk+dp)
		
			DO I=1,n
				sm(I)=0
			END DO
				x(N+1)=p
		CALL DERIVED(x,jc,n+1,n)
			DO I=1,n
					r(I)=jc(I,N+1)
				DO  J=1,n
					j_1(I,J)=jc(I,J)
				END DO
			END DO	
		CALL INVERSE(j_1,j_1,n)
			DO I=1,n
				DO J=1,n
					sm(I)=sm(I)+j_1(I,J)*r(J)
				END DO
					x(I)=x(I)-sm(I)*dp
			END DO
C	-----Zapis wynik�w do plik�w----------
		DO I=1,n
			WRITE(100+I,2000)p,x(I)
		END DO
C	--------------------------------------
		p=p+dp
	END DO
C	-----Zamkni�cie plik�w wynik�w--------
		DO I=1,n
			input=CHAR(64+I)
			CLOSE(unit=100+I)
		END DO
C	--------------------------------------
2000	FORMAT(5x,'p -',f20.3,5x,'x -',f20.3)
	END