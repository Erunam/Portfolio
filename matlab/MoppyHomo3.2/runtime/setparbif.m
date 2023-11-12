function varargout = setparbif(hdl,name)
% showing the values of the "parameter" group""
% input = name of the bifurcation parameter
global fig
global pathes
global par_bif

    par_bif.name = name;
    
    set([   hdl.r_chi ...
            hdl.r_q ...
            hdl.r_f1 ...
            hdl.r_f2 ...
            hdl.r_Da ...
            hdl.r_gamma ...
            hdl.r_beta ...
            hdl.r_thetaH ...
            hdl.r_delta ...
            hdl.r_eta ...
            hdl.r_n],'value',0.0);
    set([   hdl.chi ...
            hdl.q ...
            hdl.f1 ...
            hdl.f2 ...
            hdl.Da ...
            hdl.gamma ...
            hdl.beta ...
            hdl.thetaH ...
            hdl.delta ...
            hdl.eta ...
            hdl.n],'Callback','');
    
    setcall = eval(['hdl.' par_bif.name]);
    set(setcall,'Callback','main(gcbo,guihandles(gcbo))');
    par_bif.value(1) = str2num(get(setcall,'String'));
    
    switch par_bif.name
        case 'chi'
            set(hdl.r_chi,'value',1.0);
            set(hdl.bif_slide,'min',0.0,'max',1.0,'sliderstep',[0.02 0.02]);
        case 'q'
            set(hdl.r_q,'value',1.0);
            set(hdl.bif_slide,'min',0.0,'max',1.0,'sliderstep',[0.02 0.02]);
        case 'f1'
            set(hdl.r_f1,'value',1.0);
            set(hdl.bif_slide,'min',0.0,'max',1.0,'sliderstep',[0.02 0.02]);
        case 'f2'
            set(hdl.r_f2,'value',1.0);
            set(hdl.bif_slide,'min',0.0,'max',1.0,'sliderstep',[0.02 0.02]);
        case 'Da'
            set(hdl.r_Da,'value',1.0);
            set(hdl.bif_slide,'min',0.0,'max',1.0,'sliderstep',[0.02 0.02]);
        case 'gamma'
            set(hdl.r_gamma,'value',1.0);
            set(hdl.bif_slide,'min',1.0,'max',50.0,'sliderstep',[1.0 1.0]);
        case 'beta'
            set(hdl.r_beta,'value',1.0);
            set(hdl.bif_slide,'min',0.0,'max',5.0,'sliderstep',[0.1 0.1]);
        case 'thetaH'
            set(hdl.r_thetaH,'value',1.0);
            set(hdl.bif_slide,'min',-1.0,'max',1.0,'sliderstep',[0.05 0.05]);
        case 'delta'
            set(hdl.r_delta,'value',1.0);
            set(hdl.bif_slide,'min',0.0,'max',10.0,'sliderstep',[0.2 0.2]);
        case 'eta'
            set(hdl.r_eta,'value',1.0);
            set(hdl.bif_slide,'min',0.01,'max',100.0,'sliderstep',[0.01 0.01]);
        case 'n'
            set(hdl.r_n,'value',1.0);
            set(hdl.bif_slide,'min',0.0,'max',3.0,'sliderstep',[0.25 0.25]);
        otherwise
            return;
    end
    set(hdl.bif_val,'String',num2str(par_bif.value(1)));
    set(hdl.bif_slide,'Value',par_bif.value(1));
    set(hdl.bif_text,'String',par_bif.name);