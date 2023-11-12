	SUBROUTINE GAUSS(a,b,n,x)
C	------------------------------------------------------
C	Procedura rozwi¹zuje uk³ad n równañ liniowych 
C	  postaci A×X=B metod¹ eliminacji Gaussa
C		a(n,n)-macierz wspó³czynników
C		b(n)  -wektor wyrazów wolnych
C		x(n)  -wektor niewiadomych
C		n     -liczba równañ
C	------------------------------------------------------
	DOUBLE PRECISION a(n,n),b(n),x(n),l
		DO I=1,n
			x(I)=0
		END DO
C	Etap eliminacji zmiennych
		DO K=1,n-1
				IF (abs(a(K,K)) .EQ. 0.0) THEN
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
C	Etap postêpowania odwrotnego
		DO I=n,1,-1
				l=0.0
			DO J=n,I,-1
				l=l+a(I,J)*x(J)
			END DO
				x(I)=(b(I)-l)/a(I,I)
		END DO
	END