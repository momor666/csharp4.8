# csharp4.8

testdome questions c# 

1. Alert ServiceC#  
Refactor the AlertService and AlertDAO classes:

Create a new interface, named IAlertDAO, that contains the same methods as AlertDAO.
AlertDAO should implement the IAlertDAO interface.
AlertService should have a constructor that accepts IAlertDAO.
The RaiseAlert and GetAlertTime methods should use the object passed through the constructor.
