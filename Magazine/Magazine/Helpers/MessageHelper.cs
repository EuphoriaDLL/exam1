using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Magazine.Helpers
{
    public class MessageHelper
    {
        public void ShowInfo(string message)
        {
            MessageBox.Show(message, "Informaation", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
