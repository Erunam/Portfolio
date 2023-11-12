function returns = poincare(hdl)
% preparing and running poincare diagram

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

cd(pathes.poincare);
    worktype = getpoincare(hdl);

eval(['parameter.' par_bif.name '=par_bif.value(1);']);

    parameter.stop = worktype.stop;
    parameter.start = worktype.start;

cd(pathes.user);
tic;
    variables = calculations(parameter,worktype.name);

cd(pathes.poincare);

if (options.autosave == 1.0)
    cd(pathes.runtime);
    export = exportname(worktype.name,par_bif.name,par_bif.value(1),[worktype.start worktype.stop]);
    cd(export.path);
    save(export.data,'parameter','variables','par_bif','worktype');
    set(hdl.run_ctrl,'BackgroundColor',[0 0.25 1]);
    cd(pathes.poincare);
end

Pp = plotpoincare(variables,worktype,options.autoclean);

if ( options.autoexport==1 )
    cd(pathes.runtime);
    export = exportname(worktype.name,par_bif.name,par_bif.value(1),[worktype.start worktype.stop]);
    export2jpg(Pp,export);
    set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
    cd(pathes.poincare);
end

time = toc;
set(hdl.time,'String',num2str(time));
returns = 1;
