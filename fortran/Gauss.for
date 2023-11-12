	SUBROUTINE GAUSS(a,b,n,x)
C	------------------------------------------------------
C	Procedura rozwi¹zuje uk³ad n równañ liniowych 
C	  postaci A×X=B
C		a(n,n)-macierz wspó³czynników
C		b(n)  -wektor wyrazów wolnych
C		x(n)  -wektor niewiadomych
C		n     -liczba równañ
C	      p(1,n+1) - tablica pomocnicza
C	------------------------------------------------------
	DOUBLE PRECISION a(n,n),b(n),x(n),p(1,n+1),l
		DO I=1,n
			x(I)=0
		END DO
C	Etap eliminacji zmiennych
		DO K=1,n-1
C			-------------Przestawienie------------
			M=K
			DO WHILE (a(K,K).EQ.0)
				IF (M.GT.K) THEN
					DO J=1,n
						a(M,J)=a(K,J)
						a(K,J)=p(1,J)
					END DO
						b(M)=b(K)
						b(K)=p(1,n+1)
				END IF
			M=M+1
				DO J=1,n
					p(1,J)=a(K,J)
					a(K,J)=a(M,J)
					a(M,J)=p(1,J)
				END DO
					p(1,n+1)=b(K)
					b(K)=b(M)
					b(M)=p(1,n+1)
			END DO
C			---------------------------------------
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