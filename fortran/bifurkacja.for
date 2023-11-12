	program bifurkacja	
	!
	!program dla petli histerezy thetaH i Kv
	!
	double precision kv,kf,f(2),k,gamma,beta,da,thetaH,delta(2)
	double precision krok,tauk,sigma(2)
	double precision a(2)
	double precision t(2)
	double precision fi
	double precision pk,pj,p,dp,pn
	double precision y(4),yn(4),dy(4),dymin,eps
	integer iter,wsk

	common /par/ kv,kf,f,k,gamma,beta,da,thetaH,delta
	common /par2/ krok,tauk,sigma

	open(unit=1,file='data.dat',action='read')
	open(unit=11,file='alfabif.dat')
	open(unit=12,file='thetabif.dat')
	open(unit=13,file='parbif.dat')

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

	read(1,*)a(1)
	read(1,*)a(2)
	read(1,*)t(1)
	read(1,*)t(2)

	read(1,*)p
	read(1,*)pk
	read(1,*)dp
	
	read(1,*)eps
	read(1,*)dkl
	read(1,*)poz

	y(1)=a(1)
	y(2)=t(1)
	y(3)=a(2)
	y(4)=t(2)	
	n=0

		thetaH=p	
	call newton(y,4,dkl,iter)
c	---------------------------------------	
		write(11,2000)y(1),y(3)
		write(12,2000)y(2),y(4)
		write(13,2000)p,p
c	---------------------------------------

		pn=p+dp
	
		thetaH=pn
		do i=1,4
			yn(i)=y(i)
		end do		
	call newton(yn,4,dkl,iter)

	pk=abs(p)+abs(pk-p)
	pj=abs(p)
			
	do while((pj-pk) .lt. 0.0)
		wsk=0		
c	---------------------------------------	
		write(11,2000)y(1),y(3)
		write(12,2000)y(2),y(4)
		write(13,2000)p,p
c	---------------------------------------
		do i=1,4
			dy(i)=(yn(i)-y(i))/(pn-p)
			y(i)=yn(i)
		end do
		p=pn

		dymin=dy(1)
		kk=1
		do i=1,4
			if (dymin .gt. dy(i)) then
				dymin=dy(i)
				kk=i
			end if
		end do
				
		do while(wsk .eq. 0)
			wsk=1
			pn=p+dp
			do i=1,4
				yn(i)=y(i)+dy(i)*(pn-p)	
			end do
			
			thetaH=pn			
			call newton(yn,4,dkl,iter)
	
				if (abs(yn(kk)-y(kk)) .gt. eps) then
					proba=cos(atan(dymin))
					dp=proba*dp/poz
					wsk=0
				elseif (abs(yn(kk)-y(kk)) .lt. eps/100) then
					dp=(0.1*cos(atan(dymin))+1)*dp
					wsk=1
				end if

				if ((yn(kk)-y(kk)/dp) .gt. 5500000.0) then

				do i=1,4
					y(i)=y(i)+sign(eps,yn(i)-y(i))
				end do
					dp=-dp
					write(*,*)'trap1'
					n=n+1
	if(n .gt. 5) then
					stop
	end if

				end if

		end do

		write(*,*)p,y(4),dp
		pj=pj+abs(dp)*((-1)**(n+1))
	end do

c	call contin(x,ppocz,pkrok,pkon,4)

	close(unit=1)
	close(unit=11)
	close(unit=12)
	close(unit=13)

2000	FORMAT(5x,f24.20,5x,f24.20)
	end