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

namespace Typing_Helper
{
	/// <summary>
	/// Interaction logic for PracticeScreen.xaml
	/// </summary>
	public partial class PracticeScreen : Page
	{
		public PracticeScreen()
		{
			InitializeComponent();

			double lineHeight = 0.5;

			displayedText.SetValue(Block.LineHeightProperty, lineHeight);
			inputText.SetValue(Block.LineHeightProperty, lineHeight);
		}
	}
}
