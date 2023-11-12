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