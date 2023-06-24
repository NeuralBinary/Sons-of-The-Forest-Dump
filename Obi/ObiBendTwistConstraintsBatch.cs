using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	[Serializable]
	public class ObiBendTwistConstraintsBatch : ObiConstraintsBatch
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00003D94 File Offset: 0x00001F94
		[Token(Token = "0x17000096")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x9FA5F0", Offset = "0x9F8BF0", VA = "0x1809FA5F0", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000097")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x27B32D0", Offset = "0x27B18D0", VA = "0x1827B32D0")]
		public ObiBendTwistConstraintsBatch([Optional] ObiBendTwistConstraintsData constraints)
		{
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x27B3490", Offset = "0x27B1A90", VA = "0x1827B3490")]
		public void AddConstraint(Vector2Int indices, Quaternion restDarboux)
		{
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x27B36A0", Offset = "0x27B1CA0", VA = "0x1827B36A0", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x27B3740", Offset = "0x27B1D40", VA = "0x1827B3740", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x27B3890", Offset = "0x27B1E90", VA = "0x1827B3890", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x27B3990", Offset = "0x27B1F90", VA = "0x1827B3990", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x27B3F80", Offset = "0x27B2580", VA = "0x1827B3F80", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x27B4160", Offset = "0x27B2760", VA = "0x1827B4160", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected IBendTwistConstraintsBatchImpl m_BatchImpl;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ObiNativeQuaternionList restDarbouxVectors;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ObiNativeVector3List stiffnesses;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ObiNativeVector2List plasticity;
	}
}
