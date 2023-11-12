% function varargout = MoppyHomo(varargin)
clear all;

global pathes
global fig
global parameter 
global variables 
global par_bif
global worktype

pathes.main=cd;
cd gui;
pathes.gui=cd;
cd ..;
cd runtime;
pathes.runtime=cd;
cd ..;
cd results;
pathes.results=cd;
cd ..;
cd user;
pathes.user=cd;
cd ..;
cd data;
pathes.data=cd;
cd ..;
cd simulation
pathes.simulation=cd;
cd ..;
cd poincare;
pathes.poincare=cd;
cd ..;
cd feigenbaum;
pathes.feigenbaum=cd;
cd ..;

cd(pathes.gui);
fig.main=openfig('MoppyHomo.fig','reuse');
cd (pathes.runtime);

par_bif = getparbif(guihandles(fig.main));
