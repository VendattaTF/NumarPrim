using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumarPrim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;




namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NrPrim_23_ret_1()
        {
            //arrange

            int x = 23;
            int expected = 1;

            //act

            Corp c = new Corp();
            int actual = c.prim(x);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NrPrim_22_ret_0()
        {
            //arrange

            int x = 22;
            int expected = 0;

            //act

            Corp c = new Corp();
            int actual = c.prim(x);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsDigit_mama_ret_0()
        {
            //arrange

            string x = "mama";
            int expected = 0;

            //act

            Corp c = new Corp();
            int actual = c.IsDigitsOnly(x);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsDigit_999_ret_1()
        {
            //arrange

            string x = "999";
            int expected = 1;

            //act

            Corp c = new Corp();
            int actual = c.IsDigitsOnly(x);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ButtonClick_23_backcolor_Red()
        {
            //arrange

           

            //act
            int actual;
            Corp c = new Corp();
            c.Show();
            c.textbox.Text = "23";
            c.StartButton.PerformClick();

            

            //assert
            Assert.AreEqual(Color.Red,c.BackColor );
        }
        [TestMethod]
        public void ButtonClick_22_backcolor_Green()
        {
            //arrange



            //act
            int actual;
            Corp c = new Corp();
            c.Show();
            c.textbox.Text = "22";
            c.StartButton.PerformClick();

            //assert
            Assert.AreEqual(Color.Green, c.BackColor);
        }


    }
}
