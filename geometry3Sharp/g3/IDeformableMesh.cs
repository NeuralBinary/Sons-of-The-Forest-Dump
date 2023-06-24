using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000249 RID: 585
	[Token(Token = "0x2000249")]
	public interface IDeformableMesh : IMesh, IPointSet
	{
		// Token: 0x060014E5 RID: 5349
		[Token(Token = "0x60014E5")]
		void SetVertex(int vID, Vector3d vNewPos);

		// Token: 0x060014E6 RID: 5350
		[Token(Token = "0x60014E6")]
		void SetVertexNormal(int vid, Vector3f vNewNormal);
	}
}
