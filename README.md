SublimeSocketAsset-support
==========================

Unity SublimeSocketAsset's FAQ &amp; Issue pages.  
[SublimeSocketAsset](https://www.assetstore.unity3d.com/#/content/8003)


##FAQ
###Q1.The error "SublimeSocketAsset:error  reason:Unable to connect, as no valid crossdomain policy was found" raise.  

	SublimeSocketAsset version 1.3.x are not support Web Player Platform. This will be supported by next version 1.4.x or later.
	
###Q2.Cannot start Unity-build from SublimeText.
	It's the SSA version 1.3.x's bug.  
	You should set YOUR_PROJECT/Assets/SublimeSocketAsset/Editor/Exec/SwitchApp as "Executable" manually. 
	
	chmod 744 YOUR_PROJECT/Assets/SublimeSocketAsset/Editor/Exec/SwitchApp
	
	Sorry for no-information in the installation process about that.
	1.4.x will include these information.