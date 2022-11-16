# Tribes 1.11 Installations

These are full installations of Tribes 1.11. At this point, these installations are best used for either testing or running dedicated servers. For playing the game as a client, the 1.4x versions are recommended.

## Installation Descriptions

### Tribes 1.11 by Noxwizard

This is Tribes 1.11 by Noxwizard.

As of the time of this setup being added to the repository, it is also still available on [The Exiled team website](http://library.theexiled.pwnageservers.com/file.php?id=2696).

#### Details taken from The Exiled website
The revolutionary First Person Shooter by Dynamix. This is an installer created by Noxwizard. It is updated with the new master servers, is 1.11, and is Vista compatible.

### Tribes 1.11 by Shayk-N'-Bake

This is Tribes 1.11 vanilla by Shayk-N'-Bake. This installation was created using a 1.8-version CD as a starting point, which was then patched to version 1.11 using the official 1.8-to-1.11 patch file provided from Dynamix.

Beyond the patch to version 1.11, the only additions to this setup are:
- NoFiX's mem.dll that includes Andrew's functions from his LastHope/Hudbot mem.dll, as well as NoFiX's Vista Fix update.
- Shayk-N'-Bake's MasterServers.cs file for generating the master server address variable to more easily point to the community master servers. The array for the addresses can easily be edited from within the file. If the array is edited while Tribes is already running, you can update the actual address variable in-game by simply executing the file: `exec(MasterServers);`.