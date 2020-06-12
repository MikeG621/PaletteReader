/*
 * PaletteReader.exe, Displays PLTT information from LFD files
 * Copyright (C) 2008-2020 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later
 * 
 * VERSION: 1.0
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using Idmr.LfdReader;

namespace Idmr.PaletteReader
{
	public partial class MainForm : Form
	{
		private PictureBox[] _swatches = new PictureBox[256];
		private long[] _plttOffsets;

		public MainForm()
		{
			InitializeComponent();
			#region array assignment
			_swatches[0] = box1;
			_swatches[1] = box2;
			_swatches[2] = box3;
			_swatches[3] = box4;
			_swatches[4] = box5;
			_swatches[5] = box6;
			_swatches[6] = box7;
			_swatches[7] = box8;
			_swatches[8] = box9;
			_swatches[9] = box10;
			_swatches[10] = box11;
			_swatches[11] = box12;
			_swatches[12] = box13;
			_swatches[13] = box14;
			_swatches[14] = box15;
			_swatches[15] = box16;
			_swatches[16] = box17;
			_swatches[17] = box18;
			_swatches[18] = box19;
			_swatches[19] = box20;
			_swatches[20] = box21;
			_swatches[21] = box22;
			_swatches[22] = box23;
			_swatches[23] = box24;
			_swatches[24] = box25;
			_swatches[25] = box26;
			_swatches[26] = box27;
			_swatches[27] = box28;
			_swatches[28] = box29;
			_swatches[29] = box30;
			_swatches[30] = box31;
			_swatches[31] = box32;
			_swatches[32] = box33;
			_swatches[33] = box34;
			_swatches[34] = box35;
			_swatches[35] = box36;
			_swatches[36] = box37;
			_swatches[37] = box38;
			_swatches[38] = box39;
			_swatches[39] = box40;
			_swatches[40] = box41;
			_swatches[41] = box42;
			_swatches[42] = box43;
			_swatches[43] = box44;
			_swatches[44] = box45;
			_swatches[45] = box46;
			_swatches[46] = box47;
			_swatches[47] = box48;
			_swatches[48] = box49;
			_swatches[49] = box50;
			_swatches[50] = box51;
			_swatches[51] = box52;
			_swatches[52] = box53;
			_swatches[53] = box54;
			_swatches[54] = box55;
			_swatches[55] = box56;
			_swatches[56] = box57;
			_swatches[57] = box58;
			_swatches[58] = box59;
			_swatches[59] = box60;
			_swatches[60] = box61;
			_swatches[61] = box62;
			_swatches[62] = box63;
			_swatches[63] = box64;
			_swatches[64] = box65;
			_swatches[65] = box66;
			_swatches[66] = box67;
			_swatches[67] = box68;
			_swatches[68] = box69;
			_swatches[69] = box70;
			_swatches[70] = box71;
			_swatches[71] = box72;
			_swatches[72] = box73;
			_swatches[73] = box74;
			_swatches[74] = box75;
			_swatches[75] = box76;
			_swatches[76] = box77;
			_swatches[77] = box78;
			_swatches[78] = box79;
			_swatches[79] = box80;
			_swatches[80] = box81;
			_swatches[81] = box82;
			_swatches[82] = box83;
			_swatches[83] = box84;
			_swatches[84] = box85;
			_swatches[85] = box86;
			_swatches[86] = box87;
			_swatches[87] = box88;
			_swatches[88] = box89;
			_swatches[89] = box90;
			_swatches[90] = box91;
			_swatches[91] = box92;
			_swatches[92] = box93;
			_swatches[93] = box94;
			_swatches[94] = box95;
			_swatches[95] = box96;
			_swatches[96] = box97;
			_swatches[97] = box98;
			_swatches[98] = box99;
			_swatches[99] = box100;
			_swatches[100] = box101;
			_swatches[101] = box102;
			_swatches[102] = box103;
			_swatches[103] = box104;
			_swatches[104] = box105;
			_swatches[105] = box106;
			_swatches[106] = box107;
			_swatches[107] = box108;
			_swatches[108] = box109;
			_swatches[109] = box110;
			_swatches[110] = box111;
			_swatches[111] = box112;
			_swatches[112] = box113;
			_swatches[113] = box114;
			_swatches[114] = box115;
			_swatches[115] = box116;
			_swatches[116] = box117;
			_swatches[117] = box118;
			_swatches[118] = box119;
			_swatches[119] = box120;
			_swatches[120] = box121;
			_swatches[121] = box122;
			_swatches[122] = box123;
			_swatches[123] = box124;
			_swatches[124] = box125;
			_swatches[125] = box126;
			_swatches[126] = box127;
			_swatches[127] = box128;
			_swatches[128] = box129;
			_swatches[129] = box130;
			_swatches[130] = box131;
			_swatches[131] = box132;
			_swatches[132] = box133;
			_swatches[133] = box134;
			_swatches[134] = box135;
			_swatches[135] = box136;
			_swatches[136] = box137;
			_swatches[137] = box138;
			_swatches[138] = box139;
			_swatches[139] = box140;
			_swatches[140] = box141;
			_swatches[141] = box142;
			_swatches[142] = box143;
			_swatches[143] = box144;
			_swatches[144] = box145;
			_swatches[145] = box146;
			_swatches[146] = box147;
			_swatches[147] = box148;
			_swatches[148] = box149;
			_swatches[149] = box150;
			_swatches[150] = box151;
			_swatches[151] = box152;
			_swatches[152] = box153;
			_swatches[153] = box154;
			_swatches[154] = box155;
			_swatches[155] = box156;
			_swatches[156] = box157;
			_swatches[157] = box158;
			_swatches[158] = box159;
			_swatches[159] = box160;
			_swatches[160] = box161;
			_swatches[161] = box162;
			_swatches[162] = box163;
			_swatches[163] = box164;
			_swatches[164] = box165;
			_swatches[165] = box166;
			_swatches[166] = box167;
			_swatches[167] = box168;
			_swatches[168] = box169;
			_swatches[169] = box170;
			_swatches[170] = box171;
			_swatches[171] = box172;
			_swatches[172] = box173;
			_swatches[173] = box174;
			_swatches[174] = box175;
			_swatches[175] = box176;
			_swatches[176] = box177;
			_swatches[177] = box178;
			_swatches[178] = box179;
			_swatches[179] = box180;
			_swatches[180] = box181;
			_swatches[181] = box182;
			_swatches[182] = box183;
			_swatches[183] = box184;
			_swatches[184] = box185;
			_swatches[185] = box186;
			_swatches[186] = box187;
			_swatches[187] = box188;
			_swatches[188] = box189;
			_swatches[189] = box190;
			_swatches[190] = box191;
			_swatches[191] = box192;
			_swatches[192] = box193;
			_swatches[193] = box194;
			_swatches[194] = box195;
			_swatches[195] = box196;
			_swatches[196] = box197;
			_swatches[197] = box198;
			_swatches[198] = box199;
			_swatches[199] = box200;
			_swatches[200] = box201;
			_swatches[201] = box202;
			_swatches[202] = box203;
			_swatches[203] = box204;
			_swatches[204] = box205;
			_swatches[205] = box206;
			_swatches[206] = box207;
			_swatches[207] = box208;
			_swatches[208] = box209;
			_swatches[209] = box210;
			_swatches[210] = box211;
			_swatches[211] = box212;
			_swatches[212] = box213;
			_swatches[213] = box214;
			_swatches[214] = box215;
			_swatches[215] = box216;
			_swatches[216] = box217;
			_swatches[217] = box218;
			_swatches[218] = box219;
			_swatches[219] = box220;
			_swatches[220] = box221;
			_swatches[221] = box222;
			_swatches[222] = box223;
			_swatches[223] = box224;
			_swatches[224] = box225;
			_swatches[225] = box226;
			_swatches[226] = box227;
			_swatches[227] = box228;
			_swatches[228] = box229;
			_swatches[229] = box230;
			_swatches[230] = box231;
			_swatches[231] = box232;
			_swatches[232] = box233;
			_swatches[233] = box234;
			_swatches[234] = box235;
			_swatches[235] = box236;
			_swatches[236] = box237;
			_swatches[237] = box238;
			_swatches[238] = box239;
			_swatches[239] = box240;
			_swatches[240] = box241;
			_swatches[241] = box242;
			_swatches[242] = box243;
			_swatches[243] = box244;
			_swatches[244] = box245;
			_swatches[245] = box246;
			_swatches[246] = box247;
			_swatches[247] = box248;
			_swatches[248] = box249;
			_swatches[249] = box250;
			_swatches[250] = box251;
			_swatches[251] = box252;
			_swatches[252] = box253;
			_swatches[253] = box254;
			_swatches[254] = box255;
			_swatches[255] = box256;
			#endregion
			for (int i = 0; i < 256; i++)
			{
				_swatches[i].MouseEnter += new EventHandler(swatches_MouseEnter);
				_swatches[i].Tag = i;
				_swatches[i].BackColor = Color.Black;
				_swatches[i].Enabled = false;
			}
		}

		void swatches_MouseEnter(object sender, EventArgs e)
		{
			PictureBox p = (PictureBox)sender;
			if (p.Enabled) lblColor.Text = "R: " + p.BackColor.R + "\nG: " + p.BackColor.G + "\nB: " + p.BackColor.B + "\nIndex: " + p.Tag;
		}

		void cmdOpen_Click(object sender, EventArgs e)
		{
			opnLFD.ShowDialog();
		}

		void opnLFD_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			foreach (PictureBox p in _swatches)
			{
				p.BackColor = Color.Black;
				p.Enabled = false;
			}
			txtFile.Text = opnLFD.FileName;
			lstPltt.Items.Clear();
			lblPltt.Text = "StartIndex:\nEndIndex:";
			lblColor.Text = "R:\nG:\nB:\nIndex:";
			try
			{
				Rmap rmp = new Rmap(opnLFD.FileName);
				_plttOffsets = new long[rmp.NumberOfHeaders];
				int pltt = 0;
				for (int i = 0; i < rmp.NumberOfHeaders; i++)
				{
					if (rmp.SubHeaders[i].Type == Resource.ResourceType.Pltt)
					{
						_plttOffsets[pltt] = rmp.SubHeaders[i].Offset;
						pltt++;
						lstPltt.Items.Add(rmp.SubHeaders[i].Name);
					}
				}
			}
			catch // Cockpit LFD, doesn't have an RMAP but there is a PLTT
			{
				_plttOffsets = new long[1];
				Pltt pal = (Pltt)(new LfdFile(opnLFD.FileName).Resources[2]);
				_plttOffsets[0] = pal.Offset;
				lstPltt.Items.Add(pal.Name);
			}
		}

		void lstPLTT_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstPltt.SelectedIndex == - 1) return;
			Pltt plt = new Pltt(txtFile.Text, _plttOffsets[lstPltt.SelectedIndex]);
			lblPltt.Text = "StartIndex: " + plt.StartIndex + "\nEndIndex: " + plt.EndIndex;
			lblColor.Text = "R:\nG:\nB:\nIndex:";
			for (int i = 0; i < plt.StartIndex; i++)
			{
				_swatches[i].BackColor = Color.Black;
				_swatches[i].Enabled = false;
			}
			for (int i = plt.StartIndex; i <= plt.EndIndex; i++)
			{
				_swatches[i].Enabled = true;
				_swatches[i].BackColor = plt.Entries[i];
			}
			for (int i = plt.EndIndex + 1; i < 256; i++)
			{
				_swatches[i].BackColor = Color.Black;
				_swatches[i].Enabled = false;
			}
		}
	}
}
