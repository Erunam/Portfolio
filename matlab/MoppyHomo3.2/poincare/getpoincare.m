function worktype = getpoincare(hdl)
% getiing data for poincare diagram

    worktype.name = 'poincare';
    worktype.start = str2num(get(hdl.p_start,'String'));
    worktype.stop = str2num(get(hdl.p_stop,'String'));
    worktype.point = get(hdl.p_point,'Value');
    worktype.psize = get(hdl.p_size,'Value');
    worktype.color = get(hdl.color,'Value');
    
    switch worktype.point
        case 1.0
            worktype.point = '.';
        case 2.0
            worktype.point = '.';
        case 3.0
            worktype.point = '+';
        case 4.0
            worktype.point = '*';
        case 5.0
            worktype.point = 'o';
        case 6.0
            worktype.point = 'x';
        case 7.0
            worktype.point = 'v';
        case 8.0
            worktype.point = 's';
        otherwise
            worktype.point = 'none';
    end
    switch worktype.psize
        case 1.0
            worktype.psize = 1.0;
        case 2.0
            worktype.psize = 1.0;
        case 3.0
            worktype.psize = 2.0;
        case 4.0
            worktype.psize = 3.0;
        case 5.0
            worktype.psize = 4.0;
        case 6.0
            worktype.psize = 5.0;
        case 7.0
            worktype.psize = 6.0;
        case 8.0
            worktype.psize = 7.0;
        case 9.0
            worktype.psize = 8.0;
        case 10.0
            worktype.psize = 9.0;
        otherwise
            return;
    end
    switch worktype.color
        case 1.0
            worktype.color = [0 0 0];
        case 2.0
            worktype.color = [0 0 0];
        case 3.0
            worktype.color = [0 0.75 0];
        case 4.0
            worktype.color = [0 0.25 0];
        case 5.0
            worktype.color = [1 0 0.25];
        case 6.0
            worktype.color = [1 0.25 1];
        otherwise
            return;
    end
