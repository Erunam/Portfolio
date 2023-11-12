	subroutine calka1(a,t)

	double precision kv,kf,fr(2),kr,gamma,beta,da,thetaH,delta(2)
	double precision krok,tauk,sigma(2)

	double precision a(2),t(2)

	common /par/ kv,kf,fr,kr,gamma,beta,da,thetaH,delta
	common /par2/ krok,tauk,sigma

	n=(2*tauk/(sigma(1)+sigma(2)))
	n=nint(1/krok)
	
	do i=1,2
		do j=1,n

	fi=da*((1-a(i))**1.5)*(exp(gamma*(t(i)*beta/(1+t(i)*beta))))
	
	t(i)=t(i)+(fi+delta(i)*(thetaH-t(i)))*sigma(i)*krok
	a(i)=a(i)+fi*sigma(i)*krok
		
		enddo
	enddo
	
	end