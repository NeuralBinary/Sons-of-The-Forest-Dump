using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x20002A0")]
	public class SimpleQuadMesh
	{
		// Token: 0x0600181D RID: 6173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600181D")]
		[Address(RVA = "0x1ECD490", Offset = "0x1ECBA90", VA = "0x181ECD490")]
		public SimpleQuadMesh()
		{
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600181E")]
		[Address(RVA = "0x1ECD4C0", Offset = "0x1ECBAC0", VA = "0x181ECD4C0")]
		public void Initialize(bool bWantNormals = true, bool bWantColors = true, bool bWantUVs = true, bool bWantFaceGroups = true)
		{
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00011FFC File Offset: 0x000101FC
		[Token(Token = "0x170003C4")]
		public MeshComponents Components
		{
			[Token(Token = "0x600181F")]
			[Address(RVA = "0x1EC8270", Offset = "0x1EC6870", VA = "0x181EC8270")]
			get
			{
				return MeshComponents.None;
			}
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00012014 File Offset: 0x00010214
		[Token(Token = "0x6001820")]
		[Address(RVA = "0x1ECD820", Offset = "0x1ECBE20", VA = "0x181ECD820")]
		public int AppendVertex(double x, double y, double z)
		{
			return 0;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0001202C File Offset: 0x0001022C
		[Token(Token = "0x6001821")]
		[Address(RVA = "0x1ECDA70", Offset = "0x1ECC070", VA = "0x181ECDA70")]
		public int AppendVertex(Vector3d v)
		{
			return 0;
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00012044 File Offset: 0x00010244
		[Token(Token = "0x6001822")]
		[Address(RVA = "0x1ECDAA0", Offset = "0x1ECC0A0", VA = "0x181ECDAA0")]
		public int AppendVertex(NewVertexInfo info)
		{
			return 0;
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0001205C File Offset: 0x0001025C
		[Token(Token = "0x6001823")]
		[Address(RVA = "0x1ECDE50", Offset = "0x1ECC450", VA = "0x181ECDE50")]
		public int AppendQuad(int i, int j, int k, int l, int g = -1)
		{
			return 0;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x00012074 File Offset: 0x00010274
		[Token(Token = "0x170003C5")]
		public int VertexCount
		{
			[Token(Token = "0x6001824")]
			[Address(RVA = "0x1ECDFC0", Offset = "0x1ECC5C0", VA = "0x181ECDFC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x0001208C File Offset: 0x0001028C
		[Token(Token = "0x170003C6")]
		public int QuadCount
		{
			[Token(Token = "0x6001825")]
			[Address(RVA = "0x1ECE020", Offset = "0x1ECC620", VA = "0x181ECE020")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x000120A4 File Offset: 0x000102A4
		[Token(Token = "0x170003C7")]
		public int MaxVertexID
		{
			[Token(Token = "0x6001826")]
			[Address(RVA = "0x1ECDFC0", Offset = "0x1ECC5C0", VA = "0x181ECDFC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x000120BC File Offset: 0x000102BC
		[Token(Token = "0x170003C8")]
		public int MaxQuadID
		{
			[Token(Token = "0x6001827")]
			[Address(RVA = "0x1ECE020", Offset = "0x1ECC620", VA = "0x181ECE020")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000120D4 File Offset: 0x000102D4
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x1ECE070", Offset = "0x1ECC670", VA = "0x181ECE070")]
		public bool IsVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x000120EC File Offset: 0x000102EC
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x1ECE0D0", Offset = "0x1ECC6D0", VA = "0x181ECE0D0")]
		public bool IsQuad(int qID)
		{
			return default(bool);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x00012104 File Offset: 0x00010304
		[Token(Token = "0x170003C9")]
		public bool HasVertexColors
		{
			[Token(Token = "0x600182A")]
			[Address(RVA = "0x1ECE130", Offset = "0x1ECC730", VA = "0x181ECE130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x0001211C File Offset: 0x0001031C
		[Token(Token = "0x170003CA")]
		public bool HasVertexNormals
		{
			[Token(Token = "0x600182B")]
			[Address(RVA = "0x1ECE1A0", Offset = "0x1ECC7A0", VA = "0x181ECE1A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x00012134 File Offset: 0x00010334
		[Token(Token = "0x170003CB")]
		public bool HasVertexUVs
		{
			[Token(Token = "0x600182C")]
			[Address(RVA = "0x1ECE210", Offset = "0x1ECC810", VA = "0x181ECE210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0001214C File Offset: 0x0001034C
		[Token(Token = "0x600182D")]
		[Address(RVA = "0x1ECE2A0", Offset = "0x1ECC8A0", VA = "0x181ECE2A0")]
		public Vector3d GetVertex(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00012164 File Offset: 0x00010364
		[Token(Token = "0x600182E")]
		[Address(RVA = "0x1ECE410", Offset = "0x1ECCA10", VA = "0x181ECE410")]
		public Vector3f GetVertexNormal(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0001217C File Offset: 0x0001037C
		[Token(Token = "0x600182F")]
		[Address(RVA = "0x1ECE580", Offset = "0x1ECCB80", VA = "0x181ECE580")]
		public Vector3f GetVertexColor(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00012194 File Offset: 0x00010394
		[Token(Token = "0x6001830")]
		[Address(RVA = "0x1ECE6F0", Offset = "0x1ECCCF0", VA = "0x181ECE6F0")]
		public Vector2f GetVertexUV(int i)
		{
			return default(Vector2f);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x000121AC File Offset: 0x000103AC
		[Token(Token = "0x6001831")]
		[Address(RVA = "0x1ECE7F0", Offset = "0x1ECCDF0", VA = "0x181ECE7F0")]
		public NewVertexInfo GetVertexAll(int i)
		{
			return default(NewVertexInfo);
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x000121C4 File Offset: 0x000103C4
		[Token(Token = "0x170003CC")]
		public bool HasFaceGroups
		{
			[Token(Token = "0x6001832")]
			[Address(RVA = "0x1ECE910", Offset = "0x1ECCF10", VA = "0x181ECE910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000121DC File Offset: 0x000103DC
		[Token(Token = "0x6001833")]
		[Address(RVA = "0x1ECE980", Offset = "0x1ECCF80", VA = "0x181ECE980")]
		public Index4i GetQuad(int i)
		{
			return default(Index4i);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x000121F4 File Offset: 0x000103F4
		[Token(Token = "0x6001834")]
		[Address(RVA = "0x1ECEB50", Offset = "0x1ECD150", VA = "0x181ECEB50")]
		public int GetFaceGroup(int i)
		{
			return 0;
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001835")]
		[Address(RVA = "0x1ECEBE0", Offset = "0x1ECD1E0", VA = "0x181ECEBE0")]
		public IEnumerable<Vector3d> VerticesItr()
		{
			return null;
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x1ECEC80", Offset = "0x1ECD280", VA = "0x181ECEC80")]
		public IEnumerable<Vector3f> NormalsItr()
		{
			return null;
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x1ECED20", Offset = "0x1ECD320", VA = "0x181ECED20")]
		public IEnumerable<Vector3f> ColorsItr()
		{
			return null;
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x1ECEDC0", Offset = "0x1ECD3C0", VA = "0x181ECEDC0")]
		public IEnumerable<Vector2f> UVsItr()
		{
			return null;
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x1ECEE60", Offset = "0x1ECD460", VA = "0x181ECEE60")]
		public IEnumerable<Index4i> QuadsItr()
		{
			return null;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x1ECEF00", Offset = "0x1ECD500", VA = "0x181ECEF00")]
		public IEnumerable<int> FaceGroupsItr()
		{
			return null;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600183B")]
		[Address(RVA = "0x1ECEFA0", Offset = "0x1ECD5A0", VA = "0x181ECEFA0")]
		public IEnumerable<int> VertexIndices()
		{
			return null;
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x1ECF040", Offset = "0x1ECD640", VA = "0x181ECF040")]
		public IEnumerable<int> QuadIndices()
		{
			return null;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600183D")]
		[Address(RVA = "0x1ECF0E0", Offset = "0x1ECD6E0", VA = "0x181ECF0E0")]
		public void SetVertex(int i, Vector3d v)
		{
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600183E")]
		[Address(RVA = "0x1ECF280", Offset = "0x1ECD880", VA = "0x181ECF280")]
		public void SetVertexNormal(int i, Vector3f n)
		{
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x1ECF3E0", Offset = "0x1ECD9E0", VA = "0x181ECF3E0")]
		public void SetVertexColor(int i, Vector3f c)
		{
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x1ECF540", Offset = "0x1ECDB40", VA = "0x181ECF540")]
		public void SetVertexUV(int i, Vector2f uv)
		{
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x1ECF640", Offset = "0x1ECDC40", VA = "0x181ECF640")]
		public double[] GetVertexArray()
		{
			return null;
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x1ECF690", Offset = "0x1ECDC90", VA = "0x181ECF690")]
		public float[] GetVertexArrayFloat()
		{
			return null;
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x1ECF790", Offset = "0x1ECDD90", VA = "0x181ECF790")]
		public float[] GetVertexNormalArray()
		{
			return null;
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x1ECF7F0", Offset = "0x1ECDDF0", VA = "0x181ECF7F0")]
		public float[] GetVertexColorArray()
		{
			return null;
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x1ECF850", Offset = "0x1ECDE50", VA = "0x181ECF850")]
		public float[] GetVertexUVArray()
		{
			return null;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x1ECF8B0", Offset = "0x1ECDEB0", VA = "0x181ECF8B0")]
		public int[] GetQuadArray()
		{
			return null;
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x1ECF900", Offset = "0x1ECDF00", VA = "0x181ECF900")]
		public int[] GetFaceGroupsArray()
		{
			return null;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0001220C File Offset: 0x0001040C
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x1ECF960", Offset = "0x1ECDF60", VA = "0x181ECF960")]
		public static IOWriteResult WriteOBJ(SimpleQuadMesh mesh, string sPath, WriteOptions options)
		{
			return default(IOWriteResult);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x1ED0740", Offset = "0x1ECED40", VA = "0x181ED0740")]
		private static void write_quad(TextWriter writer, ref Index4i q, bool bNormals, bool bUVs, ref Index4i tuv)
		{
		}

		// Token: 0x04000B7B RID: 2939
		[Token(Token = "0x4000B7B")]
		[FieldOffset(Offset = "0x10")]
		public DVector<double> Vertices;

		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4000B7C")]
		[FieldOffset(Offset = "0x18")]
		public DVector<float> Normals;

		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4000B7D")]
		[FieldOffset(Offset = "0x20")]
		public DVector<float> Colors;

		// Token: 0x04000B7E RID: 2942
		[Token(Token = "0x4000B7E")]
		[FieldOffset(Offset = "0x28")]
		public DVector<float> UVs;

		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4000B7F")]
		[FieldOffset(Offset = "0x30")]
		public DVector<int> Quads;

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		[FieldOffset(Offset = "0x38")]
		public DVector<int> FaceGroups;
	}
}
