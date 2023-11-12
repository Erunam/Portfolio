function varargout=loadsave(h,hdl)
%LOADSAVE Summary of this function goes here
%  Detailed explanation goes here
global par start
global pathes fig zmiana_par
global zm sym faz sym2 faz2
global fa ft pb fa2 ft2

switch h
case hdl.b_wczytaj
    cd(pathes.wyniki)
    [filename filepath]=uigetfile
    cd(filepath)
    load(filename)
    load('data.mat')
    load('dynamika.mat')
    load('zakres.mat')
    cd(pathes.dynamika)
    fwykres
    cd(pathes.call)
    
case hdl.b_zapisz
    cd(pathes.wyniki)

    k=exist(zmiana_par)
if (k~=7)
    eval(['mkdir ' zmiana_par])
end
    cd(zmiana_par) 
    k=exist(get(get(h,'parent'),'tag'))
if (k~=7)
    eval(['mkdir ' (get(get(h,'parent'),'tag'))])
end
    cd(get(get(h,'parent'),'tag'))

    name=get(get(h,'parent'),'name')
    name=strrep(name,'Diagram Feigenbauma - ','_')
    
    name=strcat(get(get(h,'parent'),'tag'),name,'_',zmiana_par)

    name=strrep(name,'.','_')
    name=strrep(name,'-','m_')
    name=strrep(name,'+','p_')
    
    saveas(gcf,name,'tif')
%    printdlg('-crossplatform',gcf)
    cd(pathes.call)
end
cd(pathes.call)