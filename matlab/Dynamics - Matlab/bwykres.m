    function varargout=bwykres(varargin)

    global par zm start pb
    global fig pathes zmiana_par
    global pocz kon czas krok
    global ch
    global ba ba2 bt bt2
    global zmiana param

    
   cd(pathes.gui)
   
    fig.ba=openfig('B_alfa.fig','reuse')
    ba=guihandles(fig.ba)
    fig.bt=openfig('B_theta.fig','reuse')
    bt=guihandles(fig.bt)

    fig.ba2=openfig('B_alfa2.fig','reuse')
    ba2=guihandles(fig.ba2)
    fig.bt2=openfig('B_theta2.fig','reuse')
    bt2=guihandles(fig.bt2)
   
    cd (pathes.dynamika)
 
    ch=[]
    
    eval(['par.' zmiana_par '=zmiana(1)'])

    dsize=size(zm{1})
    dsize=round(dsize(1))
    
    set(ba.e_Kv,'string',num2str(par.Kv))
    set(ba.e_Kf,'string',num2str(par.Kf))
    set(ba.e_f1,'string',num2str(par.f(1)))
    set(ba.e_f2,'string',num2str(par.f(2)))
    set(ba.e_k,'string',num2str(par.k))
    set(ba.e_gamma,'string',num2str(par.gamma))
    set(ba.e_beta,'string',num2str(par.beta))
    set(ba.e_da,'string',num2str(par.da))
    set(ba.e_thetaH,'string',num2str(par.thetaH))
    set(ba.e_delta1,'string',num2str(par.delta(1)))
    set(ba.e_delta2,'string',num2str(par.delta(2)))
    
    set(ba.e_stab,'string',num2str((zm{3}(dsize,1)-zm{3}(dsize-1,1))))
    set(ba.e_stac,'string',num2str(zm{1}(dsize,1)))
    set(ba.e_bifur,'string',num2str(zm{3}(dsize,1)))
    set(ba.t_zmiana,'string',zmiana_par)
    

    set(bt.e_Kv,'string',num2str(par.Kv))
    set(bt.e_Kf,'string',num2str(par.Kf))
    set(bt.e_f1,'string',num2str(par.f(1)))
    set(bt.e_f2,'string',num2str(par.f(2)))
    set(bt.e_k,'string',num2str(par.k))
    set(bt.e_gamma,'string',num2str(par.gamma))
    set(bt.e_beta,'string',num2str(par.beta))
    set(bt.e_da,'string',num2str(par.da))
    set(bt.e_thetaH,'string',num2str(par.thetaH))
    set(bt.e_delta1,'string',num2str(par.delta(1)))
    set(bt.e_delta2,'string',num2str(par.delta(2)))
    
    set(bt.e_stab,'string',num2str((zm{3}(dsize,1)-zm{3}(dsize-1,1))))
    set(bt.e_stac,'string',num2str(zm{2}(dsize,1)))
    set(bt.e_bifur,'string',num2str(zm{3}(dsize,1)))
    set(bt.t_zmiana,'string',zmiana_par)
    
    
    set(bt.axes,'title',text('parent',bt.axes,'string','Diagram bifurkacyjny dla \Theta_1',...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'),...
        'xlabel',text('parent',bt.axes,'string',zmiana_par,...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'),...
        'ylabel',text('parent',bt.axes,'string','\Theta_1',...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'))
    set(ba.axes,'title',text('parent',ba.axes,'string','Diagram bifurkacyjny dla \alpha_1',...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'),...
        'xlabel',text('parent',ba.axes,'string',zmiana_par,...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'),...
        'ylabel',text('parent',ba.axes,'string','\alpha_1',...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'))
    
    set(ba2.e_Kv,'string',num2str(par.Kv))
    set(ba2.e_Kf,'string',num2str(par.Kf))
    set(ba2.e_f1,'string',num2str(par.f(1)))
    set(ba2.e_f2,'string',num2str(par.f(2)))
    set(ba2.e_k,'string',num2str(par.k))
    set(ba2.e_gamma,'string',num2str(par.gamma))
    set(ba2.e_beta,'string',num2str(par.beta))
    set(ba2.e_da,'string',num2str(par.da))
    set(ba2.e_thetaH,'string',num2str(par.thetaH))
    set(ba2.e_delta1,'string',num2str(par.delta(1)))
    set(ba2.e_delta2,'string',num2str(par.delta(2)))
    
    set(ba2.e_stab,'string',num2str((zm{3}(dsize,1)-zm{3}(dsize-1,1))))
    set(ba2.e_stac,'string',num2str(zm{1}(dsize,1)))
    set(ba2.e_bifur,'string',num2str(zm{3}(dsize,1)))
    set(bt.t_zmiana,'string',zmiana_par)
    
    set(bt2.e_Kv,'string',num2str(par.Kv))
    set(bt2.e_Kf,'string',num2str(par.Kf))
    set(bt2.e_f1,'string',num2str(par.f(1)))
    set(bt2.e_f2,'string',num2str(par.f(2)))
    set(bt2.e_k,'string',num2str(par.k))
    set(bt2.e_gamma,'string',num2str(par.gamma))
    set(bt2.e_beta,'string',num2str(par.beta))
    set(bt2.e_da,'string',num2str(par.da))
    set(bt2.e_thetaH,'string',num2str(par.thetaH))
    set(bt2.e_delta1,'string',num2str(par.delta(1)))
    set(bt2.e_delta2,'string',num2str(par.delta(2)))
    
    set(bt2.e_stab,'string',num2str((zm{3}(dsize,1)-zm{3}(dsize-1,1))))
    set(bt2.e_stac,'string',num2str(zm{2}(dsize,1)))
    set(bt2.e_bifur,'string',num2str(zm{3}(dsize,1)))
    set(bt.t_zmiana,'string',zmiana_par)
    
    set(bt2.axes,'title',text('parent',bt2.axes,'string','Diagram bifurkacyjny dla \Theta_2',...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'),...
        'xlabel',text('parent',bt2.axes,'string',zmiana_par,...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'),...
        'ylabel',text('parent',bt2.axes,'string','\Theta_1',...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'))
    set(ba2.axes,'title',text('parent',ba2.axes,'string','Diagram bifurkacyjny dla \alpha_2',...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'),...
        'xlabel',text('parent',ba2.axes,'string',zmiana_par,...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'),...
        'ylabel',text('parent',ba2.axes,'string','\alpha_1',...
        'fontname','Tahoma','fontsize',12,'fontweight','demi'))
 
cd(pathes.dynamika)
       
% reaktor 1
line(...
    'xdata',zm{3}(:,1),...
    'ydata',zm{1}(:,1),...
    'linestyle','-',...
    'color',[0 0 0],...
    'parent',ba.axes)
line(...
    'xdata',zm{3}(:,1),...
    'ydata',zm{2}(:,1),...
    'linestyle','-',...
    'color',[0 0 0],...
    'parent',bt.axes)
    
% reaktor 2
line(...
    'xdata',zm{3}(:,2),...
    'ydata',zm{1}(:,2),...
    'linestyle','-',...
    'color',[0 0 0],...
    'parent',ba2.axes)
line(...
    'xdata',zm{3}(:,2),...
    'ydata',zm{2}(:,2),...
    'linestyle','-',...
    'color',[0 0 0],...
    'parent',bt2.axes)

cd(pathes.call)