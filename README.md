# Info

This pack consists of complete Risk of Rain 1, Risk of Rain 2 (SotV included) and DEADBOLT soundtracks. The file `settings.xml` has been configured to support the included tracks - basically, game's original ost plays (mostly) on the same stages as vanilla with added music from 2 other games.
I tried to stay as accurate to the mood of each stage as possible and add at least one additional track (both normal theme and tele event) to each stage.

Massive credit goes to Kyle Paulsen for developing the original mod (https://thunderstore.io/package/Kyle/OriginalSoundTrack/) and to Chris Christodoulou for composing the soundtracks.

As of 2.0.0 update, you can change the volume of the modded soundtrack while in game using RiskOfOptions right here:

[![Image](https://i.imgur.com/MpXCXnC.png)](https://i.imgur.com/MpXCXnC.png "This is the mod volume sldier is")


Since the mod doesn't actually replace the original game's music but plays on top of it, game's music volume is automatically set to 0 upon game's launch, so it should look like this:

[![Image](https://i.imgur.com/20BocRc.png)](https://i.imgur.com/20BocRc.png "This is how the default music volume should be")


## Variations (unique feature)

Most boss music in the mod has shorter variants that start closer to their respective crescendos that can randomly play instead of the full version from the original OST - some more intense parts of the original tracks usually are incredibly rare to be heard in game (because of how the game difficulty is structured - you are heavily discoraged from not charging the teleporter during the tele event). The variations add a little bit more variety to the soundtrack and frankly some of those more intense parts are just too good so now you don't have to throw to hear them.


## "What songs does a specific stage have?"

You can view the complete mod OST chart here by clicking on the image:

[![Go on, click](https://i.imgur.com/DQsO9pI.png)](https://docs.google.com/spreadsheets/d/1c3XY9khh2maAJCYcTsRGdNDe3fm6T_d_kSLeWz6z3Mc/edit?usp=sharing "Just click on it")


## Customization

Since it's based on OriginalSoundTrack, you are still able to add/remove music tracks and assign stages for them (or for the existing ones) in the `settings.xml` file, which is located in the mod folder. You are still able to change the volume of the individual tracks in it, but as of 2.0.0 the global volume tag at the very top of the file does nothing and the true value was instead moved to a config file so that RiskOfOptions is able to change it.


## Compatibility

The mod is incompatible with any other mod that is using NAudio.dll to play sounds. Make sure you either delete or disable the conflicting audio mods.
It's also vanilla-compatible, so you don't need the SotV to run it AND it would work with new stages if someone hosts a game for you with the DLC enabled.


## Contact info

If you are experiencing any problems with the mod, have questions about it, think that some music choices are odd or want to help me getting around the issues, add me on discord: `MrCounterMax#8959`


## Special thanks to

- Chris Christodoulou (made the music)
- KylePaulsen (made OriginalSoundTrack)
- ZiggyLata (helped to banish the ghost files)
- Paddy (helped with the client-sided update)
- KubeRoot (helped MAJORLY with 2.0.0 update and suffered the ravages of VSC with me)
- Rune580 (allowed the free use of RiskOfOptions dependency and clarified the GPL3 license)
- and you (for playing ♥)


## Known issues

- Music on title screen/in lobby stops playing after about 20 minutes (in order to have a track to not change between the scenes, it has to be non-looping and be the only one able to play)
- Mod breaks if it doesn't play sounds for too long (restart the game)
- No way to make soundtracks more dynamic the way the original ones are (the ability to customize trade-off)
- Mod is heavy (not sure if I want to reduce the audio quality)
- ~~Mod isn't client-sided (there is a branch of the original mod on github with this issue allegedly solved, but I know nothing about programming)~~
- Updates are small and slow (spotting mistakes on my own takes time considering I am devoid of feedback and don't play the game as often)


## Change log
```
v2.0.2
- Fixed more of the readme (VS has fried my brain apparently)
```
```
v2.0.1
- Fixed a very silly typo in the icon
- Tried to make the images in readme to actually show up
```
```
v2.0.0
- Good news is that you can change the volume at any time in the menu. Bad news is that I had to reinstall VS (Special thanks to KubeRoot)
	- Moved global volume to the config file (the one in .xml no longer does anything)
	- Added a volume slider to the settings menu
	- Added RiskOfOptions hard dependency for the volume slider
- Updated some names as to not confuse people who are reading the console messages or the log files
- Updated readme
	- Added images to help find the correct volume menu
	- Rewrote "Customization" header
	- Added "Special thanks to" header
	- Some more clarification on compatibility
- Updated icon
```
```
v1.4.2
- Ok, NOW it's client-sided (Special thanks to Paddy)
- Visual Studio is nuked from my system and I will pray to whatever god there is that I would never need to open it again
```
```
v1.4.1 Experimental
- Fixed broken readme link (hopefully)
```
```
v1.4.0 Experimental
- Attempt to make the mod client-sided (might be broken atm - use the previous stable version in that case)
- The mod now has an appropriate display message (might be broken as well)
- Updated readme
- :moyai:
```
```
v1.3.4
- The Planetarium now no longer plays stage music but does play boss music (apparently, it doesn't have boss scene switch like Commencement does)
```
```
v1.3.3
- Fixed a typo (turns out his name isn't Mytrix)
- Graphic design is my passion
```
```
v1.3.2
- Added missing Köppen As Fuck variant
- Fixing sound normalization among the tracks (still ongoing)
```
```
v1.3.1
- Fixed random music playing while fighting Mytrix
- Cleaned up mod folder
```
```
v1.3.0
- Mod rebuilt for Survivors Of The Void update
- Boss music variants added
```
```
v1.2.2
- Fixed mod only playing title theme (I'm dumb)
```
```
v1.2.1
- Re-added the dehydrated theme
- Memes
- Removed more typos
```
```
v1.2.0
- Fixed issues caused by installing the mod via r2modman (special thanks to Ziggylata):
	- Fixed tracks playing at random (the mod loader does not like certain symbols in names)
	- Fixed ghost files appearing (spooky enigma)
- Removed some typos 
```
```
v1.1.2
- Fixed dependencies. I swear, it all definetely works now.
```
```
v1.1.1 
- settings.xml is now more pleasant to look at.
```
```
v1.1.0
- Removed unnecessary folders to appease r2modman gods
```
```
v1.0.0
- Hello, world.
```