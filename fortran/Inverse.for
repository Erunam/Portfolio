	SUBROUTINE INVERSE(a,a_1,n)
C     ------------------------------------------------------
C	Procedura wyznacza macierz odwrotn¹ do danej
C		a(n,n) - macierz odwracana A(i,j)
C		a_1(n,n)-macierz odwrócona A-1(i,j)
C		d(n) - wektor pomocniczy
C	Wymagania: procedura GAUSS_bp, procedura DET
C	------------------------------------------------------
	DOUBLE PRECISION a(n,n),a_1(n,n),x(n),d(n),detA
C	-----Sprawdzenie osobliwoœci macierzy-----------------
		CALL DET(a,n,detA)
		IF (abs(detA) .EQ. 0) THEN
			WRITE(*,*)'MACIERZ JEST MACIERZA OSOBLIWA'
			WRITE(*,*)'NIE ISTNIEJE MACIERZ ODWROTNA'
			STOP
		END IF
C	------------------------------------------------------
		DO J=1,n
			DO I=1,n
				d(I)=0
			END DO
				d(J)=1
				CALL GAUSS(a,d,n,x)
			DO I=1,n
				a_1(I,J)=x(I)
			END DO
		END DO
	END