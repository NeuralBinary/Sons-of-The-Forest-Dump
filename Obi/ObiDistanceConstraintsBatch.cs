using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	[Serializable]
	public class ObiDistanceConstraintsBatch : ObiConstraintsBatch, IStructuralConstraintBatch
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00003E6C File Offset: 0x0000206C
		[Token(Token = "0x170000A4")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0xE51980", Offset = "0xE4FF80", VA = "0x180E51980", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000A5")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x27B5B70", Offset = "0x27B4170", VA = "0x1827B5B70")]
		public ObiDistanceConstraintsBatch(int a = 0)
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x27B5CC0", Offset = "0x27B42C0", VA = "0x1827B5CC0")]
		public void AddConstraint(Vector2Int indices, float restLength)
		{
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x27B5DE0", Offset = "0x27B43E0", VA = "0x1827B5DE0", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00003E84 File Offset: 0x00002084
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x27B5E50", Offset = "0x27B4450", VA = "0x1827B5E50", Slot = "31")]
		public float GetRestLength(int index)
		{
			return 0f;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x27B5EB0", Offset = "0x27B44B0", VA = "0x1827B5EB0", Slot = "32")]
		public void SetRestLength(int index, float restLength)
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00003E9C File Offset: 0x0000209C
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x27B5F20", Offset = "0x27B4520", VA = "0x1827B5F20", Slot = "33")]
		public ParticlePair GetParticleIndices(int index)
		{
			return default(ParticlePair);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x27B5FA0", Offset = "0x27B45A0", VA = "0x1827B5FA0", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x27B60F0", Offset = "0x27B46F0", VA = "0x1827B60F0", Slot = "29")]
		protected override void CopyConstraint(ObiConstraintsBatch batch, int constraintIndex)
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x27B6300", Offset = "0x27B4900", VA = "0x1827B6300", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x27B63E0", Offset = "0x27B49E0", VA = "0x1827B63E0", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x27B6E90", Offset = "0x27B5490", VA = "0x1827B6E90", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x27B7050", Offset = "0x27B5650", VA = "0x1827B7050", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		protected IDistanceConstraintsBatchImpl m_BatchImpl;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ObiNativeFloatList restLengths;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ObiNativeVector2List stiffnesses;
	}
}
