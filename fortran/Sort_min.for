	SUBROUTINE SORT_MIN(x,n)
C	-------------------------------------------------------------------
C	Procedura sortuje warto�ci wektora x w porz�dku rosn�cym metod� 
C		b�belkowania.
C		x(n) - wektor liczb do posortowania
C		x(n) - wektor liczb posortowany
C
C	UWAGA: STANOWCZO ODRADZAM STOSOWANIA TEJ PROCEDURY ORAZ	WSZELKICH 
C		ALGORYTM�W OPARTYCH NA TZW. METODZIE B�BELKOWANIA W PRZYPADKU 
C		SORTOWANIA WI�KSZEJ ILO�CI DANYCH (wi�kszej ni� 500).
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