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

        public DbSet<Event> Events { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Submission> Submissions { get; set; }


    }




}
