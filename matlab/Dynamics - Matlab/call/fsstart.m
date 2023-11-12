function  varargout= fsstart(h,hdl)
%UNTITLED1 Summary of this function goes here
%  Detailed explanation goes here
global start

start.alfa0(1)=str2num(get(hdl.e_a1,'string'))
start.alfa0(2)=str2num(get(hdl.e_a2,'string'))
start.theta0(1)=str2num(get(hdl.e_t1,'string'))
start.theta0(2)=str2num(get(hdl.e_t2,'string'))
