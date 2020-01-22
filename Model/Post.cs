﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EFGetStarted.Model
{
	class Post
	{
		public int PostId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }

		public int BlogId { get; set; }
		public Blog Blog { get; set; }
		
	}
}
