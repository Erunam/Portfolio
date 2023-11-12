function returns = feigenbaum(hdl)
% preparing and running feigenbaum diagram
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

cd(pathes.feigenbaum);
    worktype = getfeigenbaum(hdl);

parameter.stop = worktype.stop;
parameter.start = worktype.start;
parameter.bifstart = worktype.min_par;
parameter.bifstop = worktype.max_par;
parameter.bifcount = worktype.resolution;

switch par_bif.name
    case 'chi'
        parameter.bn = 1;
    case 'q'
        parameter.bn = 2;
    case 'f1'
        parameter.bn = 3;
    case 'f2'
        parameter.bn = 4;
    case 'Da'
        parameter.bn = 5;
    case 'gamma'
        parameter.bn = 6;
    case 'beta'
        parameter.bn = 7;
    case 'thetaH'
        parameter.bn = 8;
    case 'delta'
        parameter.bn = 9;
    case 'eta'
        parameter.bn = 10;
    case 'n'
        parameter.bn = 11;
end
    
cd(pathes.user);
par_bif.value(1) = worktype.min_par
par_bif.value(2) = worktype.max_par;

tic;

    variables = calculations(parameter,worktype.name);

cd(pathes.feigenbaum);

if (options.autosave == 1.0)
    cd(pathes.runtime);
    export = exportname(worktype.name,par_bif.name,...
                        [par_bif.value(1) par_bif.value(2)],...
                        [worktype.start worktype.stop]);
    cd(export.path);
    save(export.data,'parameter','variables','par_bif','worktype');
    set(hdl.run_ctrl,'BackgroundColor',[0 0.25 1]);
    cd(pathes.feigenbaum);
end

Fg = plotfeigenbaum(variables,par_bif,worktype,options.autoclean);

if ( options.autoexport==1 )
    cd(pathes.runtime);
    export = exportname(worktype.name,par_bif.name,...
                        [par_bif.value(1) par_bif.value(2)],...
                        [worktype.start worktype.stop]);
    export2jpg(Fg,export);
    set(hdl.run_ctrl,'BackgroundColor',[0 0.75 0]);
    cd(pathes.feigenbaum);
end

time = toc;
set(hdl.time,'String',num2str(time));

cd(pathes.runtime);
returns = 1;
