using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	public interface ISpatial
	{
		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001E22 RID: 7714
		[Token(Token = "0x17000479")]
		bool SupportsNearestTriangle { [Token(Token = "0x6001E22")] get; }

		// Token: 0x06001E23 RID: 7715
		[Token(Token = "0x6001E23")]
		int FindNearestTriangle(Vector3d p, double fMaxDist = 1.7976931348623157E+308);

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001E24 RID: 7716
		[Token(Token = "0x1700047A")]
		bool SupportsTriangleRayIntersection { [Token(Token = "0x6001E24")] get; }

		// Token: 0x06001E25 RID: 7717
		[Token(Token = "0x6001E25")]
		int FindNearestHitTriangle(Ray3d ray, double fMaxDist = 1.7976931348623157E+308);

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001E26 RID: 7718
		[Token(Token = "0x1700047B")]
		bool SupportsPointContainment { [Token(Token = "0x6001E26")] get; }

		// Token: 0x06001E27 RID: 7719
		[Token(Token = "0x6001E27")]
		bool IsInside(Vector3d p);
	}
}
