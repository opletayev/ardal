using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ardal.AQL
{
	
	public interface IAQLEngine {
		Task<AQLQuery> GetQuery( string url );
		Task Execute( AQLQuery query, HttpContext http );
	}

    public class AQLEngine: IAQLEngine {
		protected readonly Config.Settings Settings;
		protected readonly ILogger Logger;

		public AQLEngine(IOptionsSnapshot<Config.Settings> settings, ILogger<AQLEngine> logger ) {
			this.Settings = settings.Value;
			this.Logger = logger;
		}

		public async Task Execute( AQLQuery query, HttpContext http ) {
			await http.Response.WriteAsync( $"Executing!" );
		}

		Task<AQLQuery> IAQLEngine.GetQuery( string url ) {
			return Task.FromResult<AQLQuery>( null );
		}
	}
}
