using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	[Serializable]
	public class ObiTetherConstraintsBatch : ObiConstraintsBatch
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00003F44 File Offset: 0x00002144
		[Token(Token = "0x170000AE")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000AF")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x27BC1E0", Offset = "0x27BA7E0", VA = "0x1827BC1E0")]
		public ObiTetherConstraintsBatch([Optional] ObiTetherConstraintsData constraints)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x27BC330", Offset = "0x27BA930", VA = "0x1827BC330")]
		public void AddConstraint(Vector2Int indices, float maxLength, float scale)
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x27BC460", Offset = "0x27BAA60", VA = "0x1827BC460", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x27BC4E0", Offset = "0x27BAAE0", VA = "0x1827BC4E0", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x27BC630", Offset = "0x27BAC30", VA = "0x1827BC630", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x27BC710", Offset = "0x27BAD10", VA = "0x1827BC710", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x27BCF90", Offset = "0x27BB590", VA = "0x1827BCF90", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x27BD150", Offset = "0x27BB750", VA = "0x1827BD150", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x27BD1B0", Offset = "0x27BB7B0", VA = "0x1827BD1B0")]
		public void SetParameters(float compliance, float scale)
		{
		}

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ITetherConstraintsBatchImpl m_BatchImpl;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ObiNativeVector2List maxLengthsScales;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ObiNativeFloatList stiffnesses;
	}
}
