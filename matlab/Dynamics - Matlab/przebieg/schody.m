function y=schody(x)

global pathes

max=size(x{1})

fid=fopen('n.dat','w+')
fprintf(fid,'%f \n',max(1))
fclose(fid)

!schody.exe

fid=fopen('alfasc.dat','r')
    y{1}=fscanf(fid,'%f %f',[2 inf])
fclose(fid)
fid=fopen('thetasc.dat','r')
    y{2}=fscanf(fid,'%f %f %f',[2 inf])
fclose(fid)
fid=fopen('tausc.dat','r')
    y{3}=fscanf(fid,'%f %f %f',[2 inf])
fclose(fid)

y{1}=y{1}'
y{2}=y{2}'
y{3}=y{3}'

