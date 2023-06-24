using System;
using System.Collections.Generic;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class MeshStitchLoops
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1E08330", Offset = "0x1E06930", VA = "0x181E08330")]
		public MeshStitchLoops(DMesh3 mesh, EdgeLoop l0, EdgeLoop l1)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1E08620", Offset = "0x1E06C20", VA = "0x181E08620")]
		public void AddKnownCorrespondences(int[] verts0, int[] verts1)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1E08BF0", Offset = "0x1E071F0", VA = "0x181E08BF0")]
		public bool Stitch()
		{
			return default(bool);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1E08D80", Offset = "0x1E07380", VA = "0x181E08D80")]
		private bool stitch_span_simple(MeshStitchLoops.span s, int gid)
		{
			return default(bool);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1E09210", Offset = "0x1E07810", VA = "0x181E09210")]
		private bool add_triangle(int a, int b, int c, int gid)
		{
			return default(bool);
		}

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x18")]
		public EdgeLoop Loop0;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x20")]
		public EdgeLoop Loop1;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x28")]
		public bool TrustLoopOrientations;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x2C")]
		public SetGroupBehavior Group;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x38")]
		private List<MeshStitchLoops.span> spans;

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		private struct span
		{
			// Token: 0x0400009A RID: 154
			[Token(Token = "0x400009A")]
			[FieldOffset(Offset = "0x0")]
			public Interval1i span0;

			// Token: 0x0400009B RID: 155
			[Token(Token = "0x400009B")]
			[FieldOffset(Offset = "0x8")]
			public Interval1i span1;
		}
	}
}
