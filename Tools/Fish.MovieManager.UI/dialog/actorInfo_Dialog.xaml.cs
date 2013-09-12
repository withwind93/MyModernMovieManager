﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

///
using System.Diagnostics;
using System.Collections.ObjectModel;
using NHibernate;
using NHibernate.Linq;
//
using MahApps;
using MahApps.Metro.Controls;
using MahApps.Metro;

namespace Fish.MovieManager.UI.dialog
{
	/// <summary>
	/// actorInfo_Dialog.xaml 的交互逻辑
	/// </summary>
	
	public partial class actorInfo_Dialog : MetroWindow
	{
		public actorInfo_Dialog(int x)
		{
			InitializeComponent();

			ThemeManager.ChangeTheme(this, MainWindow.currentAccent, MainWindow.currentTheme);
	
		}

		private void actorList_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			Fish.MovieManager.DoubanActorInfo.Storage.DoubanActorInfo tmp = this.actorList.SelectedItem as DoubanActorInfo.Storage.DoubanActorInfo;
			if (tmp != null)
			{
				this.name.Text = tmp.name;
				this.id.Text = tmp.id.ToString();
				this.nameEn.Text = tmp.nameEn;
				this.gender.Text = tmp.gender;
				this.bornPlace.Text = tmp.bornPlace;
			}
		}

		private void close_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
