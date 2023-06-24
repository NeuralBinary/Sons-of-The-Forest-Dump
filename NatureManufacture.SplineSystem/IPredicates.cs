using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public interface IPredicates
	{
		// Token: 0x06000072 RID: 114
		[Token(Token = "0x6000072")]
		double CounterClockwise(Point a, Point b, Point c);

		// Token: 0x06000073 RID: 115
		[Token(Token = "0x6000073")]
		double InCircle(Point a, Point b, Point c, Point p);

		// Token: 0x06000074 RID: 116
		[Token(Token = "0x6000074")]
		Point FindCircumcenter(Point org, Point dest, Point apex, ref double xi, ref double eta);

		// Token: 0x06000075 RID: 117
		[Token(Token = "0x6000075")]
		Point FindCircumcenter(Point org, Point dest, Point apex, ref double xi, ref double eta, double offconstant);
	}
}
