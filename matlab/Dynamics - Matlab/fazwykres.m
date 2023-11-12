function varargout = fazwykres(varargin)
% odpowiada za tworzenie okien z wykresami symulacyjnymi
% skad=0 zawsze gdy mamy dane ze schodami

global par start
global pathes fig zmiana_par
global zm sym faz sym2 faz2
global czas

set(faz2.text14,'string','')

if (get(faz.r_dodaj,'value')==1.0)
        ch=allchild(faz.axes)
        delete(ch)
end
if (get(faz2.r_dodaj,'value')==1.0)
        ch=allchild(faz2.axes)
        delete(ch)
end
% reaktor 1
    set(faz.e_Kv,'string',num2str(par.Kv))
    set(faz.e_Kf,'string',num2str(par.Kf))
    set(faz.e_f1,'string',num2str(par.f(1)))
    set(faz.e_f2,'string',num2str(par.f(2)))
    set(faz.e_k,'string',num2str(par.k))
    set(faz.e_gamma,'string',num2str(par.gamma))
    set(faz.e_beta,'string',num2str(par.beta))
    set(faz.e_da,'string',num2str(par.da))
    set(faz.e_thetaH,'string',num2str(par.thetaH))
    set(faz.e_delta1,'string',num2str(par.delta(1)))
    set(faz.e_delta2,'string',num2str(par.delta(2)))
    set(faz.e_toc,'string',num2str(czas))
    set(faz.e_tauk,'string',num2str(par.tauk))
    
    set(faz.axes,'title',text('parent',faz.axes,'string','Przekroj przez plaszczyzne Poincare',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'xlabel',text('parent',faz.axes,'string','\alpha_1',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',faz.axes,'string','\Theta_1',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi','rotation',0.0))
    mstart=round(str2num(get(faz.e_stab,'string'))*2)
    msize=size(zm{1})
line(...
    'xdata',zm{1}(mstart:msize(1),1),...
    'ydata',zm{2}(mstart:msize(1),1),...
    'linestyle','none',...
    'marker','.',...
    'markersize',2,...
    'color',[0 0 0],...
    'MarkerEdgeColor',[0 0 0],...
    'parent',faz.axes,...
    'tag','alfa1_theta1')


% reaktor 2
    set(faz2.e_Kv,'string',num2str(par.Kv))
    set(faz2.e_Kf,'string',num2str(par.Kf))
    set(faz2.e_f1,'string',num2str(par.f(1)))
    set(faz2.e_f2,'string',num2str(par.f(2)))
    set(faz2.e_k,'string',num2str(par.k))
    set(faz2.e_gamma,'string',num2str(par.gamma))
    set(faz2.e_beta,'string',num2str(par.beta))
    set(faz2.e_da,'string',num2str(par.da))
    set(faz2.e_thetaH,'string',num2str(par.thetaH))
    set(faz2.e_delta1,'string',num2str(par.delta(1)))
    set(faz2.e_delta2,'string',num2str(par.delta(2)))
    set(faz2.e_toc,'string',num2str(czas))
    set(faz2.e_tauk,'string',num2str(par.tauk))
    
    set(faz2.axes,'title',text('parent',faz2.axes,'string','Przekroj przez plaszczyzne Poincare',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'xlabel',text('parent',faz2.axes,'string','\alpha_2',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',faz2.axes,'string','\Theta_2',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi','rotation',0.0))
    mstart=round(str2num(get(faz2.e_stab,'string')))
    msize=size(zm{1})

line(...
    'xdata',zm{1}(mstart:msize(1),2),...
    'ydata',zm{2}(mstart:msize(1),2),...
    'linestyle','none',...
    'marker','.',...
    'markersize',2,...
    'color',[0 0 0],...
    'MarkerEdgeColor',[0 0 0],...
    'parent',faz2.axes,...
    'tag','alfa2_theta2')



set(faz2.text14,'string','koniec')


cd(pathes.call)
