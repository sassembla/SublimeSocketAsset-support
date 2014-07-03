SublimeSocketAsset-support
==========================

Unity SublimeSocketAsset's FAQ &amp; Issue pages.  
[SublimeSocketAsset](https://www.assetstore.unity3d.com/#/content/8003)


##FAQ
- - -
###Q1.The error "SublimeSocketAsset:error  reason:Unable to connect, as no valid crossdomain policy was found" raise.  

	Maybe project's platform setting is "Web Player Platform".
	Not support Web Player Platform yet. This will be supported by future version.
	
- - -
###Q2.Cannot start Unity-build from SublimeText.

	FIXED:It's the SSA version 1.3.x's bug.  
	
	You should set YOUR_PROJECT/Assets/SublimeSocketAsset/Editor/Exec/SwitchApp as "Executable" manually. 
	
	chmod 744 YOUR_PROJECT/Assets/SublimeSocketAsset/Editor/Exec/SwitchApp
	
	or update asset.
	
- - -
###Q3.About supported plattforms
|Sublime Text version|Mac|Windows|
|:------------------:|:-:|:-----:|
|2|SSA 1.0.x or later||
|3|SSA 1.5.x or later|SSA 1.5.x or later|

###Q4.Disconnect per one key-input in Sublime Text.

	Please delete "Asset/SublimeSocketAsset/Preferences.txt" first.
	Then connect again.
	
	If does not improvement,　please contact or open issue.
	
###Q5. Completion never run.

	FIXED:It's the SSA version 1.7.x's bug.
	
	SublimeSocketAsset covered Unity's default coding style only.
	like below:
	
	using UnityEngine;
	using System.Collections;

	public class Something : MonoBehaviour {


		// Use this for initialization
		void Start () {
		
		}
	
		// Update is called once per frame
		void Update () {
	
		}
	}
	
	The other case like below, will not work fine.
	
	using UnityEngine;
	using System.Collections;

	public class Something : MonoBehaviour 
	{


		// Use this for initialization
		void Start () 
		{
			
		}
	
		// Update is called once per frame
		void Update () 
		{
		
		}
	}

	We will fix it for next update.
	


###Online Support
Let's issue,, but, if won't,

fill the check list below

**checklist:**

1. Unity version : Unity ~
2. Platform: Win7,8.x, or Mac OS X 10.x.x
3. Sublime Text version: Version 2.x.x or 3.x.x 
4. Save -> Compile is working?: y/n
5. Show Error/Caution is working?: y/n
6. Run Completion is enabled and working?: y/n

then 

please contact   
[https://twitter.com/sassembla](https://twitter.com/sassembla)
or
[sassembla@mac.com](mailto:sassembla@mac.com)