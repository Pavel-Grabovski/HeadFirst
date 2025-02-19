using PlayerMP3.Controllers;
using PlayerMP3.Models;

namespace PlayerMP3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IBeatModel model = new BeatModel();
            IController controller = new BeatController(model);

            Application.Run(new DJView(controller, model));
        }
    }
}