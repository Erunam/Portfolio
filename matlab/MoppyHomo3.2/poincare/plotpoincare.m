function Pp = plotpoincare(variables,worktype,clean)
% poincare graphs
global pathes
global fig

cd(pathes.gui);

xaxes = ['\alpha_1';'\alpha_2';'\alpha_P'];
yaxes = ['\Theta_1';'\theta_2';'\theta_P'];
wintitle = ['Pp_T1_A1';'Pp_T2_A2';'Pp_AP_TP'];

% i = 
% 1 - A1T1, 2 - A2T2, 3 - APTP
if ( isfield(fig,'Pp')==0 )
    for i=1:3
            fig.Pp{i} = openfig('diagram.fig','new');
            fig.Pp{i} = guihandles(fig.Pp{i});
            set(fig.Pp{i}.graph,'Name',wintitle(i,:));
    end
end
for i=1:3
    if ( ishandle(fig.Pp{i}.graph)==0 )
        fig.Pp{i} = openfig('diagram.fig','new');
        fig.Pp{i} = guihandles(fig.Pp{i});
        set(fig.Pp{i}.graph,'Name',wintitle(i,:));
    end
end
if ( clean==1 )
    for i=1:3
        child = allchild(fig.Pp{i}.axes);
        delete(child);
    end
end
for i=1:3
    set(fig.Pp{i}.axes,...
        'ylabel',text('parent',fig.Pp{i}.axes,'String',yaxes(i,:),'Rotation',90.0),...
        'xlabel',text('parent',fig.Pp{i}.axes,'String',xaxes(i,:)));
end
% graphing
for i=1:3
        line('xdata',variables{i}(:,1),...
             'ydata',variables{i}(:,2),...
             'parent',fig.Pp{i}.axes,...
             'LineStyle','none',...
             'marker',worktype.point,...
             'markersize',worktype.psize,...
             'color',worktype.color,...
             'MarkerEdgeColor',worktype.color);
end
cd(pathes.poincare);
Pp = fig.Pp;
