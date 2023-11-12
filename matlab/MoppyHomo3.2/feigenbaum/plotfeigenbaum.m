function Fg = plotfeigenbaum(variables,par_bif,worktype,clean)
% feigenbaum graphs
global pathes
global fig

cd(pathes.gui);
    switch par_bif.name
        case 'chi'
            xaxes = '\chi';
        case 'q'
            xaxes = 'q';
        case 'f1'
            xaxes = '\f_1';
        case 'f2'
            xaxes = '\f_2';
        case 'Da'
            xaxes = 'Da';
        case 'gamma'
            xaxes = '\gamma';
        case 'beta'
            xaxes = '\beta';
        case 'delta'
            xaxes = '\delta';
        case 'thetaH'
            xaxes = '\theta_H';
        case 'eta'
            xaxes = '\eta';
        case 'n'
            xaxes = 'n';
    end

yaxes = ['\alpha_1';'\Theta_1';'\alpha_2';'\theta_2';'\alpha_P';'\theta_P'];
wintitle = ['Fg_A1';'Fg_T1';'Fg_A2';'Fg_T2';'Fg_AP';'Fg_TP'];

% i = 
% 1 - A1, 2 - T1, 3 - A2, 4 - T2, 5 - AP, 6 - TP
if ( isfield(fig,'Fg')==0 )
    for i=1:6
        fig.Fg{i} = openfig('diagram.fig','new');
        fig.Fg{i} = guihandles(fig.Fg{i});
        set(fig.Fg{i}.graph,'Name',wintitle(i,:));
    end
end
for i=1:6
    if ( ishandle(fig.Fg{i}.graph)==0 )
        fig.Fg{i} = openfig('diagram.fig','new');
        fig.Fg{i} = guihandles(fig.Fg{i});
        set(fig.Fg{i}.graph,'Name',wintitle(i,:));
    end
end
if ( clean==1 )
    for i=1:6
        child = allchild(fig.Fg{i}.axes);
        delete(child);
    end
end
for i=1:6
    set(fig.Fg{i}.axes,...
        'ylabel',text('parent',fig.Fg{i}.axes,'String',yaxes(i,:),'rotation',90.0),...
        'xlabel',text('parent',fig.Fg{i}.axes,'String',xaxes),...
        'Xlim',[worktype.min_par worktype.max_par]);
end
% graphing
parN = 1;
    for j=1:3
        for k=2:3
            line('xdata',variables{j}(:,1),...
                 'ydata',variables{j}(:,k),...
                 'linestyle','none',...
                 'marker',worktype.point,...
                 'markersize',worktype.psize,...
                 'MarkerEdgeColor',worktype.color,...
                 'color',worktype.color,...
                 'parent',fig.Fg{parN}.axes);
            parN = parN + 1;
        end
    end
cd(pathes.feigenbaum);
Fg = fig.Fg;
