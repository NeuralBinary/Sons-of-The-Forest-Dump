using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	public interface ISolverImpl
	{
		// Token: 0x06000465 RID: 1125
		[Token(Token = "0x6000465")]
		void Destroy();

		// Token: 0x06000466 RID: 1126
		[Token(Token = "0x6000466")]
		void InitializeFrame(Vector4 translation, Vector4 scale, Quaternion rotation);

		// Token: 0x06000467 RID: 1127
		[Token(Token = "0x6000467")]
		void UpdateFrame(Vector4 translation, Vector4 scale, Quaternion rotation, float deltaTime);

		// Token: 0x06000468 RID: 1128
		[Token(Token = "0x6000468")]
		void ApplyFrame(float worldLinearInertiaScale, float worldAngularInertiaScale, float deltaTime);

		// Token: 0x06000469 RID: 1129
		[Token(Token = "0x6000469")]
		void ParticleCountChanged(ObiSolver solver);

		// Token: 0x0600046A RID: 1130
		[Token(Token = "0x600046A")]
		void SetActiveParticles(int[] indices, int num);

		// Token: 0x0600046B RID: 1131
		[Token(Token = "0x600046B")]
		void InterpolateDiffuseProperties(ObiNativeVector4List properties, ObiNativeVector4List diffusePositions, ObiNativeVector4List diffuseProperties, ObiNativeIntList neighbourCount, int diffuseCount);

		// Token: 0x0600046C RID: 1132
		[Token(Token = "0x600046C")]
		void SetRigidbodyArrays(ObiSolver solver);

		// Token: 0x0600046D RID: 1133
		[Token(Token = "0x600046D")]
		IConstraintsBatchImpl CreateConstraintsBatch(Oni.ConstraintType type);

		// Token: 0x0600046E RID: 1134
		[Token(Token = "0x600046E")]
		void DestroyConstraintsBatch(IConstraintsBatchImpl batch);

		// Token: 0x0600046F RID: 1135
		[Token(Token = "0x600046F")]
		int GetConstraintCount(Oni.ConstraintType type);

		// Token: 0x06000470 RID: 1136
		[Token(Token = "0x6000470")]
		void GetCollisionContacts(Oni.Contact[] contacts, int count);

		// Token: 0x06000471 RID: 1137
		[Token(Token = "0x6000471")]
		void GetParticleCollisionContacts(Oni.Contact[] contacts, int count);

		// Token: 0x06000472 RID: 1138
		[Token(Token = "0x6000472")]
		void SetConstraintGroupParameters(Oni.ConstraintType type, ref Oni.ConstraintParameters parameters);

		// Token: 0x06000473 RID: 1139
		[Token(Token = "0x6000473")]
		IObiJobHandle CollisionDetection(float stepTime);

		// Token: 0x06000474 RID: 1140
		[Token(Token = "0x6000474")]
		IObiJobHandle Substep(float stepTime, float substepTime, int substeps);

		// Token: 0x06000475 RID: 1141
		[Token(Token = "0x6000475")]
		void ApplyInterpolation(ObiNativeVector4List startPositions, ObiNativeQuaternionList startOrientations, float stepTime, float unsimulatedTime);

		// Token: 0x06000476 RID: 1142
		[Token(Token = "0x6000476")]
		int GetDeformableTriangleCount();

		// Token: 0x06000477 RID: 1143
		[Token(Token = "0x6000477")]
		void SetDeformableTriangles(int[] indices, int num, int destOffset);

		// Token: 0x06000478 RID: 1144
		[Token(Token = "0x6000478")]
		int RemoveDeformableTriangles(int num, int sourceOffset);

		// Token: 0x06000479 RID: 1145
		[Token(Token = "0x6000479")]
		void SetSimplices(int[] simplices, SimplexCounts counts);

		// Token: 0x0600047A RID: 1146
		[Token(Token = "0x600047A")]
		void SetParameters(Oni.SolverParameters parameters);

		// Token: 0x0600047B RID: 1147
		[Token(Token = "0x600047B")]
		void GetBounds(ref Vector3 min, ref Vector3 max);

		// Token: 0x0600047C RID: 1148
		[Token(Token = "0x600047C")]
		void ResetForces();

		// Token: 0x0600047D RID: 1149
		[Token(Token = "0x600047D")]
		int GetParticleGridSize();

		// Token: 0x0600047E RID: 1150
		[Token(Token = "0x600047E")]
		void GetParticleGrid(ObiNativeAabbList cells);
	}
}
