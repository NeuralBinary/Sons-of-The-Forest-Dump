using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	public class Hexagon2d
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1FBDB80", Offset = "0x1FBC180", VA = "0x181FBDB80")]
		public Hexagon2d(Vector2d center, double radius, Hexagon2d.TopModes mode = Hexagon2d.TopModes.Flat)
		{
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00005B7C File Offset: 0x00003D7C
		[Token(Token = "0x1700011A")]
		public bool IsClosed
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1FBDBA0", Offset = "0x1FBC1A0", VA = "0x181FBDBA0")]
		public Hexagon2d Clone()
		{
			return null;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00005B94 File Offset: 0x00003D94
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011B")]
		public double InnerRadius
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x1FBDC20", Offset = "0x1FBC220", VA = "0x181FBDC20")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1FBDC40", Offset = "0x1FBC240", VA = "0x181FBDC40")]
			set
			{
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00005BAC File Offset: 0x00003DAC
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1FBDC60", Offset = "0x1FBC260", VA = "0x181FBDC60")]
		public Vector2d Corner(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[Token(Token = "0x1700011C")]
		public double Width
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1FBDD40", Offset = "0x1FBC340", VA = "0x181FBDD40")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00005BDC File Offset: 0x00003DDC
		[Token(Token = "0x1700011D")]
		public double Height
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1FBDD60", Offset = "0x1FBC360", VA = "0x181FBDD60")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00005BF4 File Offset: 0x00003DF4
		[Token(Token = "0x1700011E")]
		public double VertSpacing
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1FBDD90", Offset = "0x1FBC390", VA = "0x181FBDD90")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00005C0C File Offset: 0x00003E0C
		[Token(Token = "0x1700011F")]
		public double HorzSpacing
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1FBDDD0", Offset = "0x1FBC3D0", VA = "0x181FBDDD0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00005C24 File Offset: 0x00003E24
		[Token(Token = "0x17000120")]
		public AxisAlignedBox2d Bounds
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1FBDE00", Offset = "0x1FBC400", VA = "0x181FBDE00")]
			get
			{
				return default(AxisAlignedBox2d);
			}
		}

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d Center;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x20")]
		public double Radius;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x28")]
		public Hexagon2d.TopModes TopMode;

		// Token: 0x0200010B RID: 267
		[Token(Token = "0x200010B")]
		public enum TopModes
		{
			// Token: 0x04000401 RID: 1025
			[Token(Token = "0x4000401")]
			Flat,
			// Token: 0x04000402 RID: 1026
			[Token(Token = "0x4000402")]
			Tip
		}
	}
}
