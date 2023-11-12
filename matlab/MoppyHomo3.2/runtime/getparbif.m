function outvar = getparbif(hdl)
% getting actual value and name of the bifurcation parameter
global pathes

    outvar.name = get(hdl.bif_text,'String');
    outvar.value(1) = str2num(get(hdl.bif_val,'String'));
