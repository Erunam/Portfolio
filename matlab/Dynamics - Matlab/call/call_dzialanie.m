function varargout=call_dzialanie(h,hdl)
%
global par start
global pathes fig zmiana_par
global zm sym faz sym2 faz2
global fa ft pb fa2 ft2
global ba ba2 bt bt2
global param
global prt prt2

%
if (h==hdl.b_wczytaj)
    cd(pathes.data)
    [filename filepath]=uigetfile
    cd(filepath)
    load(filename,'par','start','zmiana_par')
    cd(pathes.call)
% wyswietla parametry
    set(hdl.e_Kv,'string',num2str(par.Kv))
    set(hdl.e_Kf,'string',num2str(par.Kf))
    set(hdl.e_f1,'string',num2str(par.f(1)))
    set(hdl.e_f2,'string',num2str(par.f(2)))
    set(hdl.e_k,'string',num2str(par.k))
    set(hdl.e_gamma,'string',num2str(par.gamma))
    set(hdl.e_beta,'string',num2str(par.beta))
    set(hdl.e_da,'string',num2str(par.da))
    set(hdl.e_thetaH,'string',num2str(par.thetaH))
    set(hdl.e_delta1,'string',num2str(par.delta(1)))
    set(hdl.e_delta2,'string',num2str(par.delta(2)))
    set(hdl.e_sigma1,'string',num2str(par.sigma(1)))
    set(hdl.e_sigma2,'string',num2str(par.sigma(2)))
    set(hdl.e_krok,'string',num2str(par.krok))    
    set(hdl.e_tauk,'string',num2str(par.tauk))
% wyswietla startowe
    set(hdl.e_alfa10,'string',num2str(start.alfa0(1)))
    set(hdl.e_alfa20,'string',num2str(start.alfa0(2)))
    set(hdl.e_theta10,'string',num2str(start.theta0(1)))
    set(hdl.e_theta20,'string',num2str(start.theta0(2)))
   
% koniec

end
%
if any (h==[hdl.b_zapisz hdl.b_symulacja hdl.b_fazowe hdl.b_bif hdl.b_portret])
% pobiera parametry
    par=struct(...
    'Kv',str2num(get(hdl.e_Kv,'string')),...
    'Kf',str2num(get(hdl.e_Kf,'string')),...
    'f',[str2num(get(hdl.e_f1,'string')) str2num(get(hdl.e_f2,'string'))],...
    'k',str2num(get(hdl.e_k,'string')),...
    'gamma',str2num(get(hdl.e_gamma,'string')),...
    'beta',str2num(get(hdl.e_beta,'string')),...
    'da',str2num(get(hdl.e_da,'string')),...
    'thetaH',str2num(get(hdl.e_thetaH,'string')),...
    'delta',[str2num(get(hdl.e_delta1,'string')) str2num(get(hdl.e_delta2,'string'))],...
    'sigma',[str2num(get(hdl.e_sigma1,'string')) str2num(get(hdl.e_sigma2,'string'))],...
    'krok',str2num(get(hdl.e_krok,'string')),...
    'tauk',str2num(get(hdl.e_tauk,'string')),...
    'blad',str2num(get(hdl.e_blad,'string'))...
    )
% pobiera startowe
    start=struct(...
    'alfa0',[str2num(get(hdl.e_alfa10,'string')) ...
        str2num(get(hdl.e_alfa20,'string'))],...
    'theta0',[str2num(get(hdl.e_theta10,'string'))... 
        str2num(get(hdl.e_theta20,'string'))],...
    'czas',[0 0]...
    )
%koniec 
end
    
    
% zapis
if (h==hdl.b_zapisz)
    cd(pathes.data)
    [filename filepath]=uiputfile
    cd(filepath)
    save(filename,'par','start','zmiana_par')
    cd(pathes.call)
end
% koniec

% przejscie do liczenia
switch h
case hdl.b_symulacja
    cd(pathes.gui)
    fig.sym=openfig('symulacja.fig','reuse')
    sym=guihandles(fig.sym)
    fig.sym2=openfig('symulacja2.fig','reuse')
    sym2=guihandles(fig.sym2)
    cd(pathes.dynamika)
    symulacja
case hdl.b_fazowe
    cd(pathes.dynamika)
    feigenbaum
case hdl.b_portret
    cd(pathes.dynamika)
    portret
case hdl.b_bif
    cd(pathes.dynamika)
    param(1)=0.0005
    param(2)=9.0
    param(3)=2.0
    bifurkacja
otherwise
    return
end