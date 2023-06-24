using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003AD RID: 941
	[Token(Token = "0x20003AD")]
	public interface IIntersectionTarget
	{
		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001E2A RID: 7722
		[Token(Token = "0x1700047C")]
		bool HasNormal { [Token(Token = "0x6001E2A")] get; }

		// Token: 0x06001E2B RID: 7723
		[Token(Token = "0x6001E2B")]
		bool RayIntersect(Ray3d ray, out Vector3d vHit, out Vector3d vHitNormal);
	}
}
