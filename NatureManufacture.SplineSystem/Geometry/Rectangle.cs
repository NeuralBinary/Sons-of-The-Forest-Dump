using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public class Rectangle
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x24EA650", Offset = "0x24E8C50", VA = "0x1824EA650")]
		public Rectangle()
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x24EA680", Offset = "0x24E8C80", VA = "0x1824EA680")]
		public Rectangle(Rectangle other)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x24EA6D0", Offset = "0x24E8CD0", VA = "0x1824EA6D0")]
		public Rectangle(double x, double y, double width, double height)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x170000AA")]
		public double Left
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x1240170", Offset = "0x123E770", VA = "0x181240170")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x170000AB")]
		public double Right
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x170000AC")]
		public double Bottom
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x5FD5E0", Offset = "0x5FBBE0", VA = "0x1805FD5E0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x170000AD")]
		public double Top
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x170000AE")]
		public double Width
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x24EA6F0", Offset = "0x24E8CF0", VA = "0x1824EA6F0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x170000AF")]
		public double Height
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x24EA700", Offset = "0x24E8D00", VA = "0x1824EA700")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x24EA710", Offset = "0x24E8D10", VA = "0x1824EA710")]
		public void Resize(double dx, double dy)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x24EA750", Offset = "0x24E8D50", VA = "0x1824EA750")]
		public void Expand(Point p)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x24EA880", Offset = "0x24E8E80", VA = "0x1824EA880")]
		public void Expand(IEnumerable<Point> points)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x24EAA40", Offset = "0x24E9040", VA = "0x1824EAA40")]
		public void Expand(Rectangle other)
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x24EAB70", Offset = "0x24E9170", VA = "0x1824EAB70")]
		public bool Contains(double x, double y)
		{
			return default(bool);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x24EABA0", Offset = "0x24E91A0", VA = "0x1824EABA0")]
		public bool Contains(Point pt)
		{
			return default(bool);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x24EABF0", Offset = "0x24E91F0", VA = "0x1824EABF0")]
		public bool Contains(Rectangle other)
		{
			return default(bool);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x24EAC40", Offset = "0x24E9240", VA = "0x1824EAC40")]
		public bool Intersects(Rectangle other)
		{
			return default(bool);
		}

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x10")]
		private double xmin;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x18")]
		private double ymin;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x20")]
		private double xmax;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x28")]
		private double ymax;
	}
}
