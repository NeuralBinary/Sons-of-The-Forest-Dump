using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	public class OBJReader : IMeshReader
	{
		// Token: 0x06000B32 RID: 2866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x200BAB0", Offset = "0x200A0B0", VA = "0x18200BAB0")]
		public OBJReader()
		{
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FE")]
		public List<string> MTLFileSearchPaths
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000B35 RID: 2869 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000B36 RID: 2870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		public event ParsingMessagesHandler warningEvent
		{
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x200BD30", Offset = "0x200A330", VA = "0x18200BD30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x200BE20", Offset = "0x200A420", VA = "0x18200BE20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00008324 File Offset: 0x00006524
		[Token(Token = "0x170001FF")]
		public bool HasPerVertexColors
		{
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0000833C File Offset: 0x0000653C
		[Token(Token = "0x17000200")]
		public int UVDimension
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x7849B0", Offset = "0x782FB0", VA = "0x1807849B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00008354 File Offset: 0x00006554
		[Token(Token = "0x17000201")]
		public bool HasTriangleGroups
		{
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0000836C File Offset: 0x0000656C
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000202")]
		public bool HasComplexVertices
		{
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x179C600", Offset = "0x179AC00", VA = "0x18179C600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x179C610", Offset = "0x179AC10", VA = "0x18179C610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00008384 File Offset: 0x00006584
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x200BF10", Offset = "0x200A510", VA = "0x18200BF10", Slot = "5")]
		public IOReadResult Read(BinaryReader reader, ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0000839C File Offset: 0x0000659C
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x200BF50", Offset = "0x200A550", VA = "0x18200BF50", Slot = "4")]
		public IOReadResult Read(TextReader reader, ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000083B4 File Offset: 0x000065B4
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x200C210", Offset = "0x200A810", VA = "0x18200C210")]
		private int append_vertex(IMeshBuilder builder, Index3i vertIdx, bool bHaveNormals, bool bHaveColors, bool bHaveUVs)
		{
			return 0;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000083CC File Offset: 0x000065CC
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x200C5E0", Offset = "0x200ABE0", VA = "0x18200C5E0")]
		private int append_triangle(IMeshBuilder builder, int nTri, int[] mapV)
		{
			return 0;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000083E4 File Offset: 0x000065E4
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x200CA10", Offset = "0x200B010", VA = "0x18200CA10")]
		private int append_triangle(IMeshBuilder builder, Triangle t)
		{
			return 0;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000083FC File Offset: 0x000065FC
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x200CBB0", Offset = "0x200B1B0", VA = "0x18200CBB0")]
		private IOReadResult BuildMeshes_Simple(ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00008414 File Offset: 0x00006614
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x200D000", Offset = "0x200B600", VA = "0x18200D000")]
		private IOReadResult BuildMeshes_ByMaterial(ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0000842C File Offset: 0x0000662C
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x200D860", Offset = "0x200BE60", VA = "0x18200D860")]
		public IOReadResult ParseInput(TextReader reader, ReadOptions options)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00008444 File Offset: 0x00006644
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x200E900", Offset = "0x200CF00", VA = "0x18200E900")]
		private int parse_v(string sToken)
		{
			return 0;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0000845C File Offset: 0x0000665C
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x200E980", Offset = "0x200CF80", VA = "0x18200E980")]
		private int parse_n(string sToken)
		{
			return 0;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00008474 File Offset: 0x00006674
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x200EA00", Offset = "0x200D000", VA = "0x18200EA00")]
		private int parse_u(string sToken)
		{
			return 0;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x200EA70", Offset = "0x200D070", VA = "0x18200EA70")]
		private void append_face(string[] tokens, OBJMaterial activeMaterial, int nActiveGroup)
		{
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x200EF50", Offset = "0x200D550", VA = "0x18200EF50")]
		private void parse_triangle(string[] tokens, ref Triangle t)
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x200F2F0", Offset = "0x200D8F0", VA = "0x18200F2F0")]
		private string FindMTLFile(string sMTLFilePath)
		{
			return null;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0000848C File Offset: 0x0000668C
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x200F480", Offset = "0x200DA80", VA = "0x18200F480")]
		public IOReadResult ReadMaterials(string sPath)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x20104C0", Offset = "0x200EAC0", VA = "0x1820104C0")]
		private string parse_mtl_path(string line, string[] tokens)
		{
			return null;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000084A4 File Offset: 0x000066A4
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x2010540", Offset = "0x200EB40", VA = "0x182010540")]
		private Vector3f parse_mtl_color(string[] tokens)
		{
			return default(Vector3f);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x20106E0", Offset = "0x200ECE0", VA = "0x1820106E0")]
		private OBJMaterial find_material(string sName)
		{
			return null;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x20108E0", Offset = "0x200EEE0", VA = "0x1820108E0")]
		private void emit_warning(string sMessage)
		{
		}

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x10")]
		private DVector<double> vPositions;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x18")]
		private DVector<float> vNormals;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x20")]
		private DVector<float> vUVs;

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x28")]
		private DVector<float> vColors;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x30")]
		private DVector<Triangle> vTriangles;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, OBJMaterial> Materials;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, string> UsedMaterials;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x48")]
		private bool m_bOBJHasPerVertexColors;

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x4C")]
		private int m_nUVComponents;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x50")]
		private bool m_bOBJHasTriangleGroups;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[FieldOffset(Offset = "0x54")]
		private int m_nSetInvalidGroupsTo;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x58")]
		private string[] splitDoubleSlash;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x60")]
		private char[] splitSlash;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x68")]
		private int nWarningLevel;

		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, int> warningCount;
	}
}
