using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Obi
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	public class BurstSolverImpl : ISolverImpl
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700007E")]
		public ObiSolver abstraction
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x1700007F")]
		public int particleCount
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x27A1B00", Offset = "0x27A0100", VA = "0x1827A1B00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Token(Token = "0x17000080")]
		public int activeParticleCount
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x27A1B50", Offset = "0x27A0150", VA = "0x1827A1B50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00003A94 File Offset: 0x00001C94
		[Token(Token = "0x17000081")]
		public BurstInertialFrame inertialFrame
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x27A1BA0", Offset = "0x27A01A0", VA = "0x1827A1BA0")]
			get
			{
				return default(BurstInertialFrame);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00003AAC File Offset: 0x00001CAC
		[Token(Token = "0x17000082")]
		public BurstAffineTransform solverToWorld
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x27A1C10", Offset = "0x27A0210", VA = "0x1827A1C10")]
			get
			{
				return default(BurstAffineTransform);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x17000083")]
		public BurstAffineTransform worldToSolver
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x27A1C40", Offset = "0x27A0240", VA = "0x1827A1C40")]
			get
			{
				return default(BurstAffineTransform);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x27A1C80", Offset = "0x27A0280", VA = "0x1827A1C80")]
		public BurstSolverImpl(ObiSolver solver)
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x27A2C80", Offset = "0x27A1280", VA = "0x1827A2C80", Slot = "4")]
		public void Destroy()
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x27A3220", Offset = "0x27A1820", VA = "0x1827A3220")]
		public void ScheduleBatchedJobsIfNeeded()
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x27A3290", Offset = "0x27A1890", VA = "0x1827A3290")]
		private void GetOrCreateColliderWorld()
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x27A3540", Offset = "0x27A1B40", VA = "0x1827A3540", Slot = "5")]
		public void InitializeFrame(Vector4 translation, Vector4 scale, Quaternion rotation)
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x27A36F0", Offset = "0x27A1CF0", VA = "0x1827A36F0", Slot = "6")]
		public void UpdateFrame(Vector4 translation, Vector4 scale, Quaternion rotation, float deltaTime)
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x27A3840", Offset = "0x27A1E40", VA = "0x1827A3840", Slot = "7")]
		public void ApplyFrame(float worldLinearInertiaScale, float worldAngularInertiaScale, float deltaTime)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00003ADC File Offset: 0x00001CDC
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x27A4120", Offset = "0x27A2720", VA = "0x1827A4120", Slot = "21")]
		public int GetDeformableTriangleCount()
		{
			return 0;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x27A4180", Offset = "0x27A2780", VA = "0x1827A4180", Slot = "22")]
		public void SetDeformableTriangles(int[] indices, int num, int destOffset)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x27A42C0", Offset = "0x27A28C0", VA = "0x1827A42C0", Slot = "23")]
		public int RemoveDeformableTriangles(int num, int sourceOffset)
		{
			return 0;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x27A4420", Offset = "0x27A2A20", VA = "0x1827A4420", Slot = "24")]
		public void SetSimplices(int[] simplices, SimplexCounts counts)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x27A45E0", Offset = "0x27A2BE0", VA = "0x1827A45E0", Slot = "9")]
		public void SetActiveParticles(int[] indices, int num)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00003B0C File Offset: 0x00001D0C
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x27A4730", Offset = "0x27A2D30", VA = "0x1827A4730")]
		private int ClampArrayAccess(int size, int num, int offset)
		{
			return 0;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00003B24 File Offset: 0x00001D24
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x27A4750", Offset = "0x27A2D50", VA = "0x1827A4750")]
		public JobHandle RecalculateInertiaTensors(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x27A4B10", Offset = "0x27A3110", VA = "0x1827A4B10", Slot = "26")]
		public void GetBounds(ref Vector3 min, ref Vector3 max)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x27A5170", Offset = "0x27A3770", VA = "0x1827A5170", Slot = "27")]
		public void ResetForces()
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x27A52C0", Offset = "0x27A38C0", VA = "0x1827A52C0", Slot = "14")]
		public int GetConstraintCount(Oni.ConstraintType type)
		{
			return 0;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x27A5340", Offset = "0x27A3940", VA = "0x1827A5340", Slot = "15")]
		public void GetCollisionContacts(Oni.Contact[] contacts, int count)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x27A5440", Offset = "0x27A3A40", VA = "0x1827A5440", Slot = "16")]
		public void GetParticleCollisionContacts(Oni.Contact[] contacts, int count)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "25")]
		public void SetParameters(Oni.SolverParameters parameters)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		public void SetConstraintGroupParameters(Oni.ConstraintType type, ref Oni.ConstraintParameters parameters)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x27A5540", Offset = "0x27A3B40", VA = "0x1827A5540", Slot = "8")]
		public void ParticleCountChanged(ObiSolver solver)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public void SetRigidbodyArrays(ObiSolver solver)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x27A6160", Offset = "0x27A4760", VA = "0x1827A6160", Slot = "12")]
		public IConstraintsBatchImpl CreateConstraintsBatch(Oni.ConstraintType type)
		{
			return null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x27A61D0", Offset = "0x27A47D0", VA = "0x1827A61D0", Slot = "13")]
		public void DestroyConstraintsBatch(IConstraintsBatchImpl batch)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x27A6270", Offset = "0x27A4870", VA = "0x1827A6270", Slot = "18")]
		public IObiJobHandle CollisionDetection(float stepTime)
		{
			return null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00003B54 File Offset: 0x00001D54
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x27A6310", Offset = "0x27A4910", VA = "0x1827A6310")]
		protected JobHandle FindFluidParticles()
		{
			return default(JobHandle);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00003B6C File Offset: 0x00001D6C
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x27A65D0", Offset = "0x27A4BD0", VA = "0x1827A65D0")]
		protected JobHandle UpdateSimplexBounds(JobHandle inputDeps, float deltaTime)
		{
			return default(JobHandle);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00003B84 File Offset: 0x00001D84
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x27A69A0", Offset = "0x27A4FA0", VA = "0x1827A69A0")]
		protected JobHandle GenerateContacts(JobHandle inputDeps, float deltaTime)
		{
			return default(JobHandle);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x27A7B60", Offset = "0x27A6160", VA = "0x1827A7B60", Slot = "19")]
		public IObiJobHandle Substep(float stepTime, float substepTime, int substeps)
		{
			return null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00003B9C File Offset: 0x00001D9C
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x27A8580", Offset = "0x27A6B80", VA = "0x1827A8580")]
		private JobHandle ApplyVelocityCorrections(JobHandle inputDeps, float deltaTime)
		{
			return default(JobHandle);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x27A8680", Offset = "0x27A6C80", VA = "0x1827A8680")]
		private JobHandle ApplyConstraints(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x27A8BC0", Offset = "0x27A71C0", VA = "0x1827A8BC0", Slot = "20")]
		public void ApplyInterpolation(ObiNativeVector4List startPositions, ObiNativeQuaternionList startOrientations, float stepTime, float unsimulatedTime)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x27A9330", Offset = "0x27A7930", VA = "0x1827A9330", Slot = "10")]
		public void InterpolateDiffuseProperties(ObiNativeVector4List properties, ObiNativeVector4List diffusePositions, ObiNativeVector4List diffuseProperties, ObiNativeIntList neighbourCount, int diffuseCount)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00003BCC File Offset: 0x00001DCC
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x27A95E0", Offset = "0x27A7BE0", VA = "0x1827A95E0", Slot = "28")]
		public int GetParticleGridSize()
		{
			return 0;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x27A9640", Offset = "0x27A7C40", VA = "0x1827A9640", Slot = "29")]
		public void GetParticleGrid(ObiNativeAabbList cells)
		{
		}

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x10")]
		private ObiSolver m_Solver;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		private const int maxBatches = 17;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x18")]
		private ConstraintBatcher constraintBatcher;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x38")]
		private IBurstConstraintsImpl[] constraints;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x40")]
		public ParticleGrid particleGrid;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x48")]
		public NativeArray<BurstContact> particleContacts;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x58")]
		public NativeArray<BatchData> particleBatchData;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x68")]
		public NativeArray<FluidInteraction> fluidInteractions;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x78")]
		public NativeArray<BatchData> fluidBatchData;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x88")]
		private BurstColliderWorld colliderGrid;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x90")]
		public NativeArray<BurstContact> colliderContacts;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0xA0")]
		public NativeList<int> activeParticles;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0xB0")]
		private NativeList<int> deformableTriangles;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0xC0")]
		public NativeList<int> simplices;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0xD0")]
		public SimplexCounts simplexCounts;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0xDC")]
		private BurstInertialFrame m_InertialFrame;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x17C")]
		private int scheduledJobCounter;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x180")]
		public NativeArray<float4> positions;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x190")]
		public NativeArray<float4> restPositions;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x1A0")]
		public NativeArray<float4> prevPositions;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x1B0")]
		public NativeArray<float4> renderablePositions;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x1C0")]
		public NativeArray<quaternion> orientations;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x1D0")]
		public NativeArray<quaternion> restOrientations;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x1E0")]
		public NativeArray<quaternion> prevOrientations;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x1F0")]
		public NativeArray<quaternion> renderableOrientations;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x200")]
		public NativeArray<float4> velocities;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x210")]
		public NativeArray<float4> angularVelocities;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x220")]
		public NativeArray<float> invMasses;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x230")]
		public NativeArray<float> invRotationalMasses;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x240")]
		public NativeArray<float4> invInertiaTensors;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x250")]
		public NativeArray<float4> externalForces;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x260")]
		public NativeArray<float4> externalTorques;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x270")]
		public NativeArray<float4> wind;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x280")]
		public NativeArray<float4> positionDeltas;

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x290")]
		public NativeArray<quaternion> orientationDeltas;

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x2A0")]
		public NativeArray<int> positionConstraintCounts;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x2B0")]
		public NativeArray<int> orientationConstraintCounts;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x2C0")]
		public NativeArray<int> collisionMaterials;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x2D0")]
		public NativeArray<int> phases;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x2E0")]
		public NativeArray<float4> anisotropies;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x2F0")]
		public NativeArray<float4> principalRadii;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x300")]
		public NativeArray<float4> normals;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x310")]
		public NativeArray<float4> vorticities;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x320")]
		public NativeArray<float4> fluidData;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x330")]
		public NativeArray<float4> userData;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x340")]
		public NativeArray<float> smoothingRadii;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x350")]
		public NativeArray<float> buoyancies;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x360")]
		public NativeArray<float> restDensities;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x370")]
		public NativeArray<float> viscosities;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x380")]
		public NativeArray<float> surfaceTension;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x390")]
		public NativeArray<float> vortConfinement;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x3A0")]
		public NativeArray<float> athmosphericDrag;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x3B0")]
		public NativeArray<float> athmosphericPressure;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x3C0")]
		public NativeArray<float> diffusion;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x3D0")]
		public NativeArray<int4> cellCoords;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x3E0")]
		public NativeArray<BurstAabb> simplexBounds;
	}
}
