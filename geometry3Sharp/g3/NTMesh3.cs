using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	public class NTMesh3 : IDeformableMesh, IMesh, IPointSet
	{
		// Token: 0x06001652 RID: 5714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x1EAD290", Offset = "0x1EAB890", VA = "0x181EAD290")]
		public NTMesh3(bool bWantNormals = true, bool bWantColors = false, bool bWantTriGroups = false)
		{
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x1EAD2C0", Offset = "0x1EAB8C0", VA = "0x181EAD2C0")]
		public NTMesh3(MeshComponents flags)
		{
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x1EAD300", Offset = "0x1EAB900", VA = "0x181EAD300")]
		private void allocate(bool bWantNormals, bool bWantColors, bool bWantTriGroups)
		{
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x1EAD900", Offset = "0x1EABF00", VA = "0x181EAD900")]
		public NTMesh3(NTMesh3 copy)
		{
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x1EAD940", Offset = "0x1EABF40", VA = "0x181EAD940")]
		public void Copy(NTMesh3 copy, bool bNormals = true, bool bColors = true)
		{
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x1EADFA0", Offset = "0x1EAC5A0", VA = "0x181EADFA0")]
		public NTMesh3(DMesh3 copy)
		{
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001658")]
		[Address(RVA = "0x1E530F0", Offset = "0x1E516F0", VA = "0x181E530F0")]
		private void updateTimeStamp(bool bShapeChange)
		{
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00011024 File Offset: 0x0000F224
		[Token(Token = "0x17000381")]
		public int Timestamp
		{
			[Token(Token = "0x6001659")]
			[Address(RVA = "0x8DCFC0", Offset = "0x8DB5C0", VA = "0x1808DCFC0", Slot = "25")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x0001103C File Offset: 0x0000F23C
		[Token(Token = "0x17000382")]
		public int ShapeTimestamp
		{
			[Token(Token = "0x600165A")]
			[Address(RVA = "0xAFDBB0", Offset = "0xAFC1B0", VA = "0x180AFDBB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x00011054 File Offset: 0x0000F254
		[Token(Token = "0x17000383")]
		public int VertexCount
		{
			[Token(Token = "0x600165B")]
			[Address(RVA = "0xF95DB0", Offset = "0xF943B0", VA = "0x180F95DB0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x0001106C File Offset: 0x0000F26C
		[Token(Token = "0x17000384")]
		public int TriangleCount
		{
			[Token(Token = "0x600165C")]
			[Address(RVA = "0x1EAE560", Offset = "0x1EACB60", VA = "0x181EAE560", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x00011084 File Offset: 0x0000F284
		[Token(Token = "0x17000385")]
		public int EdgeCount
		{
			[Token(Token = "0x600165D")]
			[Address(RVA = "0x1EAE580", Offset = "0x1EACB80", VA = "0x181EAE580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x0001109C File Offset: 0x0000F29C
		[Token(Token = "0x17000386")]
		public int MaxVertexID
		{
			[Token(Token = "0x600165E")]
			[Address(RVA = "0x1E53140", Offset = "0x1E51740", VA = "0x181E53140", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x000110B4 File Offset: 0x0000F2B4
		[Token(Token = "0x17000387")]
		public int MaxTriangleID
		{
			[Token(Token = "0x600165F")]
			[Address(RVA = "0x1EAE5A0", Offset = "0x1EACBA0", VA = "0x181EAE5A0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x000110CC File Offset: 0x0000F2CC
		[Token(Token = "0x17000388")]
		public int MaxEdgeID
		{
			[Token(Token = "0x6001660")]
			[Address(RVA = "0x1EAE5F0", Offset = "0x1EACBF0", VA = "0x181EAE5F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x000110E4 File Offset: 0x0000F2E4
		[Token(Token = "0x17000389")]
		public int MaxGroupID
		{
			[Token(Token = "0x6001661")]
			[Address(RVA = "0xAFF270", Offset = "0xAFD870", VA = "0x180AFF270")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x000110FC File Offset: 0x0000F2FC
		[Token(Token = "0x1700038A")]
		public bool HasVertexColors
		{
			[Token(Token = "0x6001662")]
			[Address(RVA = "0x76E360", Offset = "0x76C960", VA = "0x18076E360", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x00011114 File Offset: 0x0000F314
		[Token(Token = "0x1700038B")]
		public bool HasVertexNormals
		{
			[Token(Token = "0x6001663")]
			[Address(RVA = "0x1E53230", Offset = "0x1E51830", VA = "0x181E53230", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x0001112C File Offset: 0x0000F32C
		[Token(Token = "0x1700038C")]
		public bool HasVertexUVs
		{
			[Token(Token = "0x6001664")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00011144 File Offset: 0x0000F344
		[Token(Token = "0x1700038D")]
		public bool HasTriangleGroups
		{
			[Token(Token = "0x6001665")]
			[Address(RVA = "0x1EAE640", Offset = "0x1EACC40", VA = "0x181EAE640", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x0001115C File Offset: 0x0000F35C
		[Token(Token = "0x1700038E")]
		public MeshComponents Components
		{
			[Token(Token = "0x6001666")]
			[Address(RVA = "0x1EAE650", Offset = "0x1EACC50", VA = "0x181EAE650")]
			get
			{
				return MeshComponents.None;
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00011174 File Offset: 0x0000F374
		[Token(Token = "0x6001667")]
		[Address(RVA = "0x1E532A0", Offset = "0x1E518A0", VA = "0x181E532A0", Slot = "23")]
		public bool IsVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0001118C File Offset: 0x0000F38C
		[Token(Token = "0x6001668")]
		[Address(RVA = "0x1EAE680", Offset = "0x1EACC80", VA = "0x181EAE680", Slot = "14")]
		public bool IsTriangle(int tID)
		{
			return default(bool);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000111A4 File Offset: 0x0000F3A4
		[Token(Token = "0x6001669")]
		[Address(RVA = "0x1EAE6A0", Offset = "0x1EACCA0", VA = "0x181EAE6A0")]
		public bool IsEdge(int eID)
		{
			return default(bool);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000111BC File Offset: 0x0000F3BC
		[Token(Token = "0x600166A")]
		[Address(RVA = "0x1EAE6C0", Offset = "0x1EACCC0", VA = "0x181EAE6C0", Slot = "20")]
		public Vector3d GetVertex(int vID)
		{
			return default(Vector3d);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000111D4 File Offset: 0x0000F3D4
		[Token(Token = "0x600166B")]
		[Address(RVA = "0x1EAE830", Offset = "0x1EACE30", VA = "0x181EAE830")]
		public Vector3f GetVertexf(int vID)
		{
			return default(Vector3f);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600166C")]
		[Address(RVA = "0x1EAE9C0", Offset = "0x1EACFC0", VA = "0x181EAE9C0", Slot = "4")]
		public void SetVertex(int vID, Vector3d vNewPos)
		{
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x000111EC File Offset: 0x0000F3EC
		[Token(Token = "0x600166D")]
		[Address(RVA = "0x1EAEB80", Offset = "0x1EAD180", VA = "0x181EAEB80", Slot = "21")]
		public Vector3f GetVertexNormal(int vID)
		{
			return default(Vector3f);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00011204 File Offset: 0x0000F404
		[Token(Token = "0x600166E")]
		[Address(RVA = "0x1EAEC90", Offset = "0x1EAD290", VA = "0x181EAEC90", Slot = "9")]
		public Vector2f GetVertexUV(int i)
		{
			return default(Vector2f);
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x1EAECF0", Offset = "0x1EAD2F0", VA = "0x181EAECF0", Slot = "5")]
		public void SetVertexNormal(int vID, Vector3f vNewNormal)
		{
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x0001121C File Offset: 0x0000F41C
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x1EAEE70", Offset = "0x1EAD470", VA = "0x181EAEE70", Slot = "22")]
		public Vector3f GetVertexColor(int vID)
		{
			return default(Vector3f);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x1EAEF80", Offset = "0x1EAD580", VA = "0x181EAEF80")]
		public void SetVertexColor(int vID, Vector3f vNewColor)
		{
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00011234 File Offset: 0x0000F434
		[Token(Token = "0x6001672")]
		[Address(RVA = "0x1EAF100", Offset = "0x1EAD700", VA = "0x181EAF100")]
		public bool GetVertex(int vID, ref NewVertexInfo vinfo, bool bWantNormals, bool bWantColors, bool bWantUVs)
		{
			return default(bool);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0001124C File Offset: 0x0000F44C
		[Token(Token = "0x6001673")]
		[Address(RVA = "0x1EAF2E0", Offset = "0x1EAD8E0", VA = "0x181EAF2E0")]
		public int GetVtxEdgeCount(int vID)
		{
			return 0;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00011264 File Offset: 0x0000F464
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x1EAF340", Offset = "0x1EAD940", VA = "0x181EAF340")]
		public int GetMaxVtxEdgeCount()
		{
			return 0;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0001127C File Offset: 0x0000F47C
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x1EAF5B0", Offset = "0x1EADBB0", VA = "0x181EAF5B0", Slot = "10")]
		public NewVertexInfo GetVertexAll(int i)
		{
			return default(NewVertexInfo);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00011294 File Offset: 0x0000F494
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x1EAF690", Offset = "0x1EADC90", VA = "0x181EAF690", Slot = "12")]
		public Index3i GetTriangle(int tID)
		{
			return default(Index3i);
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x000112AC File Offset: 0x0000F4AC
		[Token(Token = "0x6001677")]
		[Address(RVA = "0x1EAF800", Offset = "0x1EADE00", VA = "0x181EAF800")]
		public Index3i GetTriEdges(int tID)
		{
			return default(Index3i);
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x000112C4 File Offset: 0x0000F4C4
		[Token(Token = "0x6001678")]
		[Address(RVA = "0x1EAF970", Offset = "0x1EADF70", VA = "0x181EAF970")]
		public int GetTriEdge(int tid, int j)
		{
			return 0;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001679")]
		[Address(RVA = "0x1EAFA20", Offset = "0x1EAE020", VA = "0x181EAFA20")]
		public IEnumerable<int> TriTrianglesItr(int tID)
		{
			return null;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x000112DC File Offset: 0x0000F4DC
		[Token(Token = "0x600167A")]
		[Address(RVA = "0x1EAFAE0", Offset = "0x1EAE0E0", VA = "0x181EAFAE0", Slot = "13")]
		public int GetTriangleGroup(int tID)
		{
			return 0;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x1EAFB70", Offset = "0x1EAE170", VA = "0x181EAFB70")]
		public void SetTriangleGroup(int tid, int group_id)
		{
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000112F4 File Offset: 0x0000F4F4
		[Token(Token = "0x600167C")]
		[Address(RVA = "0x1EAFC40", Offset = "0x1EAE240", VA = "0x181EAFC40")]
		public int AllocateTriangleGroup()
		{
			return 0;
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600167D")]
		[Address(RVA = "0x1EAFC50", Offset = "0x1EAE250", VA = "0x181EAFC50")]
		public void GetTriVertices(int tID, ref Vector3d v0, ref Vector3d v1, ref Vector3d v2)
		{
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x0001130C File Offset: 0x0000F50C
		[Token(Token = "0x600167E")]
		[Address(RVA = "0x1EB0130", Offset = "0x1EAE730", VA = "0x181EB0130")]
		public Vector3d GetTriVertex(int tid, int j)
		{
			return default(Vector3d);
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00011324 File Offset: 0x0000F524
		[Token(Token = "0x600167F")]
		[Address(RVA = "0x1EB0320", Offset = "0x1EAE920", VA = "0x181EB0320")]
		public Vector3d GetTriNormal(int tID)
		{
			return default(Vector3d);
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x0001133C File Offset: 0x0000F53C
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x1EB0440", Offset = "0x1EAEA40", VA = "0x181EB0440")]
		public double GetTriArea(int tID)
		{
			return 0.0;
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x1EB0530", Offset = "0x1EAEB30", VA = "0x181EB0530")]
		public void GetTriInfo(int tID, out Vector3d normal, out double fArea, out Vector3d vCentroid)
		{
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00011354 File Offset: 0x0000F554
		[Token(Token = "0x6001682")]
		[Address(RVA = "0x1EB0860", Offset = "0x1EAEE60", VA = "0x181EB0860")]
		public AxisAlignedBox3d GetTriBounds(int tID)
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0001136C File Offset: 0x0000F56C
		[Token(Token = "0x6001683")]
		[Address(RVA = "0x1EB0C50", Offset = "0x1EAF250", VA = "0x181EB0C50")]
		public Frame3f GetTriFrame(int tID, int nEdge = 0)
		{
			return default(Frame3f);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00011384 File Offset: 0x0000F584
		[Token(Token = "0x6001684")]
		[Address(RVA = "0x1EB15B0", Offset = "0x1EAFBB0", VA = "0x181EB15B0")]
		public Index2i GetEdgeV(int eID)
		{
			return default(Index2i);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0001139C File Offset: 0x0000F59C
		[Token(Token = "0x6001685")]
		[Address(RVA = "0x1EB16A0", Offset = "0x1EAFCA0", VA = "0x181EB16A0")]
		public bool GetEdgeV(int eID, ref Vector3d a, ref Vector3d b)
		{
			return default(bool);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001686")]
		[Address(RVA = "0x1EB1A00", Offset = "0x1EB0000", VA = "0x181EB1A00")]
		public IEnumerable<int> EdgeTrianglesItr(int eID)
		{
			return null;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x000113B4 File Offset: 0x0000F5B4
		[Token(Token = "0x6001687")]
		[Address(RVA = "0x1EB1A20", Offset = "0x1EB0020", VA = "0x181EB1A20")]
		public int EdgeTrianglesCount(int eID)
		{
			return 0;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x000113CC File Offset: 0x0000F5CC
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x1EB1A40", Offset = "0x1EB0040", VA = "0x181EB1A40")]
		public Index2i GetOrientedBoundaryEdgeV(int eID)
		{
			return default(Index2i);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x000113E4 File Offset: 0x0000F5E4
		[Token(Token = "0x6001689")]
		[Address(RVA = "0x1EB1BF0", Offset = "0x1EB01F0", VA = "0x181EB1BF0")]
		public int AppendVertex(Vector3d v)
		{
			return 0;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x000113FC File Offset: 0x0000F5FC
		[Token(Token = "0x600168A")]
		[Address(RVA = "0x1EB1C60", Offset = "0x1EB0260", VA = "0x181EB1C60")]
		public int AppendVertex(NewVertexInfo info)
		{
			return 0;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00011414 File Offset: 0x0000F614
		[Token(Token = "0x600168B")]
		[Address(RVA = "0x1EB1F90", Offset = "0x1EB0590", VA = "0x181EB1F90")]
		public int AppendTriangle(int v0, int v1, int v2, int gid = -1)
		{
			return 0;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0001142C File Offset: 0x0000F62C
		[Token(Token = "0x600168C")]
		[Address(RVA = "0x1EB1FD0", Offset = "0x1EB05D0", VA = "0x181EB1FD0")]
		public int AppendTriangle(Index3i tv, int gid = -1)
		{
			return 0;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600168D")]
		[Address(RVA = "0x1EB22A0", Offset = "0x1EB08A0", VA = "0x181EB22A0")]
		private void add_tri_edge(int tid, int v0, int v1, int j, int eid)
		{
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600168E")]
		[Address(RVA = "0x1EB2380", Offset = "0x1EB0980", VA = "0x181EB2380")]
		public void EnableVertexNormals(Vector3f initial_normal)
		{
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600168F")]
		[Address(RVA = "0x1E5C930", Offset = "0x1E5AF30", VA = "0x181E5C930")]
		public void DiscardVertexNormals()
		{
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001690")]
		[Address(RVA = "0x1EB2620", Offset = "0x1EB0C20", VA = "0x181EB2620")]
		public void EnableVertexColors(Vector3f initial_color)
		{
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001691")]
		[Address(RVA = "0x18682A0", Offset = "0x18668A0", VA = "0x1818682A0")]
		public void DiscardVertexColors()
		{
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001692")]
		[Address(RVA = "0x1EB28C0", Offset = "0x1EB0EC0", VA = "0x181EB28C0")]
		public void EnableTriangleGroups(int initial_group = 0)
		{
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001693")]
		[Address(RVA = "0x1EB2A80", Offset = "0x1EB1080", VA = "0x181EB2A80")]
		public void DiscardTriangleGroups()
		{
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001694")]
		[Address(RVA = "0x1EB2AE0", Offset = "0x1EB10E0", VA = "0x181EB2AE0", Slot = "24")]
		public IEnumerable<int> VertexIndices()
		{
			return null;
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001695")]
		[Address(RVA = "0x1EB2B80", Offset = "0x1EB1180", VA = "0x181EB2B80", Slot = "15")]
		public IEnumerable<int> TriangleIndices()
		{
			return null;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001696")]
		[Address(RVA = "0x1EB2C20", Offset = "0x1EB1220", VA = "0x181EB2C20")]
		public IEnumerable<int> EdgeIndices()
		{
			return null;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001697")]
		[Address(RVA = "0x1EB2CC0", Offset = "0x1EB12C0", VA = "0x181EB2CC0")]
		public IEnumerable<int> BoundaryEdgeIndices()
		{
			return null;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001698")]
		[Address(RVA = "0x1EB2D60", Offset = "0x1EB1360", VA = "0x181EB2D60")]
		public IEnumerable<Vector3d> Vertices()
		{
			return null;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001699")]
		[Address(RVA = "0x1EB2E00", Offset = "0x1EB1400", VA = "0x181EB2E00")]
		public IEnumerable<Index3i> Triangles()
		{
			return null;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00011444 File Offset: 0x0000F644
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x1EB2EA0", Offset = "0x1EB14A0", VA = "0x181EB2EA0")]
		public int FindEdge(int vA, int vB)
		{
			return 0;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0001145C File Offset: 0x0000F65C
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x1EB2EB0", Offset = "0x1EB14B0", VA = "0x181EB2EB0")]
		public int FindEdgeFromTri(int vA, int vB, int t)
		{
			return 0;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x1EB2EC0", Offset = "0x1EB14C0", VA = "0x181EB2EC0")]
		public IEnumerable<int> VtxVerticesItr(int vID)
		{
			return null;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x1EB2F80", Offset = "0x1EB1580", VA = "0x181EB2F80")]
		public IEnumerable<int> VtxEdgesItr(int vID)
		{
			return null;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00011474 File Offset: 0x0000F674
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x1EB3000", Offset = "0x1EB1600", VA = "0x181EB3000")]
		public int VtxBoundaryEdges(int vID)
		{
			return 0;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0001148C File Offset: 0x0000F68C
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x1EB3220", Offset = "0x1EB1820", VA = "0x181EB3220")]
		public int VtxAllBoundaryEdges(int vID, int[] e)
		{
			return 0;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000114A4 File Offset: 0x0000F6A4
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x1EB3470", Offset = "0x1EB1A70", VA = "0x181EB3470")]
		public MeshResult GetVtxTriangles(int vID, List<int> vTriangles)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x000114BC File Offset: 0x0000F6BC
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x1EB37B0", Offset = "0x1EB1DB0", VA = "0x181EB37B0")]
		public int GetVtxTriangleCount(int vID, bool bBruteForce = false)
		{
			return 0;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x1EB3860", Offset = "0x1EB1E60", VA = "0x181EB3860")]
		public IEnumerable<int> VtxTrianglesItr(int vID)
		{
			return null;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x000114D4 File Offset: 0x0000F6D4
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x1EB3920", Offset = "0x1EB1F20", VA = "0x181EB3920")]
		protected bool tri_has_v(int tID, int vID)
		{
			return default(bool);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000114EC File Offset: 0x0000F6EC
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x1EB3A00", Offset = "0x1EB2000", VA = "0x181EB3A00")]
		protected bool tri_is_boundary(int tID)
		{
			return default(bool);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00011504 File Offset: 0x0000F704
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x1EB3B30", Offset = "0x1EB2130", VA = "0x181EB3B30")]
		protected bool tri_has_neighbour_t(int tCheck, int tNbr)
		{
			return default(bool);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0001151C File Offset: 0x0000F71C
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x1EB3C70", Offset = "0x1EB2270", VA = "0x181EB3C70")]
		protected bool tri_has_sequential_v(int tID, int vA, int vB)
		{
			return default(bool);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00011534 File Offset: 0x0000F734
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x1EB3E00", Offset = "0x1EB2400", VA = "0x181EB3E00")]
		protected int find_tri_neighbour_edge(int tID, int vA, int vB)
		{
			return 0;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0001154C File Offset: 0x0000F74C
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x1EB3FB0", Offset = "0x1EB25B0", VA = "0x181EB3FB0")]
		protected int find_tri_neighbour_index(int tID, int vA, int vB)
		{
			return 0;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00011564 File Offset: 0x0000F764
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x1EB4140", Offset = "0x1EB2740", VA = "0x181EB4140")]
		public bool IsNonManifoldEdge(int eid)
		{
			return default(bool);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0001157C File Offset: 0x0000F77C
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x1EB4170", Offset = "0x1EB2770", VA = "0x181EB4170")]
		public bool IsBoundaryEdge(int eid)
		{
			return default(bool);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00011594 File Offset: 0x0000F794
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x1EB4170", Offset = "0x1EB2770", VA = "0x181EB4170")]
		protected bool edge_is_boundary(int eid)
		{
			return default(bool);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x000115AC File Offset: 0x0000F7AC
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x1EB41A0", Offset = "0x1EB27A0", VA = "0x181EB41A0")]
		protected bool edge_has_v(int eid, int vid)
		{
			return default(bool);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x000115C4 File Offset: 0x0000F7C4
		[Token(Token = "0x60016AD")]
		[Address(RVA = "0x1EB4270", Offset = "0x1EB2870", VA = "0x181EB4270")]
		protected bool edge_has_t(int eid, int tid)
		{
			return default(bool);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x000115DC File Offset: 0x0000F7DC
		[Token(Token = "0x60016AE")]
		[Address(RVA = "0x1EB4290", Offset = "0x1EB2890", VA = "0x181EB4290")]
		protected int edge_other_v(int eID, int vID)
		{
			return 0;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x000115F4 File Offset: 0x0000F7F4
		[Token(Token = "0x60016AF")]
		[Address(RVA = "0x1EB43B0", Offset = "0x1EB29B0", VA = "0x181EB43B0")]
		public bool vertex_is_boundary(int vID)
		{
			return default(bool);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0001160C File Offset: 0x0000F80C
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x1EB43C0", Offset = "0x1EB29C0", VA = "0x181EB43C0")]
		public bool IsBoundaryVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00011624 File Offset: 0x0000F824
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x1EB4550", Offset = "0x1EB2B50", VA = "0x181EB4550")]
		public bool IsBoundaryTriangle(int tID)
		{
			return default(bool);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0001163C File Offset: 0x0000F83C
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x1EB4680", Offset = "0x1EB2C80", VA = "0x181EB4680")]
		private int find_edge(int vA, int vB)
		{
			return 0;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00011654 File Offset: 0x0000F854
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x1EB48D0", Offset = "0x1EB2ED0", VA = "0x181EB48D0")]
		private int find_edge_from_tri(int vA, int vB, int tID)
		{
			return 0;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0001166C File Offset: 0x0000F86C
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x1EB4AA0", Offset = "0x1EB30A0", VA = "0x181EB4AA0")]
		public bool IsBowtieVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00011684 File Offset: 0x0000F884
		[Token(Token = "0x60016B5")]
		[Address(RVA = "0x1EB4C30", Offset = "0x1EB3230", VA = "0x181EB4C30")]
		public AxisAlignedBox3d GetBounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x0001169C File Offset: 0x0000F89C
		[Token(Token = "0x1700038F")]
		public AxisAlignedBox3d CachedBounds
		{
			[Token(Token = "0x60016B6")]
			[Address(RVA = "0x1EB51D0", Offset = "0x1EB37D0", VA = "0x181EB51D0")]
			get
			{
				return default(AxisAlignedBox3d);
			}
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x000116B4 File Offset: 0x0000F8B4
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x1EB5250", Offset = "0x1EB3850", VA = "0x181EB5250")]
		public bool IsClosed()
		{
			return default(bool);
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x000116CC File Offset: 0x0000F8CC
		[Token(Token = "0x17000390")]
		public bool CachedIsClosed
		{
			[Token(Token = "0x60016B8")]
			[Address(RVA = "0x1EB5530", Offset = "0x1EB3B30", VA = "0x181EB5530")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x000116E4 File Offset: 0x0000F8E4
		[Token(Token = "0x17000391")]
		public bool IsCompact
		{
			[Token(Token = "0x60016B9")]
			[Address(RVA = "0x1EB5580", Offset = "0x1EB3B80", VA = "0x181EB5580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x000116FC File Offset: 0x0000F8FC
		[Token(Token = "0x17000392")]
		public bool IsCompactV
		{
			[Token(Token = "0x60016BA")]
			[Address(RVA = "0x1E62A50", Offset = "0x1E61050", VA = "0x181E62A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016BB")]
		[Address(RVA = "0x1EB5660", Offset = "0x1EB3C60", VA = "0x181EB5660")]
		private void set_triangle(int tid, int v0, int v1, int v2)
		{
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016BC")]
		[Address(RVA = "0x1EB57E0", Offset = "0x1EB3DE0", VA = "0x181EB57E0")]
		private void set_triangle_edges(int tid, int e0, int e1, int e2)
		{
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00011714 File Offset: 0x0000F914
		[Token(Token = "0x60016BD")]
		[Address(RVA = "0x1EB5960", Offset = "0x1EB3F60", VA = "0x181EB5960")]
		private int add_edge(int vA, int vB, int tA, int tB = -1)
		{
			return 0;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0001172C File Offset: 0x0000F92C
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x1EB5B00", Offset = "0x1EB4100", VA = "0x181EB5B00")]
		private int replace_tri_vertex(int tID, int vOld, int vNew)
		{
			return 0;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00011744 File Offset: 0x0000F944
		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x1EB5C90", Offset = "0x1EB4290", VA = "0x181EB5C90")]
		private int add_triangle_only(int a, int b, int c, int e0, int e1, int e2)
		{
			return 0;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x1EB5DD0", Offset = "0x1EB43D0", VA = "0x181EB5DD0")]
		private void allocate_vertex_edges_list(int vid)
		{
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x1EB5E60", Offset = "0x1EB4460", VA = "0x181EB5E60")]
		private List<int> vertex_edges_list(int vid)
		{
			return null;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x1EB5EF0", Offset = "0x1EB44F0", VA = "0x181EB5EF0")]
		private void allocate_edge_triangles_list(int eid)
		{
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x1EB5F80", Offset = "0x1EB4580", VA = "0x181EB5F80")]
		private void set_edge_vertices(int eID, int a, int b)
		{
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0001175C File Offset: 0x0000F95C
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x1EB60D0", Offset = "0x1EB46D0", VA = "0x181EB60D0")]
		private int replace_edge_vertex(int eID, int vOld, int vNew)
		{
			return 0;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00011774 File Offset: 0x0000F974
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x1EB6380", Offset = "0x1EB4980", VA = "0x181EB6380")]
		private bool replace_edge_triangle(int eID, int tOld, int tNew)
		{
			return default(bool);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x1EB63F0", Offset = "0x1EB49F0", VA = "0x181EB63F0")]
		private void add_edge_triangle(int eID, int tID)
		{
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0001178C File Offset: 0x0000F98C
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x1EB6410", Offset = "0x1EB4A10", VA = "0x181EB6410")]
		private bool remove_edge_triangle(int eID, int tID)
		{
			return default(bool);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000117A4 File Offset: 0x0000F9A4
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x1EB6430", Offset = "0x1EB4A30", VA = "0x181EB6430")]
		private int replace_triangle_edge(int tID, int eOld, int eNew)
		{
			return 0;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x000117BC File Offset: 0x0000F9BC
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x1EB65C0", Offset = "0x1EB4BC0", VA = "0x181EB65C0")]
		public MeshResult RemoveTriangle(int tID, bool bRemoveIsolatedVertices = true)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000117D4 File Offset: 0x0000F9D4
		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x1EB6850", Offset = "0x1EB4E50", VA = "0x181EB6850")]
		public MeshResult SplitEdge(int vA, int vB, out NTMesh3.EdgeSplitInfo split)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x000117EC File Offset: 0x0000F9EC
		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x1EB68B0", Offset = "0x1EB4EB0", VA = "0x181EB68B0")]
		public MeshResult SplitEdge(int eab, out NTMesh3.EdgeSplitInfo split)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00011804 File Offset: 0x0000FA04
		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x1EB7490", Offset = "0x1EB5A90", VA = "0x181EB7490", Slot = "26")]
		public virtual MeshResult PokeTriangle(int tid, out NTMesh3.PokeTriangleInfo result)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0001181C File Offset: 0x0000FA1C
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x1EB7560", Offset = "0x1EB5B60", VA = "0x181EB7560", Slot = "27")]
		public virtual MeshResult PokeTriangle(int tid, Vector3d baryCoordinates, out NTMesh3.PokeTriangleInfo result)
		{
			return MeshResult.Ok;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x1EB7C70", Offset = "0x1EB6270", VA = "0x181EB7C70")]
		public DMesh3 Deconstruct()
		{
			return null;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x1EB8130", Offset = "0x1EB6730", VA = "0x181EB8130")]
		[Conditional("DEBUG")]
		public void debug_check_is_vertex(int v)
		{
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x1EB81B0", Offset = "0x1EB67B0", VA = "0x181EB81B0")]
		[Conditional("DEBUG")]
		public void debug_check_is_triangle(int t)
		{
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x1EB8230", Offset = "0x1EB6830", VA = "0x181EB8230")]
		[Conditional("DEBUG")]
		public void debug_check_is_edge(int e)
		{
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00011834 File Offset: 0x0000FA34
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x1EB82B0", Offset = "0x1EB68B0", VA = "0x181EB82B0")]
		public bool CheckValidity(FailMode eFailMode = FailMode.Throw)
		{
			return default(bool);
		}

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		public const int InvalidID = -1;

		// Token: 0x04000A6A RID: 2666
		[Token(Token = "0x4000A6A")]
		public const int NonManifoldID = -2;

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3d InvalidVertex;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Index3i InvalidTriangle;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x24")]
		public static readonly Index2i InvalidEdge;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x10")]
		private RefCountVector vertices_refcount;

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x18")]
		private DVector<double> vertices;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x20")]
		private DVector<float> normals;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x28")]
		private DVector<float> colors;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x30")]
		private SmallListSet vertex_edges;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x38")]
		private RefCountVector triangles_refcount;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x40")]
		private DVector<int> triangles;

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		[FieldOffset(Offset = "0x48")]
		private DVector<int> triangle_edges;

		// Token: 0x04000A76 RID: 2678
		[Token(Token = "0x4000A76")]
		[FieldOffset(Offset = "0x50")]
		private DVector<int> triangle_groups;

		// Token: 0x04000A77 RID: 2679
		[Token(Token = "0x4000A77")]
		[FieldOffset(Offset = "0x58")]
		private RefCountVector edges_refcount;

		// Token: 0x04000A78 RID: 2680
		[Token(Token = "0x4000A78")]
		[FieldOffset(Offset = "0x60")]
		private DVector<int> edges;

		// Token: 0x04000A79 RID: 2681
		[Token(Token = "0x4000A79")]
		[FieldOffset(Offset = "0x68")]
		private SmallListSet edge_triangles;

		// Token: 0x04000A7A RID: 2682
		[Token(Token = "0x4000A7A")]
		[FieldOffset(Offset = "0x70")]
		private int timestamp;

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x74")]
		private int shape_timestamp;

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x78")]
		private int max_group_id;

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x80")]
		private AxisAlignedBox3d cached_bounds;

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0xB0")]
		private int cached_bounds_timestamp;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0xB4")]
		private bool cached_is_closed;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0xB8")]
		private int cached_is_closed_timstamp;

		// Token: 0x02000278 RID: 632
		[Token(Token = "0x2000278")]
		public struct EdgeSplitInfo
		{
			// Token: 0x04000A81 RID: 2689
			[Token(Token = "0x4000A81")]
			[FieldOffset(Offset = "0x0")]
			public bool bIsBoundary;

			// Token: 0x04000A82 RID: 2690
			[Token(Token = "0x4000A82")]
			[FieldOffset(Offset = "0x4")]
			public int vNew;

			// Token: 0x04000A83 RID: 2691
			[Token(Token = "0x4000A83")]
			[FieldOffset(Offset = "0x8")]
			public int eNewBN;

			// Token: 0x04000A84 RID: 2692
			[Token(Token = "0x4000A84")]
			[FieldOffset(Offset = "0x10")]
			public List<int> NewEdges;
		}

		// Token: 0x02000279 RID: 633
		[Token(Token = "0x2000279")]
		public struct PokeTriangleInfo
		{
			// Token: 0x04000A85 RID: 2693
			[Token(Token = "0x4000A85")]
			[FieldOffset(Offset = "0x0")]
			public int new_vid;

			// Token: 0x04000A86 RID: 2694
			[Token(Token = "0x4000A86")]
			[FieldOffset(Offset = "0x4")]
			public int new_t1;

			// Token: 0x04000A87 RID: 2695
			[Token(Token = "0x4000A87")]
			[FieldOffset(Offset = "0x8")]
			public int new_t2;

			// Token: 0x04000A88 RID: 2696
			[Token(Token = "0x4000A88")]
			[FieldOffset(Offset = "0xC")]
			public Index3i new_edges;
		}
	}
}
