using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	[Serializable]
	public class ObiBendConstraintsBatch : ObiConstraintsBatch
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00003D7C File Offset: 0x00001F7C
		[Token(Token = "0x17000094")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000095")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x27B2440", Offset = "0x27B0A40", VA = "0x1827B2440")]
		public ObiBendConstraintsBatch([Optional] ObiBendConstraintsData constraints)
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x27B2600", Offset = "0x27B0C00", VA = "0x1827B2600", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x27B2BA0", Offset = "0x27B11A0", VA = "0x1827B2BA0")]
		public void AddConstraint(Vector3Int indices, float restBend)
		{
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x27B2D40", Offset = "0x27B1340", VA = "0x1827B2D40", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x27B2DB0", Offset = "0x27B13B0", VA = "0x1827B2DB0", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x27B2F70", Offset = "0x27B1570", VA = "0x1827B2F70", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x27B3090", Offset = "0x27B1690", VA = "0x1827B3090", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x27B3270", Offset = "0x27B1870", VA = "0x1827B3270", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected IBendConstraintsBatchImpl m_BatchImpl;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ObiNativeFloatList restBends;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ObiNativeVector2List bendingStiffnesses;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ObiNativeVector2List plasticity;
	}
}
