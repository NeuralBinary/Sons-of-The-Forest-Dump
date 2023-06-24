using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	public class BurstShapeMatchingConstraintsBatch : BurstConstraintsBatchImpl, IShapeMatchingConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x06000357 RID: 855 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x278E530", Offset = "0x278CB30", VA = "0x18278E530")]
		public BurstShapeMatchingConstraintsBatch(BurstShapeMatchingConstraints constraints)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x278E5A0", Offset = "0x278CBA0", VA = "0x18278E5A0", Slot = "15")]
		public void SetShapeMatchingConstraints(ObiNativeIntList particleIndices, ObiNativeIntList firstIndex, ObiNativeIntList numIndices, ObiNativeIntList explicitGroup, ObiNativeFloatList shapeMaterialParameters, ObiNativeVector4List restComs, ObiNativeVector4List coms, ObiNativeQuaternionList constraintOrientations, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x278EA80", Offset = "0x278D080", VA = "0x18278EA80", Slot = "14")]
		public override void Destroy()
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000338C File Offset: 0x0000158C
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x18BE6A0", Offset = "0x18BCCA0", VA = "0x1818BE6A0", Slot = "11")]
		public override JobHandle Initialize(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000033A4 File Offset: 0x000015A4
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x278EAF0", Offset = "0x278D0F0", VA = "0x18278EAF0", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000033BC File Offset: 0x000015BC
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x278EED0", Offset = "0x278D4D0", VA = "0x18278EED0", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x278F190", Offset = "0x278D790", VA = "0x18278F190", Slot = "16")]
		public void CalculateRestShapeMatching()
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x278F730", Offset = "0x278DD30", VA = "0x18278F730")]
		protected static void RecalculateRestData(int i, ref NativeArray<int> particleIndices, ref NativeArray<int> firstIndex, ref NativeArray<float4> restComs, ref NativeArray<float4x4> Aqq, ref NativeArray<float4x4> deformation, ref NativeArray<int> numIndices, ref NativeArray<float> invMasses, ref NativeArray<float4> restPositions, ref NativeArray<quaternion> restOrientations, ref NativeArray<float4> invInertiaTensors)
		{
		}

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<int> firstIndex;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<int> numIndices;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x68")]
		private NativeArray<int> explicitGroup;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x78")]
		private NativeArray<float> shapeMaterialParameters;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x88")]
		private NativeArray<float4> restComs;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x98")]
		private NativeArray<float4> coms;

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0xA8")]
		private NativeArray<quaternion> constraintOrientations;

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0xB8")]
		private NativeArray<float4x4> Aqq;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0xC8")]
		private NativeArray<float4x4> deformation;

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x200009F")]
		[BurstCompile]
		public struct ShapeMatchingCalculateRestJob : IJobParallelFor
		{
			// Token: 0x0600035F RID: 863 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x27901F0", Offset = "0x278E7F0", VA = "0x1827901F0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x04000382 RID: 898
			[Token(Token = "0x4000382")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x04000383 RID: 899
			[Token(Token = "0x4000383")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<int> firstIndex;

			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<int> numIndices;

			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<float4> restComs;

			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float4> coms;

			// Token: 0x04000387 RID: 903
			[Token(Token = "0x4000387")]
			[FieldOffset(Offset = "0x50")]
			public NativeArray<float4x4> Aqq;

			// Token: 0x04000388 RID: 904
			[Token(Token = "0x4000388")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float4x4> deformation;

			// Token: 0x04000389 RID: 905
			[Token(Token = "0x4000389")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<float4> restPositions;

			// Token: 0x0400038A RID: 906
			[Token(Token = "0x400038A")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeArray<quaternion> restOrientations;

			// Token: 0x0400038B RID: 907
			[Token(Token = "0x400038B")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x0400038C RID: 908
			[Token(Token = "0x400038C")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public NativeArray<float4> invInertiaTensors;
		}

		// Token: 0x020000A0 RID: 160
		[Token(Token = "0x20000A0")]
		[BurstCompile]
		public struct ShapeMatchingConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x06000360 RID: 864 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x2790290", Offset = "0x278E890", VA = "0x182790290", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x0400038D RID: 909
			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x0400038E RID: 910
			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<int> firstIndex;

			// Token: 0x0400038F RID: 911
			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<int> numIndices;

			// Token: 0x04000390 RID: 912
			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<int> explicitGroup;

			// Token: 0x04000391 RID: 913
			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> shapeMaterialParameters;

			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x50")]
			public NativeArray<float4> restComs;

			// Token: 0x04000393 RID: 915
			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0x60")]
			public NativeArray<float4> coms;

			// Token: 0x04000394 RID: 916
			[Token(Token = "0x4000394")]
			[FieldOffset(Offset = "0x70")]
			public NativeArray<quaternion> constraintOrientations;

			// Token: 0x04000395 RID: 917
			[Token(Token = "0x4000395")]
			[FieldOffset(Offset = "0x80")]
			public NativeArray<float4x4> Aqq;

			// Token: 0x04000396 RID: 918
			[Token(Token = "0x4000396")]
			[FieldOffset(Offset = "0x90")]
			public NativeArray<float4x4> deformation;

			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4000397")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x04000398 RID: 920
			[Token(Token = "0x4000398")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public NativeArray<float4> restPositions;

			// Token: 0x04000399 RID: 921
			[Token(Token = "0x4000399")]
			[FieldOffset(Offset = "0xC0")]
			[ReadOnly]
			public NativeArray<quaternion> restOrientations;

			// Token: 0x0400039A RID: 922
			[Token(Token = "0x400039A")]
			[FieldOffset(Offset = "0xD0")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x0400039B RID: 923
			[Token(Token = "0x400039B")]
			[FieldOffset(Offset = "0xE0")]
			[ReadOnly]
			public NativeArray<float> invRotationalMasses;

			// Token: 0x0400039C RID: 924
			[Token(Token = "0x400039C")]
			[FieldOffset(Offset = "0xF0")]
			[ReadOnly]
			public NativeArray<float4> invInertiaTensors;

			// Token: 0x0400039D RID: 925
			[Token(Token = "0x400039D")]
			[FieldOffset(Offset = "0x100")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> orientations;

			// Token: 0x0400039E RID: 926
			[Token(Token = "0x400039E")]
			[FieldOffset(Offset = "0x110")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x0400039F RID: 927
			[Token(Token = "0x400039F")]
			[FieldOffset(Offset = "0x120")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;

			// Token: 0x040003A0 RID: 928
			[Token(Token = "0x40003A0")]
			[FieldOffset(Offset = "0x130")]
			[ReadOnly]
			public float deltaTime;
		}

		// Token: 0x020000A1 RID: 161
		[Token(Token = "0x20000A1")]
		[BurstCompile]
		public struct ApplyShapeMatchingConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x06000361 RID: 865 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x2791BC0", Offset = "0x27901C0", VA = "0x182791BC0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040003A1 RID: 929
			[Token(Token = "0x40003A1")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x040003A2 RID: 930
			[Token(Token = "0x40003A2")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<int> firstIndex;

			// Token: 0x040003A3 RID: 931
			[Token(Token = "0x40003A3")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<int> numIndices;

			// Token: 0x040003A4 RID: 932
			[Token(Token = "0x40003A4")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public float sorFactor;

			// Token: 0x040003A5 RID: 933
			[Token(Token = "0x40003A5")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> positions;

			// Token: 0x040003A6 RID: 934
			[Token(Token = "0x40003A6")]
			[FieldOffset(Offset = "0x48")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x040003A7 RID: 935
			[Token(Token = "0x40003A7")]
			[FieldOffset(Offset = "0x58")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;
		}
	}
}
