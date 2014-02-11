C_SCCMClientRepairGUI
=====================

This GUI application reinstalls the SCCM client and adds a regkey to delay policy re-requests. 

Requirements
------------
.NET 4.0

Background
----------

In our environment, we received notification that Software Center would not populate. Through
investigation we found that policy kept resetting on clients. This reset removed WMI classes 
containing program information for advertised packages. 

Adding the following registry key fixed the issue:

Key: HKLM/Software/Microsoft/CCM
Value Name: UserPolicyReRequestDelay
Value Type: REG_DWORD
Value Data: 500000

App Details
-----------

This application uses a background worker thread that launches CCMClean to remove the SCCM 2007/2012 client. 
It then launches CCMSetup with hardcoded parameters specifying the MP and SiteCode. You may change the 
parameters within the source code to fit your environment. After launching CCMSETUP, thisapp queries the 
ccmsetup.log for an exit code 0. Once found it stops the SMS Agent Host service and inserts the above registry key. 
It then starts the service and exits. 

CCMClean and CCMSetup.exe locations are specified in an app.config file which should be
deployed with the compiled assembly. 

Finally, a progress bar and status label is updated throughout the program producing a responsive UI. 




