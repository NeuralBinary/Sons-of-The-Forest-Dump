using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000296 RID: 662
	[Token(Token = "0x2000296")]
	public class SimpleMesh : IDeformableMesh, IMesh, IPointSet
	{
		// Token: 0x06001797 RID: 6039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001797")]
		[Address(RVA = "0x1EC7270", Offset = "0x1EC5870", VA = "0x181EC7270")]
		public SimpleMesh()
		{
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001798")]
		[Address(RVA = "0x1EC72A0", Offset = "0x1EC58A0", VA = "0x181EC72A0")]
		public SimpleMesh(IMesh copy)
		{
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x1EC79E0", Offset = "0x1EC5FE0", VA = "0x181EC79E0")]
		public void Initialize(bool bWantNormals = true, bool bWantColors = true, bool bWantUVs = true, bool bWantFaceGroups = true)
		{
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600179A")]
		[Address(RVA = "0x1EC7D40", Offset = "0x1EC6340", VA = "0x181EC7D40")]
		public void Initialize(VectorArray3d v, VectorArray3i t, [Optional] VectorArray3f n, [Optional] VectorArray3f c, [Optional] VectorArray2f uv, [Optional] int[] g)
		{
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x00011BAC File Offset: 0x0000FDAC
		[Token(Token = "0x170003A9")]
		public MeshComponents Components
		{
			[Token(Token = "0x600179B")]
			[Address(RVA = "0x1EC8270", Offset = "0x1EC6870", VA = "0x181EC8270")]
			get
			{
				return MeshComponents.None;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00011BC4 File Offset: 0x0000FDC4
		[Token(Token = "0x170003AA")]
		public int Timestamp
		{
			[Token(Token = "0x600179C")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40", Slot = "25")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600179D")]
		[Address(RVA = "0x1EC82B0", Offset = "0x1EC68B0", VA = "0x181EC82B0")]
		private void updateTimeStamp()
		{
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00011BDC File Offset: 0x0000FDDC
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x1EC82C0", Offset = "0x1EC68C0", VA = "0x181EC82C0")]
		public int AppendVertex(double x, double y, double z)
		{
			return 0;
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00011BF4 File Offset: 0x0000FDF4
		[Token(Token = "0x600179F")]
		[Address(RVA = "0x1EC8510", Offset = "0x1EC6B10", VA = "0x181EC8510")]
		public int AppendVertex(NewVertexInfo info)
		{
			return 0;
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x1EC88D0", Offset = "0x1EC6ED0", VA = "0x181EC88D0")]
		public void AppendVertices(VectorArray3d v, [Optional] VectorArray3f n, [Optional] VectorArray3f c, [Optional] VectorArray2f uv)
		{
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00011C0C File Offset: 0x0000FE0C
		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x1EC8C60", Offset = "0x1EC7260", VA = "0x181EC8C60")]
		public int AppendTriangle(int i, int j, int k, int g = -1)
		{
			return 0;
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x1EC8DD0", Offset = "0x1EC73D0", VA = "0x181EC8DD0")]
		public void AppendTriangles(int[] vTriangles, int[] vertexMap, int g = -1)
		{
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x1EC9070", Offset = "0x1EC7670", VA = "0x181EC9070")]
		public void AppendTriangles(IndexArray3i t, [Optional] int[] groups)
		{
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x1EC9170", Offset = "0x1EC7770", VA = "0x181EC9170")]
		public void Translate(double tx, double ty, double tz)
		{
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x1EC93F0", Offset = "0x1EC79F0", VA = "0x181EC93F0")]
		public void Scale(double sx, double sy, double sz)
		{
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A6")]
		[Address(RVA = "0x1EC9670", Offset = "0x1EC7C70", VA = "0x181EC9670")]
		public void Scale(double s)
		{
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00011C24 File Offset: 0x0000FE24
		[Token(Token = "0x170003AB")]
		public int VertexCount
		{
			[Token(Token = "0x60017A7")]
			[Address(RVA = "0x1EC96A0", Offset = "0x1EC7CA0", VA = "0x181EC96A0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00011C3C File Offset: 0x0000FE3C
		[Token(Token = "0x170003AC")]
		public int TriangleCount
		{
			[Token(Token = "0x60017A8")]
			[Address(RVA = "0x1EC9700", Offset = "0x1EC7D00", VA = "0x181EC9700", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x00011C54 File Offset: 0x0000FE54
		[Token(Token = "0x170003AD")]
		public int MaxVertexID
		{
			[Token(Token = "0x60017A9")]
			[Address(RVA = "0x1EC96A0", Offset = "0x1EC7CA0", VA = "0x181EC96A0", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00011C6C File Offset: 0x0000FE6C
		[Token(Token = "0x170003AE")]
		public int MaxTriangleID
		{
			[Token(Token = "0x60017AA")]
			[Address(RVA = "0x1EC9700", Offset = "0x1EC7D00", VA = "0x181EC9700", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00011C84 File Offset: 0x0000FE84
		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x1EC9760", Offset = "0x1EC7D60", VA = "0x181EC9760", Slot = "23")]
		public bool IsVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00011C9C File Offset: 0x0000FE9C
		[Token(Token = "0x60017AC")]
		[Address(RVA = "0x1EC97C0", Offset = "0x1EC7DC0", VA = "0x181EC97C0", Slot = "14")]
		public bool IsTriangle(int tID)
		{
			return default(bool);
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x00011CB4 File Offset: 0x0000FEB4
		[Token(Token = "0x170003AF")]
		public bool HasVertexColors
		{
			[Token(Token = "0x60017AD")]
			[Address(RVA = "0x1EC9820", Offset = "0x1EC7E20", VA = "0x181EC9820", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x00011CCC File Offset: 0x0000FECC
		[Token(Token = "0x170003B0")]
		public bool HasVertexNormals
		{
			[Token(Token = "0x60017AE")]
			[Address(RVA = "0x1EC9890", Offset = "0x1EC7E90", VA = "0x181EC9890", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		[Token(Token = "0x170003B1")]
		public bool HasVertexUVs
		{
			[Token(Token = "0x60017AF")]
			[Address(RVA = "0x1EC9900", Offset = "0x1EC7F00", VA = "0x181EC9900", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00011CFC File Offset: 0x0000FEFC
		[Token(Token = "0x60017B0")]
		[Address(RVA = "0x1EC9990", Offset = "0x1EC7F90", VA = "0x181EC9990", Slot = "20")]
		public Vector3d GetVertex(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00011D14 File Offset: 0x0000FF14
		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x1EC9B00", Offset = "0x1EC8100", VA = "0x181EC9B00", Slot = "21")]
		public Vector3f GetVertexNormal(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00011D2C File Offset: 0x0000FF2C
		[Token(Token = "0x60017B2")]
		[Address(RVA = "0x1EC9C70", Offset = "0x1EC8270", VA = "0x181EC9C70", Slot = "22")]
		public Vector3f GetVertexColor(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00011D44 File Offset: 0x0000FF44
		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x1EC9DE0", Offset = "0x1EC83E0", VA = "0x181EC9DE0", Slot = "9")]
		public Vector2f GetVertexUV(int i)
		{
			return default(Vector2f);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00011D5C File Offset: 0x0000FF5C
		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x1EC9EE0", Offset = "0x1EC84E0", VA = "0x181EC9EE0", Slot = "10")]
		public NewVertexInfo GetVertexAll(int i)
		{
			return default(NewVertexInfo);
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00011D74 File Offset: 0x0000FF74
		[Token(Token = "0x170003B2")]
		public bool HasTriangleGroups
		{
			[Token(Token = "0x60017B5")]
			[Address(RVA = "0x1ECA440", Offset = "0x1EC8A40", VA = "0x181ECA440", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00011D8C File Offset: 0x0000FF8C
		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x1ECA4C0", Offset = "0x1EC8AC0", VA = "0x181ECA4C0", Slot = "12")]
		public Index3i GetTriangle(int i)
		{
			return default(Index3i);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00011DA4 File Offset: 0x0000FFA4
		[Token(Token = "0x60017B7")]
		[Address(RVA = "0x1ECA630", Offset = "0x1EC8C30", VA = "0x181ECA630", Slot = "13")]
		public int GetTriangleGroup(int i)
		{
			return 0;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017B8")]
		[Address(RVA = "0x1ECA6C0", Offset = "0x1EC8CC0", VA = "0x181ECA6C0")]
		public IEnumerable<Vector3d> VerticesItr()
		{
			return null;
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017B9")]
		[Address(RVA = "0x1ECA760", Offset = "0x1EC8D60", VA = "0x181ECA760")]
		public IEnumerable<Vector3f> NormalsItr()
		{
			return null;
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017BA")]
		[Address(RVA = "0x1ECA800", Offset = "0x1EC8E00", VA = "0x181ECA800")]
		public IEnumerable<Vector3f> ColorsItr()
		{
			return null;
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x1ECA8A0", Offset = "0x1EC8EA0", VA = "0x181ECA8A0")]
		public IEnumerable<Vector2f> UVsItr()
		{
			return null;
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x1ECA940", Offset = "0x1EC8F40", VA = "0x181ECA940")]
		public IEnumerable<Index3i> TrianglesItr()
		{
			return null;
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x1ECA9E0", Offset = "0x1EC8FE0", VA = "0x181ECA9E0")]
		public IEnumerable<int> TriangleGroupsItr()
		{
			return null;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x1ECAA80", Offset = "0x1EC9080", VA = "0x181ECAA80", Slot = "24")]
		public IEnumerable<int> VertexIndices()
		{
			return null;
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017BF")]
		[Address(RVA = "0x1ECAB20", Offset = "0x1EC9120", VA = "0x181ECAB20", Slot = "15")]
		public IEnumerable<int> TriangleIndices()
		{
			return null;
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017C0")]
		[Address(RVA = "0x1ECABC0", Offset = "0x1EC91C0", VA = "0x181ECABC0", Slot = "4")]
		public void SetVertex(int i, Vector3d v)
		{
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017C1")]
		[Address(RVA = "0x1ECAD70", Offset = "0x1EC9370", VA = "0x181ECAD70", Slot = "5")]
		public void SetVertexNormal(int i, Vector3f n)
		{
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017C2")]
		[Address(RVA = "0x1ECAEF0", Offset = "0x1EC94F0", VA = "0x181ECAEF0")]
		public void SetVertexColor(int i, Vector3f c)
		{
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x1ECB070", Offset = "0x1EC9670", VA = "0x181ECB070")]
		public void SetVertexUV(int i, Vector2f uv)
		{
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x1ECB180", Offset = "0x1EC9780", VA = "0x181ECB180")]
		public double[] GetVertexArray()
		{
			return null;
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x1ECB1D0", Offset = "0x1EC97D0", VA = "0x181ECB1D0")]
		public float[] GetVertexArrayFloat()
		{
			return null;
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x1ECB2D0", Offset = "0x1EC98D0", VA = "0x181ECB2D0")]
		public float[] GetVertexNormalArray()
		{
			return null;
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x1ECB330", Offset = "0x1EC9930", VA = "0x181ECB330")]
		public float[] GetVertexColorArray()
		{
			return null;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x1ECB390", Offset = "0x1EC9990", VA = "0x181ECB390")]
		public float[] GetVertexUVArray()
		{
			return null;
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x1ECB3F0", Offset = "0x1EC99F0", VA = "0x181ECB3F0")]
		public int[] GetTriangleArray()
		{
			return null;
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x1ECB440", Offset = "0x1EC9A40", VA = "0x181ECB440")]
		public int[] GetFaceGroupsArray()
		{
			return null;
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x1ECB4A0", Offset = "0x1EC9AA0", VA = "0x181ECB4A0")]
		public unsafe void GetVertexBuffer(double* pBuffer)
		{
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x1ECB4F0", Offset = "0x1EC9AF0", VA = "0x181ECB4F0")]
		public unsafe void GetVertexNormalBuffer(float* pBuffer)
		{
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x1ECB550", Offset = "0x1EC9B50", VA = "0x181ECB550")]
		public unsafe void GetVertexColorBuffer(float* pBuffer)
		{
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x1ECB5B0", Offset = "0x1EC9BB0", VA = "0x181ECB5B0")]
		public unsafe void GetVertexUVBuffer(float* pBuffer)
		{
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x1ECB610", Offset = "0x1EC9C10", VA = "0x181ECB610")]
		public unsafe void GetTriangleBuffer(int* pBuffer)
		{
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x1ECB660", Offset = "0x1EC9C60", VA = "0x181ECB660")]
		public unsafe void GetFaceGroupsBuffer(int* pBuffer)
		{
		}

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DVector<double> Vertices;

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DVector<float> Normals;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DVector<float> Colors;

		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4000B43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DVector<float> UVs;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DVector<int> Triangles;

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DVector<int> FaceGroups;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int timestamp;
	}
}
