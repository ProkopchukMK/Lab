using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCalculator
{
    class PresenterCalculator
    {
        MainWindow mainWindow = null;
        ModelCalculator modelCalculator = null;

        double x;
        double y;
        string sign;

        public PresenterCalculator(MainWindow mainWindow)
        {
            this.modelCalculator = new ModelCalculator();
            this.mainWindow = mainWindow;
            this.mainWindow.equal += new EventHandler(mainWindow_Equal);
            this.mainWindow.sqrt += new EventHandler(mainWindow_Sqrt);
            this.mainWindow.pow += new EventHandler(mainWindow_Pow);
        }
        //operation Pow
        private void mainWindow_Pow(object sender, EventArgs e)
        {
            string[] split = mainWindow.Field.Text.Split(new char[] { ' ' });
            x = Double.Parse(split[0], NumberStyles.Any);

            this.mainWindow.Field.Text = this.mainWindow.Field.Text + "²" + " = " + this.modelCalculator.Pow2(x).ToString();
        }
        // operation SQRT
        private void mainWindow_Sqrt(object sender, EventArgs e)
        {
            string[] split = mainWindow.Field.Text.Split(new char[] { ' ' });
            x = Double.Parse(split[0], NumberStyles.Any);

            this.mainWindow.Field.Text = Convert.ToChar(0x221A) + this.mainWindow.Field.Text + " = " + this.modelCalculator.Sqrt(x).ToString();
        }
        // operation + - * /
        private void mainWindow_Equal(object sender, EventArgs e)
        {
            string[] split = mainWindow.Field.Text.Split(new char[] { ' ' });
            x = Double.Parse(split[0], NumberStyles.Any);
            sign = split[1];
            y = Double.Parse(split[2], NumberStyles.Any);

            this.mainWindow.Field.Text = this.mainWindow.Field.Text + " = " + this.modelCalculator.Equals(x,y,sign).ToString();
        }
    }
}
