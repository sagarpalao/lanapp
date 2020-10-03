# LAN APP - An application management protocol for PCs connected in LAN


## So what’s the problem ?
* Making one PC, monitor the apps in other PC in a LAN.  
* Solutions available for LINUX but what about Windows.  
* Not dedicating one PC just as a Windows server. Why waste resources.

<hr/>

## Solution
* We came up with a protocol which we name as LAN APP.  
* Each PC will have a Windows Service giving information about the apps installed in that machine in real time.  
* The Server PC (not exactly server) will have an APP which will bind all PC in the LAN.  
* By a simple trigger of selecting an APP it will check whether that app is installed in the PCs in the LAN.

<hr/>

## Technical Insight
* Windows Service: Coded in C#, Uses Windows Registry to check if app is present
* LAN APP: A windows App, Coded in C#
* Communication Protocol

<hr/>

## Limitations
* Firstly our app works only when all PCs are ON.
* That’s when the sockets works.  
* So if we can backup the last checkings and persistently maintain it.  
* Next is if we can install the app controlling it from one PC without the Win Server.