function outvar=getparameter(hdl)
% getting values for the "parameter" group

    outvar.chi = str2num(get(hdl.chi,'String'));
    outvar.q = str2num(get(hdl.q,'String'));
    outvar.f1 = str2num(get(hdl.f1,'String'));
    outvar.f2 = str2num(get(hdl.f2,'String'));
    outvar.Da = str2num(get(hdl.Da,'String'));
    outvar.gamma = str2num(get(hdl.gamma,'String'));
    outvar.beta = str2num(get(hdl.beta,'String'));
    outvar.thetaH = str2num(get(hdl.thetaH,'String'));
    outvar.delta = str2num(get(hdl.delta,'String'));
    outvar.eta = str2num(get(hdl.eta,'String'));
    outvar.n = str2num(get(hdl.n,'String'));
    outvar.N1 = str2num(get(hdl.N1,'String'));
    outvar.N2 = str2num(get(hdl.N2,'String'));
        
    outvar.alpha1 = str2num(get(hdl.alpha1,'String'));
    outvar.theta1 = str2num(get(hdl.theta1,'String'));
    outvar.alpha2 = str2num(get(hdl.alpha2,'String'));
    outvar.theta2 = str2num(get(hdl.theta2,'String'));

    outvar.alphaf = str2num(get(hdl.alpha_f,'String'));
    outvar.thetaf = str2num(get(hdl.theta_f,'String'));    
