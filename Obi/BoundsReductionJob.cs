using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Obi
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	[BurstCompile]
	internal struct BoundsReductionJob : IJobParallelFor
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x27A1780", Offset = "0x279FD80", VA = "0x1827A1780", Slot = "4")]
		public void Execute(int first)
		{
		}

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableParallelForRestriction]
		public NativeArray<BurstAabb> bounds;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public int stride;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x14")]
		[ReadOnly]
		public int size;
	}
}
