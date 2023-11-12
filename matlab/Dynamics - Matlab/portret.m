function varargout=portret(varargin)

global par zm start pb
global fig pathes zmiana_par
global sym faz sym2 faz2
global fa ft fa2 ft2
global ba ba2 bt bt2
global param czas
global prt prt2

zm=[]

cd(pathes.gui)
fig.prt=openfig('portret.fig','reuse')
prt=guihandles(fig.prt)
fig.prt2=openfig('portret2.fig','reuse')
prt2=guihandles(fig.prt2)

    par.sigma(1)=par.Kv*(1-par.f(1)*par.f(2))/(par.Kf+par.f(2)*(1-par.Kf))
    par.sigma(2)=(1-par.Kv)*(1-par.f(1)*par.f(2))/((1-par.Kf)+par.f(1)*par.Kf)
    par.k=(1-par.Kf+par.f(1)*par.Kf)/(par.Kf+par.f(2)-par.Kf*par.f(2))

cd(pathes.dynamika)

ustawprt

tic

cd(pathes.przebieg)
for i=1:4
    for j=1:11
switch i
case 1
    k=0.0
    l=(j-1)*0.1
case 2
    k=1.0
    l=(j-1)*0.1
case 3
    k=(j-1)*0.1
    l=0.0
case 4
    k=(j-1)*0.1
    l=1.0
end
    zm{i,j}{1}=[k k]
    zm{i,j}{2}=[l l]
    
    fid=fopen('data.dat','w+')
    fprintf(fid,'%f \n',...
    [par.Kv par.Kf...
        par.f(1) par.f(2) par.k...
        par.gamma par.beta par.da...
        par.thetaH par.delta(1) par.delta(2)...
        par.sigma(1) par.sigma(2)...
        par.krok par.tauk])
    fprintf(fid,'%f \n',...
    [zm{i,j}{1}(1,1) zm{i,j}{1}(1,2)...
     zm{i,j}{2}(1,1) zm{i,j}{2}(1,2)...
     0 0])
    fclose(fid)

! prtprzebieg.exe

    fid=fopen('alfa.dat','r')
    zm{i,j}{1}=fscanf(fid,'%f %f',[2 inf])
    zm{i,j}{1}=zm{i,j}{1}'
    fclose(fid)
    fid=fopen('theta.dat','r')
    zm{i,j}{2}=fscanf(fid,'%f %f',[2 inf])
    zm{i,j}{2}=zm{i,j}{2}'
    fclose(fid)
    
    end
end

czas=toc
cd(pathes.wyniki)
cd portret

name=get(prt.e_zmiana,'string')
name=strcat(zmiana_par,name)
name=strrep(name,'-','m_')
name=strrep(name,'.','_')

eval(['save ' name ' zm'])
save dynamika par start zmiana_par
save data pathes czas
save zakres czas czas czas

cd(pathes.dynamika)
pwykres