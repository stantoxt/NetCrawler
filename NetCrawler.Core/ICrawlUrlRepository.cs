﻿namespace NetCrawler.Core
{
	public interface ICrawlUrlRepository
	{
		bool IsKnown(string key);
		bool TryAdd(string key, CrawlUrl crawlUrl);
		void Done(string key);
		CrawlUrl Next();
		CrawlUrl PeekNext();
	}
}