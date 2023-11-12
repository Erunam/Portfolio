function Sm = plotsimulation(variables,worktype,clean)
% simulation graphs
global pathes
global fig

cd(pathes.gui);

yaxes = ['\alpha_1';'\Theta_1';'\alpha_2';'\theta_2';'\alpha_P';'\theta_P'];
wintitle = ['Sm_A1';'Sm_T1';'Sm_A2';'Sm_T2';'Sm_AP';'Sm_TP'];

% i = 
% 1 - A1, 2 - T1, 3 - A2, 4 - T2, 5 - AP, 6 - TP
if ( isfield(fig,'Sm')==0 )
    for i=1:6
        fig.Sm{i} = openfig('simulation.fig','new');
        fig.Sm{i} = guihandles(fig.Sm{i});
        set(fig.Sm{i}.graph,'Name',wintitle(i,:));
    end
end
for i=1:6
    if ( ishandle(fig.Sm{i}.graph)==0 )
        fig.Sm{i} = openfig('simulation.fig','new');
        fig.Sm{i} = guihandles(fig.Sm{i});
        set(fig.Sm{i}.graph,'Name',wintitle(i,:));
    end
end
if ( clean==1 )
    for i=1:6
        child = allchild(fig.Sm{i}.axes);
        delete(child);
    end
end
for i=1:6
    set(fig.Sm{i}.axes,...
        'ylabel',text('parent',fig.Sm{i}.axes,'String',yaxes(i,:),'rotation',0.0),...
        'xlabel',text('parent',fig.Sm{i}.axes,'String','\tau'));
end
% graphing
parN = 1;
for i=1:3
    for j=2:3
        line('xdata',variables{i}(:,1),...
             'ydata',variables{i}(:,j),...
             'parent',fig.Sm{parN}.axes,...
             'LineStyle',worktype.line,...
             'Color',worktype.color);
        parN=parN+1;
    end
end
cd(pathes.simulation);
Sm = fig.Sm;
