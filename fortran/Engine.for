	PROGRAM engine

	CHARACTER*64 odp,input,output
	
C	G³ówna pêtla programu
	DO WHILE (odp .NE. 't')
	
C	Wybór sposobu wprowadzania danych
	WRITE(*,1000)
	READ(*,*)odp
	
C	Wczytanie danych
	SELECT CASE (odp)
		CASE ('P','p')
			WRITE(*,*)'   Podaj nazwê pliku'
			READ(*,*)input
			OPEN(unit=2,file=input)
			
		CASE ('R','r')

		CASE DEFAULT
		
	END SELECT
C	Otwarcie pliku dla wyników
	WRITE(*,*)'Podaj nazwê pliku wyników'
	READ(*,*)output
	OPEN (unit=1,file=output)
C	------------------G³ówny modu³ programu----------------------------

C	-------------------------------------------------------------------
C	Operacje koñcowe
	CLOSE(unit=2);CLOSE(unit=1)
	WRITE(*,*)
	WRITE(*,*)'    CZY ZAKOÑCZYÆ DZIA£ANIE PROGRAMU (t/n)'
	READ(*,*)odp
	END DO

1000	FORMAT(/,'Proszê wybraæ sposób wprowadzania danych',/,'P - z pliku
     &',/,'R - rêczne wprowadzanie',/,'S - przyk³adowe')
	
	END