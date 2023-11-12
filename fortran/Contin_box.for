	SUBROUTINE FUNKCJA1(x,fun,n,m)
	
	DOUBLE PRECISION x(n),fun(m)
	double precision a(2),t(2),temp(2)
	
	double precision kv,kf,f(2),k,gamma,beta,da,thetaH,delta(2)
	double precision krok,tauk,sigma(2)
	common /par/ kv,kf,f,k,gamma,beta,da,thetaH,delta
	common /par2/ krok,tauk,sigma
	
	a(1)=x(1)
	a(2)=x(3)
	t(1)=x(2)
	t(2)=x(4)
	thetaH=x(5)
	
C	------------DEFINICJE FUNKCJI---------------	
C	warunek brzegowy ------------
		temp(1)=a(1);temp(2)=t(1)
		a(1)=k*f(2)*a(2)
          t(1)=k*f(2)*t(2)
          
          a(2)=(1/k)*f(1)*temp(1)
          t(2)=(1/k)*f(1)*temp(2)          
C	---------------- ------------
	call calkacon(a,t)

	fun(1)=a(1)-x(1)
	fun(2)=t(1)-x(2)
	fun(3)=a(2)-x(3)
	fun(4)=t(2)-x(4)

C	--------------------------------------------
	END	subroutine
	subroutine calkacon(a,t)

	double precision kv,kf,f(2),k,gamma,beta,da,thetaH,delta(2)
	double precision krok,tauk,sigma(2)

	double precision a(2),t(2)

	common /par/ kv,kf,f,k,gamma,beta,da,thetaH,delta
	common /par2/ krok,tauk,sigma

	n=(2*tauk/(sigma(1)+sigma(2)))
	n=nint(1/krok)
	
	do i=1,2
		do j=1,n

	fi=da*((1-a(i))**1.5)*(dexp(gamma*(t(i)*beta/(1.d0+t(i)*beta))))
	
	t(i)=t(i)+(fi+delta(i)*(thetaH-t(i)))*sigma(i)*krok
	a(i)=a(i)+fi*sigma(i)*krok
		
		enddo
	enddo
	
	end

	SUBROUTINE CONTIN(x0,p,dp,pk,n)
C	-----------------------------------------------------------------
C	Procedura wyznacza przebieg funkcji Xi=f(p) metod¹ kontynuacji
C		x0 - startowe wspó³rzêdne wektora X0=f(p0)
C		p  - pocz¹tkowa wartoœæ parametru p
C		pk - koñcowa wartoœæ parametru p
C		dp - krok 
C	Wymagania: procedury DERIVED,INVERSE
C	UWAGA1: Procedura otwiera pliki o jednostce pomiêdzy 101 a 100+n 
C		i nazwach ANSI od kodu 65 do 65+n.Korzysta z etykiety 2000
C	UWAGA2:	Nale¿y pamiêtaæ aby w podprocedurze FUNKCJA parametr p
C		widoczny w metodzie kontynuacji traktowaæ i wpisywaæ do
C 		definicji funkcji jako element wektora x(l) gdzie l=n+1
C		(dla 3 zmiennych piszemy p jako x(4))
C	-----------------------------------------------------------------
	DOUBLE PRECISION x0(n),x(n+1),jc(n,n+1),j_1(n,n),r(n),p,dp,pk
	DOUBLE PRECISION sm(n),dx

C	-----Utworzenie plików dla wyników-----
	open(unit=11,file='alfabif.dat')
	open(unit=12,file='thetabif.dat')
	open(unit=13,file='parbif.dat')
	
	DO I=1,n
		x(I)=x0(I)
	END DO
		x(N+1)=p
		dx=dp
c	---------------------------------------	
		write(11,2000)x(1),x(3)
		write(12,2000)x(2),x(4)
		write(13,2000)x(5)
c	---------------------------------------
	pk=abs(p)+abs(pk-p)
	p=abs(p)
	dp=abs(dp)
c	---------------------------------------
	DO WHILE (p .LE. pk)
		
			DO I=1,n
				sm(I)=0.d0
			END DO
		CALL DERIVED1(x,jc,n+1,n)
			DO I=1,n
					r(I)=jc(I,N+1)
				DO  J=1,n
					j_1(I,J)=jc(I,J)
				END DO
			END DO	
		CALL INVERSE1(j_1,j_1,n)
			DO I=1,n
				DO J=1,n
					sm(I)=sm(I)+j_1(I,J)*r(J)
				END DO
					x(I)=x(I)-sm(I)*dp
			END DO
C	-----Zapis wyników do plików----------

	write(11,2000)x(1),x(3)
	write(12,2000)x(2),x(4)
	write(13,2000)x(5)

C	--------------------------------------
		x(n+1)=x(n+1)+dx
		p=p+dp
	END DO
C	-----Zamkniêcie plików wyników--------
		CLOSE(unit=11)
		CLOSE(unit=12)
		CLOSE(unit=13)
		
C	--------------------------------------
2000	FORMAT(5x,f20.10,5x,f20.10)
	END

	SUBROUTINE DERIVED1(x,df,n,m)
C	-------------------------------------------------------------------
C	Procedura oblicza macierz Jakobiego funkcji wielu zmiennych
C	 w punkcie o wspó³rzêdnych danych wektorem x(n)
C		df(n,n) - macierz Jakobiego 'df(i,j)=dFi/Xj  i,j=1,2,...,n'
C		x(n) - wektor wspó³rzêdnych punktu
C		n - liczba zmiennych funkcji
C		m - liczba funkcji 
C		dx - zmienn¹ nale¿y dobieraæ ostro¿nie i z g³ow¹
C			 ma wielki wp³yw na wynik ró¿niczkowania
C			 proponujê przyj¹æ wartoœæ z przedzia³u 3-10
C	Wymagania: procedura FUNKCJA (definiowana przez u¿ytkownika)
C	-------------------------------------------------------------------
	DOUBLE PRECISION x(n),df(m,n),f1(m),f2(m),h,dx
	dx=5.d0;h=0.d0

		DO J=1,n
			if (x(j) .ne. 0.d0) then
				h=abs(x(J)*10**(-dx))
			else
				h=0.0000001
			end if
			
			x(J)=x(J)-h
				CALL FUNKCJA1(x,f1,n,m)
			x(J)=x(J)+2*h
				CALL FUNKCJA1(x,f2,n,m)	
			x(J)=x(J)-h
			
			DO I=1,m
				df(I,J)=(f2(I)-f1(I))/(2*h)
			END DO
		END DO
	END

	SUBROUTINE INVERSE1(a,a_1,n)
C     ------------------------------------------------------
C	Procedura wyznacza macierz odwrotn¹ do danej
C		a(n,n) - macierz odwracana A(i,j)
C		a_1(n,n)-macierz odwrócona A-1(i,j)
C		d(n) - wektor pomocniczy
C	Wymagania: procedura GAUSS, procedura DET
C	------------------------------------------------------
	DOUBLE PRECISION a(n,n),a_1(n,n),x(n),d(n),detA
C	-----Sprawdzenie osobliwoœci macierzy-----------------
		CALL DET1(a,n,detA)
		IF (abs(detA) .LT. 0.0000000001) THEN
			WRITE(*,*)'   MACIERZ JEST MACIERZA OSOBLIWA'
			WRITE(*,*)'NIE ISTNIEJE MACIERZ DO NIEJ ODWROTNA'
			open(unit=100,file='osobliwosc.dat')
			write(100,2200)x(1),x(3)
			write(100,2200)x(2),x(4)
			write(100,2200)x(5),x(5)
			close(unit=100)
			
			STOP

		END IF
C	------------------------------------------------------
		DO J=1,n
			DO I=1,n
				d(I)=0
			END DO
				d(J)=1
				CALL GAUSS1(a,d,n,x)
			DO I=1,n
				a_1(I,J)=x(I)
			END DO
		END DO
2200	FORMAT(5x,f20.10,5x,f20.10)
	END
	SUBROUTINE GAUSS1(a0,b,n,x)
C	------------------------------------------------------
C	Procedura rozwi¹zuje uk³ad n równañ liniowych 
C	  postaci A×X=B metod¹ eliminacji Gaussa
C		a(n,n)-macierz wspó³czynników
C		b(n)  -wektor wyrazów wolnych
C		x(n)  -wektor niewiadomych
C		n     -liczba równañ
C	------------------------------------------------------
	DOUBLE PRECISION a(n,n),b(n),x(n),l,a0(n,n)
		DO I=1,n
			x(I)=0
			do j=1,n
				a(i,j)=a0(i,j)
			end do
		END DO
C	Etap eliminacji zmiennych
		DO K=1,n-1
				IF (a(K,K) .EQ. 0.0) THEN
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
	SUBROUTINE DET1(a0,n,detA)
C	--------------------------------------------------------
C	Procedura oblicza wyznacznik macierzy kwadratowej
C		a(n,n) - macierz kwadratowa o elementach a(i,j)
C		n - wymiar macierzy A
C	--------------------------------------------------------
	DOUBLE PRECISION a(n,n),detA,a0(n,n)
	DO I=1,n
		DO J=1,n
			a(I,J)=a0(I,J)
		END DO
	END DO
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