function options = getoptions(hdl)
% getting values of graph options group fot options struct

    options.autosave = get(hdl.autosave,'Value');
    options.autoexport = get(hdl.autoexport,'Value');
    options.autoclean = get(hdl.autoclean,'Value');
