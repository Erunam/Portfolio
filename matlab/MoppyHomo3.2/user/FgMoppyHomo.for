	program MoppyHomo

	double precision a(2),ap,t(2),tp,x(2),tau(2),czas
	double precision par(11),eta(2)
	double precision dx(2),dt(2),tauP,tauS
	double precision S1,S2,W1,W2,eps,fi,exponen
	double precision tmpa,tmpt,tmptau
	double precision af,tf,a0(2),t0(2),as(2),ts(2)
	double precision bifstart,bifstop,bifstep
	integer n(2),guide,m,k
      integer bn,bifcount

	open(unit=1,file='data.dat',action='read')
	open(unit=11,file='reaktorA.dat')
	open(unit=12,file='reaktorB.dat')
	open(unit=13,file='output.dat')
	
	read(1,*)par(1)		!kv
	read(1,*)par(2)		!q
	read(1,*)par(3)		!f1
	read(1,*)par(4)		!f2
	read(1,*)par(5)		!Da
	read(1,*)par(6)		!gama
	read(1,*)par(7)		!beta
	read(1,*)par(8)		!th
	read(1,*)par(9)		!delta
	read(1,*)par(10)	!eta
	read(1,*)par(11)	!xn
	read(1,*)n(1)
	read(1,*)n(2)
	read(1,*)a(1)
	read(1,*)t(1)
	read(1,*)a(2)
	read(1,*)t(2)
	read(1,*)af
	read(1,*)tf
	read(1,*)tauP
	read(1,*)tauS

      read(1,*)bifstart
      read(1,*)bifstop
      read(1,*)bifcount
      read(1,*)bn

c		guide = 1
		
c		a0 = a
c		t0 = t
c		tau = 0.0
c		dx(1) = 1.0/n(1)
c		dx(2) = 1.0/n(2)
c		czas = 0.0
        
        if (bifcount .lt. 1) then
            bifcount = 1
        end if
        
	    par(bn) = bifstart
		bifstep = (bifstop-bifstart)/(bifcount)
	
		as = a
		ts = t        
      
	do l=1,bifcount+1

		a = as
		t = ts

		eps = par(1)/(1.0-(par(1)))
		S1 = (1.0-par(3)*par(4))/(par(2)+par(4)*(1.0-par(2)))
		S2 = (1.0-par(3)*par(4))/(1.0-par(2)+par(3)*par(2))
c	(q+par(4)*(1.0-q))/(1.0-q+par(3)*q)
		W1 = S1/S2
c	(1.0-q+par(3)*q)/(q+par(4)*(1.0-q)
		W2 = S2/S1

	if(eps*W1 .lt. 1.0) then
		m = 2
		k = 1
	else
		m = 1
		k = 2
	end if
		guide = 1

		a0 = a
		t0 = t
		tau = 0.0
		dx(1) = 1.0/n(1)
		dx(2) = 1.0/n(2)
		czas = 0.0

	do while (czas .lt. tauS)
		do i=1,n(1)
	exponen = dexp((par(6)*par(7)*t(1))/(1.0+par(7)*t(1)))
	fi = par(5)*exponen*((1.0-a(1))**par(11))
	a(1) = a(1)+S1*fi*dx(1)
	t(1) = t(1)+S1*(fi+par(9)*(par(8)-t(1)))*dx(1)
c	x(1) = x(1)+dx(1)
		end do
		do i=1,n(2)
	exponen = dexp((par(6)*par(7)*t(2))/(1.0+par(7)*t(2)))
	fi = par(5)*exponen*((1.0-a(2))**par(11))
	a(2) = a(2)+eps*S2*fi*dx(2)
	t(2) = t(2)+eps*S2*(fi+(par(9)/par(10))*(par(8)-t(2)))*dx(2)
c	x(2) = x(2)+dx(2)
		end do

			tau(1) = tau(1) + 1.0
			tau(2) = tau(2) + eps*W1*1.0
			
			czas = tau(1)
		if (czas .gt. tauP) then
					write(11,1000)par(bn),a(1),t(1)
					write(12,1000)par(bn),a(2),t(2)
			if(eps*W1 .eq. 1) then
					ap = ((1-par(3))/S1)*a(1)+((1-par(4))/S2)*a(2)
					tp = ((1-par(3))/S1)*t(1)+((1-par(4))/S2)*t(2)
					czas = tau(1)
					write(13,1000)par(bn),ap,tp
			else
					a0(m) = a(m)
					t0(m) = t(m)
				if (mod(guide,2) .ne. 0) then
					ap = ((1-par(3))/S1)*a0(1)+((1-par(4))/S2)*a0(2)
					tp = ((1-par(3))/S1)*t0(1)+((1-par(4))/S2)*t0(2)
					czas = tau(m)
					write(13,1000)par(bn),ap,tp
				end if
					ap = ((1-par(3))/S1)*a(1)+((1-par(4))/S2)*a(2)
					tp = ((1-par(3))/S1)*t(1)+((1-par(4))/S2)*t(2)
					czas = tau(k)
        				write(13,1000)par(bn),ap,tp
			end if
		end if
					a0 = a
					t0 = t
					guide = guide +1

	! warunki brzegowe
		tmptau = tau(2)
		tmpa = a(2)
		tmpt = t(2)
	
		a(2) = par(4)*W2*a(1)
		t(2) = par(4)*W2*t(1)
		tau(2) = tau(1)
		a(1) = par(3)*W1*tmpa
		t(1) = par(3)*W1*tmpt
		tau(1) = tmptau

	end do
          par(bn) = par(bn) + bifstep
      end do

	close(unit=1)
	close(unit=11)
	close(unit=12)
	close(unit=13)


1000	format(f16.12,4x,f16.12,4x,f16.12)
1001	format(f16.12,4x,f16.12)	

	end
