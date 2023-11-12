	program schody

	DOUBLE PRECISION a(2),t(2),tau(2)
	

	open(unit=20,file='n.dat',action='read')
	open(unit=21,file='alfa.dat',action='read')
	open(unit=22,file='theta.dat',action='read')
	open(unit=23,file='tau.dat',action='read')
	
	open(unit=31,file='alfasc.dat')
	open(unit=32,file='thetasc.dat')
	open(unit=33,file='tausc.dat')

	read(20,*)q
	
	n=nint(q)
		
		read(23,*)tau
		write(33,1)tau
	do i=1,n-2
		read(21,*)a
		read(22,*)t
		read(23,*)tau
		
		write(31,1)a
		write(32,1)t
		write(33,1)tau

		write(31,1)a
		write(32,1)t
		write(33,1)tau
	end do
		read(21,*)a
		read(22,*)t
		write(31,1)a
		write(32,1)t
	
	close(20)
	close(21)
	close(22)
	close(23)
	close(31)
	close(32)
	close(33)

1	format(2x,f10.6,6x,f10.6)

	end