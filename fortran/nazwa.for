	SUBROUTINE NAZWA(name,nn)
	
	CHARACTER*16 name(nn)

	k=48;l=48
	DO I=1,nx
		name(i)='    x'//CHAR(k)//CHAR(l)//
		l=l+1
		IF (l .eq. 57) THEN
			l=48
			k=k+1
		END IF
	END DO
	END