	SUBROUTINE ILOCZYN(a,b,c,n,l,m)
C	-------------------------------------------------------------------------
C	Procedura oblicza iloczyn dwóch macierzy  A×B=C
C		A(n,l) - macierz o wymiarach n×l (n wierszy,l kolumn)
C		B(l,m) - macierz o wymiarach l×m (l wierszy,m kolumn)
C		C(n,m) - iloczyn macierzy A i B o wymiarach n×m (n wierszy,m kolumn)
C	-------------------------------------------------------------------------
	DOUBLE PRECISION a(n,l),b(l,m),c(n,m),suma
	suma=0.0
	DO I=1,n
		DO J=1,m
			DO K=1,l
				suma=suma+a(I,K)*b(K,J)
			END DO
			C(I,J)=suma
			suma=0.0
		END DO
	END DO
	END