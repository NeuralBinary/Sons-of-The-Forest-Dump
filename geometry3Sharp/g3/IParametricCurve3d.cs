using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	public interface IParametricCurve3d
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000719 RID: 1817
		[Token(Token = "0x17000121")]
		bool IsClosed { [Token(Token = "0x6000719")] get; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600071A RID: 1818
		[Token(Token = "0x17000122")]
		double ParamLength { [Token(Token = "0x600071A")] get; }

		// Token: 0x0600071B RID: 1819
		[Token(Token = "0x600071B")]
		Vector3d SampleT(double t);

		// Token: 0x0600071C RID: 1820
		[Token(Token = "0x600071C")]
		Vector3d TangentT(double t);

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600071D RID: 1821
		[Token(Token = "0x17000123")]
		bool HasArcLength { [Token(Token = "0x600071D")] get; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600071E RID: 1822
		[Token(Token = "0x17000124")]
		double ArcLength { [Token(Token = "0x600071E")] get; }

		// Token: 0x0600071F RID: 1823
		[Token(Token = "0x600071F")]
		Vector3d SampleArcLength(double a);

		// Token: 0x06000720 RID: 1824
		[Token(Token = "0x6000720")]
		void Reverse();

		// Token: 0x06000721 RID: 1825
		[Token(Token = "0x6000721")]
		IParametricCurve3d Clone();
	}
}
