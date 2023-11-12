function varargout=ustawprt(varargin)

global par start
global pathes fig zmiana_par
global zm sym faz sym2 faz2
global prt prt2

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

set(prt.sl_zmiana,'min',val(1),'max',val(2),'sliderstep',[val(3) val(3)],'value',val(4))
set(prt.e_zmiana,'string',num2str(val(4)))
set(prt.tx_zmiana,'string',zmiana_par)
set(prt.e_a1,'string',num2str(start.alfa0(1)))
set(prt.e_a2,'string',num2str(start.alfa0(2)))
set(prt.e_t1,'string',num2str(start.theta0(1)))
set(prt.e_t2,'string',num2str(start.theta0(2)))

set(prt2.sl_zmiana,'min',val(1),'max',val(2),'sliderstep',[val(3) val(3)],'value',val(4))
set(prt2.e_zmiana,'string',num2str(val(4)))
set(prt2.tx_zmiana,'string',zmiana_par)
set(prt2.e_a1,'string',num2str(start.alfa0(1)))
set(prt2.e_a2,'string',num2str(start.alfa0(2)))
set(prt2.e_t1,'string',num2str(start.theta0(1)))
set(prt2.e_t2,'string',num2str(start.theta0(2)))