using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using SwinGameSDK;

public static class StopWatch
{
	public static Stopwatch stopWatch = new Stopwatch();

	public static string TimeTaken(string elapsedTime)
	{
		stopWatch.Start();
		Thread.Sleep (10);

		// Get the elapsed time as a TimeSpan value.
		TimeSpan ts = stopWatch.Elapsed;

		// Format and display the TimeSpan value.
		elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
			ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds/10);

		return "RunTime" + elapsedTime;

	}
}