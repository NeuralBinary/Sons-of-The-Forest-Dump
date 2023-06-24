using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Obi
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public static class ConstraintSorter
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x60003D2")]
		public static JobHandle SortConstraints<T>(int particleCount, NativeArray<T> constraints, ref NativeArray<T> sortedConstraints, JobHandle handle) where T : struct, IConstraint
		{
			return default(JobHandle);
		}

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000C4")]
		public struct ConstraintComparer<K> : IComparer<K> where K : IConstraint
		{
			// Token: 0x060003D3 RID: 979 RVA: 0x0000386C File Offset: 0x00001A6C
			[Token(Token = "0x60003D3")]
			public int Compare(K x, K y)
			{
				return 0;
			}
		}

		// Token: 0x020000C5 RID: 197
		[Token(Token = "0x20000C5")]
		[BurstCompile]
		public struct CountSortPerFirstParticleJob<K> : IJob where K : struct, IConstraint
		{
			// Token: 0x060003D4 RID: 980 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60003D4")]
			public void Execute()
			{
			}

			// Token: 0x04000456 RID: 1110
			[Token(Token = "0x4000456")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<K> input;

			// Token: 0x04000457 RID: 1111
			[Token(Token = "0x4000457")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<K> output;

			// Token: 0x04000458 RID: 1112
			[Token(Token = "0x4000458")]
			[FieldOffset(Offset = "0x0")]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> digitCount;

			// Token: 0x04000459 RID: 1113
			[Token(Token = "0x4000459")]
			[FieldOffset(Offset = "0x0")]
			public int maxDigits;

			// Token: 0x0400045A RID: 1114
			[Token(Token = "0x400045A")]
			[FieldOffset(Offset = "0x0")]
			public int maxIndex;
		}

		// Token: 0x020000C6 RID: 198
		[Token(Token = "0x20000C6")]
		[BurstCompile]
		public struct SortSubArraysJob<K> : IJobParallelFor where K : struct, IConstraint
		{
			// Token: 0x060003D5 RID: 981 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60003D5")]
			public void Execute(int workItemIndex)
			{
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60003D6")]
			public static void DefaultSortOfSubArrays(NativeArray<K> inOutArray, int startIndex, int length, ConstraintSorter.ConstraintComparer<K> comparer)
			{
			}

			// Token: 0x0400045B RID: 1115
			[Token(Token = "0x400045B")]
			[FieldOffset(Offset = "0x0")]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<K> InOutArray;

			// Token: 0x0400045C RID: 1116
			[Token(Token = "0x400045C")]
			[FieldOffset(Offset = "0x0")]
			[DeallocateOnJobCompletion]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> NextElementIndex;

			// Token: 0x0400045D RID: 1117
			[Token(Token = "0x400045D")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public ConstraintSorter.ConstraintComparer<K> comparer;
		}
	}
}
