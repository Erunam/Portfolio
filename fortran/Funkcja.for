	SUBROUTINE FUNKCJA(x,fun,n,m)
C	--------------------------------------------
C	Procedura oblicza wartoœci funkji w punkcie
C		x(n) - wektor wspó³rzêdnych punktu
C		f(m) - wektor wartoœci funkcji
C		n - liczba zmiennych funkcji
C		m - liczba funkcji
C	--------------------------------------------
	DOUBLE PRECISION x(n),fun(n)
	double precision a(2),t(2),temp(2)
	
	double precision kv,kf,f(2),k,gamma,beta,da,thetaH,delta(2)
	double precision krok,tauk,sigma(2)
	common /par/ kv,kf,f,k,gamma,beta,da,thetaH,delta
	common /par2/ krok,tauk,sigma

	a(1)=x(1)
	a(2)=x(3)
	t(1)=x(2)
	t(2)=x(4)
	
C	------------DEFINICJE FUNKCJI---------------	
C	warunek brzegowy ------------
		temp(1)=a(1);temp(2)=t(1)
		a(1)=k*f(2)*a(2)
          t(1)=k*f(2)*t(2)
          
          a(2)=(1/k)*f(1)*temp(1)
          t(2)=(1/k)*f(1)*temp(2)          
C	---------------- ------------
	call calka(a,t)

	fun(1)=a(1)-x(1)
	fun(2)=t(1)-x(2)
	fun(3)=a(2)-x(3)
	fun(4)=t(2)-x(4)

C	--------------------------------------------
	END SUBROUTINE
	
	subroutine calka(a,t)

	double precision kv,kf,f(2),k,gamma,beta,da,thetaH,delta(2)
	double precision krok,tauk,sigma(2)

	double precision a(2),t(2)

	common /par/ kv,kf,f,k,gamma,beta,da,thetaH,delta
	common /par2/ krok,tauk,sigma

	n=(2*tauk/(sigma(1)+sigma(2)))
	n=nint(1/krok)
	
	do i=1,2
		do j=1,n

	fi=da*((1-a(i))**1.5)*(dexp(gamma*(t(i)*beta/(1.D0+t(i)*beta))))
	
	t(i)=t(i)+(fi+delta(i)*(thetaH-t(i)))*sigma(i)*krok
	a(i)=a(i)+fi*sigma(i)*krok
		
		enddo
	enddo
	
	end