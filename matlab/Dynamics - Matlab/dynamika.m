% function varargout=dynamika(varargin)
clear all

global par zm start pb
global fig pathes zmiana_par
global sym faz sym2 faz2
global fa ft fa2 ft2
global ba ba2 bt bt2
global param
global prt prt2

zmiana_par='thetaH'

pathes.dynamika=cd
cd gui
pathes.gui=cd
cd ..
cd call
pathes.call=cd
cd ..
cd wyniki
pathes.wyniki=cd
cd ..
cd przebieg
pathes.przebieg=cd
cd ..
cd data
pathes.data=cd
cd ..

cd(pathes.gui)
fig.dynamika=openfig('dynamika.fig','new')
cd (pathes.call)    
