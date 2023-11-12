	SUBROUTINE RK_IV(x,z0,zk,h,n)
C	-------------------------------------------------------------------------------------
C	Procedura rozwi¹zuje uk³ad n równañ ró¿niczkowych I-rzêdu postaci
C		Dx(n)/Dz=f(x(n),z) metod¹ Rungego-Kuty IV rzêdu
C			x(n) - wektor o sk³adowych X1(z0),X2(z0),...,Xn(z0) dla z=z0
C			f(n) - funkcja wektorowa o sk³adowych F1(X1,X2,...Xn,z),...,Fn(X1,X2,...Xn,z)
C			z0 - pocz¹tkowa wartoœæ argumentu z
C			zk - koñcowa wartoœæ argumentu z
C			h - krok ca³kowania
C			n - liczba równañ
C	Wymagania: procedura FUNKCJA
C	-------------------------------------------------------------------------------------
	DOUBLE PRECISION x(n),k1(n),k2(n),k3(n),k4(n),f(n),p(n+1)
		z=z0
		DO WHILE (z .LT. zk)

C	------------Wyprowadzenie wyników-------------------------------

C	----------------------------------------------------------------

				DO I=1,n
					p(I)=x(I)
				END DO
					p(n+1)=z
			CALL FUNKCJA(p,f,n+1,n)
				DO I=1,n
					k1(I)=h*f(I)
					p(I)=x(I)+k1(I)/2
				END DO
					p(n+1)=z+h/2
			CALL FUNKCJA(p,f,n+1,n)
				DO I=1,n
					k2(I)=h*f(I)
					p(I)=x(I)+k2(I)/2
				END DO
					p(n+1)=z+h/2
			CALL FUNKCJA(p,f,n+1,n)
				DO I=1,n
					k3(I)=h*f(I)
					p(I)=x(I)+k3(I)
				END DO
					p(n+1)=z+h
			CALL FUNKCJA(p,f,n+1,n)
				DO I=1,n
					k4(I)=h*f(I)
					x(I)=x(I)+(1/6.0)*(k1(I)+2*k2(I)+2*k3(I)+k4(I))
				END DO
			z=z+h
			WRITE(*,1)z,zk
		END DO
1	FORMAT(5x,'argument ',en10.2,' z ',en10.2)
	END