Ok, heres a guide on how to make a Starseige: Tribes HUD (Heads Up Display). - Dr.Arsenic; HeckaCoolDewd@Hotmail.com

1) Make a file of which to place your HUD code.
2) Add this function; 

                       [CODE]

function onExit()
{
   // Your gui MUST be removed here \/
                              HUD::Remove();
   // Thats it for Removing your hud...

   if(isObject(playGui))
      storeObject(playGui, "config\\play.gui");

   saveActionMap("config\\config.cs", "actionMap.sae", "playMap.sae", "pdaMap.sae");
   $pref::VideoFullScreen = isFullScreenMode(MainWindow);

   checkMasterTranslation();
   echo("exporting pref::* to prefs.cs");
   export("pref::*", "config\\ClientPrefs.cs", False);
   export("Server::*", "config\\ServerPrefs.cs", False);
   export("pref::lastMission", "config\\ServerPrefs.cs", True);
   BanList::export("config\\banlist.cs");
}
                     [END CODE]

3) Without that function you will screw up your play.gui file big time (Can you say perminant uglyness?)
4) To CREATE the actual the objects on your screen you will have to do this...

                       [CODE]

   // ------------------------- Object Name - Type --------- PosX - PosY, Width, Length
   $Hud::Object[0] = NewObject("HUD_Object0", FearGui::FearGuiMenu, 0, 0, 100, 180);

   // NOTICE THE TYPE!!!!
   // If the type is a menu, you have to know two things; 
   //  (1) How to layer it (Before objects renders it in the back, After objects created renders it in front... Play with it.) 
   //  (2) You MUST have the width and length defined or it wont show up.
   // If your making just text (Call after any Menu's are created or it will be overlapped) you use this...

   // ------------------------- Object Name - Type --------- PosX - PosY, Width, Length
   $Hud::Object[0] = NewObject("HUD_Object0", FearGuiFormattedText, 10, 10, 0, 0);

   // Ok, you defined the GUI object, now to place it...
   // Simple... yes, this is where the layering takes place.
   AddToSet("PlayGui", $Hud::Object[0]);

   // Make it so it shows on your screen... not much to explain here.
   Control::setVisible("HUD_Object0",true);

   // This is **only** needed for **Text Objects**
   // --------------- Object Name - Display Text
   Control::setValue("HUD_Object0", "TEXT HERE");

                     [END CODE]

5) Ok, hopefully you got that down... now, heres an example of a simple GUI that displays your current player's name.

                       [CODE]

function HUD::Init()
{
   $Hud::Object[1] = NewObject("HUD_Object1", FearGuiFormattedText, 10, 10, 0, 0);
   AddToSet("PlayGui", $Hud::Object[1]);
   Control::setVisible("HUD_Object1",true);
   Control::setValue("HUD_Object1", "<F2>"@$PCFG::Name);
}

$Hud::NumObjects = 1;

function Hud::Remove()
{
   for(%i = 0; %i = $Hud::NumObjects+1; %i++) {
      DeleteObject($Hud::Object[%i]);
   }
}

function onExit()
{
   HUD::Remove();

   if(isObject(playGui))
      storeObject(playGui, "config\\play.gui");

   saveActionMap("config\\config.cs", "actionMap.sae", "playMap.sae", "pdaMap.sae");
   $pref::VideoFullScreen = isFullScreenMode(MainWindow);

   checkMasterTranslation();
   echo("exporting pref::* to prefs.cs");
   export("pref::*", "config\\ClientPrefs.cs", False);
   export("Server::*", "config\\ServerPrefs.cs", False);
   export("pref::lastMission", "config\\ServerPrefs.cs", True);
   BanList::export("config\\banlist.cs");
}

                     [END CODE]