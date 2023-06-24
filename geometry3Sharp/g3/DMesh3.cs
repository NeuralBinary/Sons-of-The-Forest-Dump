using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200021D RID: 541
	[Token(Token = "0x200021D")]
	public class DMesh3 : IDeformableMesh, IMesh, IPointSet
	{
		// Token: 0x060012F6 RID: 4854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x1E50540", Offset = "0x1E4EB40", VA = "0x181E50540")]
		public DMesh3(bool bWantNormals = true, bool bWantColors = false, bool bWantUVs = false, bool bWantTriGroups = false)
		{
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x1E50B50", Offset = "0x1E4F150", VA = "0x181E50B50")]
		public DMesh3(MeshComponents flags)
		{
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x1E50B90", Offset = "0x1E4F190", VA = "0x181E50B90")]
		public DMesh3(DMesh3 copy, bool bCompact = false, bool bWantNormals = true, bool bWantColors = true, bool bWantUVs = true)
		{
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x1E50BF0", Offset = "0x1E4F1F0", VA = "0x181E50BF0")]
		public DMesh3(DMesh3 copy, bool bCompact, MeshComponents flags)
		{
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x1E50C50", Offset = "0x1E4F250", VA = "0x181E50C50")]
		public DMesh3(IMesh copy, MeshHints hints, bool bWantNormals = true, bool bWantColors = true, bool bWantUVs = true)
		{
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x1E50C90", Offset = "0x1E4F290", VA = "0x181E50C90")]
		public DMesh3(IMesh copy, MeshHints hints, MeshComponents flags)
		{
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0000F014 File Offset: 0x0000D214
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x1E50CE0", Offset = "0x1E4F2E0", VA = "0x181E50CE0")]
		public DMesh3.CompactInfo CompactCopy(DMesh3 copy, bool bNormals = true, bool bColors = true, bool bUVs = true)
		{
			return default(DMesh3.CompactInfo);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x1E51C00", Offset = "0x1E50200", VA = "0x181E51C00")]
		public void Copy(DMesh3 copy, bool bNormals = true, bool bColors = true, bool bUVs = true)
		{
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0000F02C File Offset: 0x0000D22C
		[Token(Token = "0x60012FE")]
		[Address(RVA = "0x1E52270", Offset = "0x1E50870", VA = "0x181E52270")]
		public DMesh3.CompactInfo Copy(IMesh copy, MeshHints hints, bool bNormals = true, bool bColors = true, bool bUVs = true)
		{
			return default(DMesh3.CompactInfo);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012FF")]
		[Address(RVA = "0x1E530F0", Offset = "0x1E516F0", VA = "0x181E530F0")]
		private void updateTimeStamp(bool bShapeChange)
		{
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x0000F044 File Offset: 0x0000D244
		[Token(Token = "0x1700030D")]
		public int Timestamp
		{
			[Token(Token = "0x6001300")]
			[Address(RVA = "0x8DCFC0", Offset = "0x8DB5C0", VA = "0x1808DCFC0", Slot = "25")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x0000F05C File Offset: 0x0000D25C
		[Token(Token = "0x1700030E")]
		public int ShapeTimestamp
		{
			[Token(Token = "0x6001301")]
			[Address(RVA = "0xAFDBB0", Offset = "0xAFC1B0", VA = "0x180AFDBB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x0000F074 File Offset: 0x0000D274
		[Token(Token = "0x1700030F")]
		public int VertexCount
		{
			[Token(Token = "0x6001302")]
			[Address(RVA = "0xF95DB0", Offset = "0xF943B0", VA = "0x180F95DB0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x0000F08C File Offset: 0x0000D28C
		[Token(Token = "0x17000310")]
		public int TriangleCount
		{
			[Token(Token = "0x6001303")]
			[Address(RVA = "0x1E53100", Offset = "0x1E51700", VA = "0x181E53100", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		[Token(Token = "0x17000311")]
		public int EdgeCount
		{
			[Token(Token = "0x6001304")]
			[Address(RVA = "0x1E53120", Offset = "0x1E51720", VA = "0x181E53120")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x0000F0BC File Offset: 0x0000D2BC
		[Token(Token = "0x17000312")]
		public int MaxVertexID
		{
			[Token(Token = "0x6001305")]
			[Address(RVA = "0x1E53140", Offset = "0x1E51740", VA = "0x181E53140", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		[Token(Token = "0x17000313")]
		public int MaxTriangleID
		{
			[Token(Token = "0x6001306")]
			[Address(RVA = "0x1E53190", Offset = "0x1E51790", VA = "0x181E53190", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		[Token(Token = "0x17000314")]
		public int MaxEdgeID
		{
			[Token(Token = "0x6001307")]
			[Address(RVA = "0x1E531E0", Offset = "0x1E517E0", VA = "0x181E531E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0000F104 File Offset: 0x0000D304
		[Token(Token = "0x17000315")]
		public int MaxGroupID
		{
			[Token(Token = "0x6001308")]
			[Address(RVA = "0xAFF270", Offset = "0xAFD870", VA = "0x180AFF270")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x0000F11C File Offset: 0x0000D31C
		[Token(Token = "0x17000316")]
		public bool HasVertexColors
		{
			[Token(Token = "0x6001309")]
			[Address(RVA = "0x76E360", Offset = "0x76C960", VA = "0x18076E360", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0000F134 File Offset: 0x0000D334
		[Token(Token = "0x17000317")]
		public bool HasVertexNormals
		{
			[Token(Token = "0x600130A")]
			[Address(RVA = "0x1E53230", Offset = "0x1E51830", VA = "0x181E53230", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x0000F14C File Offset: 0x0000D34C
		[Token(Token = "0x17000318")]
		public bool HasVertexUVs
		{
			[Token(Token = "0x600130B")]
			[Address(RVA = "0x1E53240", Offset = "0x1E51840", VA = "0x181E53240", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0000F164 File Offset: 0x0000D364
		[Token(Token = "0x17000319")]
		public bool HasTriangleGroups
		{
			[Token(Token = "0x600130C")]
			[Address(RVA = "0x1E53250", Offset = "0x1E51850", VA = "0x181E53250", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x0000F17C File Offset: 0x0000D37C
		[Token(Token = "0x1700031A")]
		public MeshComponents Components
		{
			[Token(Token = "0x600130D")]
			[Address(RVA = "0x1E53260", Offset = "0x1E51860", VA = "0x181E53260")]
			get
			{
				return MeshComponents.None;
			}
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0000F194 File Offset: 0x0000D394
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x1E532A0", Offset = "0x1E518A0", VA = "0x181E532A0", Slot = "23")]
		public bool IsVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		[Token(Token = "0x600130F")]
		[Address(RVA = "0x1E532C0", Offset = "0x1E518C0", VA = "0x181E532C0", Slot = "14")]
		public bool IsTriangle(int tID)
		{
			return default(bool);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		[Token(Token = "0x6001310")]
		[Address(RVA = "0x1E532E0", Offset = "0x1E518E0", VA = "0x181E532E0")]
		public bool IsEdge(int eID)
		{
			return default(bool);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		[Token(Token = "0x6001311")]
		[Address(RVA = "0x1E53300", Offset = "0x1E51900", VA = "0x181E53300", Slot = "20")]
		public Vector3d GetVertex(int vID)
		{
			return default(Vector3d);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0000F1F4 File Offset: 0x0000D3F4
		[Token(Token = "0x6001312")]
		[Address(RVA = "0x1E53470", Offset = "0x1E51A70", VA = "0x181E53470")]
		public Vector3f GetVertexf(int vID)
		{
			return default(Vector3f);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001313")]
		[Address(RVA = "0x1E53600", Offset = "0x1E51C00", VA = "0x181E53600", Slot = "4")]
		public void SetVertex(int vID, Vector3d vNewPos)
		{
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0000F20C File Offset: 0x0000D40C
		[Token(Token = "0x6001314")]
		[Address(RVA = "0x1E537C0", Offset = "0x1E51DC0", VA = "0x181E537C0", Slot = "21")]
		public Vector3f GetVertexNormal(int vID)
		{
			return default(Vector3f);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001315")]
		[Address(RVA = "0x1E538D0", Offset = "0x1E51ED0", VA = "0x181E538D0", Slot = "5")]
		public void SetVertexNormal(int vID, Vector3f vNewNormal)
		{
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0000F224 File Offset: 0x0000D424
		[Token(Token = "0x6001316")]
		[Address(RVA = "0x1E53A50", Offset = "0x1E52050", VA = "0x181E53A50", Slot = "22")]
		public Vector3f GetVertexColor(int vID)
		{
			return default(Vector3f);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001317")]
		[Address(RVA = "0x1E53B60", Offset = "0x1E52160", VA = "0x181E53B60")]
		public void SetVertexColor(int vID, Vector3f vNewColor)
		{
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0000F23C File Offset: 0x0000D43C
		[Token(Token = "0x6001318")]
		[Address(RVA = "0x1E53CE0", Offset = "0x1E522E0", VA = "0x181E53CE0", Slot = "9")]
		public Vector2f GetVertexUV(int vID)
		{
			return default(Vector2f);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001319")]
		[Address(RVA = "0x1E53DB0", Offset = "0x1E523B0", VA = "0x181E53DB0")]
		public void SetVertexUV(int vID, Vector2f vNewUV)
		{
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0000F254 File Offset: 0x0000D454
		[Token(Token = "0x600131A")]
		[Address(RVA = "0x1E53EC0", Offset = "0x1E524C0", VA = "0x181E53EC0")]
		public bool GetVertex(int vID, ref NewVertexInfo vinfo, bool bWantNormals, bool bWantColors, bool bWantUVs)
		{
			return default(bool);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600131B")]
		[Address(RVA = "0x1E54100", Offset = "0x1E52700", VA = "0x181E54100")]
		[Obsolete("GetVtxEdges will be removed in future, use VtxEdgesItr instead")]
		public ReadOnlyCollection<int> GetVtxEdges(int vID)
		{
			return null;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0000F26C File Offset: 0x0000D46C
		[Token(Token = "0x600131C")]
		[Address(RVA = "0x1E54180", Offset = "0x1E52780", VA = "0x181E54180")]
		public int GetVtxEdgeCount(int vID)
		{
			return 0;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0000F284 File Offset: 0x0000D484
		[Token(Token = "0x600131D")]
		[Address(RVA = "0x1E541E0", Offset = "0x1E527E0", VA = "0x181E541E0")]
		[Obsolete("GetVtxEdgeValence will be removed in future, use GetVtxEdgeCount instead")]
		public int GetVtxEdgeValence(int vID)
		{
			return 0;
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0000F29C File Offset: 0x0000D49C
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x1E54200", Offset = "0x1E52800", VA = "0x181E54200")]
		public int GetMaxVtxEdgeCount()
		{
			return 0;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0000F2B4 File Offset: 0x0000D4B4
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x1E54470", Offset = "0x1E52A70", VA = "0x181E54470", Slot = "10")]
		public NewVertexInfo GetVertexAll(int i)
		{
			return default(NewVertexInfo);
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0000F2CC File Offset: 0x0000D4CC
		[Token(Token = "0x6001320")]
		[Address(RVA = "0x1E54580", Offset = "0x1E52B80", VA = "0x181E54580")]
		public Frame3f GetVertexFrame(int vID, bool bFrameNormalY = false)
		{
			return default(Frame3f);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0000F2E4 File Offset: 0x0000D4E4
		[Token(Token = "0x6001321")]
		[Address(RVA = "0x1E54E10", Offset = "0x1E53410", VA = "0x181E54E10", Slot = "12")]
		public Index3i GetTriangle(int tID)
		{
			return default(Index3i);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		[Token(Token = "0x6001322")]
		[Address(RVA = "0x1E54F80", Offset = "0x1E53580", VA = "0x181E54F80")]
		public Index3i GetTriEdges(int tID)
		{
			return default(Index3i);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0000F314 File Offset: 0x0000D514
		[Token(Token = "0x6001323")]
		[Address(RVA = "0x1E550F0", Offset = "0x1E536F0", VA = "0x181E550F0")]
		public int GetTriEdge(int tid, int j)
		{
			return 0;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0000F32C File Offset: 0x0000D52C
		[Token(Token = "0x6001324")]
		[Address(RVA = "0x1E551A0", Offset = "0x1E537A0", VA = "0x181E551A0")]
		public Index3i GetTriNeighbourTris(int tID)
		{
			return default(Index3i);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001325")]
		[Address(RVA = "0x1E553C0", Offset = "0x1E539C0", VA = "0x181E553C0")]
		public IEnumerable<int> TriTrianglesItr(int tID)
		{
			return null;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0000F344 File Offset: 0x0000D544
		[Token(Token = "0x6001326")]
		[Address(RVA = "0x1E55480", Offset = "0x1E53A80", VA = "0x181E55480", Slot = "13")]
		public int GetTriangleGroup(int tID)
		{
			return 0;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001327")]
		[Address(RVA = "0x1E55510", Offset = "0x1E53B10", VA = "0x181E55510")]
		public void SetTriangleGroup(int tid, int group_id)
		{
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0000F35C File Offset: 0x0000D55C
		[Token(Token = "0x6001328")]
		[Address(RVA = "0x1E555E0", Offset = "0x1E53BE0", VA = "0x181E555E0")]
		public int AllocateTriangleGroup()
		{
			return 0;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001329")]
		[Address(RVA = "0x1E555F0", Offset = "0x1E53BF0", VA = "0x181E555F0")]
		public void GetTriVertices(int tID, ref Vector3d v0, ref Vector3d v1, ref Vector3d v2)
		{
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0000F374 File Offset: 0x0000D574
		[Token(Token = "0x600132A")]
		[Address(RVA = "0x1E55AD0", Offset = "0x1E540D0", VA = "0x181E55AD0")]
		public Vector3d GetTriVertex(int tid, int j)
		{
			return default(Vector3d);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0000F38C File Offset: 0x0000D58C
		[Token(Token = "0x600132B")]
		[Address(RVA = "0x1E55CC0", Offset = "0x1E542C0", VA = "0x181E55CC0")]
		public Vector3d GetTriBaryPoint(int tID, double bary0, double bary1, double bary2)
		{
			return default(Vector3d);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0000F3A4 File Offset: 0x0000D5A4
		[Token(Token = "0x600132C")]
		[Address(RVA = "0x1E56240", Offset = "0x1E54840", VA = "0x181E56240")]
		public Vector3d GetTriNormal(int tID)
		{
			return default(Vector3d);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0000F3BC File Offset: 0x0000D5BC
		[Token(Token = "0x600132D")]
		[Address(RVA = "0x1E56360", Offset = "0x1E54960", VA = "0x181E56360")]
		public double GetTriArea(int tID)
		{
			return 0.0;
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600132E")]
		[Address(RVA = "0x1E56450", Offset = "0x1E54A50", VA = "0x181E56450")]
		public void GetTriInfo(int tID, out Vector3d normal, out double fArea, out Vector3d vCentroid)
		{
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0000F3D4 File Offset: 0x0000D5D4
		[Token(Token = "0x600132F")]
		[Address(RVA = "0x1E56780", Offset = "0x1E54D80", VA = "0x181E56780")]
		public Vector3d GetTriBaryNormal(int tID, double bary0, double bary1, double bary2)
		{
			return default(Vector3d);
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		[Token(Token = "0x6001330")]
		[Address(RVA = "0x1E56D90", Offset = "0x1E55390", VA = "0x181E56D90")]
		public Vector3d GetTriCentroid(int tID)
		{
			return default(Vector3d);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001331")]
		[Address(RVA = "0x1E572E0", Offset = "0x1E558E0", VA = "0x181E572E0")]
		public void GetTriBaryPoint(int tID, double bary0, double bary1, double bary2, out NewVertexInfo vinfo)
		{
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0000F404 File Offset: 0x0000D604
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x1E57DF0", Offset = "0x1E563F0", VA = "0x181E57DF0")]
		public AxisAlignedBox3d GetTriBounds(int tID)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x0000F41C File Offset: 0x0000D61C
		[Token(Token = "0x6001333")]
		[Address(RVA = "0x1E581E0", Offset = "0x1E567E0", VA = "0x181E581E0")]
		public Frame3f GetTriFrame(int tID, int nEdge = 0)
		{
			return default(Frame3f);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0000F434 File Offset: 0x0000D634
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x1E58C70", Offset = "0x1E57270", VA = "0x181E58C70")]
		public double GetTriSolidAngle(int tID, ref Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0000F44C File Offset: 0x0000D64C
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x1E594C0", Offset = "0x1E57AC0", VA = "0x181E594C0")]
		public double GetTriInternalAngleR(int tID, int i)
		{
			return 0.0;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0000F464 File Offset: 0x0000D664
		[Token(Token = "0x6001336")]
		[Address(RVA = "0x1E5A240", Offset = "0x1E58840", VA = "0x181E5A240")]
		public Index2i GetEdgeV(int eID)
		{
			return default(Index2i);
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0000F47C File Offset: 0x0000D67C
		[Token(Token = "0x6001337")]
		[Address(RVA = "0x1E5A340", Offset = "0x1E58940", VA = "0x181E5A340")]
		public bool GetEdgeV(int eID, ref Vector3d a, ref Vector3d b)
		{
			return default(bool);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0000F494 File Offset: 0x0000D694
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x1E5A6A0", Offset = "0x1E58CA0", VA = "0x181E5A6A0")]
		public Index2i GetEdgeT(int eID)
		{
			return default(Index2i);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x1E5A7A0", Offset = "0x1E58DA0", VA = "0x181E5A7A0")]
		public Index4i GetEdge(int eID)
		{
			return default(Index4i);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		[Token(Token = "0x600133A")]
		[Address(RVA = "0x1E5A960", Offset = "0x1E58F60", VA = "0x181E5A960")]
		public bool GetEdge(int eID, ref int a, ref int b, ref int t0, ref int t1)
		{
			return default(bool);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		[Token(Token = "0x600133B")]
		[Address(RVA = "0x1E5AB60", Offset = "0x1E59160", VA = "0x181E5AB60")]
		public Index2i GetOrientedBoundaryEdgeV(int eID)
		{
			return default(Index2i);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
		[Token(Token = "0x600133C")]
		[Address(RVA = "0x1E5AD10", Offset = "0x1E59310", VA = "0x181E5AD10")]
		public Vector3d GetEdgeNormal(int eID)
		{
			return default(Vector3d);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0000F50C File Offset: 0x0000D70C
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x1E5AFD0", Offset = "0x1E595D0", VA = "0x181E5AFD0")]
		public Vector3d GetEdgePoint(int eID, double t)
		{
			return default(Vector3d);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0000F524 File Offset: 0x0000D724
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x1E5B210", Offset = "0x1E59810", VA = "0x181E5B210")]
		public int AppendVertex(Vector3d v)
		{
			return 0;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0000F53C File Offset: 0x0000D73C
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x1E5B280", Offset = "0x1E59880", VA = "0x181E5B280")]
		public int AppendVertex(ref NewVertexInfo info)
		{
			return 0;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0000F554 File Offset: 0x0000D754
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x1E5B5A0", Offset = "0x1E59BA0", VA = "0x181E5B5A0")]
		public int AppendVertex(NewVertexInfo info)
		{
			return 0;
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0000F56C File Offset: 0x0000D76C
		[Token(Token = "0x6001341")]
		[Address(RVA = "0x1E5B5C0", Offset = "0x1E59BC0", VA = "0x181E5B5C0")]
		public int AppendVertex(DMesh3 from, int fromVID)
		{
			return 0;
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0000F584 File Offset: 0x0000D784
		[Token(Token = "0x6001342")]
		[Address(RVA = "0x1E5BAB0", Offset = "0x1E5A0B0", VA = "0x181E5BAB0")]
		public MeshResult InsertVertex(int vid, ref NewVertexInfo info, bool bUnsafe = false)
		{
			return MeshResult.Ok;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0000F59C File Offset: 0x0000D79C
		[Token(Token = "0x6001343")]
		[Address(RVA = "0x1E5BE10", Offset = "0x1E5A410", VA = "0x181E5BE10")]
		public MeshResult InsertVertex(int vid, NewVertexInfo info)
		{
			return MeshResult.Ok;
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		public virtual void BeginUnsafeVerticesInsert()
		{
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x1E5BE30", Offset = "0x1E5A430", VA = "0x181E5BE30", Slot = "27")]
		public virtual void EndUnsafeVerticesInsert()
		{
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x1E5BE50", Offset = "0x1E5A450", VA = "0x181E5BE50")]
		public int AppendTriangle(int v0, int v1, int v2, int gid = -1)
		{
			return 0;
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0000F5CC File Offset: 0x0000D7CC
		[Token(Token = "0x6001347")]
		[Address(RVA = "0x1E5BE90", Offset = "0x1E5A490", VA = "0x181E5BE90")]
		public int AppendTriangle(Index3i tv, int gid = -1)
		{
			return 0;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001348")]
		[Address(RVA = "0x1E5C1B0", Offset = "0x1E5A7B0", VA = "0x181E5C1B0")]
		private void add_tri_edge(int tid, int v0, int v1, int j, int eid)
		{
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x1E5C2F0", Offset = "0x1E5A8F0", VA = "0x181E5C2F0")]
		public MeshResult InsertTriangle(int tid, Index3i tv, int gid = -1, bool bUnsafe = false)
		{
			return MeshResult.Ok;
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		public virtual void BeginUnsafeTrianglesInsert()
		{
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600134B")]
		[Address(RVA = "0x1E5C670", Offset = "0x1E5AC70", VA = "0x181E5C670", Slot = "29")]
		public virtual void EndUnsafeTrianglesInsert()
		{
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x1E5C690", Offset = "0x1E5AC90", VA = "0x181E5C690")]
		public void EnableVertexNormals(Vector3f initial_normal)
		{
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600134D")]
		[Address(RVA = "0x1E5C930", Offset = "0x1E5AF30", VA = "0x181E5C930")]
		public void DiscardVertexNormals()
		{
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600134E")]
		[Address(RVA = "0x1E5C990", Offset = "0x1E5AF90", VA = "0x181E5C990")]
		public void EnableVertexColors(Vector3f initial_color)
		{
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600134F")]
		[Address(RVA = "0x18682A0", Offset = "0x18668A0", VA = "0x1818682A0")]
		public void DiscardVertexColors()
		{
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x1E5CC30", Offset = "0x1E5B230", VA = "0x181E5CC30")]
		public void EnableVertexUVs(Vector2f initial_uv)
		{
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x1E5CE50", Offset = "0x1E5B450", VA = "0x181E5CE50")]
		public void DiscardVertexUVs()
		{
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x1E5CEB0", Offset = "0x1E5B4B0", VA = "0x181E5CEB0")]
		public void EnableTriangleGroups(int initial_group = 0)
		{
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001353")]
		[Address(RVA = "0x1E5D070", Offset = "0x1E5B670", VA = "0x181E5D070")]
		public void DiscardTriangleGroups()
		{
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001354")]
		[Address(RVA = "0x1E5D0D0", Offset = "0x1E5B6D0", VA = "0x181E5D0D0", Slot = "24")]
		public IEnumerable<int> VertexIndices()
		{
			return null;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001355")]
		[Address(RVA = "0x1E5D170", Offset = "0x1E5B770", VA = "0x181E5D170", Slot = "15")]
		public IEnumerable<int> TriangleIndices()
		{
			return null;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001356")]
		[Address(RVA = "0x1E5D210", Offset = "0x1E5B810", VA = "0x181E5D210")]
		public IEnumerable<int> EdgeIndices()
		{
			return null;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001357")]
		[Address(RVA = "0x1E5D2B0", Offset = "0x1E5B8B0", VA = "0x181E5D2B0")]
		public IEnumerable<int> BoundaryEdgeIndices()
		{
			return null;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001358")]
		[Address(RVA = "0x1E5D350", Offset = "0x1E5B950", VA = "0x181E5D350")]
		public IEnumerable<Vector3d> Vertices()
		{
			return null;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001359")]
		[Address(RVA = "0x1E5D3F0", Offset = "0x1E5B9F0", VA = "0x181E5D3F0")]
		public IEnumerable<Index3i> Triangles()
		{
			return null;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600135A")]
		[Address(RVA = "0x1E5D490", Offset = "0x1E5BA90", VA = "0x181E5D490")]
		public IEnumerable<Index4i> Edges()
		{
			return null;
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0000F5FC File Offset: 0x0000D7FC
		[Token(Token = "0x600135B")]
		[Address(RVA = "0x1E5D530", Offset = "0x1E5BB30", VA = "0x181E5D530")]
		public int FindEdge(int vA, int vB)
		{
			return 0;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0000F614 File Offset: 0x0000D814
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x1E5D540", Offset = "0x1E5BB40", VA = "0x181E5D540")]
		public int FindEdgeFromTri(int vA, int vB, int tID)
		{
			return 0;
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0000F62C File Offset: 0x0000D82C
		[Token(Token = "0x600135D")]
		[Address(RVA = "0x1E5D550", Offset = "0x1E5BB50", VA = "0x181E5D550")]
		public Index2i GetEdgeOpposingV(int eID)
		{
			return default(Index2i);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0000F644 File Offset: 0x0000D844
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x1E5D770", Offset = "0x1E5BD70", VA = "0x181E5D770")]
		public int FindTriangle(int a, int b, int c)
		{
			return 0;
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x1E5D900", Offset = "0x1E5BF00", VA = "0x181E5D900")]
		public IEnumerable<int> VtxVerticesItr(int vID)
		{
			return null;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001360")]
		[Address(RVA = "0x1E5D9C0", Offset = "0x1E5BFC0", VA = "0x181E5D9C0")]
		public IEnumerable<int> VtxEdgesItr(int vID)
		{
			return null;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0000F65C File Offset: 0x0000D85C
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x1E5DA40", Offset = "0x1E5C040", VA = "0x181E5DA40")]
		public int VtxBoundaryEdges(int vID, ref int e0, ref int e1)
		{
			return 0;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0000F674 File Offset: 0x0000D874
		[Token(Token = "0x6001362")]
		[Address(RVA = "0x1E5DD20", Offset = "0x1E5C320", VA = "0x181E5DD20")]
		public int VtxAllBoundaryEdges(int vID, int[] e)
		{
			return 0;
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0000F68C File Offset: 0x0000D88C
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x1E5DFF0", Offset = "0x1E5C5F0", VA = "0x181E5DFF0")]
		public MeshResult GetVtxTriangles(int vID, List<int> vTriangles, bool bUseOrientation)
		{
			return MeshResult.Ok;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x1E5E650", Offset = "0x1E5CC50", VA = "0x181E5E650")]
		public int GetVtxTriangleCount(int vID, bool bBruteForce = false)
		{
			return 0;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x1E5EA00", Offset = "0x1E5D000", VA = "0x181E5EA00")]
		public IEnumerable<int> VtxTrianglesItr(int vID)
		{
			return null;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001366")]
		[Address(RVA = "0x1E5EAC0", Offset = "0x1E5D0C0", VA = "0x181E5EAC0")]
		public void GetVtxNbrhood(int eID, int vID, ref int vOther, ref int oppV1, ref int oppV2, ref int t1, ref int t2)
		{
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001367")]
		[Address(RVA = "0x1E5ECC0", Offset = "0x1E5D2C0", VA = "0x181E5ECC0")]
		public void VtxOneRingCentroid(int vID, ref Vector3d centroid)
		{
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		[Token(Token = "0x6001368")]
		[Address(RVA = "0x1E5F130", Offset = "0x1E5D730", VA = "0x181E5F130")]
		public bool tri_has_v(int tID, int vID)
		{
			return default(bool);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		[Token(Token = "0x6001369")]
		[Address(RVA = "0x1E5F210", Offset = "0x1E5D810", VA = "0x181E5F210")]
		public bool tri_is_boundary(int tID)
		{
			return default(bool);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0000F6EC File Offset: 0x0000D8EC
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x1E5F320", Offset = "0x1E5D920", VA = "0x181E5F320")]
		public bool tri_has_neighbour_t(int tCheck, int tNbr)
		{
			return default(bool);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0000F704 File Offset: 0x0000D904
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x1E5F450", Offset = "0x1E5DA50", VA = "0x181E5F450")]
		public bool tri_has_sequential_v(int tID, int vA, int vB)
		{
			return default(bool);
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0000F71C File Offset: 0x0000D91C
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x1E5F5E0", Offset = "0x1E5DBE0", VA = "0x181E5F5E0")]
		public int find_tri_neighbour_edge(int tID, int vA, int vB)
		{
			return 0;
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0000F734 File Offset: 0x0000D934
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x1E5F790", Offset = "0x1E5DD90", VA = "0x181E5F790")]
		public int find_tri_neighbour_index(int tID, int vA, int vB)
		{
			return 0;
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0000F74C File Offset: 0x0000D94C
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x1E5F920", Offset = "0x1E5DF20", VA = "0x181E5F920")]
		public bool IsBoundaryEdge(int eid)
		{
			return default(bool);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0000F764 File Offset: 0x0000D964
		[Token(Token = "0x600136F")]
		[Address(RVA = "0x1E5F9C0", Offset = "0x1E5DFC0", VA = "0x181E5F9C0")]
		[Obsolete("edge_is_boundary will be removed in future, use IsBoundaryEdge instead")]
		public bool edge_is_boundary(int eid)
		{
			return default(bool);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0000F77C File Offset: 0x0000D97C
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x1E5FA60", Offset = "0x1E5E060", VA = "0x181E5FA60")]
		public bool edge_has_v(int eid, int vid)
		{
			return default(bool);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0000F794 File Offset: 0x0000D994
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x1E5FB30", Offset = "0x1E5E130", VA = "0x181E5FB30")]
		public bool edge_has_t(int eid, int tid)
		{
			return default(bool);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0000F7AC File Offset: 0x0000D9AC
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x1E5FC00", Offset = "0x1E5E200", VA = "0x181E5FC00")]
		public int edge_other_v(int eID, int vID)
		{
			return 0;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0000F7C4 File Offset: 0x0000D9C4
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x1E5FD20", Offset = "0x1E5E320", VA = "0x181E5FD20")]
		public int edge_other_t(int eID, int tid)
		{
			return 0;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0000F7DC File Offset: 0x0000D9DC
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x1E5FE50", Offset = "0x1E5E450", VA = "0x181E5FE50")]
		[Obsolete("vertex_is_boundary will be removed in future, use IsBoundaryVertex instead")]
		public bool vertex_is_boundary(int vID)
		{
			return default(bool);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x1E5FE60", Offset = "0x1E5E460", VA = "0x181E5FE60")]
		public bool IsBoundaryVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0000F80C File Offset: 0x0000DA0C
		[Token(Token = "0x6001376")]
		[Address(RVA = "0x1E60070", Offset = "0x1E5E670", VA = "0x181E60070")]
		public bool IsBoundaryTriangle(int tID)
		{
			return default(bool);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0000F824 File Offset: 0x0000DA24
		[Token(Token = "0x6001377")]
		[Address(RVA = "0x1E60180", Offset = "0x1E5E780", VA = "0x181E60180")]
		private int find_edge(int vA, int vB)
		{
			return 0;
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0000F83C File Offset: 0x0000DA3C
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x1E603D0", Offset = "0x1E5E9D0", VA = "0x181E603D0")]
		private int find_edge_from_tri(int vA, int vB, int tID)
		{
			return 0;
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0000F854 File Offset: 0x0000DA54
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x1E605A0", Offset = "0x1E5EBA0", VA = "0x181E605A0")]
		public bool IsGroupBoundaryEdge(int eID)
		{
			return default(bool);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0000F86C File Offset: 0x0000DA6C
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x1E60740", Offset = "0x1E5ED40", VA = "0x181E60740")]
		public bool IsGroupBoundaryVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0000F884 File Offset: 0x0000DA84
		[Token(Token = "0x600137B")]
		[Address(RVA = "0x1E60B30", Offset = "0x1E5F130", VA = "0x181E60B30")]
		public bool IsGroupJunctionVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0000F89C File Offset: 0x0000DA9C
		[Token(Token = "0x600137C")]
		[Address(RVA = "0x1E61000", Offset = "0x1E5F600", VA = "0x181E61000")]
		public bool GetVertexGroups(int vID, out Index4i groups)
		{
			return default(bool);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x1E61490", Offset = "0x1E5FA90", VA = "0x181E61490")]
		public bool GetAllVertexGroups(int vID, ref List<int> groups)
		{
			return default(bool);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x1E619A0", Offset = "0x1E5FFA0", VA = "0x181E619A0")]
		public List<int> GetAllVertexGroups(int vID)
		{
			return null;
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0000F8CC File Offset: 0x0000DACC
		[Token(Token = "0x600137F")]
		[Address(RVA = "0x1E61A30", Offset = "0x1E60030", VA = "0x181E61A30")]
		public bool IsBowtieVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0000F8E4 File Offset: 0x0000DAE4
		[Token(Token = "0x6001380")]
		[Address(RVA = "0x1E62040", Offset = "0x1E60640", VA = "0x181E62040")]
		public AxisAlignedBox3d GetBounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		[Token(Token = "0x1700031B")]
		public AxisAlignedBox3d CachedBounds
		{
			[Token(Token = "0x6001381")]
			[Address(RVA = "0x1E625E0", Offset = "0x1E60BE0", VA = "0x181E625E0")]
			get
			{
				return default(AxisAlignedBox3d);
			}
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0000F914 File Offset: 0x0000DB14
		[Token(Token = "0x6001382")]
		[Address(RVA = "0x1E62660", Offset = "0x1E60C60", VA = "0x181E62660")]
		public bool IsClosed()
		{
			return default(bool);
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0000F92C File Offset: 0x0000DB2C
		[Token(Token = "0x1700031C")]
		public bool CachedIsClosed
		{
			[Token(Token = "0x6001383")]
			[Address(RVA = "0x1E62920", Offset = "0x1E60F20", VA = "0x181E62920")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x0000F944 File Offset: 0x0000DB44
		[Token(Token = "0x1700031D")]
		public bool IsCompact
		{
			[Token(Token = "0x6001384")]
			[Address(RVA = "0x1E62970", Offset = "0x1E60F70", VA = "0x181E62970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0000F95C File Offset: 0x0000DB5C
		[Token(Token = "0x1700031E")]
		public bool IsCompactV
		{
			[Token(Token = "0x6001385")]
			[Address(RVA = "0x1E62A50", Offset = "0x1E61050", VA = "0x181E62A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x0000F974 File Offset: 0x0000DB74
		[Token(Token = "0x1700031F")]
		public bool IsCompactT
		{
			[Token(Token = "0x6001386")]
			[Address(RVA = "0x1E62AA0", Offset = "0x1E610A0", VA = "0x181E62AA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0000F98C File Offset: 0x0000DB8C
		[Token(Token = "0x17000320")]
		public double CompactMetric
		{
			[Token(Token = "0x6001387")]
			[Address(RVA = "0x1E62AF0", Offset = "0x1E610F0", VA = "0x181E62AF0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
		[Token(Token = "0x6001388")]
		[Address(RVA = "0x1E62BE0", Offset = "0x1E611E0", VA = "0x181E62BE0")]
		public double WindingNumber(Vector3d v)
		{
			return 0.0;
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0000F9BC File Offset: 0x0000DBBC
		[Token(Token = "0x17000321")]
		public bool HasMetadata
		{
			[Token(Token = "0x6001389")]
			[Address(RVA = "0x1E62E40", Offset = "0x1E61440", VA = "0x181E62E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600138A")]
		[Address(RVA = "0x1E62EC0", Offset = "0x1E614C0", VA = "0x181E62EC0")]
		public void AttachMetadata(string key, object o)
		{
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600138B")]
		[Address(RVA = "0x1E62FE0", Offset = "0x1E615E0", VA = "0x181E62FE0")]
		public object FindMetadata(string key)
		{
			return null;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
		[Token(Token = "0x600138C")]
		[Address(RVA = "0x1E63060", Offset = "0x1E61660", VA = "0x181E63060")]
		public bool RemoveMetadata(string key)
		{
			return default(bool);
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600138D")]
		[Address(RVA = "0x1E630C0", Offset = "0x1E616C0", VA = "0x181E630C0")]
		public void ClearMetadata()
		{
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000322")]
		public DVector<double> VerticesBuffer
		{
			[Token(Token = "0x600138E")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600138F")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000323")]
		public RefCountVector VerticesRefCounts
		{
			[Token(Token = "0x6001390")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001391")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000324")]
		public DVector<float> NormalsBuffer
		{
			[Token(Token = "0x6001392")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001393")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000325")]
		public DVector<float> ColorsBuffer
		{
			[Token(Token = "0x6001394")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001395")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000326")]
		public DVector<float> UVBuffer
		{
			[Token(Token = "0x6001396")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001397")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			set
			{
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000327")]
		public DVector<int> TrianglesBuffer
		{
			[Token(Token = "0x6001398")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001399")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			set
			{
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000328")]
		public RefCountVector TrianglesRefCounts
		{
			[Token(Token = "0x600139A")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600139B")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			set
			{
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000329")]
		public DVector<int> GroupsBuffer
		{
			[Token(Token = "0x600139C")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600139D")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			set
			{
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700032A")]
		public DVector<int> EdgesBuffer
		{
			[Token(Token = "0x600139E")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600139F")]
			[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0")]
			set
			{
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700032B")]
		public RefCountVector EdgesRefCounts
		{
			[Token(Token = "0x60013A0")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013A1")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
			set
			{
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700032C")]
		public SmallListSet VertexEdges
		{
			[Token(Token = "0x60013A2")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013A3")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			set
			{
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x1E63150", Offset = "0x1E61750", VA = "0x181E63150")]
		public void RebuildFromEdgeRefcounts()
		{
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x1E63830", Offset = "0x1E61E30", VA = "0x181E63830")]
		public DMesh3.CompactInfo CompactInPlace(bool bComputeCompactInfo = false)
		{
			return default(DMesh3.CompactInfo);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x1E64890", Offset = "0x1E62E90", VA = "0x181E64890")]
		[Conditional("DEBUG")]
		public void debug_check_is_vertex(int v)
		{
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x1E64910", Offset = "0x1E62F10", VA = "0x181E64910")]
		[Conditional("DEBUG")]
		public void debug_check_is_triangle(int t)
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x1E64990", Offset = "0x1E62F90", VA = "0x181E64990")]
		[Conditional("DEBUG")]
		public void debug_check_is_edge(int e)
		{
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013A9")]
		[Address(RVA = "0x1E64A10", Offset = "0x1E63010", VA = "0x181E64A10")]
		public void debug_print_vertex(int v)
		{
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x1E65DC0", Offset = "0x1E643C0", VA = "0x181E65DC0")]
		public void debug_print_mesh()
		{
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x1E65FA0", Offset = "0x1E645A0", VA = "0x181E65FA0")]
		public string MeshInfoString()
		{
			return null;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0000FA04 File Offset: 0x0000DC04
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x1E66830", Offset = "0x1E64E30", VA = "0x181E66830")]
		public bool IsSameMesh(DMesh3 m2, bool bCheckConnectivity, bool bCheckEdgeIDs = false, bool bCheckNormals = false, bool bCheckColors = false, bool bCheckUVs = false, bool bCheckGroups = false, float Epsilon = 1.1920929E-07f)
		{
			return default(bool);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0000FA1C File Offset: 0x0000DC1C
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x1E67760", Offset = "0x1E65D60", VA = "0x181E67760")]
		public bool CheckValidity(bool bAllowNonManifoldVertices = false, FailMode eFailMode = FailMode.Throw)
		{
			return default(bool);
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0000FA34 File Offset: 0x0000DC34
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x1E692A0", Offset = "0x1E678A0", VA = "0x181E692A0")]
		public MeshResult ReverseTriOrientation(int tID)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x1E69300", Offset = "0x1E67900", VA = "0x181E69300")]
		private void internal_reverse_tri_orientation(int tID)
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x1E693B0", Offset = "0x1E679B0", VA = "0x181E693B0")]
		public void ReverseOrientation(bool bFlipNormals = true)
		{
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0000FA4C File Offset: 0x0000DC4C
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x1E69AD0", Offset = "0x1E680D0", VA = "0x181E69AD0")]
		public MeshResult RemoveVertex(int vID, bool bRemoveAllTriangles = true, bool bPreserveManifold = false)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0000FA64 File Offset: 0x0000DC64
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x1E6A000", Offset = "0x1E68600", VA = "0x181E6A000")]
		public MeshResult RemoveTriangle(int tID, bool bRemoveIsolatedVertices = true, bool bPreserveManifold = false)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x1E6A390", Offset = "0x1E68990", VA = "0x181E6A390", Slot = "30")]
		public virtual MeshResult SetTriangle(int tID, Index3i newv, bool bRemoveIsolatedVertices = true)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0000FA94 File Offset: 0x0000DC94
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x1E6A900", Offset = "0x1E68F00", VA = "0x181E6A900")]
		public MeshResult SplitEdge(int vA, int vB, out DMesh3.EdgeSplitInfo split)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0000FAAC File Offset: 0x0000DCAC
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x1E6A970", Offset = "0x1E68F70", VA = "0x181E6A970")]
		public MeshResult SplitEdge(int eab, out DMesh3.EdgeSplitInfo split, double split_t = 0.5)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0000FAC4 File Offset: 0x0000DCC4
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x1E6BAD0", Offset = "0x1E6A0D0", VA = "0x181E6BAD0")]
		public MeshResult FlipEdge(int vA, int vB, out DMesh3.EdgeFlipInfo flip)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0000FADC File Offset: 0x0000DCDC
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x1E6BB30", Offset = "0x1E6A130", VA = "0x181E6BB30")]
		public MeshResult FlipEdge(int eab, out DMesh3.EdgeFlipInfo flip)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void debug_fail(string s)
		{
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x1E6C4B0", Offset = "0x1E6AAB0", VA = "0x181E6C4B0")]
		private void check_tri(int t)
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x1E6C4D0", Offset = "0x1E6AAD0", VA = "0x181E6C4D0")]
		private void check_edge(int e)
		{
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x1E6C4F0", Offset = "0x1E6AAF0", VA = "0x181E6C4F0")]
		public MeshResult CollapseEdge(int vKeep, int vRemove, out DMesh3.EdgeCollapseInfo collapse)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x1E6D2B0", Offset = "0x1E6B8B0", VA = "0x181E6D2B0")]
		public MeshResult MergeEdges(int eKeep, int eDiscard, out DMesh3.MergeEdgesInfo merge_info)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0000FB24 File Offset: 0x0000DD24
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x1E6E3C0", Offset = "0x1E6C9C0", VA = "0x181E6E3C0", Slot = "31")]
		public virtual MeshResult PokeTriangle(int tid, out DMesh3.PokeTriangleInfo result)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x1E6E490", Offset = "0x1E6CA90", VA = "0x181E6E490", Slot = "32")]
		public virtual MeshResult PokeTriangle(int tid, Vector3d baryCoordinates, out DMesh3.PokeTriangleInfo result)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x1E6E8A0", Offset = "0x1E6CEA0", VA = "0x181E6E8A0")]
		private void set_triangle(int tid, int v0, int v1, int v2)
		{
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x1E6EA20", Offset = "0x1E6D020", VA = "0x181E6EA20")]
		private void set_triangle_edges(int tid, int e0, int e1, int e2)
		{
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0000FB54 File Offset: 0x0000DD54
		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x1E6EBA0", Offset = "0x1E6D1A0", VA = "0x181E6EBA0")]
		private int add_edge(int vA, int vB, int tA, int tB = -1)
		{
			return 0;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x1E6ECD0", Offset = "0x1E6D2D0", VA = "0x181E6ECD0")]
		private int replace_tri_vertex(int tID, int vOld, int vNew)
		{
			return 0;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0000FB84 File Offset: 0x0000DD84
		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x1E6EE60", Offset = "0x1E6D460", VA = "0x181E6EE60")]
		private int add_triangle_only(int a, int b, int c, int e0, int e1, int e2)
		{
			return 0;
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x1E6EFA0", Offset = "0x1E6D5A0", VA = "0x181E6EFA0")]
		private void allocate_edges_list(int vid)
		{
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x1E6F030", Offset = "0x1E6D630", VA = "0x181E6F030")]
		private List<int> vertex_edges_list(int vid)
		{
			return null;
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x1E6F0C0", Offset = "0x1E6D6C0", VA = "0x181E6F0C0")]
		private List<int> vertex_vertices_list(int vid)
		{
			return null;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C7")]
		[Address(RVA = "0x1E6F350", Offset = "0x1E6D950", VA = "0x181E6F350")]
		private void set_edge_vertices(int eID, int a, int b)
		{
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x1E6F4A0", Offset = "0x1E6DAA0", VA = "0x181E6F4A0")]
		private void set_edge_triangles(int eID, int t0, int t1)
		{
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x1E6F5C0", Offset = "0x1E6DBC0", VA = "0x181E6F5C0")]
		private int replace_edge_vertex(int eID, int vOld, int vNew)
		{
			return 0;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		[Token(Token = "0x60013CA")]
		[Address(RVA = "0x1E6F870", Offset = "0x1E6DE70", VA = "0x181E6F870")]
		private int replace_edge_triangle(int eID, int tOld, int tNew)
		{
			return 0;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x1E6FA00", Offset = "0x1E6E000", VA = "0x181E6FA00")]
		private int replace_triangle_edge(int tID, int eOld, int eNew)
		{
			return 0;
		}

		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		public const int InvalidID = -1;

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		public const int NonManifoldID = -2;

		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3d InvalidVertex;

		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Index3i InvalidTriangle;

		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		[FieldOffset(Offset = "0x24")]
		public static readonly Index2i InvalidEdge;

		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		[FieldOffset(Offset = "0x10")]
		private RefCountVector vertices_refcount;

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0x18")]
		private DVector<double> vertices;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		[FieldOffset(Offset = "0x20")]
		private DVector<float> normals;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		[FieldOffset(Offset = "0x28")]
		private DVector<float> colors;

		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		[FieldOffset(Offset = "0x30")]
		private DVector<float> uv;

		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		[FieldOffset(Offset = "0x38")]
		private SmallListSet vertex_edges;

		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		[FieldOffset(Offset = "0x40")]
		private RefCountVector triangles_refcount;

		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		[FieldOffset(Offset = "0x48")]
		private DVector<int> triangles;

		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		[FieldOffset(Offset = "0x50")]
		private DVector<int> triangle_edges;

		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x40008DD")]
		[FieldOffset(Offset = "0x58")]
		private DVector<int> triangle_groups;

		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		[FieldOffset(Offset = "0x60")]
		private RefCountVector edges_refcount;

		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		[FieldOffset(Offset = "0x68")]
		private DVector<int> edges;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[FieldOffset(Offset = "0x70")]
		private int timestamp;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0x74")]
		private int shape_timestamp;

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		[FieldOffset(Offset = "0x78")]
		private int max_group_id;

		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<string, object> Metadata;

		// Token: 0x040008E4 RID: 2276
		[Token(Token = "0x40008E4")]
		[FieldOffset(Offset = "0x88")]
		private AxisAlignedBox3d cached_bounds;

		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x40008E5")]
		[FieldOffset(Offset = "0xB8")]
		private int cached_bounds_timestamp;

		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x40008E6")]
		[FieldOffset(Offset = "0xBC")]
		private bool cached_is_closed;

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		[FieldOffset(Offset = "0xC0")]
		private int cached_is_closed_timestamp;

		// Token: 0x0200021E RID: 542
		[Token(Token = "0x200021E")]
		public struct CompactInfo
		{
			// Token: 0x040008E8 RID: 2280
			[Token(Token = "0x40008E8")]
			[FieldOffset(Offset = "0x0")]
			public IIndexMap MapV;
		}

		// Token: 0x0200021F RID: 543
		[Token(Token = "0x200021F")]
		public struct EdgeSplitInfo
		{
			// Token: 0x040008E9 RID: 2281
			[Token(Token = "0x40008E9")]
			[FieldOffset(Offset = "0x0")]
			public bool bIsBoundary;

			// Token: 0x040008EA RID: 2282
			[Token(Token = "0x40008EA")]
			[FieldOffset(Offset = "0x4")]
			public int vNew;

			// Token: 0x040008EB RID: 2283
			[Token(Token = "0x40008EB")]
			[FieldOffset(Offset = "0x8")]
			public int eNewBN;

			// Token: 0x040008EC RID: 2284
			[Token(Token = "0x40008EC")]
			[FieldOffset(Offset = "0xC")]
			public int eNewCN;

			// Token: 0x040008ED RID: 2285
			[Token(Token = "0x40008ED")]
			[FieldOffset(Offset = "0x10")]
			public int eNewDN;

			// Token: 0x040008EE RID: 2286
			[Token(Token = "0x40008EE")]
			[FieldOffset(Offset = "0x14")]
			public int eNewT2;

			// Token: 0x040008EF RID: 2287
			[Token(Token = "0x40008EF")]
			[FieldOffset(Offset = "0x18")]
			public int eNewT3;
		}

		// Token: 0x02000220 RID: 544
		[Token(Token = "0x2000220")]
		public struct EdgeFlipInfo
		{
			// Token: 0x040008F0 RID: 2288
			[Token(Token = "0x40008F0")]
			[FieldOffset(Offset = "0x0")]
			public int eID;

			// Token: 0x040008F1 RID: 2289
			[Token(Token = "0x40008F1")]
			[FieldOffset(Offset = "0x4")]
			public int v0;

			// Token: 0x040008F2 RID: 2290
			[Token(Token = "0x40008F2")]
			[FieldOffset(Offset = "0x8")]
			public int v1;

			// Token: 0x040008F3 RID: 2291
			[Token(Token = "0x40008F3")]
			[FieldOffset(Offset = "0xC")]
			public int ov0;

			// Token: 0x040008F4 RID: 2292
			[Token(Token = "0x40008F4")]
			[FieldOffset(Offset = "0x10")]
			public int ov1;

			// Token: 0x040008F5 RID: 2293
			[Token(Token = "0x40008F5")]
			[FieldOffset(Offset = "0x14")]
			public int t0;

			// Token: 0x040008F6 RID: 2294
			[Token(Token = "0x40008F6")]
			[FieldOffset(Offset = "0x18")]
			public int t1;
		}

		// Token: 0x02000221 RID: 545
		[Token(Token = "0x2000221")]
		public struct EdgeCollapseInfo
		{
			// Token: 0x040008F7 RID: 2295
			[Token(Token = "0x40008F7")]
			[FieldOffset(Offset = "0x0")]
			public int vKept;

			// Token: 0x040008F8 RID: 2296
			[Token(Token = "0x40008F8")]
			[FieldOffset(Offset = "0x4")]
			public int vRemoved;

			// Token: 0x040008F9 RID: 2297
			[Token(Token = "0x40008F9")]
			[FieldOffset(Offset = "0x8")]
			public bool bIsBoundary;

			// Token: 0x040008FA RID: 2298
			[Token(Token = "0x40008FA")]
			[FieldOffset(Offset = "0xC")]
			public int eCollapsed;

			// Token: 0x040008FB RID: 2299
			[Token(Token = "0x40008FB")]
			[FieldOffset(Offset = "0x10")]
			public int tRemoved0;

			// Token: 0x040008FC RID: 2300
			[Token(Token = "0x40008FC")]
			[FieldOffset(Offset = "0x14")]
			public int tRemoved1;

			// Token: 0x040008FD RID: 2301
			[Token(Token = "0x40008FD")]
			[FieldOffset(Offset = "0x18")]
			public int eRemoved0;

			// Token: 0x040008FE RID: 2302
			[Token(Token = "0x40008FE")]
			[FieldOffset(Offset = "0x1C")]
			public int eRemoved1;

			// Token: 0x040008FF RID: 2303
			[Token(Token = "0x40008FF")]
			[FieldOffset(Offset = "0x20")]
			public int eKept0;

			// Token: 0x04000900 RID: 2304
			[Token(Token = "0x4000900")]
			[FieldOffset(Offset = "0x24")]
			public int eKept1;
		}

		// Token: 0x02000222 RID: 546
		[Token(Token = "0x2000222")]
		public struct MergeEdgesInfo
		{
			// Token: 0x04000901 RID: 2305
			[Token(Token = "0x4000901")]
			[FieldOffset(Offset = "0x0")]
			public int eKept;

			// Token: 0x04000902 RID: 2306
			[Token(Token = "0x4000902")]
			[FieldOffset(Offset = "0x4")]
			public int eRemoved;

			// Token: 0x04000903 RID: 2307
			[Token(Token = "0x4000903")]
			[FieldOffset(Offset = "0x8")]
			public Vector2i vKept;

			// Token: 0x04000904 RID: 2308
			[Token(Token = "0x4000904")]
			[FieldOffset(Offset = "0x10")]
			public Vector2i vRemoved;

			// Token: 0x04000905 RID: 2309
			[Token(Token = "0x4000905")]
			[FieldOffset(Offset = "0x18")]
			public Vector2i eRemovedExtra;

			// Token: 0x04000906 RID: 2310
			[Token(Token = "0x4000906")]
			[FieldOffset(Offset = "0x20")]
			public Vector2i eKeptExtra;
		}

		// Token: 0x02000223 RID: 547
		[Token(Token = "0x2000223")]
		public struct PokeTriangleInfo
		{
			// Token: 0x04000907 RID: 2311
			[Token(Token = "0x4000907")]
			[FieldOffset(Offset = "0x0")]
			public int new_vid;

			// Token: 0x04000908 RID: 2312
			[Token(Token = "0x4000908")]
			[FieldOffset(Offset = "0x4")]
			public int new_t1;

			// Token: 0x04000909 RID: 2313
			[Token(Token = "0x4000909")]
			[FieldOffset(Offset = "0x8")]
			public int new_t2;

			// Token: 0x0400090A RID: 2314
			[Token(Token = "0x400090A")]
			[FieldOffset(Offset = "0xC")]
			public Index3i new_edges;
		}
	}
}
