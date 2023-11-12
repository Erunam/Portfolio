function varargout = export2jpg(hdl,export)
% exporting graphs to tif file as the function name is

cd(export.path);

ng = size(hdl);
ng = round(ng(2));

for i=1:ng
    filename = strcat(export.name(i,:),'.tif');
    if ( ishandle(hdl{i}.graph)==1 )
        saveas(hdl{i}.graph,filename,'tif');
    end
end