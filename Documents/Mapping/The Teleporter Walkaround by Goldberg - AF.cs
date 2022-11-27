function GroupTrigger::onEnter(%this, %object)
{
%client = Player::getClient(%object);
	if(%this.num == "Main1"){
      %positionIn = "-452.957 807.625 85.5675";
      %positionOut = "-9.77895 1694.47 1471.63";
   }
      else if(%this.num == "Main2"){
      %positionIn = "646.831 233.683 76.1779";
      %positionOut = "-5.61334 1694.48 1471.42";
   }
   else if(%this.num == "Main3"){
      %positionIn = "-17.8541 1819.83 1483.64";
      %positionOut = "-22.3762 1819.84 1483.47";
   }

  	if(%this.in){ 
         GameBase::setPosition(%client, %positionIn);
         //messageAll(0, "~wshieldhit.wav");
	   Client::SendMessage(%client,0,"~wshieldhit.wav");
      }
      	else if(%this.out){
         GameBase::setPosition(%client, %positionOut);
         //messageAll(0, "~wshieldhit.wav");
         Client::SendMessage(%client,0,"~wshieldhit.wav");
	}
 
} 


