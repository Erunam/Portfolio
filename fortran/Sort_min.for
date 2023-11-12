	SUBROUTINE SORT_MIN(x,n)
C	-------------------------------------------------------------------
C	Procedura sortuje wartoœci wektora x w porz¹dku rosn¹cym metod¹ 
C		b¹belkowania.
C		x(n) - wektor liczb do posortowania
C		x(n) - wektor liczb posortowany
C
C	UWAGA: STANOWCZO ODRADZAM STOSOWANIA TEJ PROCEDURY ORAZ	WSZELKICH 
C		ALGORYTMÓW OPARTYCH NA TZW. METODZIE B¥BELKOWANIA W PRZYPADKU 
C		SORTOWANIA WIÊKSZEJ ILOŒCI DANYCH (wiêkszej ni¿ 500).
C	-------------------------------------------------------------------
	DIMENSION x(N)
		DO I=1,N
			L=I+1
		DO K=L,N
			IF (X(I) .GT. X(K)) THEN
				c=x(I)
				x(I)=x(K)
				x(K)=c
			END IF
		END DO
		END DO
	END