	SUBROUTINE NEWTON(x,n,d,iter)
C	-----------------------------------------------------------
C	Procedura rozwi¹zuje uk³ad równañ metod¹ Newtona
C		x(n) - wektor pocz¹tkowych wartoœci niewiadomych
C		d - ¿¹dana liczba cyfr znacz¹cych (w postaci x.x)
C		n - liczba niewiadomych
C		h(n) - wektor poprawek
C		f(n) - wektor wartoœci funkcji
C		df(n,n) - macierz Jacobiego
C	Wymagania: procedury:FUNKCJA,DERIVED,GAUSS
C	-----------------------------------------------------------
	DOUBLE PRECISION x(n),h(n),f(n),df(n,n),a(n),p(n),dtf
	dtf=10**(-d);delta=2;iter=0;k=1
			DO I=1,n
				a(I)=x(I)
				p(I)=0.5*x(I)
			END DO
	DO WHILE (dtf .LT. delta)
		iter=iter+1
			IF (iter .GT. 300) THEN
					iter=0
				DO I=1,n
					x(I)=a(I)+((-1)**k)*p(I)*k
				END DO
					k=k+1
				IF (k .GT. 10) THEN
					WRITE(*,*)'    Przykro mi ale programista nie uwzg
     &lêdni³ a¿ takiego pecha'
					WRITE(*,*)'	Proszê podaæ inne wartoœci pocz¹tkowe 
     &lub zmniejszyæ dok³adnoœæ'
					STOP
				END IF
			END IF
		CALL FUNKCJA(x,f,n,n)
			DO I=1,n
				f(I)=-1*f(I)
			END DO	
		CALL DERIVED(x,df,n,n)
		CALL GAUSS(df,f,n,h)	
			DO I=1,n
				x(I)=x(I)+h(I)
			END DO
		delta=0
		DO i=1,n
			f(i)=abs(f(i))
			delta=delta+f(i)
		END DO

	END DO
	END