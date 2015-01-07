using System;
using Duality;

namespace ExceptionlessTest
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
