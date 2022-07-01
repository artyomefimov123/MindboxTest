using System;
using Xunit;
using Figures.Exceptions;
using Figures;

namespace Test
{

    public class Test
    {
        #region ������������ �����
        /// <summary>
        /// ������������� ������
        /// </summary>
        [Fact]
        public void Add_NegativeCircleRadius_ReturnsIncorrectValueException()
        {
            Assert.Throws<IncorrectValueException>(() => { new Circle(-7); });
        }

        /// <summary>
        /// �������� ������������ ���������� ������� 
        /// </summary>
        [Fact]
        public void IsEqual_CircleRadius_ReturnsCircleArea()
        {
            Circle circle = new Circle(3.5);

            var circleArea = Math.Round(circle.GetArea(), 4);

            Assert.Equal(38.4845, circleArea);
        }

        #endregion

        #region ������������ ������������
        /// <summary>
        /// �������� ���������� ��� ������������� ������� 
        /// </summary>
        [Fact]
        public void Add_NegativeTriangleSide_ReturnsIncorrectValueException()
        {
            Assert.Throws<IncorrectValueException>(() => { new Triangle(-1, -2, -3); });
        }

        /// <summary>
        /// �������� ���������� ��� �������������� � ���������� ��������� ������������
        /// </summary>
        [Fact]
        public void Add_NotExistingTriangleSides_ReturnsIncorrectTriangleSidesValuesException()
        {
            Assert.Throws<IncorrectTriangleSidesValuesException>(() => { new Triangle(3, 4, 8); });
        }

        /// <summary>
        /// �������� ������������ ���������� ������� ������������
        /// </summary>
        [Fact]
        public void IsEqual_TriangleSides_ReturnsTriangleArea()
        {

            Triangle triangle = new Triangle(3, 4, 5);

            var triangleArea = triangle.GetArea();

            Assert.Equal(6, triangleArea);
        }

        /// <summary>
        /// �������� ������������ ����������� ��������������� ������������, ��������� true
        /// </summary>
        [Fact]
        public void IsRightTriangle_TriangleSides_ShouldBeTrue()
        {

            Triangle triangle = new Triangle(3, 4, 5);

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.True(isRightTriangle);
        }
        #endregion  
    }
}
