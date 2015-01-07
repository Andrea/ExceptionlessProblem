using Duality;
using Exceptionless;

namespace ExceptionlessTest
{
	/// <summary>
	/// Defines a Duality core plugin.
	/// </summary>
    public class ExceptionlessTestCorePlugin : CorePlugin
    {
		// Override methods here for global logic
		protected override void InitPlugin()
		{
			ExceptionlessClient.Current.Startup();
		}
    }
}
