using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality;

namespace exceptionlessTest
{
	[Serializable]
    public class ExceptionThrowingComponent : Component, ICmpInitializable
    {

		public void OnInit(InitContext context)
		{
			if (context != InitContext.Activate || DualityApp.ExecContext != DualityApp.ExecutionContext.Game)
				return;

			Log.Game.Write("Hi throwing an exception for exceptionless");

			throw new Exception("Exception test ");
			
		}

		public void OnShutdown(ShutdownContext context)
		{
	
		}
    }
}
