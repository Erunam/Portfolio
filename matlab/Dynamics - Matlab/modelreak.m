function dy=modelreak(y,par,n)
    
    
    fi=par.da*(exp(par.gamma*((y(2)*par.beta)/(1+y(2)*par.beta))))*(1-y(1))
    
    dy(1)=fi
    dy(2)=fi+par.delta(n)*(par.thetaH-y(2))