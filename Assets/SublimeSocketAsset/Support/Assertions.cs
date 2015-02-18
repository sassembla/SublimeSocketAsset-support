/**
    Assertion features for Unity.
*/
using System;
using System.Globalization;
using UnityEngine;

namespace SublimeSocketAsset {

	static class Assertions {
		
		/**
			assert which extends bool.
			
			e.g.
				(false).Assert("hereComes");

				will fail.

			(mustNotNull != null).Assert("but null,,");
		*/
		public static void Assert (this bool condition, string reason) {
			if (condition) return;

			OutputStackThenDown(reason);
		}


		/**
			assert which extends string of date
		
			e.g.
				("2014/07/08 00:00:00").TimeAssert("hereComes");

				will fail after 2014/07/08 00:00:00.

			("2014/07/07 00:00:00").TimeAssert("time's up!");
		*/
		public static void TimeAssert (this string limitDate, string reason, int additionalSec = 0) {
			DateTime parsedDate;
			
			var fullhead_time_result = DateTime.TryParseExact(limitDate, "yyyy/MM/dd hh:mm:ss", null, DateTimeStyles.None, out parsedDate);
			if (!fullhead_time_result) {
				var no_head_time_result = DateTime.TryParseExact(limitDate, "yyyy/MM/dd h:mm:ss", null, DateTimeStyles.None, out parsedDate);
				if (!no_head_time_result) {
					return;
				}
			}

			var now = DateTime.Now;
			var diff = now - parsedDate;
			var diffSec = Math.Floor(diff.TotalSeconds);
			
			if (diffSec < additionalSec) {
				return;
			}

			OutputStackThenDown(reason + " passed:" + (additionalSec - diffSec) + "sec");
		}

		/**
			utility.
		*/
		private static void OutputStackThenDown (string reason) {
			System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(true);

			// at least 2 stack exists in st. 0 is "System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(true);", 1 is where the assertion faild.
			var assertFaildPointDescription = st.GetFrame(2).ToString();

			// get specific data from stacktrace.
			var descriptions = assertFaildPointDescription.Split(':');
			var fileName = descriptions[2].Split(' ')[1];
			var line = descriptions[3];

			Debug.LogError("A:" + fileName + ":" + line + ":" + reason);
			
			// broke up
			Debug.Break();
		}
	}
}