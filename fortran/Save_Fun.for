	SUBROUTINE SAVE_FUN(pocz,fun,nx)
C	------------------------------------------------------------
C	Procedura zapisuje dane do pliku
C	------------------------------------------------------------
	DOUBLE PRECISION pocz(nx),fun

	WRITE(1,999)pocz,fun
	WRITE(1,*)'-------------------------------------------------
     &----------------------------'
999	FORMAT('�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�'
     &,EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,
     &'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1
     &,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.
     &1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10
     &.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN1
     &0.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',
     &EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�'
     &,EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�',EN10.1,'�')

     	END