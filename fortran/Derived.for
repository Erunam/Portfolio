	SUBROUTINE DERIVED(x,df,n,m)
C	-------------------------------------------------------------------
C	Procedura oblicza macierz Jakobiego funkcji wielu zmiennych
C	 w punkcie o wsp�rz�dnych danych wektorem x(n)
C		df(n,n) - macierz Jakobiego 'df(i,j)=dFi/Xj  i,j=1,2,...,n'
C		x(n) - wektor wsp�rz�dnych punktu
C		n - liczba zmiennych funkcji
C		m - liczba funkcji 
C		dx - zmienn� nale�y dobiera� ostro�nie i z g�ow�
C			 ma wielki wp�yw na wynik r�niczkowania
C			 proponuj� przyj�� warto�� z przedzia�u 3-10
C	Wymagania: procedura FUNKCJA (definiowana przez u�ytkownika)
C	-------------------------------------------------------------------
	DOUBLE PRECISION x(n),df(m,n),f1(m),f2(m),h,zero,zakres
	dx=5
		DO J=1,n
			if (x(j) .ne. 0.0) then
				h=abs(x(J)*10**(-dx))
			else
				h=0.0000001
			endif
			x(J)=x(J)-h
				CALL FUNKCJA(x,f1,n,m)
			x(J)=x(J)+2*h
				CALL FUNKCJA(x,f2,n,m)	
			x(J)=x(J)-h
			DO I=1,m
				df(I,J)=(f2(I)-f1(I))/(2*h)
				
				zero=f2(I)-f1(I)
			END DO
		END DO
	END