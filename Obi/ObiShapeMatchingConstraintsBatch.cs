using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	[Serializable]
	public class ObiShapeMatchingConstraintsBatch : ObiConstraintsBatch
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00003ECC File Offset: 0x000020CC
		[Token(Token = "0x170000A8")]
		public override Oni.ConstraintType constraintType
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "22")]
			get
			{
				return Oni.ConstraintType.Tether;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000A9")]
		public override IConstraintsBatchImpl implementation
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x27B84F0", Offset = "0x27B6AF0", VA = "0x1827B84F0")]
		public ObiShapeMatchingConstraintsBatch([Optional] ObiShapeMatchingConstraintsData constraints)
		{
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x27B8880", Offset = "0x27B6E80", VA = "0x1827B8880")]
		public void AddConstraint(int[] indices, bool isExplicit)
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x27B89D0", Offset = "0x27B6FD0", VA = "0x1827B89D0", Slot = "30")]
		public override void Clear()
		{
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x27B8A60", Offset = "0x27B7060", VA = "0x1827B8A60", Slot = "26")]
		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x27B8B80", Offset = "0x27B7180", VA = "0x1827B8B80", Slot = "25")]
		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x27B8D80", Offset = "0x27B7380", VA = "0x1827B8D80", Slot = "24")]
		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x27B9CB0", Offset = "0x27B82B0", VA = "0x1827B9CB0", Slot = "27")]
		public override void AddToSolver(ObiSolver solver)
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x27B9F30", Offset = "0x27B8530", VA = "0x1827B9F30", Slot = "28")]
		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x27B9F90", Offset = "0x27B8590", VA = "0x1827B9F90")]
		public void RecalculateRestShapeMatching()
		{
		}

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected IShapeMatchingConstraintsBatchImpl m_BatchImpl;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ObiNativeIntList firstIndex;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ObiNativeIntList numIndices;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ObiNativeIntList explicitGroup;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ObiNativeFloatList materialParameters;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ObiNativeVector4List restComs;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ObiNativeVector4List coms;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public ObiNativeQuaternionList orientations;
	}
}
