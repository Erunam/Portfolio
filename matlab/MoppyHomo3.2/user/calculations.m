function reaktor = calculations(parameter,mode)
% kernel prepared by user

if (parameter.chi==0.0)
    parameter.chi=0.000001;
elseif (parameter.chi==1.0)
    parameter.chi=0.999999;
elseif (parameter.q==0.0)
    parameter.q=0.000001;
elseif (parameter.q==1.0)
    parameter.q=0.999999;
end
    
fid=fopen('data.dat','w+');
fprintf(fid,'%f \n',...
   [parameter.chi ...
    parameter.q ...
    parameter.f1 ...
    parameter.f2 ...
    parameter.Da ...
    parameter.gamma ...
    parameter.beta ...
    parameter.thetaH ...
    parameter.delta ...
    parameter.eta ...
    parameter.n ...
    parameter.N1 ...
    parameter.N2 ...
    parameter.alpha1 ...
    parameter.theta1 ...
    parameter.alpha2 ...
    parameter.theta2 ...
    parameter.alphaf ...
    parameter.thetaf ...
    parameter.start ...
    parameter.stop]);
switch mode
    case 'simulation'
        user = 'SmMoppyHomo.exe';
    case 'poincare'
        user = 'PpMoppyHomo.exe';
    case 'feigenbaum'
        user = 'FgMoppyHomo.exe';
        fprintf(fid,'%f \n',...
            [parameter.bifstart ...
             parameter.bifstop ...
             parameter.bifcount ...
             parameter.bn]);
end
fclose(fid);

eval (['! ' user]);

fidA=fopen('reaktorA.dat','r');
fidB=fopen('reaktorB.dat','r');
fidO=fopen('output.dat','r');

switch mode
    case 'simulation'
        reaktorA=fscanf(fidA,'%f %f %f',[3 inf]);
        reaktorB=fscanf(fidB,'%f %f %f',[3 inf]);        
        output=fscanf(fidO,'%f %f %f',[3 inf]);
    case 'feigenbaum'
        reaktorA=fscanf(fidA,'%f %f %f',[3 inf]);
        reaktorB=fscanf(fidB,'%f %f %f',[3 inf]);        
        output=fscanf(fidO,'%f %f %f',[3 inf]);
    case 'poincare'
        reaktorA=fscanf(fidA,'%f %f',[2 inf]);
        reaktorB=fscanf(fidB,'%f %f',[2 inf]);
        output=fscanf(fidO,'%f %f',[2 inf]);
end
fclose(fidA);
fclose(fidB);
fclose(fidO);

reaktorA = reaktorA';
reaktorB = reaktorB';
output = output';

switch mode
    case 'simulation'
    t=[0];
    A=[0];
    T=[0];
    [t A] = stairs(reaktorA(:,1),reaktorA(:,2));
    [t T] = stairs(reaktorA(:,1),reaktorA(:,3));
    reaktor{1} = [t A T];
    t=[0];
    A=[0];
    T=[0];
    [t A] = stairs(reaktorB(:,1),reaktorB(:,2));
    [t T] = stairs(reaktorB(:,1),reaktorB(:,3));
    reaktor{2} = [t A T];
    t=[0];
    A=[0];
    T=[0];
    [t A] = stairs(output(:,1),output(:,2));
    [t T] = stairs(output(:,1),output(:,3));
    reaktor{3} = [t A T];
    otherwise
    reaktor{1} = reaktorA;
    reaktor{2} = reaktorB;
    reaktor{3} = output;
end
