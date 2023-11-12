function varargout = symulacja(varargin)
% odpowiada za tworzenie okien z wykresami symulacyjnymi

global par start
global pathes fig zmiana_par
global zm sym faz sym2 faz2
global czas

zm=[0]

ustaw
tic

cd(pathes.przebieg)

zm=przebieg(start)
zm=schody(zm)

czas=toc

cd(pathes.dynamika)

swykres
