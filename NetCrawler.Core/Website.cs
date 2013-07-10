﻿using System;

namespace NetCrawler.Core
{
	public class Website
	{
		private Uri rootUri;
		private string rootUrl;

		public string RootUrl
		{
			get { return rootUrl; }
			set
			{
				rootUrl = value;
				rootUri = new Uri(rootUrl);
			}
		}

		public bool FollowExternalLinks { get; set; }
		public int MaxConcurrentConnections { get; set; }

		public DateTimeOffset LastVisit { get; set; }
		public TimeSpan IntervalBetweenVisits { get; set; }

		public bool IsRelativeUrl(CrawlUrl crawlUrl)
		{
			return rootUri.IsBaseOf(crawlUrl.Uri);
		}
	}
}