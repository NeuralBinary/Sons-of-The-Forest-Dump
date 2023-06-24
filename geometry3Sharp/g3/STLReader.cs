using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	public class STLReader : IMeshReader
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000B99 RID: 2969 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000B9A RID: 2970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000004")]
		public event ParsingMessagesHandler warningEvent
		{
			[Token(Token = "0x6000B99")]
			[Address(RVA = "0x201AFB0", Offset = "0x20195B0", VA = "0x18201AFB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B9A")]
			[Address(RVA = "0x201B0A0", Offset = "0x20196A0", VA = "0x18201B0A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x201B190", Offset = "0x2019790", VA = "0x18201B190")]
		private void ParseArguments(CommandArgumentSet args)
		{
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x201B2A0", Offset = "0x20198A0", VA = "0x18201B2A0")]
		private void append_vertex(float x, float y, float z)
		{
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00008774 File Offset: 0x00006974
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x201B3D0", Offset = "0x20199D0", VA = "0x18201B3D0", Slot = "5")]
		public IOReadResult Read(BinaryReader reader, ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0000878C File Offset: 0x0000698C
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x201BB10", Offset = "0x201A110", VA = "0x18201BB10", Slot = "4")]
		public IOReadResult Read(TextReader reader, ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x201C380", Offset = "0x201A980", VA = "0x18201C380", Slot = "6")]
		protected virtual void BuildMesh(STLReader.STLSolid solid, IMeshBuilder builder)
		{
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x201C4E0", Offset = "0x201AAE0", VA = "0x18201C4E0", Slot = "7")]
		protected virtual void BuildMesh_NoMerge(STLReader.STLSolid solid, IMeshBuilder builder)
		{
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x201C910", Offset = "0x201AF10", VA = "0x18201C910", Slot = "8")]
		protected virtual DMesh3 BuildMesh_Auto(STLReader.STLSolid solid)
		{
			return null;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000087A4 File Offset: 0x000069A4
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x201C9D0", Offset = "0x201AFD0", VA = "0x18201C9D0")]
		protected int count_boundary_edges(DMesh3 mesh)
		{
			return 0;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000087BC File Offset: 0x000069BC
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x201CB90", Offset = "0x201B190", VA = "0x18201CB90")]
		protected bool check_for_cracks(DMesh3 mesh, out int boundary_edge_count, double crack_tol = 9.999999974752427E-07)
		{
			return default(bool);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x201D690", Offset = "0x201BC90", VA = "0x18201D690", Slot = "9")]
		protected virtual DMesh3 BuildMesh_IdenticalWeld(STLReader.STLSolid solid)
		{
			return null;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x201DAD0", Offset = "0x201C0D0", VA = "0x18201DAD0", Slot = "10")]
		protected virtual DMesh3 BuildMesh_TolerantWeld(STLReader.STLSolid solid, double weld_tolerance)
		{
			return null;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x201E2B0", Offset = "0x201C8B0", VA = "0x18201E2B0")]
		private void append_mapped_triangles(STLReader.STLSolid solid, DMesh3Builder builder, int[] mapV)
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x201E3C0", Offset = "0x201C9C0", VA = "0x18201E3C0")]
		private void emit_warning(string sMessage)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x201E520", Offset = "0x201CB20", VA = "0x18201E520")]
		public STLReader()
		{
		}

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x10")]
		public STLReader.Strategy RebuildStrategy;

		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x40006AE")]
		[FieldOffset(Offset = "0x18")]
		public double WeldTolerance;

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x20")]
		public bool WantPerTriAttribs;

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x0")]
		public static string PerTriAttribMetadataName;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, int> warningCount;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		public const string StrategyFlag = "-stl-weld-strategy";

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		public const string PerTriAttribFlag = "-want-tri-attrib";

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x40006B5")]
		[FieldOffset(Offset = "0x38")]
		private List<STLReader.STLSolid> Objects;

		// Token: 0x020001AF RID: 431
		[Token(Token = "0x20001AF")]
		public enum Strategy
		{
			// Token: 0x040006B7 RID: 1719
			[Token(Token = "0x40006B7")]
			NoProcessing,
			// Token: 0x040006B8 RID: 1720
			[Token(Token = "0x40006B8")]
			IdenticalVertexWeld,
			// Token: 0x040006B9 RID: 1721
			[Token(Token = "0x40006B9")]
			TolerantVertexWeld,
			// Token: 0x040006BA RID: 1722
			[Token(Token = "0x40006BA")]
			AutoBestResult
		}

		// Token: 0x020001B0 RID: 432
		[Token(Token = "0x20001B0")]
		protected class STLSolid
		{
			// Token: 0x06000BAA RID: 2986 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x201E680", Offset = "0x201CC80", VA = "0x18201E680")]
			public STLSolid()
			{
			}

			// Token: 0x040006BB RID: 1723
			[Token(Token = "0x40006BB")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x040006BC RID: 1724
			[Token(Token = "0x40006BC")]
			[FieldOffset(Offset = "0x18")]
			public DVectorArray3f Vertices;

			// Token: 0x040006BD RID: 1725
			[Token(Token = "0x40006BD")]
			[FieldOffset(Offset = "0x20")]
			public DVector<short> TriAttribs;
		}

		// Token: 0x020001B1 RID: 433
		[Token(Token = "0x20001B1")]
		private struct stl_triangle
		{
			// Token: 0x040006BE RID: 1726
			[Token(Token = "0x40006BE")]
			[FieldOffset(Offset = "0x0")]
			public float nx;

			// Token: 0x040006BF RID: 1727
			[Token(Token = "0x40006BF")]
			[FieldOffset(Offset = "0x4")]
			public float ny;

			// Token: 0x040006C0 RID: 1728
			[Token(Token = "0x40006C0")]
			[FieldOffset(Offset = "0x8")]
			public float nz;

			// Token: 0x040006C1 RID: 1729
			[Token(Token = "0x40006C1")]
			[FieldOffset(Offset = "0xC")]
			public float ax;

			// Token: 0x040006C2 RID: 1730
			[Token(Token = "0x40006C2")]
			[FieldOffset(Offset = "0x10")]
			public float ay;

			// Token: 0x040006C3 RID: 1731
			[Token(Token = "0x40006C3")]
			[FieldOffset(Offset = "0x14")]
			public float az;

			// Token: 0x040006C4 RID: 1732
			[Token(Token = "0x40006C4")]
			[FieldOffset(Offset = "0x18")]
			public float bx;

			// Token: 0x040006C5 RID: 1733
			[Token(Token = "0x40006C5")]
			[FieldOffset(Offset = "0x1C")]
			public float by;

			// Token: 0x040006C6 RID: 1734
			[Token(Token = "0x40006C6")]
			[FieldOffset(Offset = "0x20")]
			public float bz;

			// Token: 0x040006C7 RID: 1735
			[Token(Token = "0x40006C7")]
			[FieldOffset(Offset = "0x24")]
			public float cx;

			// Token: 0x040006C8 RID: 1736
			[Token(Token = "0x40006C8")]
			[FieldOffset(Offset = "0x28")]
			public float cy;

			// Token: 0x040006C9 RID: 1737
			[Token(Token = "0x40006C9")]
			[FieldOffset(Offset = "0x2C")]
			public float cz;

			// Token: 0x040006CA RID: 1738
			[Token(Token = "0x40006CA")]
			[FieldOffset(Offset = "0x30")]
			public short attrib;
		}
	}
}
