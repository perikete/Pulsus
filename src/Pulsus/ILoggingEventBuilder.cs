﻿using System;

namespace Pulsus
{
	public interface ILoggingEventBuilder<T>
	{
		LoggingEvent LoggingEvent { get; }
		T Timestamp(DateTime timestamp, bool useUtc);
		T AddData(string key, object value); 
		T AddTags(params string[] tags);
		T Text(string text, params object[] args);
		T Source(string source, params object[] args);
		T User(string user, params object[] args);
		T Level(LoggingEventLevel level);
		T Level(int level);
	}
}
