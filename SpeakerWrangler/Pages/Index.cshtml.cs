using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SpeakerWrangler.Models;

namespace SpeakerWrangler.Pages
{
	public class IndexModel : PageModel
	{
		private readonly SpeakerWranglerDbContext _Context;

		public IndexModel(SpeakerWranglerDbContext context)
		{
			this._Context = context;
		}

		public IEnumerable<Speaker> Speakers { get; private set; }

		public void OnGet()
		{
			this.Speakers = _Context.Speakers.OrderBy(s => s.Name);
		}

	}
}
