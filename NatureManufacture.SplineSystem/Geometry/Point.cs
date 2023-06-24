using System;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class Point : IComparable<Point>, IEquatable<Point>
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x24E9660", Offset = "0x24E7C60", VA = "0x1824E9660")]
		public Point()
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x24B8320", Offset = "0x24B6920", VA = "0x1824B8320")]
		public Point(double x, double y)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x24E9670", Offset = "0x24E7C70", VA = "0x1824E9670")]
		public Point(double x, double y, int label)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00003150 File Offset: 0x00001350
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		public int ID
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00003168 File Offset: 0x00001368
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009F")]
		public double X
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x5FD5E0", Offset = "0x5FBBE0", VA = "0x1805FD5E0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x24D0860", Offset = "0x24CEE60", VA = "0x1824D0860")]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00003180 File Offset: 0x00001380
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A0")]
		public double Y
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000380")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00003198 File Offset: 0x00001398
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		public double Z
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x5FD5B0", Offset = "0x5FBBB0", VA = "0x1805FD5B0")]
			set
			{
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000031B0 File Offset: 0x000013B0
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A2")]
		public int Label
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
			set
			{
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x24E9680", Offset = "0x24E7C80", VA = "0x1824E9680")]
		public static bool operator ==(Point a, Point b)
		{
			return default(bool);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x24E96C0", Offset = "0x24E7CC0", VA = "0x1824E96C0")]
		public static bool operator !=(Point a, Point b)
		{
			return default(bool);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x24E9700", Offset = "0x24E7D00", VA = "0x1824E9700", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x24E9790", Offset = "0x24E7D90", VA = "0x1824E9790", Slot = "5")]
		public bool Equals(Point p)
		{
			return default(bool);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x24E97C0", Offset = "0x24E7DC0", VA = "0x1824E97C0", Slot = "4")]
		public int CompareTo(Point other)
		{
			return 0;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x24E9830", Offset = "0x24E7E30", VA = "0x1824E9830", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x24E98B0", Offset = "0x24E7EB0", VA = "0x1824E98B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x10")]
		internal int id;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x14")]
		internal int label;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x18")]
		internal double x;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x20")]
		internal double y;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x28")]
		internal double z;
	}
}
