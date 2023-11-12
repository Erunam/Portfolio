function varargout=fwcall(h,hdl)

global par zm start pb
global fig pathes zmiana_par
global sym faz sym2 faz2
global pocz kon czas krok
global fa ft fa2 ft2
global ch

switch h
case hdl.e_stab
    set(fa.e_stab,'string',get(h,'string'))
    set(fa2.e_stab,'string',get(h,'string'))
    set(ft.e_stab,'string',get(h,'string'))
    set(ft2.e_stab,'string',get(h,'string'))
%    delete(ch)
 %   cd(pathes.dynamika)
  %  fwykres
case hdl.r_dodaj
%    ch=allchild(hdl.axes)
 %   delete(ch)
 cla
case hdl.b_nowy
    cd(pathes.dynamika)
    feigenbaum
case hdl.e_tauk
    par.tauk=str2num(get(h,'string'))
    set(fa.e_tauk,'string',get(h,'string'))
    set(fa2.e_tauk,'string',get(h,'string'))
    set(ft.e_tauk,'string',get(h,'string'))
    set(ft2.e_tauk,'string',get(h,'string'))

end
cd(pathes.call)