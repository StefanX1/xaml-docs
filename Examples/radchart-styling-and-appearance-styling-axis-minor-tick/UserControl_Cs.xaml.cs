using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radchart-styling-and-appearance-styling-axis-minor-tick_2
this.radChart.DefaultView.ChartArea.AxisY.AxisStyles.MinorTickLineStyle = this.Resources[ "AxisYMinorTickStyle" ] as Style;
this.radChart.DefaultView.ChartArea.AxisY.AxisStyles.TickLineStyle = this.Resources[ "AxisYTickStyle" ] as Style;
#endregion
}
