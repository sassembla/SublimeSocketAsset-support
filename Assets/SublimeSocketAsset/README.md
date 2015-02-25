# SublimeSocketAsset
ver 2.0.2

###Demo movie
version 1.3.x or later [https://vimeo.com/67494197](https://vimeo.com/67494197)

###Requirement

This Asset requires below.  

* Sublime Text :The Editor.  
 [http://www.sublimetext.com](http://www.sublimetext.com)
 
* SublimeSocket :The plugin for Sublime Text.

* SublimeSocketAsset (this)

###Limitation
SublimeSocketAsset uses Unity Editor's Auto Refresh function.

please check,  
Unity Editor > Preferences > General > Auto Refresh is enabled.


###problem with Mac OS X Yosemite,  
The Application which is out of focus will slow down forcely. This causes Unity Editor's tick speed down too.  
SublimeSocketAsset depends on Unity Editor, because of that completion function will speed down too.  

Unity Editor's tick speed will regain when you "Save" your code with SublimeSocketAsset. but will slow down again. 

We'll solve this problem version in ver 2.1.x 


###Free version limitation

* only work for Sublime Text 3.
* completion limited only UnityEngine.dll's class.
* all codes are not editable. in Asset Store version, you can edit all codes (except json, ws, UniRx, NRefactory dlls.)

please test free version:
[https://github.com/sassembla/SublimeSocketAsset-support](https://github.com/sassembla/SublimeSocketAsset-support)

###Supported Sublime Text / OS

| Sublime Text | Mac | Windows |
|:-----------:|:------------:|:------------:|
| Sublime Text 2|SublimeSocket 1.0.x or later|None|
| Sublime Text 3|SublimeSocket 1.5.x or later|SublimeSocket 1.5.x or later|

###Installation
SublimeSocketAsset is already in your project. then,  

1.
**Install** "SublimeSocket plugin" to your Sublime Text.  
**Check your Sublime Text's version and install plugin.  
Please see below.**  
[http://sassembla.github.io/Public/source/SublimeSocket/How to install SublimeSocket for Sublime Text X.html](http://sassembla.github.io/Public/source/SublimeSocket/How%20to%20install%20SublimeSocket%20for%20Sublime%20Text%20X.html)  
######then -> Turn on SublimeSocket & SublimeSocketAsset
2.
In Sublime Text,   
CommandPalette(command + shift + p) >  
type "sublimesocket on" >  
choose "SublimeSocket: on" from list.  
SublimeSocket will start running.


3.
In Unity editor,  
ToolBar >  
SublimeSocketAsset >  
chosse **"connect"**  
or   
**[Play] your Project.**

###Sublime Text 3 beta support [experimental]
Sublime Text 3 is now supported by SublimeSocketAsset version 1.5.x or later.  
But not yet default setting.  

1.
Open Asset/SublimeSocketAsset/Editor/Scripts/UnitySublimeSocketClient.cs
2.
Search the below line.  

		public static readonly string SublimeTextVersion = "2";
3.
Change the number to "3".  

		public static readonly string SublimeTextVersion = "3";

Note that Windows7/8 has no notification function.  
The notification function for Windows8 is in the plan.

###Compile & Show errors on SublimeText
1.
Open project files with SublimeText.

2.
Unity-compile will start when source code will be saved on SublimeText.

###Play & See runtime-parameter on SublimeText
1.
Write "Debug.Log(SPECIFIC-FORMAT)" to the project's code.
format is below.

2.
In Unity editor, "Play" the project.

3.
The result of latest param-parameter will appear on formatted "Debug.Log()" line.

######The runtime-parameter log specific format
	Debug.Log("L:" + "comment or nothing" + [THE_PARAM_WANT_TO_SEE_VALUE]);
	

###Completion  
#####sample movie
[On Windows](https://vimeo.com/71184393)  
[On Mac](https://vimeo.com/71184153)
#####enable/disable
default setting is "ON".
If you want to disable completion,  
set "completion": "off" in Preferences.txt.
		
#####About completion cache file
this function generates the library-cache that includes the stable classes info.

	SublimeSocketAsset/StaticCompletionCache.cache

Please ignore it in version control.

		
		
###Customize SSA
SSA's functions are customizable. 
All behaviours are defined in **./Filter/UnityFilterSource.txt**

e.g. UnityFilterSource.txt: 

	~...
	->defineFilter: {
        "name": "unity",
        "filters": [
            {
                // Unity error
                "(.*)[(]([0-9].*?),.*[)]: error .*: (.*)": {
                    "injects": {
                        "groups[0]": "name",
                        "groups[1]": "line",
                        "groups[2]": "reason"
                    },
                    "selectors": [
                        {
                            "showAtLog<-name, line, reason": {
                                "format": "ERROR: on [name]:[line] [reason]"
                            }
                        },
                        {
                            "appendRegion<-name, line, reason": {
                                "format": "\"ERROR: [reason]\"",
                                "condition": "keyword"
                            }
                        }
                    ]
                }
            },
	        {…~
These settings represents capture the regexp from Unity's log, then will show some errors in the Sublime Text Editot.

you can modify/add new patterns and behaviours manually.


###AutoConnect
SSA will connect Unity editor to SublimeText when Unity editor "boot" and "Play" entered.  

Unity editor > ToolBar > SublimeSocketAsset >   

	autoConnect-on
	autoConnect-off

or
	
	change "autoConnect" value in Preferences.txt


#####To connect to WebPlayer-setting Editor
You need to set policy server setting. see below.

	./Filter/WebPlayerPolicyServingFilter.txt


###What is ./Preferences.txt
This file is preference for SublimeSocketAsset.  
Written by SublimeSocketAsset itself.

These are settings for controlling USSA.

	{
		"version": "1.0.0",
		"server": "ws://127.0.0.1:8823",
		"target": "~/Library/Logs/Unity/Editor.log",
		"status": "notConnected",
		"error": "Connection refused",
		"autoConnect": "on",
		"playFlag": "off",
		"breakFlag": "off"
	}	

detail
	
	version: SublimeSocketAsset's version.
	server: SublimeText's plugin receiver.
	target: The Unity's log output path that read by SublimeSocket read.
	status: current status for SublimeSocket. connected or notConnected.
	error: current error displays if the error occured.
	autoConnect:
		if on, SublimeSocket start connecting both the Unity editor and the SublimeText when_
		1.Unity editor booted.
		2."Play" ignited on editor.
	
		else no, do nothing.
	
	playFlag,breakFlag: not use yet. flag for future function.


###FAQ & Online Support
[SublimeSocketAsset-support](https://github.com/sassembla/SublimeSocketAsset-support)  
https://github.com/sassembla/SublimeSocketAsset-support

please contact   
[https://twitter.com/sassembla](https://twitter.com/sassembla)
or
[sassembla@mac.com](mailto:sassembla@mac.com)

