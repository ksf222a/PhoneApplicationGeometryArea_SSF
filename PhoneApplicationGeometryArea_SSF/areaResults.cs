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
    public class areaResults
    {
        private string formula;
        private double area;
        
        public void setValues(double _area, string _formula)
        {
            area =_area;
            formula = _formula;
        }
        
        public double getArea()
        {
            return area;
        }
        public string getFormula()
        {
            return formula;
        }
    }
}
