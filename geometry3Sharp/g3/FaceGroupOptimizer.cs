using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000245 RID: 581
	[Token(Token = "0x2000245")]
	public class FaceGroupOptimizer
	{
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000346")]
		public DMesh3 Mesh
		{
			[Token(Token = "0x60014BC")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x1E881E0", Offset = "0x1E867E0", VA = "0x181E881E0")]
		public FaceGroupOptimizer(DMesh3 meshIn)
		{
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x000102BC File Offset: 0x0000E4BC
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x1E883B0", Offset = "0x1E869B0", VA = "0x181E883B0")]
		public int ClipFins(bool bClipLoners)
		{
			return 0;
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x000102D4 File Offset: 0x0000E4D4
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x1E88930", Offset = "0x1E86F30", VA = "0x181E88930")]
		public int FillEars(bool bFillTinyHoles)
		{
			return 0;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x000102EC File Offset: 0x0000E4EC
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x1E88C10", Offset = "0x1E87210", VA = "0x181E88C10")]
		public bool LocalOptimize(bool bClipFins, bool bFillEars, bool bFillTinyHoles = true, bool bClipLoners = true, int max_iters = 100)
		{
			return default(bool);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00010304 File Offset: 0x0000E504
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x1E88CC0", Offset = "0x1E872C0", VA = "0x181E88CC0")]
		public int DilateAllGroups(int nRings)
		{
			return 0;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0001031C File Offset: 0x0000E51C
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x1E89120", Offset = "0x1E87720", VA = "0x181E89120")]
		public int ContractAllGroups(int nRings, bool bBackgroundOnly)
		{
			return 0;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00010334 File Offset: 0x0000E534
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x1E89620", Offset = "0x1E87C20", VA = "0x181E89620")]
		private int find_max_nbr(int tid, out int nbr_same, out int nbr_diff, out int bdry_e)
		{
			return 0;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0001034C File Offset: 0x0000E54C
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x1E89910", Offset = "0x1E87F10", VA = "0x181E89910")]
		private int is_ear(int tid, bool include_tiny_holes, bool bBackgroundOnly)
		{
			return 0;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x1E899E0", Offset = "0x1E87FE0", VA = "0x181E899E0")]
		private void count_same_nbrs(int tid, out int nbr_same, out int nbr_diff, out int nbr_bg, out int bdry_e)
		{
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00010364 File Offset: 0x0000E564
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x1E89AF0", Offset = "0x1E880F0", VA = "0x181E89AF0")]
		private bool is_fin(int tid, bool include_loners)
		{
			return default(bool);
		}

		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0x10")]
		private DMesh3 mesh;

		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x18")]
		public Func<IEnumerable<int>> GetEnumeratorF;

		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		[FieldOffset(Offset = "0x20")]
		public int BackgroundGroupID;

		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x40009B1")]
		[FieldOffset(Offset = "0x24")]
		public bool DontClipEnclosedFins;

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		[FieldOffset(Offset = "0x25")]
		public bool NoEarGroupSwaps;

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		[FieldOffset(Offset = "0x28")]
		private List<Index2i> temp;
	}
}
