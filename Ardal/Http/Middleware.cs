using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ardal.Http
{
    public class Middleware
    {
        private readonly RequestDelegate Next;
		private readonly Config.Settings Settings;
		private readonly ILogger Logger;
		private readonly AQL.IAQLEngine Engine;

		public Middleware(RequestDelegate next, AQL.IAQLEngine engine, IOptionsSnapshot<Config.Settings> settings, ILogger<Middleware> logger )
        {
            this.Next = next;
			this.Settings = settings.Value;
			this.Logger = logger;
			this.Engine = engine;
		}

		public async Task Invoke(HttpContext context)
        {
			var url = context.Request.Path;
			try {
				var query = await Engine.GetQuery( url );
				if( query == null ) {
					await context.Response.WriteAsync( $"Not found!" );
					return;
				}

				await Engine.Execute( query, context );
			}
			catch(Exception ex) {
				await context.Response.WriteAsync( $"Error: {ex.Message}!" );
				throw ex; // todo: for now
			}
		}
    }
}
