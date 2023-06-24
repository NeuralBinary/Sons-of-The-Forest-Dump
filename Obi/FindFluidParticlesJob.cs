using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Obi
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	[BurstCompile]
	internal struct FindFluidParticlesJob : IJob
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x27A9660", Offset = "0x27A7C60", VA = "0x1827A9660", Slot = "4")]
		public void Execute()
		{
		}

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeList<int> activeParticles;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<int> phases;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x20")]
		public NativeList<int> fluidParticles;
	}
}
