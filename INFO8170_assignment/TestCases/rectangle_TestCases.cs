using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFO8170_assignment;
using NUnit.Framework;

namespace TestCases
{
    [TestFixture]
    class rectangle_TestCases
    {
        [Test]
        public void GetLength_input5_expectLengthequals5()
        {   
            //Arrange
            int l = 4;
            int w = 3;
            Rectangle rect = new Rectangle(l,w);

            //Act
            int length = rect.GetLength();
            //assert
            Assert.AreEqual(length, l);
        }
        [Test]
        public void GetWidth_input5_expectWidthequals5()
        {
            //Arrange
            int l = 4;
            int w = 3;
            Rectangle rect = new Rectangle(l, w);

            //Act
            int width = rect.GetWidth();
            //assert
            Assert.AreEqual(width, w);
            
        }
        [Test]
        public void SetLength_input5_expectLengthequals5()
        {
            //Arrange
            int length = 5;
            Rectangle rect = new Rectangle();

            //Act
            rect.SetLength(length);

            //Assert
            Assert.AreEqual(length, 5);

        }
        [Test]
        public void SetWidth_input5_expectLengthequals5()
        {
            //Arrange
            int width = 5;
            Rectangle rect = new Rectangle();

            //Act
            rect.SetWidth(width);

            //Assert
            Assert.AreEqual(width, 5);

        }
        [Test]
        public void GetPerimeter_input2_expectLengthequals8()
        {
            //arrange
            int l = 2;
            int w = 2;
            Rectangle rect = new Rectangle(l,w);


            //act
            int result = rect.GetPerimeter();
            //assert
            Assert.AreEqual(result, 8);



        }
        [Test]
        public void GetArea_input2_expectLengthequals4()
        {
            //arrange
            int l = 2;
            int w = 2;
            Rectangle rect = new Rectangle(l,w);

            //act
            var result = rect.GetArea();

            //assert
            Assert.AreEqual(result, 4);

        }


    }
}
