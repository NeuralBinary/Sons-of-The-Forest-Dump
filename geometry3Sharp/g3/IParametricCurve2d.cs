using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	public interface IParametricCurve2d
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000728 RID: 1832
		[Token(Token = "0x17000129")]
		bool IsClosed { [Token(Token = "0x6000728")] get; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000729 RID: 1833
		[Token(Token = "0x1700012A")]
		double ParamLength { [Token(Token = "0x6000729")] get; }

		// Token: 0x0600072A RID: 1834
		[Token(Token = "0x600072A")]
		Vector2d SampleT(double t);

		// Token: 0x0600072B RID: 1835
		[Token(Token = "0x600072B")]
		Vector2d TangentT(double t);

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600072C RID: 1836
		[Token(Token = "0x1700012B")]
		bool HasArcLength { [Token(Token = "0x600072C")] get; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600072D RID: 1837
		[Token(Token = "0x1700012C")]
		double ArcLength { [Token(Token = "0x600072D")] get; }

		// Token: 0x0600072E RID: 1838
		[Token(Token = "0x600072E")]
		Vector2d SampleArcLength(double a);

		// Token: 0x0600072F RID: 1839
		[Token(Token = "0x600072F")]
		void Reverse();

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000730 RID: 1840
		[Token(Token = "0x1700012D")]
		bool IsTransformable { [Token(Token = "0x6000730")] get; }

		// Token: 0x06000731 RID: 1841
		[Token(Token = "0x6000731")]
		void Transform(ITransform2 xform);

		// Token: 0x06000732 RID: 1842
		[Token(Token = "0x6000732")]
		IParametricCurve2d Clone();
	}
}
