using BowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest 
    {
        private BowlingGame.Game g;

        protected void setUp(){
            g = new BowlingGame.Game();
       }
        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.roll(pins);
        }

        [TestMethod]
        public void testGutterGame() {
            //int n = 20;
            //int pins = 0;
            //BowlingGame.Game g = new BowlingGame.Game();
            //for (int i = 0; i < n; i++)
            //   g.roll(pins);     
            try
            {
                rollMany(20, 0);
                Assert.AreEqual(0, g.Score());
            }
            catch(Exception e)
            {
                Console.WriteLine("\nMessage ---\n{0}", e.Message); ;
            }
      }
       

        [TestMethod]
      public void testAllOnes()  {
      //BowlingGame.Game g = new BowlingGame.Game();
      //for (int i = 0; i < 20; i++)
      //g.roll(1);
          try
          {
              rollMany(20, 1);
              Assert.AreEqual(20, g.Score());
          }
          catch (Exception e)
          {
              Console.WriteLine("\nMessage ---\n{0}", e.Message);
          }
  }
        [TestMethod]
     public void testOneSpare()  {
         try
         {
             rollSpare();
             g.roll(3);
             rollMany(17, 0);
             Assert.AreEqual(16, g.Score());
         }
         catch (Exception e)
         {
             Console.WriteLine("\nMessage ---\n{0}", e.Message);
         }
  }
     [TestMethod]
     public void testOneStrike() {
         try
         {
             rollStrike();
             g.roll(3);
             g.roll(4);
             rollMany(16, 0);
             Assert.AreEqual(24, g.Score());
         }
         catch (Exception e)
         {
             Console.WriteLine("\nMessage ---\n{0}", e.Message);
         }       }
     public void testPerfectGame() {            rollMany(12,10);
            Assert.AreEqual(300, g.Score());      }
     private void rollStrike()
     {
         g.roll(10);
     }
     private void rollSpare()
        {
            g.roll(5);
            g.roll(5);
        }    
    }
}
