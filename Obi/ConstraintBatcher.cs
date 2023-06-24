using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Obi
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	public struct ConstraintBatcher : IDisposable
	{
		// Token: 0x060003CD RID: 973 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x279BE30", Offset = "0x279A430", VA = "0x18279BE30")]
		public ConstraintBatcher(int maxBatches)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x279BE80", Offset = "0x279A480", VA = "0x18279BE80", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x60003CF")]
		public JobHandle BatchConstraints<T>(ref T constraintDesc, int particleCount, ref NativeArray<BatchData> batchData, ref NativeArray<int> activeBatchCount, JobHandle inputDeps) where T : struct, IConstraintProvider
		{
			return default(JobHandle);
		}

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		public const int minWorkItemSize = 64;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x0")]
		public int maxBatches;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x8")]
		private BatchLUT batchLUT;

		// Token: 0x020000C0 RID: 192
		[Token(Token = "0x20000C0")]
		private struct WorkItem
		{
			// Token: 0x060003D0 RID: 976 RVA: 0x0000383C File Offset: 0x00001A3C
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x279BE90", Offset = "0x279A490", VA = "0x18279BE90")]
			public bool Add(int constraintIndex)
			{
				return default(bool);
			}

			// Token: 0x0400044C RID: 1100
			[Token(Token = "0x400044C")]
			[FieldOffset(Offset = "0x0")]
			[FixedBuffer(typeof(int), 64)]
			public ConstraintBatcher.WorkItem.<constraints>e__FixedBuffer constraints;

			// Token: 0x0400044D RID: 1101
			[Token(Token = "0x400044D")]
			[FieldOffset(Offset = "0x100")]
			public int constraintCount;

			// Token: 0x020000C1 RID: 193
			[Token(Token = "0x20000C1")]
			[UnsafeValueType]
			[CompilerGenerated]
			public struct <constraints>e__FixedBuffer
			{
				// Token: 0x0400044E RID: 1102
				[Token(Token = "0x400044E")]
				[FieldOffset(Offset = "0x0")]
				public int FixedElementField;
			}
		}

		// Token: 0x020000C2 RID: 194
		[Token(Token = "0x20000C2")]
		[BurstCompile]
		private struct BatchContactsJob<K> : IJob where K : struct, IConstraintProvider
		{
			// Token: 0x060003D1 RID: 977 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60003D1")]
			public void Execute()
			{
			}

			// Token: 0x0400044F RID: 1103
			[Token(Token = "0x400044F")]
			[FieldOffset(Offset = "0x0")]
			[DeallocateOnJobCompletion]
			public NativeArray<ushort> batchMasks;

			// Token: 0x04000450 RID: 1104
			[Token(Token = "0x4000450")]
			[FieldOffset(Offset = "0x0")]
			[DeallocateOnJobCompletion]
			public NativeArray<int> batchIndices;

			// Token: 0x04000451 RID: 1105
			[Token(Token = "0x4000451")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public BatchLUT lut;

			// Token: 0x04000452 RID: 1106
			[Token(Token = "0x4000452")]
			[FieldOffset(Offset = "0x0")]
			public K constraintDesc;

			// Token: 0x04000453 RID: 1107
			[Token(Token = "0x4000453")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<BatchData> batchData;

			// Token: 0x04000454 RID: 1108
			[Token(Token = "0x4000454")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<int> activeBatchCount;

			// Token: 0x04000455 RID: 1109
			[Token(Token = "0x4000455")]
			[FieldOffset(Offset = "0x0")]
			public int maxBatches;
		}
	}
}
