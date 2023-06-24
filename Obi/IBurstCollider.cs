using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	internal interface IBurstCollider
	{
		// Token: 0x060002A9 RID: 681
		[Token(Token = "0x60002A9")]
		void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance);
	}
}
