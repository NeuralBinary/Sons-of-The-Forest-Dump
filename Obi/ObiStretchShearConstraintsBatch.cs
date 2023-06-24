using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	[Serializable]
	public class ObiStretchShearConstraintsBatch : ObiConstraintsBatch, IStructuralConstraintBatch
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00003EFC File Offset: 0x000020FC
		[Token(Token = "0x170000AC")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x15FFA90", Offset = "0x15FE090", VA = "0x1815FFA90", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000AD")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x27BAE90", Offset = "0x27B9490", VA = "0x1827BAE90")]
		public ObiStretchShearConstraintsBatch([Optional] ObiStretchShearConstraintsData constraints)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x27BB0D0", Offset = "0x27B96D0", VA = "0x1827BB0D0")]
		public void AddConstraint(Vector2Int indices, int orientationIndex, float restLength, Quaternion restOrientation)
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x27BB2C0", Offset = "0x27B98C0", VA = "0x1827BB2C0", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00003F14 File Offset: 0x00002114
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x27BB360", Offset = "0x27B9960", VA = "0x1827BB360", Slot = "31")]
		public float GetRestLength(int index)
		{
			return 0f;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x27BB3C0", Offset = "0x27B99C0", VA = "0x1827BB3C0", Slot = "32")]
		public void SetRestLength(int index, float restLength)
		{
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00003F2C File Offset: 0x0000212C
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x27BB430", Offset = "0x27B9A30", VA = "0x1827BB430", Slot = "33")]
		public ParticlePair GetParticleIndices(int index)
		{
			return default(ParticlePair);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x27BB4B0", Offset = "0x27B9AB0", VA = "0x1827BB4B0", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x27BB600", Offset = "0x27B9C00", VA = "0x1827BB600", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x27BB730", Offset = "0x27B9D30", VA = "0x1827BB730", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x27BBF80", Offset = "0x27BA580", VA = "0x1827BBF80", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x27BC180", Offset = "0x27BA780", VA = "0x1827BC180", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected IStretchShearConstraintsBatchImpl m_BatchImpl;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ObiNativeIntList orientationIndices;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ObiNativeFloatList restLengths;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ObiNativeQuaternionList restOrientations;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public ObiNativeVector3List stiffnesses;
	}
}
