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

            IPlayerModel model = new PlayerModel();
            IController controller = new PlayerController(model);

            Application.Run(controller.GetView());
        }
    }
}