﻿using NetCrawler.Core;
using ServiceStack.Redis;

namespace NetCrawler.Redis
{
	public class RedisCrawlUrlRepository : ICrawlUrlRepository
	{
		private readonly RedisClient client;

		public RedisCrawlUrlRepository()
		{
			client = new RedisClient("localhost");
			client.FlushAll();
		}

		public bool IsKnown(string key)
		{
			return client.Exists(key) == 1;
		}

		public bool TryAdd(string key, CrawlUrl crawlUrl)
		{
			return client.As<CrawlUrl>().SetEntryIfNotExists(key, crawlUrl);
		}

		public void Done(string key)
		{
			throw new System.NotImplementedException();
		}

		public CrawlUrl Next()
		{
			throw new System.NotImplementedException();
		}

		public CrawlUrl PeekNext()
		{
			throw new System.NotImplementedException();
		}
	}
}