function returns = simulation(hdl)
% preparing and runnig simulation
global pathes
global fig
global parameter
global variables
global par_bif
global worktype

cd(pathes.runtime);
    parameter = getparameter(hdl);
    par_bif = getparbif(hdl);
    options = getoptions(hdl);

cd(pathes.simulation);
    worktype = getsimulation(hdl);

eval(['parameter.' par_bif.name '=par_bif.value(1);']);

parameter.stop = worktype.stop;
parameter.start = worktype.start;

cd(pathes.user);
tic;
    variables = calculations(parameter,worktype.name);

cd(pathes.simulation);

if ( options.autosave == 1.0 )
    cd(pathes.runtime);
    export = exportname(worktype.name,par_bif.name,par_bif.value(1),...
                        [worktype.start worktype.stop]);
    cd(export.path);
    save(export.data,'parameter','variables','par_bif','worktype');
    set(hdl.run_ctrl,'BackgroundColor',[0 0.25 1]);
    cd(pathes.simulation);
end

Sm = plotsimulation(variables,worktype,options.autoclean);

if ( options.autoexport==1 )
    cd(pathes.runtime);
    export = exportname(worktype.name,par_bif.name,par_bif.value(1),...
                        [worktype.start worktype.stop]);
    export2jpg(Sm,export);
    set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
    cd(pathes.simulation);
end

time = toc;
set(hdl.time,'String',num2str(time));
returns=1;
