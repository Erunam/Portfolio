function varargout = setparameter(hdl,input)
% showing the actual values of the "parameter" group into main window
    set(hdl.chi,'string',num2str(input.chi));
    set(hdl.q,'string',num2str(input.q));
    set(hdl.f1,'string',num2str(input.f1));
    set(hdl.f2,'string',num2str(input.f2));
    set(hdl.Da,'string',num2str(input.Da));
    set(hdl.gamma,'string',num2str(input.gamma));
    set(hdl.beta,'string',num2str(input.beta));
    set(hdl.thetaH,'string',num2str(input.thetaH));
    set(hdl.delta,'string',num2str(input.delta));
    set(hdl.eta,'string',num2str(input.eta));
    set(hdl.n,'string',num2str(input.n));

    set(hdl.N1,'string',num2str(input.N1));
    set(hdl.N2,'string',num2str(input.N2));

    set(hdl.alpha1,'String',num2str(input.alpha1));
    set(hdl.theta1,'String',num2str(input.theta1));
    set(hdl.alpha2,'String',num2str(input.alpha2));
    set(hdl.theta2,'String',num2str(input.theta2));

    set(hdl.alpha_f,'String',num2str(input.alphaf));
    set(hdl.theta_f,'String',num2str(input.thetaf));  
