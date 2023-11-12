function przeb=bifdos(przeb)

global par
global zmiana param

fid=fopen('data.dat','w+')
fprintf(fid,'%f \n',...
    [par.Kv par.Kf...
        par.f(1) par.f(2) par.k...
        par.gamma par.beta par.da...
        par.thetaH par.delta(1) par.delta(2)...
        par.sigma(1) par.sigma(2)...
        par.krok par.tauk])
fprintf(fid,'%f \n',...
    [przeb.alfa0(1) przeb.alfa0(2)...
        przeb.theta0(1) przeb.theta0(2)])
fprintf(fid,'%f \n',...
    [zmiana(1) zmiana(2) zmiana(3)...
     param(1) param(2) param(3)])

fclose(fid)

przeb=struct2cell(przeb)

! bifurkacja.exe

fid=fopen('alfabif.dat','r')
    przeb{1}=fscanf(fid,'%f %f',[2 inf])
fclose(fid)
fid=fopen('thetabif.dat','r')
    przeb{2}=fscanf(fid,'%f %f',[2 inf])
fclose(fid)
fid=fopen('parbif.dat','r')
    przeb{3}=fscanf(fid,'%f %f',[2 inf])
fclose(fid)
przeb{1}=przeb{1}'
przeb{2}=przeb{2}'
przeb{3}=przeb{3}'