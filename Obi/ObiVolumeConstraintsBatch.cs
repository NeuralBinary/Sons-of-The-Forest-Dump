using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	[Serializable]
	public class ObiVolumeConstraintsBatch : ObiConstraintsBatch
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00003F5C File Offset: 0x0000215C
		[Token(Token = "0x170000B0")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000B1")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x27BD640", Offset = "0x27BBC40", VA = "0x1827BD640")]
		public ObiVolumeConstraintsBatch([Optional] ObiVolumeConstraintsData constraints)
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x27BD870", Offset = "0x27BBE70", VA = "0x1827BD870")]
		public void AddConstraint(int[] triangles, float restVolume)
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x27BD9C0", Offset = "0x27BBFC0", VA = "0x1827BD9C0", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x27BDA60", Offset = "0x27BC060", VA = "0x1827BDA60", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x27BDB30", Offset = "0x27BC130", VA = "0x1827BDB30", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x27BE3D0", Offset = "0x27BC9D0", VA = "0x1827BE3D0", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x27BE5D0", Offset = "0x27BCBD0", VA = "0x1827BE5D0", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x27BE630", Offset = "0x27BCC30", VA = "0x1827BE630")]
		public void SetParameters(float compliance, float pressure)
		{
		}

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected IVolumeConstraintsBatchImpl m_BatchImpl;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ObiNativeIntList firstTriangle;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ObiNativeIntList numTriangles;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ObiNativeFloatList restVolumes;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public ObiNativeVector2List pressureStiffness;
	}
}
