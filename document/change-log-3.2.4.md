2014-08-28
----------
- added queue factories configuration
	* https://github.com/Shuttle/shuttle-esb/issues/37
- [BUG] nuget dependencies reference specific version
	* https://github.com/Shuttle/shuttle-esb/issues/38


2014-08-23
----------
- [BUG] message handler not released
	* message handler is now released when an exception is thrown in the handling code
	* https://github.com/Shuttle/shuttle-esb/issues/36