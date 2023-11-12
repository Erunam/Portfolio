function varargout = swykres(varargin)
% odpowiada za tworzenie okien z wykresami symulacyjnymi

global par start
global pathes fig zmiana_par
global zm sym faz sym2 faz2
global czas

if (get(sym.r_dodaj,'value')==1.0)
        ch=allchild(sym.a_alfa)
        delete(ch)
        ch=allchild(sym.a_theta)
        delete(ch)
end
if (get(sym2.r_dodaj,'value')==1.0)
        ch=allchild(sym2.a_alfa)
        delete(ch)
        ch=allchild(sym2.a_theta)
        delete(ch)
end

% reaktor 1
    set(sym.e_Kv,'string',num2str(par.Kv))
    set(sym.e_Kf,'string',num2str(par.Kf))
    set(sym.e_f1,'string',num2str(par.f(1)))
    set(sym.e_f2,'string',num2str(par.f(2)))
    set(sym.e_k,'string',num2str(par.k))
    set(sym.e_gamma,'string',num2str(par.gamma))
    set(sym.e_beta,'string',num2str(par.beta))
    set(sym.e_da,'string',num2str(par.da))
    set(sym.e_thetaH,'string',num2str(par.thetaH))
    set(sym.e_delta1,'string',num2str(par.delta(1)))
    set(sym.e_delta2,'string',num2str(par.delta(2)))
    set(sym.e_toc,'string',num2str(czas))
    set(sym.e_tauk,'string',num2str(par.tauk))
    
    set(sym.a_alfa,'xlabel',text('parent',sym.a_alfa,'string','\tau',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',sym.a_alfa,'string','\alpha_1',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi','rotation',0.0))
    set(sym.a_theta,'xlabel',text('parent',sym.a_theta,'string','\tau',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',sym.a_theta,'string','\Theta_1',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi','rotation',0.0))

    mstart=round(str2num(get(sym.e_stab,'string'))*4-1)
    if (str2num(get(sym.e_stab,'string'))==1)
        mstart=1
    end
    msize=size(zm{1})

line(...
    'xdata',zm{3}(mstart:msize(1),1),...
    'ydata',zm{1}(mstart:msize(1),1),...
    'parent',sym.a_alfa,...
    'tag','alfa1')
    
line(...
    'xdata',zm{3}(mstart:msize(1),1),...
    'ydata',zm{2}(mstart:msize(1),1),...
    'parent',sym.a_theta,...
    'tag','theta1')
    
% reaktor 2
    set(sym2.e_Kv,'string',num2str(par.Kv))
    set(sym2.e_Kf,'string',num2str(par.Kf))
    set(sym2.e_f1,'string',num2str(par.f(1)))
    set(sym2.e_f2,'string',num2str(par.f(2)))
    set(sym2.e_k,'string',num2str(par.k))
    set(sym2.e_gamma,'string',num2str(par.gamma))
    set(sym2.e_beta,'string',num2str(par.beta))
    set(sym2.e_da,'string',num2str(par.da))
    set(sym2.e_thetaH,'string',num2str(par.thetaH))
    set(sym2.e_delta1,'string',num2str(par.delta(1)))
    set(sym2.e_delta2,'string',num2str(par.delta(2)))
    set(sym2.e_toc,'string',num2str(czas))
    set(sym2.e_tauk,'string',num2str(par.tauk))    
        
    set(sym2.a_alfa,'xlabel',text('parent',sym2.a_alfa,'string','\tau',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',sym2.a_alfa,'string','\alpha_2',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi','rotation',0.0))
    set(sym2.a_theta,'xlabel',text('parent',sym2.a_theta,'string','\tau',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi'),...
        'ylabel',text('parent',sym2.a_theta,'string','\Theta_2',...
        'fontname','Tahoma','fontsize',10,'fontweight','demi','rotation',0.0))
    mstart=round(str2num(get(sym2.e_stab,'string'))*4-1)
    if (str2num(get(sym2.e_stab,'string'))==1)
        mstart=1
    end
    
    msize=size(zm{1})

line(...
    'xdata',zm{3}(mstart:msize(1),2),...
    'ydata',zm{1}(mstart:msize(1),2),...
    'parent',sym2.a_alfa,...
    'tag','alfa2')

line(...
    'xdata',zm{3}(mstart:msize(1),2),...
    'ydata',zm{2}(mstart:msize(1),2),...
    'parent',sym2.a_theta,...
    'tag','theta2')


cd(pathes.call)
