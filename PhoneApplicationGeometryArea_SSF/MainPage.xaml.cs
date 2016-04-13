using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PhoneApplicationGeometryArea_SSF
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            InputScope scope = new InputScope();
            InputScopeName name = new InputScopeName();

            name.NameValue = InputScopeNameValue.Number;
            scope.Names.Add(name);

            textBoxBaseRadius.InputScope = scope;
            textBoxHeight.InputScope = scope;
        }
        int SelectedChoice = 1;
        

        

        private void rbTriangle_Click(object sender, RoutedEventArgs e)
        {
            textBlockRadBase.Text = "Base";
            textBlockHeight.Visibility = Visibility.Visible;
            textBoxHeight.Visibility = Visibility.Visible;
            SelectedChoice = 1;
        }

        private void rbCircle_Click(object sender, RoutedEventArgs e)
        {
            textBlockRadBase.Text = "Radius";
            textBlockHeight.Visibility = Visibility.Collapsed;
            textBoxHeight.Visibility = Visibility.Collapsed;
            SelectedChoice = 2;
        }

        private void rbRectangle_Click(object sender, RoutedEventArgs e)
        {
            textBlockRadBase.Text = "Base";
            textBlockHeight.Visibility = Visibility.Visible;
            textBoxHeight.Visibility = Visibility.Visible;
            SelectedChoice = 3;
        }
        private Boolean dataValidate()
        {
            Boolean isValid=true;
            double userInput=0d;
            if(!(double.TryParse(textBoxBaseRadius.Text.Trim(), out userInput)))
            {
                isValid=false;
                MessageBox.Show("You entered non-numeric data for "+  textBlockRadBase.Text.Trim() +" , please try again","Invalid Entry",MessageBoxButton.OK);
                textBoxBaseRadius.Text="";
            }
            if (SelectedChoice!=2 && !(double.TryParse(textBoxHeight.Text.Trim() , out userInput)))
            {
                isValid=false;
                MessageBox.Show("You entered non-numeric data for Height, please try again","Invalid Entry",MessageBoxButton.OK);
                textBoxHeight.Text = "";
            }
            return isValid;
        }
        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            areaResults areaReslt = new areaResults();
            String shapeName = "";
            if (dataValidate())
            {
              switch (SelectedChoice)
                {
                    case 1:
                        triangles triangle = new triangles();
                        triangle.setBase(double.Parse(textBoxBaseRadius.Text.Trim()));
                        triangle.setHeight(double.Parse(textBoxHeight.Text.Trim()));
                        areaReslt = triangle.getResults();
                        shapeName = "triangle";
                        break;
                    case 2:
                        circles circle = new circles();
                        circle.setRadius(double.Parse(textBoxBaseRadius.Text.Trim()));
                        areaReslt = circle.getResults();
                        shapeName = "circle";
                        break;

                    case 3:
                        rectangles rectangle = new rectangles();
                        rectangle.setBase(double.Parse(textBoxBaseRadius.Text.Trim()));
                        rectangle.setHeight(double.Parse(textBoxHeight.Text.Trim()));
                        areaReslt = rectangle.getResults();
                        shapeName = "rectangle";
                        break;
                }
              textBlockArea.Text = "Area for " + shapeName +  " = " + areaReslt.getArea().ToString("#.##");
                textBlockFormula.Text = "Formula for " + shapeName + ": " + areaReslt.getFormula().ToString();
            }
        
        }

        
    }
}