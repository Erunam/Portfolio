	PROGRAM engine

	CHARACTER*64 odp,input,output
	
C	G��wna p�tla programu
	DO WHILE (odp .NE. 't')
	
C	Wyb�r sposobu wprowadzania danych
	WRITE(*,1000)
	READ(*,*)odp
	
C	Wczytanie danych
	SELECT CASE (odp)
		CASE ('P','p')
			WRITE(*,*)'   Podaj nazw� pliku'
			READ(*,*)input
			OPEN(unit=2,file=input)
			
		CASE ('R','r')

		CASE DEFAULT
		
	END SELECT
C	Otwarcie pliku dla wynik�w
	WRITE(*,*)'Podaj nazw� pliku wynik�w'
	READ(*,*)output
	OPEN (unit=1,file=output)
C	------------------G��wny modu� programu----------------------------

C	-------------------------------------------------------------------
C	Operacje ko�cowe
	CLOSE(unit=2);CLOSE(unit=1)
	WRITE(*,*)
	WRITE(*,*)'    CZY ZAKO�CZY� DZIA�ANIE PROGRAMU (t/n)'
	READ(*,*)odp
	END DO

1000	FORMAT(/,'Prosz� wybra� spos�b wprowadzania danych',/,'P - z pliku
     &',/,'R - r�czne wprowadzanie',/,'S - przyk�adowe')
	
	END