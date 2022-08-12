deleteVariables("Server::MasterAddress*");

%i = -1;
$MasterAddress[%i++] = "t1m1.masters.tribesmasterserver.com:28000";
$MasterAddress[%i++] = "t1m1.pu.net:28000";
$MasterAddress[%i++] = "t1m1.tribes0.com:28000";
$MasterAddress[%i++] = "skbmaster.ath.cx:28000";
$MasterAddress[%i++] = "kigen.ath.cx:28000";
$MasterAddress[%i++] = "t1m1.masters.dynamix.com:28000";

for(%i = 0; (%address = $MasterAddress[%i]) != ""; %i++)
{
	
	if($Server::MasterAddressN0 == "") $Server::MasterAddressN0 = %address;
	else $Server::MasterAddressN0 = $Server::MasterAddressN0 @ " " @ %address;
}
