function varargout=bifurkacja(varargin)

global par zm start pb
global fig pathes zmiana_par
global pocz kon czas krok
global ba bt ba2 bt2
global param zmiana

pb=[]
zm=[]

cd(pathes.gui)
dial=openfig('dialog.fig','new')
d=guihandles(dial)

set(d.t_zmiana,'string',zmiana_par)

cd(pathes.call)

waitfor(d.baton,'value',1.0)

zmiana=[str2num(get(d.e_zmianapocz,'string')) ...
        str2num(get(d.e_zmianakon,'string')) ...
        str2num(get(d.e_krok,'string'))]
zmiana(3)=(zmiana(2)-zmiana(1))/zmiana(3)
if (zmiana(1)==zmiana(2))
    start.alfa0=[...
            str2num(get(ba.e_stac,'string')) ...
            str2num(get(ba2.e_stac,'string'))]
    start.theta0=[...
            str2num(get(bt.e_stac,'string')) ...
            str2num(get(bt2.e_stac,'string'))]
    start.alfa0=[...
            str2num(get(ba.e_stac,'string')) ...
            str2num(get(ba2.e_stac,'string'))]
    zmiana(1)=str2num(get(bt.e_bifur,'string'))
    zmiana(3)=1/zmiana(3)
end

close(dial)
cd(pathes.wyniki)
%
    k=exist(zmiana_par)
if (k~=7)
    eval(['mkdir ' zmiana_par])
end

cd(zmiana_par)

name='bifurkacje'

k=exist(name)
if (k~=7)
    eval(['mkdir ' name])
end
%

    cd(name)
    
    namefolder=strcat(num2str(start.alfa0(1)),num2str(start.alfa0(2)),num2str(start.theta0(1)),...
        num2str(zmiana(1)),'_',num2str(zmiana(2)),'_',num2str(zmiana(3)))

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

tic
    
    zm=bifdos(start)

czas=toc

zm=zm'
    
cd(pathes.zmiana)
eval(['save ' zmiana_par ' zm'])
save dynamika par start zmiana_par
save zak_param zmiana param
save data pathes 

cd(pathes.dynamika)
bwykres