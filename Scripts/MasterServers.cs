    // ======================================================================================================
    // Client Master Servers Configuration Script
    // By: Shayk-N'-Bake
    // https://github.com/shaykbake/Tribes/
    // ------------------------------------------------------------------------------------------------------
    // Installation: Place into TRIBES\config directory and add the following line to the autoexec.cs file:
    // exec(MasterServers);
    // You can edit the $MasterAddress* variables below to change the addresses your client will query for servers.
    // ------------------------------------------------------------------------------------------------------
    // Please visit https://github.com/shaykbake/Tribes/ and view the file for any updates or changes to the known list of master servers.
    // ======================================================================================================
     
     
    deleteVariables("$Server::MasterAddress*");
     
    %i = -1;
    $MasterAddress[%i++] = "t1m1.pu.net:28000";
    $MasterAddress[%i++] = "t1m1.tribes0.com:28000";
    $MasterAddress[%i++] = "t1m1.kigen.co:28000";
    $MasterAddress[%i++] = "skbmaster.kigen.co:28000";
    $MasterAddress[%i++] = "t1m1.tribes1.co:28000";
    $MasterAddress[%i++] = "t1m1.masters.tribesmasters.com:28000";
     
    for(%i = 0; (%address = $MasterAddress[%i]) != ""; %i++)
    {
    	if($Server::MasterAddressN0 == "") $Server::MasterAddressN0 = %address;
    	else $Server::MasterAddressN0 = $Server::MasterAddressN0 @ " " @ %address;
    }

