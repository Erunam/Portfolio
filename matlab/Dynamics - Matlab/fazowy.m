function varargout = fazowy(varargin)
% odpowiada za tworzenie okien z wykresami symulacyjnymi
% skad=0 zawsze gdy mamy dane ze schodami

global par start
global pathes fig zmiana_par
global zm sym faz sym2 faz2 sym2
global czas

zm=[0]

cd(pathes.gui)
fig.faz=openfig('fazowy.fig','reuse')
faz=guihandles(fig.faz)
fig.faz2=openfig('fazowy2.fig','reuse')
faz2=guihandles(fig.faz2)

set(faz2.text14,'string','')

cd(pathes.dynamika)

ustawfaz

tic
    
cd(pathes.przebieg)
   
zm=przebieg(start)
    
czas=toc

cd(pathes.dynamika)

fazwykres
    
   