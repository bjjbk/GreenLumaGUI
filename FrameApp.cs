using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GreenLumaGUI
{
    internal class FrameApp
    {
        public static Frame FrameMain { get; set; }

        public static void SetCurrentMainFrame(Frame frame) => FrameMain = frame;


        public static void NavigateToPageMain(Page page)
        {
            if (FrameMain != null)
                FrameMain.Navigate(page);
            else
                throw new InvalidOperationException("Текущий Frame не был установлен. Установите его с помощью SetCurrentFrame.");
        }
    }
}
