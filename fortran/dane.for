	SUBROUTINE dane(odp,pocz,kon,steps,name,nx)
C	-----------------------------------------------------
C	Procedura ³aduje dane do obliczeñ
C	-----------------------------------------------------
	CHARACTER*3 odp,input*64
	CHARACTER*11 name(nx)
	DOUBLE PRECISION pocz(nx),kon(nx),steps(nx)
C	Wczytanie danych
	
	k=48;l=48
	DO I=1,nx
		name(i)='    x'//CHAR(k)//CHAR(l)//
		l=l+1
		IF (l .eq. 57) THEN
			l=48
			k=k+1
		END IF
	END DO

	SELECT CASE (odp)
		CASE ('P','p')
			WRITE(*,*)'   Podaj nazwê pliku'
			READ(*,*)input
			OPEN(unit=2,file=input)
				DO I=1,nx
				READ(2,*)pocz(I),kon(I),steps(I)
			END DO
		CASE ('R','r')
			WRITE(*,*)'Podaj wartoœci pocz¹tkowe wszystkich zmiennych'
				DO I=1,nx
					WRITE(*,*)'X0',I
					READ(*,*)pocz(I)
				END DO
			WRITE(*,*)'Podaj wartoœci koñcowe wszystkich zmiennych'
				DO I=1,nx
					WRITE(*,*)'Xk',I
					READ(*,*)kon(I)
				END DO
			WRITE(*,*)'Podaj zmianê (krok) zmiennych'
				DO I=1,nx
					WRITE(*,*)'deltaX',I
					READ(*,*)steps(I)
				END DO
		CASE DEFAULT
			pocz(1)=1;pocz(2)=0;pocz(3)=2
			kon(1)=4;kon(2)=3;kon(3)=4
			steps(1)=1;steps(2)=1.5;steps(3)=0.8
	END SELECT
	END