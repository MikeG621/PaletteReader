/*
 * PaletteReader.exe, Displays PLTT information from LFD files
 * Copyright (C) 2008-2020 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later
 * 
 * VERSION: 1.0
 */
 
using System;
using System.Windows.Forms;

namespace Idmr.PaletteReader
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
