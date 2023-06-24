using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public class BurstAerodynamicConstraintsBatch : BurstConstraintsBatchImpl, IAerodynamicConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060002AD RID: 685 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2774310", Offset = "0x2772910", VA = "0x182774310")]
		public BurstAerodynamicConstraintsBatch(BurstAerodynamicConstraints constraints)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2774380", Offset = "0x2772980", VA = "0x182774380", Slot = "15")]
		public void SetAerodynamicConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList aerodynamicCoeffs, int count)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x18BE6A0", Offset = "0x18BCCA0", VA = "0x1818BE6A0", Slot = "11")]
		public override JobHandle Initialize(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x27744A0", Offset = "0x2772AA0", VA = "0x1827744A0", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x18BE6A0", Offset = "0x18BCCA0", VA = "0x1818BE6A0", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<float> aerodynamicCoeffs;

		// Token: 0x02000064 RID: 100
		[Token(Token = "0x2000064")]
		[BurstCompile]
		public struct AerodynamicConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x060002B2 RID: 690 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x27747A0", Offset = "0x2772DA0", VA = "0x1827747A0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x04000211 RID: 529
			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x04000212 RID: 530
			[Token(Token = "0x4000212")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			[NativeDisableParallelForRestriction]
			public NativeArray<float> aerodynamicCoeffs;

			// Token: 0x04000213 RID: 531
			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x04000214 RID: 532
			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float4> normals;

			// Token: 0x04000215 RID: 533
			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float4> wind;

			// Token: 0x04000216 RID: 534
			[Token(Token = "0x4000216")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000217 RID: 535
			[Token(Token = "0x4000217")]
			[FieldOffset(Offset = "0x60")]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> velocities;

			// Token: 0x04000218 RID: 536
			[Token(Token = "0x4000218")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public float deltaTime;
		}
	}
}
