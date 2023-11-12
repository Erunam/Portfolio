function output = getsimulation(hdl)
% getting data for simulation

    output.name = 'simulation';
    output.start = str2num(get(hdl.s_start,'String'));
    output.stop = str2num(get(hdl.s_stop,'String'));
    output.line = get(hdl.s_line,'Value');
    output.psize = get(hdl.s_size,'Value');
    output.color = get(hdl.color,'Value');
 
    switch output.line
        case 1.0
            output.line = '-';
        case 2.0
            output.line = '-';
        case 3.0
            output.line = '--';
        case 4.0
            output.line = ':';
        case 5.0
            output.line = '-.';
        otherwise
            output.line = 'none';
    end
    switch output.psize
        case 1.0
            output.psize = 1.0;
        case 2.0
            output.psize = 1.0;
        case 3.0
            output.psize = 2.0;
        case 4.0
            output.psize = 3.0;
        case 5.0
            output.psize = 4.0;
        case 6.0
            output.psize = 5.0;
        case 7.0
            output.psize = 6.0;
        case 8.0
            output.psize = 7.0;
        case 9.0
            output.psize = 8.0;
        case 10.0
            output.psize = 9.0;
        otherwise
            return;
    end
    switch output.color
        case 1.0
            output.color = [0 0 0];
        case 2.0
            output.color = [0 0 0];
        case 3.0
            output.color = [0 0.75 0];
        case 4.0
            output.color = [0 0.25 0];
        case 5.0
            output.color = [1 0 0.25];
        case 6.0
            output.color = [1 0.25 1];
        otherwise
            return;
    end
