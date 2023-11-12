function varargout = pwykres(varargin)
% odpowiada za tworzenie okien z wykresami symulacyjnymi
% skad=0 zawsze gdy mamy dane ze schodami

global par start
global pathes fig zmiana_par
global zm sym faz sym2 faz2
global czas
global prt prt2

if (get(prt.r_dodaj,'value')==1.0)
        ch=allchild(prt.axes)
        delete(ch)
end
if (get(prt2.r_dodaj,'value')==1.0)
        ch=allchild(prt2.axes)
        delete(ch)
end
% reaktor 1
    set(prt.e_Kv,'string',num2str(par.Kv))
    set(prt.e_Kf,'string',num2str(par.Kf))
    set(prt.e_f1,'string',num2str(par.f(1)))
    set(prt.e_f2,'string',num2str(par.f(2)))
    set(prt.e_k,'string',num2str(par.k))
    set(prt.e_gamma,'string',num2str(par.gamma))
    set(prt.e_beta,'string',num2str(par.beta))
    set(prt.e_da,'string',num2str(par.da))
    set(prt.e_thetaH,'string',num2str(par.thetaH))
    set(prt.e_delta1,'string',num2str(par.delta(1)))
    set(prt.e_delta2,'string',num2str(par.delta(2)))
    set(prt.e_toc,'string',num2str(czas))
    set(prt.e_tauk,'string',num2str(par.tauk))
    
    set(prt.axes,'title',text('parent',prt.axes,'string','Portret fazowy',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'xlabel',text('parent',prt.axes,'string','\alpha_1',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',prt.axes,'string','\Theta_1',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi','rotation',0.0))

col=colormap('summer')
for i=1:4
    for j=1:10
line(...
    'xdata',zm{i,j}{1}(:,1),...
    'ydata',zm{i,j}{2}(:,1),...
    'linestyle','none',...
    'marker','.',...
    'markersize',6,...
    'color',[col((i*10+j),1) col((i*10+j),1) col((i*10+j),1)],...
    'parent',prt.axes,...
    'tag','alfa1_theta1')
end
end

% reaktor 2
    set(prt2.e_Kv,'string',num2str(par.Kv))
    set(prt2.e_Kf,'string',num2str(par.Kf))
    set(prt2.e_f1,'string',num2str(par.f(1)))
    set(prt2.e_f2,'string',num2str(par.f(2)))
    set(prt2.e_k,'string',num2str(par.k))
    set(prt2.e_gamma,'string',num2str(par.gamma))
    set(prt2.e_beta,'string',num2str(par.beta))
    set(prt2.e_da,'string',num2str(par.da))
    set(prt2.e_thetaH,'string',num2str(par.thetaH))
    set(prt2.e_delta1,'string',num2str(par.delta(1)))
    set(prt2.e_delta2,'string',num2str(par.delta(2)))
    set(prt2.e_toc,'string',num2str(czas))
    set(prt2.e_tauk,'string',num2str(par.tauk))
    
    set(prt2.axes,'title',text('parent',prt2.axes,'string','Portret fazowy',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'xlabel',text('parent',prt2.axes,'string','\alpha_2',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',prt2.axes,'string','\Theta_2',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi','rotation',0.0))
for i=1:4
    for j=1:10
line(...
    'xdata',zm{i,j}{1}(:,2),...
    'ydata',zm{i,j}{2}(:,2),...
    'linestyle','none',...
    'marker','.',...
    'markersize',6,...
    'color',[col((i*10+j),1) col((i*10+j),1) col((i*10+j),1)],...
    'parent',prt2.axes,...
    'tag','alfa2_theta2')
end
end

cd(pathes.call)
