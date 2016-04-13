﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PhoneApplicationGeometryArea_SSF
{
    public class rectangles
    {
        private double height = 0d;
        private double baseLength = 0d;
        const string FORMULA = "Area=Length * Width";
        public void setRectanglesValues(double _height, double _baseLength)
        {
            height = _height;
            baseLength = _baseLength;
        }
        public void setHeight(double _height)
        {
            height = _height;
        }
        public void setBase(double _baseLength)
        {
            baseLength = _baseLength;
        }
        private double calculateArea()
        {
            return height * baseLength ;
        }
        private string getFourmula()
        {
            return FORMULA;
        }
        public areaResults getResults()
        {
            areaResults aResults = new areaResults();
            aResults.setValues(calculateArea(), getFourmula());
            return aResults;
        }

    }
}
