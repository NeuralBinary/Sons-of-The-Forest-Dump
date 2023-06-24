using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	[Serializable]
	public class ObiAerodynamicConstraintsBatch : ObiConstraintsBatch
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00003D64 File Offset: 0x00001F64
		[Token(Token = "0x17000092")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x230C2B0", Offset = "0x230A8B0", VA = "0x18230C2B0", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000093")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x27B13C0", Offset = "0x27AF9C0", VA = "0x1827B13C0")]
		public ObiAerodynamicConstraintsBatch([Optional] ObiAerodynamicConstraintsData constraints)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x27B1470", Offset = "0x27AFA70", VA = "0x1827B1470")]
		public void AddConstraint(int index, float area, float drag, float lift)
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x27B1540", Offset = "0x27AFB40", VA = "0x1827B1540", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x27B1610", Offset = "0x27AFC10", VA = "0x1827B1610", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x27B1680", Offset = "0x27AFC80", VA = "0x1827B1680", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x27B1750", Offset = "0x27AFD50", VA = "0x1827B1750", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x27B2240", Offset = "0x27B0840", VA = "0x1827B2240", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x27B23E0", Offset = "0x27B09E0", VA = "0x1827B23E0", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected IAerodynamicConstraintsBatchImpl m_BatchImpl;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ObiNativeFloatList aerodynamicCoeffs;
	}
}
