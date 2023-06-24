using System;
using Il2CppDummyDll;
using TriangleNet.Meshing;

namespace TriangleNet.Smoothing
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public interface ISmoother
	{
		// Token: 0x0600022A RID: 554
		[Token(Token = "0x600022A")]
		void Smooth(IMesh mesh);

		// Token: 0x0600022B RID: 555
		[Token(Token = "0x600022B")]
		void Smooth(IMesh mesh, int limit);
	}
}
