function varargout=ustaw(varargin)

global par start
global pathes fig zmiana_par
global zm sym faz sym2 faz2

switch zmiana_par
case 'Kv'
    val=[0 1 0.001 par.Kv]
case 'Kf'
    val=[0 1 0.001 par.Kf]
case 'f1'
    val=[0 1 0.001 par.f(1)]
case 'f2'
    val=[0 1 0.001 par.f(2)]
case 'gamma'
    val=[1 50 0.05 par.gamma]
case 'beta'
    val=[0 5 0.005 par.beta]
case 'Da'
    val=[0.01 50 0.1 par.da]
case 'thetaH'
    val=[-1 0.5 0.0002 par.thetaH]
case 'delta1'
    val=[0 10 0.01 par.delta(1)]
case 'delta2'
    val=[0 10 0.01 par.delta(2)]
otherwise
    return
end

set(sym.sl_zmiana,'min',val(1),'max',val(2),'sliderstep',[val(3) val(3)],'value',val(4))
set(sym.e_zmiana,'string',num2str(val(4)))
set(sym.tx_zmiana,'string',zmiana_par)
set(sym.e_a1,'string',num2str(start.alfa0(1)))
set(sym.e_a2,'string',num2str(start.alfa0(2)))
set(sym.e_t1,'string',num2str(start.theta0(1)))
set(sym.e_t2,'string',num2str(start.theta0(2)))

set(sym2.sl_zmiana,'min',val(1),'max',val(2),'sliderstep',[val(3) val(3)],'value',val(4))
set(sym2.e_zmiana,'string',num2str(val(4)))
set(sym2.tx_zmiana,'string',zmiana_par)
set(sym2.e_a1,'string',num2str(start.alfa0(1)))
set(sym2.e_a2,'string',num2str(start.alfa0(2)))
set(sym2.e_t1,'string',num2str(start.theta0(1)))
set(sym2.e_t2,'string',num2str(start.theta0(2)))