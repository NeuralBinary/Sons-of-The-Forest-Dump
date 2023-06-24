using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	[Serializable]
	public class ObiChainConstraintsBatch : ObiConstraintsBatch
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00003DAC File Offset: 0x00001FAC
		[Token(Token = "0x17000098")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000099")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x27B41C0", Offset = "0x27B27C0", VA = "0x1827B41C0")]
		public ObiChainConstraintsBatch([Optional] ObiChainConstraintsData constraints)
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x27B4380", Offset = "0x27B2980", VA = "0x1827B4380")]
		public void AddConstraint(int[] indices, float restLength, float stretchStiffness, float compressionStiffness)
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x27B4480", Offset = "0x27B2A80", VA = "0x1827B4480", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x27B4500", Offset = "0x27B2B00", VA = "0x1827B4500", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x27B45A0", Offset = "0x27B2BA0", VA = "0x1827B45A0", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x27B5070", Offset = "0x27B3670", VA = "0x1827B5070", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x27B5230", Offset = "0x27B3830", VA = "0x1827B5230", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected IChainConstraintsBatchImpl m_BatchImpl;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ObiNativeIntList firstParticle;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ObiNativeIntList numParticles;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ObiNativeVector2List lengths;
	}
}
