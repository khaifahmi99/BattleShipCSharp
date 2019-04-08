using System;
using SwinGameSDK;
using static SwinGameSDK.SwinGame; // requires mcs version 4+, 
// using SwinGameSDK.SwinGame; // requires mcs version 4+, 

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Open the game window
            OpenGraphicsWindow("GameMain", 800, 600);
            ShowSwinGameSplashScreen();

            GameResources.LoadResources();

            SwinGame.PlayMusic(GameResources.GameMusic("Background"));

            //Run the game loop
            while (false == WindowCloseRequested() | GameController.CurrentState == GameState.Quitting)
            {
                //Fetch the next batch of UI interaction
                //ProcessEvents();

                //Clear the screen and draw the framerate
                //ClearScreen(Color.White);
                //DrawFramerate(0,0);

                //Draw onto the screen
                //RefreshScreen(60);
                GameController.HandleUserInput();
                GameController.DrawScreen();
            }

            SwinGame.StopMusic();

            // Free Resources and Close Audio, to end the program.
            GameResources.FreeResources();

        }
    }
}
