using System;
using SwinGameSDK;
using NUnit.Framework;

namespace MyGame
{
	[TestFixture()]
	public class TestCreditSceneandbugs
	{
		//New variable created just for the unit test purpose
		private static int _CREDIT_CHECK = 0;
		private const int Credit1 =0;
		private const int Credit2 =1;

		//This unit test is to test one of the feature i did previously which is the credits button1
		[Test()]
		public void TestCreditScene1 ()
		{
			PerformChangeBackgroundAction(MenuController.CREDIT1); 
			Assert.IsTrue (_CREDIT_CHECK == 1);
		}

		//This unit test is to test one of the feature i did previously which is the credits button2
		[Test()]
		public void TestCreditScene2 ()
		{
			PerformChangeBackgroundAction(MenuController.CREDIT2); 
			Assert.IsTrue (_CREDIT_CHECK == 2);
		}

		//This test is created to test the previous bugs which is the deployment on the battleship position
		[Test()]
		public void Testbugsdeploylocation()
		{
			int Row = 0;
			int Col = 0;
			Point2D mouse = SwinGame.MousePosition ();

			Row = Convert.ToInt32 (Math.Floor((mouse.Y - UtilityFunctions.FIELD_TOP) / (UtilityFunctions.CELL_HEIGHT + UtilityFunctions.CELL_GAP)));
			Col =  Convert.ToInt32 (Math.Floor((mouse.X - UtilityFunctions.FIELD_LEFT) / (UtilityFunctions.CELL_WIDTH + UtilityFunctions.CELL_GAP)));

			Assert.IsTrue (-3== Row);
			Assert.IsTrue(-9 == Col);
		}


		//This method is duplicated from the MenuController class in order to do unit testing
		public static void PerformChangeBackgroundAction (int button)
		{
			switch (button) {
			case Credit1:
				_CREDIT_CHECK = 1;
				ChangeBackground0 ();
				break;
			case Credit2:
				_CREDIT_CHECK = 2;
				ChangeBackground1 ();
				break;
			}
			GameController.EndCurrentState ();
		}

		//This method is duplicated from the GameResources class in order to do unit testing
		public static void ChangeBackground0 ()
		{
			SwinGame.DrawBitmap ("Credits1.jpg", 0, 0);
			//SwinGame.RefreshScreen (); 
			SwinGame.Delay (3500);
			SwinGame.ProcessEvents ();
		}
		//This method is duplicated from the GameResources class in order to do unit testing
		public static void ChangeBackground1 ()
		{
			SwinGame.DrawBitmap ("Credits2.jpg", 0, 0);
			//SwinGame.RefreshScreen (); 
			SwinGame.Delay (3500);
			SwinGame.ProcessEvents ();
		}


	}
}

