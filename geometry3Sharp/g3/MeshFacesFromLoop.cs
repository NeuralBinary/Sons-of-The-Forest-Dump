using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	public class MeshFacesFromLoop
	{
		// Token: 0x06001A55 RID: 6741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A55")]
		[Address(RVA = "0x1F24190", Offset = "0x1F22790", VA = "0x181F24190")]
		public MeshFacesFromLoop(DMesh3 Mesh, DCurve3 SpaceCurve, ISpatial Spatial)
		{
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A56")]
		[Address(RVA = "0x1F246D0", Offset = "0x1F22CD0", VA = "0x181F246D0")]
		public MeshFacesFromLoop(DMesh3 Mesh, DCurve3 SpaceCurve, ISpatial Spatial, int tSeed)
		{
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A57")]
		[Address(RVA = "0x1F24D80", Offset = "0x1F23380", VA = "0x181F24D80")]
		public int[] ToArray()
		{
			return null;
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A58")]
		[Address(RVA = "0x1F24DD0", Offset = "0x1F233D0", VA = "0x181F24DD0")]
		public MeshFaceSelection ToSelection()
		{
			return null;
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170003EF")]
		public IList<int> PathTriangles
		{
			[Token(Token = "0x6001A59")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170003F0")]
		public IList<int> InteriorTriangles
		{
			[Token(Token = "0x6001A5A")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x1F24E50", Offset = "0x1F23450", VA = "0x181F24E50")]
		private void find_interior_from_tris()
		{
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x1F25610", Offset = "0x1F23C10", VA = "0x181F25610")]
		private void find_interior_from_seed(int tSeed)
		{
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x1F25730", Offset = "0x1F23D30", VA = "0x181F25730")]
		private void find_path()
		{
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x1F25A60", Offset = "0x1F24060", VA = "0x181F25A60")]
		private void push_onto_sequence(int parentID)
		{
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x1F25DC0", Offset = "0x1F243C0", VA = "0x181F25DC0")]
		private List<int> find_path(int t1, int t2)
		{
			return null;
		}

		// Token: 0x04000DD6 RID: 3542
		[Token(Token = "0x4000DD6")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000DD7 RID: 3543
		[Token(Token = "0x4000DD7")]
		[FieldOffset(Offset = "0x18")]
		private int[] InitialLoopT;

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000DD8")]
		[FieldOffset(Offset = "0x20")]
		private List<int> PathT;

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x28")]
		private List<int> InteriorT;

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x30")]
		private List<MeshFacesFromLoop.TriWithParent> sequence;

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<int> used;

		// Token: 0x04000DDC RID: 3548
		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x40")]
		private List<int> buffer;

		// Token: 0x0200030C RID: 780
		[Token(Token = "0x200030C")]
		private struct TriWithParent
		{
			// Token: 0x04000DDD RID: 3549
			[Token(Token = "0x4000DDD")]
			[FieldOffset(Offset = "0x0")]
			public int tID;

			// Token: 0x04000DDE RID: 3550
			[Token(Token = "0x4000DDE")]
			[FieldOffset(Offset = "0x4")]
			public int parentID;
		}
	}
}
