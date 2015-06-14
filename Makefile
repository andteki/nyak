
OPTIONS= /t:winexe
SRC=Nyak.cs MainWindow.cs
CSC=c:\Windows\Microsoft.NET\Framework64\v3.5\csc
all:
	$(CSC) $(OPTIONS) $(SRC)
