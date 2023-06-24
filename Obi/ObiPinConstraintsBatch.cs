using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	[Serializable]
	public class ObiPinConstraintsBatch : ObiConstraintsBatch
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00003EB4 File Offset: 0x000020B4
		[Token(Token = "0x170000A6")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0xB51A40", Offset = "0xB50040", VA = "0x180B51A40", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000A7")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x27B70B0", Offset = "0x27B56B0", VA = "0x1827B70B0")]
		public ObiPinConstraintsBatch([Optional] ObiPinConstraintsData constraints)
		{
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x27B73E0", Offset = "0x27B59E0", VA = "0x1827B73E0")]
		public void AddConstraint(int solverIndex, ObiColliderBase body, Vector3 offset, Quaternion restDarboux, float linearCompliance, float rotationalCompliance, float breakThreshold)
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x27B7810", Offset = "0x27B5E10", VA = "0x1827B7810", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x27B78F0", Offset = "0x27B5EF0", VA = "0x1827B78F0", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x27B79C0", Offset = "0x27B5FC0", VA = "0x1827B79C0", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x27B7B20", Offset = "0x27B6120", VA = "0x1827B7B20", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x27B8170", Offset = "0x27B6770", VA = "0x1827B8170", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x27B8400", Offset = "0x27B6A00", VA = "0x1827B8400", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected IPinConstraintsBatchImpl m_BatchImpl;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public List<ObiColliderHandle> pinBodies;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ObiNativeIntList colliderIndices;

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ObiNativeVector4List offsets;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public ObiNativeQuaternionList restDarbouxVectors;

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public ObiNativeFloatList stiffnesses;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public ObiNativeFloatList breakThresholds;
	}
}
