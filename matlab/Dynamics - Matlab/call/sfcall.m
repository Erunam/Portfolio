function varargout=sfcall(h,hdl)

global par
global pathes fig zmiana_par
global sym faz fa ft sym2 faz2 fa2 ft2

switch h
case hdl.r_dodaj
    return
    %cla
case hdl.sl_zmiana
    set(hdl.e_zmiana,'string',num2str(get(h,'value')))
case hdl.e_zmiana
    set(hdl.sl_zmiana,'value',str2num(get(h,'string')))
case hdl.b_go
    val=get(hdl.sl_zmiana,'value')
    switch zmiana_par
    case 'f1'
        par.f(1)=val
        cd(pathes.dynamika)
    case 'f2'
        par.f(2)=val
        cd(pathes.dynamika)
    case 'delta1'
        par.delta(1)=val
        cd(pathes.dynamika)
    case 'delta2'
        par.delta(2)=val
        cd(pathes.dynamika)
    otherwise       
    par=setfield(par,zmiana_par,val)
    cd(pathes.dynamika)
    end
    if (isfield(hdl,'fazowy')==1)
        fazowy
    elseif (isfield(hdl,'portret')==1)
        portret
    else
        symulacja
    end
case hdl.b_fazowy
    cd(pathes.dynamika)
    fazowy
case hdl.e_stab
    cd(pathes.dynamika)
    if (isfield(hdl,'fazowy')==1)
        fazwykres
    else
        swykres
    end
case hdl.e_tauk
    par.tauk=str2num(get(h,'string'))
otherwise
    return
end
    