using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakerWrangler.Models
{
	public class SpeakerWranglerDbContext : DbContext
	{

		public SpeakerWranglerDbContext(DbContextOptions<SpeakerWranglerDbContext> options) : base(options)
		{

		}

		public DbSet<Speaker> Speakers { get; set; }

	}


	public class Speaker
	{

		public int ID { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }


	}

}
