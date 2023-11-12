function varargout=feigenbaum(varargin)

global par zm start pb
global fig pathes zmiana_par
global sym faz sym2 faz2
global pocz kon czas krok
global fa ft fa2 ft2
global ch

zm=[]
pb=[]

cd(pathes.gui)
dial=openfig('dialog.fig','new')
d=guihandles(dial)

set(d.t_zmiana,'string',zmiana_par)

cd(pathes.call)

waitfor(d.baton,'value',1.0)

zmiana=[str2num(get(d.e_zmianapocz,'string')) ...
        str2num(get(d.e_zmianakon,'string')) ...
        str2num(get(d.e_krok,'string'))]

pocz=zmiana(1)
kon=zmiana(2)
krok=(zmiana(2)-zmiana(1))/zmiana(3)

close(dial)
cd(pathes.wyniki)
%
    k=exist(zmiana_par)
if (k~=7)
    eval(['mkdir ' zmiana_par])
end
%
    cd(zmiana_par)
    namefolder=strcat(num2str(start.alfa0(1)),num2str(start.alfa0(2)),num2str(start.theta0(1)),...
        num2str(start.theta0(1)),'_',num2str(pocz),'_',num2str(kon),'_',num2str(krok),'k_',num2str(par.tauk))
    k=exist(namefolder)
if (k==7)
    eval(['cd ' namefolder])
    delete *.*
    cd ..
    eval(['!rmdir ' namefolder])
end

eval(['mkdir ' namefolder])
eval(['cd ' namefolder])
pathes.zmiana=cd

cd (pathes.przebieg)
k=1
n=1

n=round(zmiana(3))+1

for i=1:n
tic
eval(['par.' zmiana_par '=zmiana(1)'])    
    prz=fprzebieg(start)
    
%    prz=schody(prz)
    
    zm{k}=prz
    pb(k,1)=zmiana(1)

    %
%    dsize=size(zm{k}{1})
 %   dsize=round(dsize(1))
  %  start=struct(...
   % 'alfa0',[zm{k}{1}(dsize,1) zm{k}{1}(dsize,2)],...
%    'theta0',[zm{k}{2}(dsize,1) zm{k}{2}(dsize,2)],...
 %   'czas',[0 0])
    %
    k=k+1
    zmiana(1)=zmiana(1)+krok

czas=toc
end
ch=k-1
zm=zm'

    
cd(pathes.zmiana)
eval(['save ' zmiana_par ' zm pb'])
save dynamika par start zmiana_par
save zakres pocz krok kon
save data pathes czas

cd(pathes.dynamika)
fwykres
