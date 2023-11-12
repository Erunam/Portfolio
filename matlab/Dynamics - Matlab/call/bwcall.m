function varargout=bwcall(h,hdl)

global par zm start pb
global fig pathes zmiana_par
global sym faz sym2 faz2
global pocz kon czas krok
global fa ft fa2 ft2
global ch
global ba ba2 bt bt2
global zmiana param

switch h
case hdl.e_eps
    set(ba.e_eps,'string',get(h,'string'))
    set(ba2.e_eps,'string',get(h,'string'))
    set(bt.e_eps,'string',get(h,'string'))
    set(bt2.e_dkl,'string',get(h,'string'))
case hdl.e_dkl
    set(ba.e_dkl,'string',get(h,'string'))
    set(ba2.e_dkl,'string',get(h,'string'))
    set(bt.e_dkl,'string',get(h,'string'))
    set(bt2.e_dkl,'string',get(h,'string'))
case hdl.e_poz
    set(ba.e_poz,'string',get(h,'string'))
    set(ba2.e_poz,'string',get(h,'string'))
    set(bt.e_poz,'string',get(h,'string'))
    set(bt2.e_poz,'string',get(h,'string'))
case hdl.r_dodaj
%    ch=allchild(hdl.axes)
    delete(ch)
case hdl.b_nowy
    param(1)=str2num(get(hdl.e_eps,'string'))
    param(2)=str2num(get(hdl.e_dkl,'string'))
    param(3)=str2num(get(hdl.e_poz,'string'))
    
    cd(pathes.dynamika)
    bifurkacja
case hdl.b_wczytaj
    cd(pathes.wyniki)
    [filename filepath]=uigetfile
    cd(filepath)
    load(filename)
    load('dynamika.mat')
    load('zak_param.mat')
    load('data.mat')
    
    cd(pathes.dynamika)
    bwykres
    cd(pathes.call)
end
cd(pathes.call)