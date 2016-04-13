using System;
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
    public class circles
    {
        private double radius = 0d;
        const string FORMULA = "Area=πr2";
        
        public void setRadius(double _radius)
        {
            radius = _radius;
        }
       
        private double calculateArea()
        {
            return Math.PI*radius*radius ;
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
