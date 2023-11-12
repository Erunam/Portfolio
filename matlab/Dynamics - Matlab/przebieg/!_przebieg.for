	program przebieg

	double precision kv,kf,f(2),k,gamma,beta,da,thetaH,delta(2)
	double precision krok,tauk,sigma(2)
	double precision a(2)
	double precision t(2)
	double precision tau(2)
	double precision fi,temp(3)
		
	open(unit=1,file='data.dat',action='read')
	open(unit=11,file='alfa.dat')
	open(unit=12,file='theta.dat')
	open(unit=13,file='tau.dat')

	read(1,*)kv
	read(1,*)kf
	read(1,*)f(1)
	read(1,*)f(2)
	read(1,*)k
	read(1,*)gamma
	read(1,*)beta
	read(1,*)da
	read(1,*)thetaH
	read(1,*)delta(1)
	read(1,*)delta(2)
	read(1,*)sigma(1)
	read(1,*)sigma(2)
	read(1,*)krok
	read(1,*)tauk
	
	n=(2*tauk/(sigma(1)+sigma(2)))

	read(1,*)a(1)
	read(1,*)a(2)
	read(1,*)t(1)
	read(1,*)t(2)
	read(1,*)tau(1)
	read(1,*)tau(2)

	n=nint(1/krok)

	if (kf .eq. 0.0) then
		do j=1,n
	fi=da*((1-a(1))**1.5)*(exp(gamma*(t(1)*beta/(1+t(1)*beta))))
	
	t(1)=t(1)+(fi+delta(1)*(thetaH-t(1)))*sigma(1)*krok
	a(1)=a(1)+fi*sigma(1)*krok
	tau(1)=tau(1)+sigma(1)*krok
		enddo

          a(2)=(1/k)*f(1)*a(1)
          t(2)=(1/k)*f(1)*a(1)
          tau(2)=tau(1)
	    a(1)=k*f(2)*a(2)
          t(1)=k*f(2)*t(2)
          tau(1)=tau(2)

	elseif (kf .eq. 1.0)then
		do j=1,n
	fi=da*((1-a(2))**1.5)*(exp(gamma*(t(2)*beta/(1+t(2)*beta))))
	
	t(2)=t(2)+(fi+delta(2)*(thetaH-t(2)))*sigma(2)*krok
	a(2)=a(2)+fi*sigma(2)*krok
	tau(2)=tau(2)+sigma(2)*krok
		enddo
	    
		a(1)=k*f(2)*a(2)
          t(1)=k*f(2)*t(2)
          tau(1)=tau(2)
          a(2)=(1/k)*f(1)*a(1)
          t(2)=(1/k)*f(1)*a(1)
          tau(2)=tau(1)
		
	end if

C	warunek brzegowy ------------
c	    temp(1)=a(1);temp(2)=t(1);temp(3)=tau(1)
c	    a(1)=k*f(2)*a(2)
c         t(1)=k*f(2)*t(2)
c         tau(1)=tau(2)
c         a(2)=(1/k)*f(1)*temp(1)
c         t(2)=(1/k)*f(1)*temp(2)
c         tau(2)=temp(3)
C	---------------- ------------


	do while ((tau(1) < tauk) .and. (tau(2) < tauk))

	do i=1,2
		do j=1,n

	fi=da*((1-a(i))**1.5)*(exp(gamma*(t(i)*beta/(1+t(i)*beta))))
	
	t(i)=t(i)+(fi+delta(i)*(thetaH-t(i)))*sigma(i)*krok
	a(i)=a(i)+fi*sigma(i)*krok
	tau(i)=tau(i)+sigma(i)*krok

		enddo

	enddo
	if (kf .eq. 0.0) then
C	warunek brzegowy ------------
	    temp(1)=a(1);temp(2)=t(1);temp(3)=tau(1)
	    a(1)=k*f(2)*a(2)
          t(1)=k*f(2)*t(2)
          tau(1)=tau(2)
          a(2)=(1/k)*f(1)*temp(1)
          t(2)=(1/k)*f(1)*temp(2)
          tau(2)=temp(3)
C	---------------- ------------
	elseif (kf .eq. 1.0)then
C	warunek brzegowy ------------
	    temp(1)=a(1);temp(2)=t(1);temp(3)=tau(1)
	    a(1)=k*f(2)*a(2)
          t(1)=k*f(2)*t(2)
          tau(1)=tau(2)
          a(2)=(1/k)*f(1)*temp(1)
          t(2)=(1/k)*f(1)*temp(2)
          tau(2)=temp(3)
C	---------------- ------------

	end if

	write(11,1)a
	write(12,1)t
	write(13,1)tau

C	warunek brzegowy ------------
	    temp(1)=a(1);temp(2)=t(1);temp(3)=tau(1)
	    a(1)=k*f(2)*a(2)
          t(1)=k*f(2)*t(2)
          tau(1)=tau(2)
          a(2)=(1/k)*f(1)*temp(1)
          t(2)=(1/k)*f(1)*temp(2)
          tau(2)=temp(3)
C	---------------- ------------
	end do

	close(1)
	close(11)
	close(12)
	close(13)

1	format(2x,f16.8,6x,f16.8)

	end