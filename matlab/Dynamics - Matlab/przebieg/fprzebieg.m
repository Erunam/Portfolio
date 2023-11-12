function przeb=fprzebieg(przeb)

global par

    par.sigma(1)=par.Kv*(1-par.f(1)*par.f(2))/(par.Kf+par.f(2)*(1-par.Kf))
    par.sigma(2)=(1-par.Kv)*(1-par.f(1)*par.f(2))/((1-par.Kf)+par.f(1)*par.Kf)
    par.k=(1-par.Kf+par.f(1)*par.Kf)/(par.Kf+par.f(2)-par.Kf*par.f(2))


fid=fopen('data.dat','w+')                          % otwiera plik 'data.dat' jako do zapisu 'w+' i nadaje mu numer fid
fprintf(fid,'%f \n',...                             % zapisuje do pliku o numerze fid dane
    [par.Kv par.Kf...
        par.f(1) par.f(2) par.k...
        par.gamma par.beta par.da...
        par.thetaH par.delta(1) par.delta(2)...
        par.sigma(1) par.sigma(2)...
        par.krok par.tauk])
fprintf(fid,'%f \n',...
    [przeb.alfa0(1) przeb.alfa0(2)...
        przeb.theta0(1) przeb.theta0(2)...
        przeb.czas(1) przeb.czas(2)])
fclose(fid)                                         %zamyka plik o numerze fid

przeb=struct2cell(przeb)

! fprzebieg.exe

fid=fopen('alfa.dat','r')
    przeb{1}=fscanf(fid,'%f %f',[2 inf])            % odczytuje plik o numerze fid format '%f %f'(liczby rzeczywiste) [liczba kolumn inf]
fclose(fid)
fid=fopen('theta.dat','r')
    przeb{2}=fscanf(fid,'%f %f %f',[2 inf])
fclose(fid)
fid=fopen('tau.dat','r')
    przeb{3}=fscanf(fid,'%f %f %f',[2 inf])
fclose(fid)
przeb{1}=przeb{1}'
przeb{2}=przeb{2}'
przeb{3}=przeb{3}'