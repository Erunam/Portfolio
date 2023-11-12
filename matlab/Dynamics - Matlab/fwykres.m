    function varargout=fwykres(varargin)

    global par zm start pb
    global fig pathes zmiana_par
    global sym faz sym2 faz2
    global pocz kon czas krok
    global fa ft fa2 ft2
    global ch

    cd(pathes.gui)
   
    fig.fa=openfig('F_alfa.fig','reuse')
    fa=guihandles(fig.fa)
    fig.ft=openfig('F_theta.fig','reuse')
    ft=guihandles(fig.ft)

    fig.fa2=openfig('F_alfa2.fig','reuse')
    fa2=guihandles(fig.fa2)
    fig.ft2=openfig('F_theta2.fig','reuse')
    ft2=guihandles(fig.ft2)
   
    cd (pathes.dynamika)
    
    eval(['par.' zmiana_par '=pocz'])
    
    set(fa.e_Kv,'string',num2str(par.Kv))
    set(fa.e_Kf,'string',num2str(par.Kf))
    set(fa.e_f1,'string',num2str(par.f(1)))
    set(fa.e_f2,'string',num2str(par.f(2)))
    set(fa.e_k,'string',num2str(par.k))
    set(fa.e_gamma,'string',num2str(par.gamma))
    set(fa.e_beta,'string',num2str(par.beta))
    set(fa.e_da,'string',num2str(par.da))
    set(fa.e_thetaH,'string',num2str(par.thetaH))
    set(fa.e_delta1,'string',num2str(par.delta(1)))
    set(fa.e_delta2,'string',num2str(par.delta(2)))
    set(fa.e_tauk,'string',num2str(par.tauk))
    set(fa.e_zmianapocz,'string',num2str(pocz))
    set(fa.e_zmianakon,'string',num2str(kon))
    set(fa.t_zmiana,'string',zmiana_par)
    
    set(ft.e_Kv,'string',num2str(par.Kv))
    set(ft.e_Kf,'string',num2str(par.Kf))
    set(ft.e_f1,'string',num2str(par.f(1)))
    set(ft.e_f2,'string',num2str(par.f(2)))
    set(ft.e_k,'string',num2str(par.k))
    set(ft.e_gamma,'string',num2str(par.gamma))
    set(ft.e_beta,'string',num2str(par.beta))
    set(ft.e_da,'string',num2str(par.da))
    set(ft.e_thetaH,'string',num2str(par.thetaH))
    set(ft.e_delta1,'string',num2str(par.delta(1)))
    set(ft.e_delta2,'string',num2str(par.delta(2)))
    set(ft.e_tauk,'string',num2str(par.tauk))
    set(ft.e_zmianapocz,'string',num2str(pocz))
    set(ft.e_zmianakon,'string',num2str(kon))
    set(ft.t_zmiana,'string',zmiana_par)
   
    set(ft.axes,'title',text('parent',ft.axes,'string','Diagram Feigenbauma dla \fontname{Tahoma}\bf\Theta_1',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'xlabel',text('parent',ft.axes,'string','\fontname{Tahoma}\bfK_F',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',ft.axes,'string','\bf\Theta_1',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'))
   set(fa.axes,'title',text('parent',fa.axes,'string','Diagram Feigenbauma dla \fontname{Tahoma}\bf\alpha_1',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'xlabel',text('parent',fa.axes,'string','\fontname{Tahoma}\bfK_F',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',fa.axes,'string','\bf\alpha_1',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'))
    
    set(fa2.e_Kv,'string',num2str(par.Kv))
    set(fa2.e_Kf,'string',num2str(par.Kf))
    set(fa2.e_f1,'string',num2str(par.f(1)))
    set(fa2.e_f2,'string',num2str(par.f(2)))
    set(fa2.e_k,'string',num2str(par.k))
    set(fa2.e_gamma,'string',num2str(par.gamma))
    set(fa2.e_beta,'string',num2str(par.beta))
    set(fa2.e_da,'string',num2str(par.da))
    set(fa2.e_thetaH,'string',num2str(par.thetaH))
    set(fa2.e_delta1,'string',num2str(par.delta(1)))
    set(fa2.e_delta2,'string',num2str(par.delta(2)))
    set(fa2.e_tauk,'string',num2str(par.tauk))
    set(fa2.e_zmianapocz,'string',num2str(pocz))
    set(fa2.e_zmianakon,'string',num2str(kon))
    set(fa2.t_zmiana,'string',zmiana_par)
    
    set(ft2.e_Kv,'string',num2str(par.Kv))
    set(ft2.e_Kf,'string',num2str(par.Kf))
    set(ft2.e_f1,'string',num2str(par.f(1)))
    set(ft2.e_f2,'string',num2str(par.f(2)))
    set(ft2.e_k,'string',num2str(par.k))
    set(ft2.e_gamma,'string',num2str(par.gamma))
    set(ft2.e_beta,'string',num2str(par.beta))
    set(ft2.e_da,'string',num2str(par.da))
    set(ft2.e_thetaH,'string',num2str(par.thetaH))
    set(ft2.e_delta1,'string',num2str(par.delta(1)))
    set(ft2.e_delta2,'string',num2str(par.delta(2)))
    set(ft2.e_tauk,'string',num2str(par.tauk))
    set(ft2.e_zmianapocz,'string',num2str(pocz))
    set(ft2.e_zmianakon,'string',num2str(kon))
    set(ft2.t_zmiana,'string',zmiana_par)
   
    set(ft2.axes,'title',text('parent',ft2.axes,'string','Diagram Feigenbauma dla \fontname{Tahoma}\bf\Theta_2',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'xlabel',text('parent',ft2.axes,'string','\fontname{Tahoma}\bfK_F',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',ft2.axes,'string','\bf\Theta_2',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'))
   set(fa2.axes,'title',text('parent',fa2.axes,'string','Diagram Feigenbauma dla \fontname{Tahoma}\bf\alpha_2',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'xlabel',text('parent',fa2.axes,'string','\fontname{Tahoma}\bfK_F',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',fa2.axes,'string','\bf\alpha_2',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'))

cd(pathes.dynamika)
    psize=size(zm)
    psize=round(psize(1))
    mstart=[round(str2num(get(fa.e_stab,'string'))*2) ...
            round(str2num(get(ft.e_stab,'string'))*2)]
        
for i=1:501
    dsize=size(zm{i}{1})
    dsize=round(dsize(1))
    msize=dsize-mstart+1
    pb_a=zeros(msize(1),1)
    pb_t=zeros(msize(2),1)

    pb_a(:,1)=pb(i)
    pb_t(:,1)=pb(i)

% reaktor 1
line(...
    'xdata',pb_a(:),...
    'ydata',zm{i}{1}(mstart(1):dsize,1),...
    'linestyle','none',...
    'marker','.',...
    'markersize',1,...
    'color',[0 0 0],...
    'parent',fa.axes)
line(...
    'xdata',pb_t(:),...
    'ydata',zm{i}{2}(mstart(2):dsize,1),...
    'linestyle','none',...
    'marker','.',...
    'markersize',1,...
    'color',[0 0 0],...
    'parent',ft.axes)
% reaktor 2
line(...
    'xdata',pb_a(:),...
    'ydata',zm{i}{1}(mstart(1):dsize,2),...
    'parent',fa2.axes,...
    'linestyle','none',...
    'marker','.',...
    'color',[0 0 0],...
    'markersize',1)
line(...
    'xdata',pb_t(:),...
    'ydata',zm{i}{2}(mstart(2):dsize,2),...
    'parent',ft2.axes,...
    'linestyle','none',...
    'marker','.',...
    'color',[0 0 0],...
    'markersize',1)
end

cd(pathes.call)