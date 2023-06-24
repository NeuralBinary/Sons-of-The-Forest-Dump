using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	public class NullSolverImpl : ISolverImpl
	{
		// Token: 0x06000482 RID: 1154 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void Destroy()
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public void InitializeFrame(Vector4 translation, Vector4 scale, Quaternion rotation)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		public void UpdateFrame(Vector4 translation, Vector4 scale, Quaternion rotation, float deltaTime)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public void ApplyFrame(float worldLinearInertiaScale, float worldAngularInertiaScale, float deltaTime)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "21")]
		public int GetDeformableTriangleCount()
		{
			return 0;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "22")]
		public void SetDeformableTriangles(int[] indices, int num, int destOffset)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00003BFC File Offset: 0x00001DFC
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "23")]
		public int RemoveDeformableTriangles(int num, int sourceOffset)
		{
			return 0;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "24")]
		public void SetSimplices(int[] simplices, SimplexCounts counts)
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public void ParticleCountChanged(ObiSolver solver)
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public void SetRigidbodyArrays(ObiSolver solver)
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		public void SetActiveParticles(int[] indices, int num)
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		public void ResetForces()
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		public void GetBounds(ref Vector3 min, ref Vector3 max)
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "25")]
		public void SetParameters(Oni.SolverParameters parameters)
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00003C14 File Offset: 0x00001E14
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "14")]
		public int GetConstraintCount(Oni.ConstraintType type)
		{
			return 0;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		public void GetCollisionContacts(Oni.Contact[] contacts, int count)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		public void GetParticleCollisionContacts(Oni.Contact[] contacts, int count)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		public void SetConstraintGroupParameters(Oni.ConstraintType type, ref Oni.ConstraintParameters parameters)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "12")]
		public IConstraintsBatchImpl CreateConstraintsBatch(Oni.ConstraintType constraintType)
		{
			return null;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
		public void DestroyConstraintsBatch(IConstraintsBatchImpl group)
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "18")]
		public IObiJobHandle CollisionDetection(float stepTime)
		{
			return null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "19")]
		public IObiJobHandle Substep(float stepTime, float substepTime, int index)
		{
			return null;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "20")]
		public void ApplyInterpolation(ObiNativeVector4List startPositions, ObiNativeQuaternionList startOrientations, float stepTime, float unsimulatedTime)
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public void InterpolateDiffuseProperties(ObiNativeVector4List properties, ObiNativeVector4List diffusePositions, ObiNativeVector4List diffuseProperties, ObiNativeIntList neighbourCount, int diffuseCount)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00003C2C File Offset: 0x00001E2C
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "28")]
		public int GetParticleGridSize()
		{
			return 0;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "29")]
		public void GetParticleGrid(ObiNativeAabbList cells)
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NullSolverImpl()
		{
		}
	}
}
