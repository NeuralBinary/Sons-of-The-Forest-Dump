using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000202 RID: 514
	[Token(Token = "0x2000202")]
	public interface ITransform2
	{
		// Token: 0x060010F0 RID: 4336
		[Token(Token = "0x60010F0")]
		Vector2d TransformP(Vector2d p);

		// Token: 0x060010F1 RID: 4337
		[Token(Token = "0x60010F1")]
		Vector2d TransformN(Vector2d n);

		// Token: 0x060010F2 RID: 4338
		[Token(Token = "0x60010F2")]
		double TransformScalar(double s);
	}
}
