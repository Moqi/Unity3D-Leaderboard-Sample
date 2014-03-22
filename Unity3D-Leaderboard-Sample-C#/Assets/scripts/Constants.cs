using UnityEngine;
using System.Collections;


/* GETTING API_KEY & SECRET_KEY.

1. [Register] (https://apphq.shephertz.com/register) with App42 platform.
2. Create an app once you are on Quick-start page after registration.
3. Fill all the mandatory fields to get your APIKey and SecretKey.
4. Paste the API_KEY & SECRET_KEY below.

 */


/* GETTING GAME_NAME.

 * Go to Business Service Manager -> Game Service -> Select Your App -> Click on Add Game button.
 * Once your game/level is created you are ready to use leaderboard services as explained below.
    1. Save User score.
    2. Get Top N Rankers.
 */

public class Constants
{
	public string apiKey  ="YOUR_API_KEY"; // API key that you have receieved after the success of app creation from AppHQ.
	public string secretKey ="YOUR_SECRET_KEY";	// SECRET key that you have receieved after the success of app creation from AppHQ.
	
	public string gameName ="YOUR_GAME_NAME"; // Name of the game which you can create from AppHQ console by clicking 
											// Business Service -> Game Service -> Game -> Add Game.
}
