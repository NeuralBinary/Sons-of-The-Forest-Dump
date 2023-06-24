using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	public class ParticleGrid : IDisposable
	{
		// Token: 0x060003FC RID: 1020 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x279C1B0", Offset = "0x279A7B0", VA = "0x18279C1B0")]
		public ParticleGrid()
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x279C2D0", Offset = "0x279A8D0", VA = "0x18279C2D0")]
		public void Update(BurstSolverImpl solver, float deltaTime, JobHandle inputDeps)
		{
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x279C6B0", Offset = "0x279ACB0", VA = "0x18279C6B0")]
		public JobHandle GenerateContacts(BurstSolverImpl solver, float deltaTime)
		{
			return default(JobHandle);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00003A34 File Offset: 0x00001C34
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x279CC20", Offset = "0x279B220", VA = "0x18279CC20")]
		public JobHandle InterpolateDiffuseProperties(BurstSolverImpl solver, NativeArray<float4> properties, NativeArray<float4> diffusePositions, NativeArray<float4> diffuseProperties, NativeArray<int> neighbourCount, int diffuseCount)
		{
			return default(JobHandle);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x279D170", Offset = "0x279B770", VA = "0x18279D170")]
		public void GetCells(ObiNativeAabbList cells)
		{
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x279D5A0", Offset = "0x279BBA0", VA = "0x18279D5A0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x10")]
		public NativeMultilevelGrid<int> grid;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x40")]
		public NativeQueue<BurstContact> particleContactQueue;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x58")]
		public NativeQueue<FluidInteraction> fluidInteractionQueue;

		// Token: 0x020000CF RID: 207
		[Token(Token = "0x20000CF")]
		[BurstCompile]
		private struct CalculateCellCoords : IJobParallelFor
		{
			// Token: 0x06000402 RID: 1026 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x279D630", Offset = "0x279BC30", VA = "0x18279D630", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x04000475 RID: 1141
			[Token(Token = "0x4000475")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<BurstAabb> simplexBounds;

			// Token: 0x04000476 RID: 1142
			[Token(Token = "0x4000476")]
			[FieldOffset(Offset = "0x10")]
			public NativeArray<int4> cellCoords;

			// Token: 0x04000477 RID: 1143
			[Token(Token = "0x4000477")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public bool is2D;
		}

		// Token: 0x020000D0 RID: 208
		[Token(Token = "0x20000D0")]
		[BurstCompile]
		private struct UpdateGrid : IJob
		{
			// Token: 0x06000403 RID: 1027 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x279D840", Offset = "0x279BE40", VA = "0x18279D840", Slot = "4")]
			public void Execute()
			{
			}

			// Token: 0x04000478 RID: 1144
			[Token(Token = "0x4000478")]
			[FieldOffset(Offset = "0x0")]
			public NativeMultilevelGrid<int> grid;

			// Token: 0x04000479 RID: 1145
			[Token(Token = "0x4000479")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<int4> cellCoords;

			// Token: 0x0400047A RID: 1146
			[Token(Token = "0x400047A")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public int simplexCount;
		}

		// Token: 0x020000D1 RID: 209
		[Token(Token = "0x20000D1")]
		[BurstCompile]
		public struct GenerateParticleParticleContactsJob : IJobParallelFor
		{
			// Token: 0x06000404 RID: 1028 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x279D9F0", Offset = "0x279BFF0", VA = "0x18279D9F0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x279DB80", Offset = "0x279C180", VA = "0x18279DB80")]
			private void IntraCellSearch(int cellIndex, ref BurstSimplex simplexShape)
			{
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x279DD70", Offset = "0x279C370", VA = "0x18279DD70")]
			private void InterCellSearch(int cellIndex, int neighborCellIndex, ref BurstSimplex simplexShape)
			{
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x279DF80", Offset = "0x279C580", VA = "0x18279DF80")]
			private void IntraLevelSearch(int cellIndex, ref BurstSimplex simplexShape)
			{
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00003A4C File Offset: 0x00001C4C
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x279E4E0", Offset = "0x279CAE0", VA = "0x18279E4E0")]
			private int GetSimplexPhase(int simplexStart, int simplexSize, out Oni.ParticleFlags flags, ref bool restPositionsEnabled)
			{
				return 0;
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x279E620", Offset = "0x279CC20", VA = "0x18279E620")]
			private void InteractionTest(int A, int B, ref BurstSimplex simplexShape)
			{
			}

			// Token: 0x0400047B RID: 1147
			[Token(Token = "0x400047B")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeMultilevelGrid<int> grid;

			// Token: 0x0400047C RID: 1148
			[Token(Token = "0x400047C")]
			[FieldOffset(Offset = "0x30")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public NativeArray<int> gridLevels;

			// Token: 0x0400047D RID: 1149
			[Token(Token = "0x400047D")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x0400047E RID: 1150
			[Token(Token = "0x400047E")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<quaternion> orientations;

			// Token: 0x0400047F RID: 1151
			[Token(Token = "0x400047F")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float4> restPositions;

			// Token: 0x04000480 RID: 1152
			[Token(Token = "0x4000480")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<float4> velocities;

			// Token: 0x04000481 RID: 1153
			[Token(Token = "0x4000481")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000482 RID: 1154
			[Token(Token = "0x4000482")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public NativeArray<float4> radii;

			// Token: 0x04000483 RID: 1155
			[Token(Token = "0x4000483")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public NativeArray<float4> normals;

			// Token: 0x04000484 RID: 1156
			[Token(Token = "0x4000484")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public NativeArray<float> fluidRadii;

			// Token: 0x04000485 RID: 1157
			[Token(Token = "0x4000485")]
			[FieldOffset(Offset = "0xC0")]
			[ReadOnly]
			public NativeArray<int> phases;

			// Token: 0x04000486 RID: 1158
			[Token(Token = "0x4000486")]
			[FieldOffset(Offset = "0xD0")]
			[ReadOnly]
			public NativeList<int> simplices;

			// Token: 0x04000487 RID: 1159
			[Token(Token = "0x4000487")]
			[FieldOffset(Offset = "0xE0")]
			[ReadOnly]
			public SimplexCounts simplexCounts;

			// Token: 0x04000488 RID: 1160
			[Token(Token = "0x4000488")]
			[FieldOffset(Offset = "0xF0")]
			[ReadOnly]
			public NativeArray<BurstAabb> simplexBounds;

			// Token: 0x04000489 RID: 1161
			[Token(Token = "0x4000489")]
			[FieldOffset(Offset = "0x100")]
			[ReadOnly]
			public NativeArray<int> particleMaterialIndices;

			// Token: 0x0400048A RID: 1162
			[Token(Token = "0x400048A")]
			[FieldOffset(Offset = "0x110")]
			[ReadOnly]
			public NativeArray<BurstCollisionMaterial> collisionMaterials;

			// Token: 0x0400048B RID: 1163
			[Token(Token = "0x400048B")]
			[FieldOffset(Offset = "0x120")]
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeQueue<BurstContact>.ParallelWriter contactsQueue;

			// Token: 0x0400048C RID: 1164
			[Token(Token = "0x400048C")]
			[FieldOffset(Offset = "0x138")]
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeQueue<FluidInteraction>.ParallelWriter fluidInteractionsQueue;

			// Token: 0x0400048D RID: 1165
			[Token(Token = "0x400048D")]
			[FieldOffset(Offset = "0x150")]
			[ReadOnly]
			public float dt;

			// Token: 0x0400048E RID: 1166
			[Token(Token = "0x400048E")]
			[FieldOffset(Offset = "0x154")]
			[ReadOnly]
			public float collisionMargin;

			// Token: 0x0400048F RID: 1167
			[Token(Token = "0x400048F")]
			[FieldOffset(Offset = "0x158")]
			[ReadOnly]
			public int optimizationIterations;

			// Token: 0x04000490 RID: 1168
			[Token(Token = "0x4000490")]
			[FieldOffset(Offset = "0x15C")]
			[ReadOnly]
			public float optimizationTolerance;
		}

		// Token: 0x020000D2 RID: 210
		[Token(Token = "0x20000D2")]
		[BurstCompile]
		public struct InterpolateDiffusePropertiesJob : IJobParallelFor
		{
			// Token: 0x0600040A RID: 1034 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x279F9F0", Offset = "0x279DFF0", VA = "0x18279F9F0", Slot = "4")]
			public void Execute(int p)
			{
			}

			// Token: 0x04000491 RID: 1169
			[Token(Token = "0x4000491")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeMultilevelGrid<int> grid;

			// Token: 0x04000492 RID: 1170
			[Token(Token = "0x4000492")]
			[FieldOffset(Offset = "0x30")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public NativeArray<int4> cellOffsets;

			// Token: 0x04000493 RID: 1171
			[Token(Token = "0x4000493")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x04000494 RID: 1172
			[Token(Token = "0x4000494")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float4> properties;

			// Token: 0x04000495 RID: 1173
			[Token(Token = "0x4000495")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float4> diffusePositions;

			// Token: 0x04000496 RID: 1174
			[Token(Token = "0x4000496")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public Poly6Kernel densityKernel;

			// Token: 0x04000497 RID: 1175
			[Token(Token = "0x4000497")]
			[FieldOffset(Offset = "0x78")]
			public NativeArray<float4> diffuseProperties;

			// Token: 0x04000498 RID: 1176
			[Token(Token = "0x4000498")]
			[FieldOffset(Offset = "0x88")]
			public NativeArray<int> neighbourCount;

			// Token: 0x04000499 RID: 1177
			[Token(Token = "0x4000499")]
			[FieldOffset(Offset = "0x98")]
			[ReadOnly]
			[DeallocateOnJobCompletion]
			public NativeArray<int> gridLevels;

			// Token: 0x0400049A RID: 1178
			[Token(Token = "0x400049A")]
			[FieldOffset(Offset = "0xA8")]
			[ReadOnly]
			public BurstInertialFrame inertialFrame;

			// Token: 0x0400049B RID: 1179
			[Token(Token = "0x400049B")]
			[FieldOffset(Offset = "0x148")]
			[ReadOnly]
			public bool mode2D;
		}
	}
}
