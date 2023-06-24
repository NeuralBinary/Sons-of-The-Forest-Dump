using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	[Serializable]
	public class ObiSkinConstraintsBatch : ObiConstraintsBatch
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00003EE4 File Offset: 0x000020E4
		[Token(Token = "0x170000AA")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xE51990", Offset = "0xE4FF90", VA = "0x180E51990", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000AB")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x27B9FE0", Offset = "0x27B85E0", VA = "0x1827B9FE0")]
		public ObiSkinConstraintsBatch([Optional] ObiSkinConstraintsData constraints)
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x27BA210", Offset = "0x27B8810", VA = "0x1827BA210")]
		public void AddConstraint(int index, Vector4 point, Vector4 normal, float radius, float collisionRadius, float backstop, float stiffness)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x27BA3E0", Offset = "0x27B89E0", VA = "0x1827BA3E0", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x27BA480", Offset = "0x27B8A80", VA = "0x1827BA480", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x27BA550", Offset = "0x27B8B50", VA = "0x1827BA550", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x27BA690", Offset = "0x27B8C90", VA = "0x1827BA690", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x27BAC30", Offset = "0x27B9230", VA = "0x1827BAC30", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x27BAE30", Offset = "0x27B9430", VA = "0x1827BAE30", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ISkinConstraintsBatchImpl m_BatchImpl;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ObiNativeVector4List skinPoints;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ObiNativeVector4List skinNormals;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ObiNativeFloatList skinRadiiBackstop;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public ObiNativeFloatList skinCompliance;
	}
}
