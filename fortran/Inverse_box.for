	SUBROUTINE INVERSE(a,a_1,n)
C     ------------------------------------------------------
C	Procedura wyznacza macierz odwrotn� do danej
C		a(n,n) - macierz odwracana A(i,j)
C		a_1(n,n)-macierz odwr�cona A-1(i,j)
C		d(n) - wektor pomocniczy
C	Wymagania: procedura GAUSS, procedura DET
C	------------------------------------------------------
	DOUBLE PRECISION a(n,n),a_1(n,n),x(n),d(n),detA
C	-----Sprawdzenie osobliwo�ci macierzy-----------------
		CALL DET(a,n,detA)
		IF (abs(detA) .EQ. 0) THEN
			WRITE(*,*)'   MACIERZ JEST MACIERZA OSOBLIWA'
			WRITE(*,*)'NIE ISTNIEJE MACIERZ DO NIEJ ODWROTNA'
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
	SUBROUTINE GAUSS(a,b,n,x)
C	------------------------------------------------------
C	Procedura rozwi�zuje uk�ad n r�wna� liniowych 
C	  postaci A�X=B metod� eliminacji Gaussa
C		a(n,n)-macierz wsp�czynnik�w
C		b(n)  -wektor wyraz�w wolnych
C		x(n)  -wektor niewiadomych
C		n     -liczba r�wna�
C	------------------------------------------------------
	DOUBLE PRECISION a(n,n),b(n),x(n),l
		DO I=1,n
			x(I)=0
		END DO
C	Etap eliminacji zmiennych
		DO K=1,n-1
				IF (abs(a(K,K)) .LT. 0.00000001) THEN
					WRITE(*,*)'ZLE UWARUNKOWANA MACIERZ WSPOLCZYNNIKOW'
					STOP
				END IF
			DO I=K+1,n
					b(I)=b(I)-b(K)*a(I,K)/a(K,K)
				DO J=n,K,-1	
					a(I,J)=a(I,J)-(a(K,J)*(a(I,K)/a(K,K)))
				END DO
			END DO
		END DO
C	Etap post�powania odwrotnego
		DO I=n,1,-1
				l=0.0
			DO J=n,I,-1
				l=l+a(I,J)*x(J)
			END DO
				x(I)=(b(I)-l)/a(I,I)
		END DO
	END
	SUBROUTINE DET(a,n,detA)
C	--------------------------------------------------------
C	Procedura oblicza wyznacznik macierzy kwadratowej
C		a(n,n) - macierz kwadratowa o elementach a(i,j)
C		n - wymiar macierzy A
C	--------------------------------------------------------
	DOUBLE PRECISION a(n,n),detA
	detA=1
		DO K=1,n-1
			DO I=K+1,n
				DO J=n,K,-1	
					a(I,J)=a(I,J)-(a(K,J)*(a(I,K)/a(K,K)))
				END DO
			END DO
		END DO
		DO I=1,N
			detA=detA*a(I,I)
		END DO
	END