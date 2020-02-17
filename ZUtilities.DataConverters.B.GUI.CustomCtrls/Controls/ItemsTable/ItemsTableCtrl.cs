using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZUtilities.DataConverters.B.GUI.CustomCtrls.Controls
{
    public class ItemsTableCtrl : Control
    {
        static ItemsTableCtrl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemsTableCtrl), new FrameworkPropertyMetadata(typeof(ItemsTableCtrl)));
        }
    }
}
