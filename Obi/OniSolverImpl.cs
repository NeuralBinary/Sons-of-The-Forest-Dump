using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	public class OniSolverImpl : ISolverImpl
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00003CEC File Offset: 0x00001EEC
		[Token(Token = "0x17000091")]
		public IntPtr oniSolver
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x27AE7C0", Offset = "0x27ACDC0", VA = "0x1827AE7C0")]
		public OniSolverImpl(IntPtr solver)
		{
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x27AF170", Offset = "0x27AD770", VA = "0x1827AF170", Slot = "4")]
		public void Destroy()
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x27AF200", Offset = "0x27AD800", VA = "0x1827AF200", Slot = "5")]
		public void InitializeFrame(Vector4 translation, Vector4 scale, Quaternion rotation)
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x27AF2B0", Offset = "0x27AD8B0", VA = "0x1827AF2B0", Slot = "6")]
		public void UpdateFrame(Vector4 translation, Vector4 scale, Quaternion rotation, float deltaTime)
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x27AF370", Offset = "0x27AD970", VA = "0x1827AF370", Slot = "7")]
		public void ApplyFrame(float worldLinearInertiaScale, float worldAngularInertiaScale, float deltaTime)
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00003D04 File Offset: 0x00001F04
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x27AF430", Offset = "0x27ADA30", VA = "0x1827AF430", Slot = "21")]
		public int GetDeformableTriangleCount()
		{
			return 0;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x27AF4B0", Offset = "0x27ADAB0", VA = "0x1827AF4B0", Slot = "22")]
		public void SetDeformableTriangles(int[] indices, int num, int destOffset)
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00003D1C File Offset: 0x00001F1C
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x27AF570", Offset = "0x27ADB70", VA = "0x1827AF570", Slot = "23")]
		public int RemoveDeformableTriangles(int num, int sourceOffset)
		{
			return 0;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x27AF610", Offset = "0x27ADC10", VA = "0x1827AF610", Slot = "24")]
		public void SetSimplices(int[] simplices, SimplexCounts counts)
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x27AF6D0", Offset = "0x27ADCD0", VA = "0x1827AF6D0", Slot = "8")]
		public void ParticleCountChanged(ObiSolver solver)
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x27B0870", Offset = "0x27AEE70", VA = "0x1827B0870", Slot = "11")]
		public void SetRigidbodyArrays(ObiSolver solver)
		{
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x27B09E0", Offset = "0x27AEFE0", VA = "0x1827B09E0", Slot = "9")]
		public void SetActiveParticles(int[] indices, int num)
		{
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x27B0A90", Offset = "0x27AF090", VA = "0x1827B0A90", Slot = "27")]
		public void ResetForces()
		{
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x27B0B10", Offset = "0x27AF110", VA = "0x1827B0B10", Slot = "26")]
		public void GetBounds(ref Vector3 min, ref Vector3 max)
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x27B0BB0", Offset = "0x27AF1B0", VA = "0x1827B0BB0", Slot = "25")]
		public void SetParameters(Oni.SolverParameters parameters)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00003D34 File Offset: 0x00001F34
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x27B0C40", Offset = "0x27AF240", VA = "0x1827B0C40", Slot = "14")]
		public int GetConstraintCount(Oni.ConstraintType type)
		{
			return 0;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x27B0C50", Offset = "0x27AF250", VA = "0x1827B0C50", Slot = "15")]
		public void GetCollisionContacts(Oni.Contact[] contacts, int count)
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x27B0D00", Offset = "0x27AF300", VA = "0x1827B0D00", Slot = "16")]
		public void GetParticleCollisionContacts(Oni.Contact[] contacts, int count)
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x27B0DB0", Offset = "0x27AF3B0", VA = "0x1827B0DB0", Slot = "17")]
		public void SetConstraintGroupParameters(Oni.ConstraintType type, ref Oni.ConstraintParameters parameters)
		{
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x27B0E50", Offset = "0x27AF450", VA = "0x1827B0E50", Slot = "12")]
		public IConstraintsBatchImpl CreateConstraintsBatch(Oni.ConstraintType constraintType)
		{
			return null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x27B0EC0", Offset = "0x27AF4C0", VA = "0x1827B0EC0", Slot = "13")]
		public void DestroyConstraintsBatch(IConstraintsBatchImpl batch)
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x27B0F60", Offset = "0x27AF560", VA = "0x1827B0F60", Slot = "18")]
		public IObiJobHandle CollisionDetection(float stepTime)
		{
			return null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x27B1030", Offset = "0x27AF630", VA = "0x1827B1030", Slot = "19")]
		public IObiJobHandle Substep(float stepTime, float substepTime, int substeps)
		{
			return null;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x27B1110", Offset = "0x27AF710", VA = "0x1827B1110", Slot = "20")]
		public void ApplyInterpolation(ObiNativeVector4List startPositions, ObiNativeQuaternionList startOrientations, float stepTime, float unsimulatedTime)
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x27B1210", Offset = "0x27AF810", VA = "0x1827B1210", Slot = "10")]
		public void InterpolateDiffuseProperties(ObiNativeVector4List properties, ObiNativeVector4List diffusePositions, ObiNativeVector4List diffuseProperties, ObiNativeIntList neighbourCount, int diffuseCount)
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x27B1340", Offset = "0x27AF940", VA = "0x1827B1340", Slot = "28")]
		public int GetParticleGridSize()
		{
			return 0;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "29")]
		public void GetParticleGrid(ObiNativeAabbList cells)
		{
		}

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_OniSolver;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x18")]
		private IOniConstraintsImpl[] constraints;
	}
}
