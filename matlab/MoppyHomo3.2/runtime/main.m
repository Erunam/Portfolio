function varargout=main(h,hdl)
% callbacks for main-dialog. main executive function.

global pathes
global fig
global parameter
global variables
global par_bif
global worktype

switch h
% button load
case hdl.load
    set(hdl.rescue_ctrl,'BackgroundColor',[1 0 0.25]);
    cd(pathes.data);
    [filename filepath]=uigetfile;
    if ( isempty(filename)==0 )
        cd(filepath);
            load(filename,'parameter','variables','par_bif','worktype');
        cd(pathes.runtime);

        setparameter(hdl,parameter);
        setparbif(hdl,par_bif.name);
        
        set(hdl.rescue_ctrl,'BackgroundColor',[0 0.75 0]);
        if ( isstruct(worktype)==1 )
            set(hdl.rescue_ctrl,'BackgroundColor',[0 0.25 1]);
        end
    end
    cd(pathes.runtime);
% baton zapisz
case hdl.save
    set(hdl.rescue_ctrl,'BackgroundColor',[1 0 0.25]);

    parameter = getparameter(hdl);
    par_bif = getparbif(hdl);
    
    cd(pathes.data);
    [filename filepath]=uiputfile;
    if ( isempty(filename)==0 )
        cd(filepath);
            save(filename,'parameter','variables','par_bif','worktype');
        set(hdl.rescue_ctrl,'BackgroundColor',[0 0.75 0]);
    end
    cd(pathes.runtime);
% baton rescue
case hdl.rescue
    if (isstruct(worktype)==1)
        switch worktype.name
            case 'simulation'
                set(hdl.run_ctrl,'BackgroundColor',[1 0 0.25]);
                cd(pathes.simulation);
                plotsimulation(variables,worktype,1);
                cd(pathes.runtime);
                set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
            case 'poincare'
                set(hdl.run_ctrl,'BackgroundColor',[1 0 0.25]);
                cd(pathes.poincare);
                plotpoincare(variables,worktype,1);
                cd(pathes.runtime);
                set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);         
            case 'feigenbaum'
                set(hdl.run_ctrl,'BackgroundColor',[1 0 0.25]);
                cd(pathes.feigenbaum);
                plotfeigenbaum(variables,par_bif,worktype,1);
                cd(pathes.runtime);
                set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
            otherwise
                set(hdl.run_ctrl,'BackgroundColor',[1 0 0.25]);
                return;
        end
        set(hdl.rescue_ctrl,'BackgroundColor',[0 0.75 0]);
    end
% workmode "symulacja"
%   start
case hdl.s_go
    set(hdl.run_ctrl,'BackgroundColor',[1 0 0.25]);
    cd(pathes.simulation);
        simulation(hdl);
    cd(pathes.runtime);
    set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
%   export
case hdl.s_export
    set(hdl.run_ctrl,'BackgroundColor',[1 0 0.25]);
    export = exportname(worktype.name,par_bif.name,par_bif.value(1),...
                        [worktype.start worktype.stop]);
    export2jpg(fig.Sm,export);
    set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
    cd(pathes.runtime);
    
% workmode "poincare"
%   start
case hdl.p_go
    cd(pathes.poincare);
    set(hdl.run_ctrl,'BackgroundColor',[1 0 0.25]);
        poincare(hdl);
    cd(pathes.runtime);
    set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
%   export
case hdl.p_export
    set(hdl.run_ctrl,'BackgroundColor',[1 0 0.25]);
    export = exportname(worktype.name,par_bif.name,par_bif.value(1),...
                        [worktype.start worktype.stop]);
    export2jpg(fig.Pp,export);
    set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
    cd(pathes.runtime);

% workmode "feigenbaum"
%   start
case hdl.f_go
    cd(pathes.feigenbaum);
    set(hdl.run_ctrl,'BackgroundColor',[1 0 0.25]);
        feigenbaum(hdl);
    cd(pathes.runtime);
    set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
%   export
case hdl.f_export
    set(hdl.run_ctrl,'BackgroundColor',[1 0 0.25]);
    export = exportname(worktype.name,par_bif.name,...
                        [par_bif.value(1) par_bif.value(2)],...
                        [worktype.start worktype.stop]);
    export2jpg(fig.Fg,export);
    set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
    cd(pathes.runtime);

% callback dla grupy "parameter"
%   alpha_f, theta_f
case hdl.alpha_f
    set([hdl.alpha1 hdl.alpha2],'String',get(h,'String'));
    set([hdl.theta1 hdl.theta2],'String',get(hdl.theta_f,'String'));
    set(hdl.rescue_ctrl,'BackgroundColor',[0 0.75 0]);
case hdl.theta_f
    set([hdl.alpha1 hdl.alpha2],'String',get(hdl.alpha_f,'String'));
    set([hdl.theta1 hdl.theta2],'String',get(h,'String'));
    set(hdl.rescue_ctrl,'BackgroundColor',[0 0.75 0]);
% callback dla grupy "par_bif"
%   "edit"
case hdl.bif_val
    set(hdl.bif_slide,'Value',str2num(get(h,'String')));
    parameter = eval(['hdl.' par_bif.name]);
    set(parameter,'String',get(h,'String'));
    set(hdl.rescue_ctrl,'BackgroundColor',[0 0.75 0]);
%   "slider"
case hdl.bif_slide
    set(hdl.bif_val,'String',num2str(get(h,'Value')));
    parameter = eval(['hdl.' par_bif.name]);
    set(parameter,'String',num2str(get(h,'Value')));
    set(hdl.rescue_ctrl,'BackgroundColor',[0 0.75 0]);
end
%   grupa "radio"
if (any (h==[hdl.r_chi ...
            hdl.r_q ...
            hdl.r_f1 ...
            hdl.r_f2 ...
            hdl.r_Da ...
            hdl.r_gamma ...
            hdl.r_beta ...
            hdl.r_delta ...
            hdl.r_thetaH ...
            hdl.r_eta ...
            hdl.r_n]))
    setparbif(hdl,get(h,'String'));
    set(hdl.rescue_ctrl,'BackgroundColor',[0 0.75 0]);
end
%   "parameter" do "par_bif"
if (any (h==[hdl.chi ...
            hdl.q ...
            hdl.f1 ...
            hdl.f2 ...
            hdl.Da ...
            hdl.gamma ...
            hdl.beta ...
            hdl.delta ...
            hdl.thetaH ...
            hdl.eta ...
            hdl.n]))
    set(hdl.bif_val,'String',get(h,'String'));
    set(hdl.bif_slide,'Value',str2num(get(h,'String')));
    set(hdl.rescue_ctrl,'BackgroundColor',[0 0.75 0]);
end
