using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	public class MeshFaceSelection : IEnumerable<int>, IEnumerable
	{
		// Token: 0x06001A26 RID: 6694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A26")]
		[Address(RVA = "0x1F1E700", Offset = "0x1F1CD00", VA = "0x181F1E700")]
		public MeshFaceSelection(DMesh3 mesh)
		{
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x1F1E900", Offset = "0x1F1CF00", VA = "0x181F1E900")]
		public MeshFaceSelection(MeshFaceSelection copy)
		{
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170003ED")]
		protected BitArray Bitmap
		{
			[Token(Token = "0x6001A28")]
			[Address(RVA = "0x1F1EB60", Offset = "0x1F1D160", VA = "0x181F1EB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x1F1EC90", Offset = "0x1F1D290", VA = "0x181F1EC90")]
		public MeshFaceSelection(DMesh3 mesh, MeshVertexSelection convertV, int minCount = 3)
		{
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x1F1F1F0", Offset = "0x1F1D7F0", VA = "0x181F1F1F0")]
		public MeshFaceSelection(DMesh3 mesh, int group_id)
		{
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0x1F1F380", Offset = "0x1F1D980", VA = "0x181F1F380", Slot = "4")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x1F1F460", Offset = "0x1F1DA60", VA = "0x181F1F460", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0x1F1F540", Offset = "0x1F1DB40", VA = "0x181F1F540")]
		private void add(int tid)
		{
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x1F1F5B0", Offset = "0x1F1DBB0", VA = "0x181F1F5B0")]
		private void remove(int tid)
		{
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00012FA4 File Offset: 0x000111A4
		[Token(Token = "0x170003EE")]
		public int Count
		{
			[Token(Token = "0x6001A2F")]
			[Address(RVA = "0x1F1F610", Offset = "0x1F1DC10", VA = "0x181F1F610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00012FBC File Offset: 0x000111BC
		[Token(Token = "0x6001A30")]
		[Address(RVA = "0x1F1F650", Offset = "0x1F1DC50", VA = "0x181F1F650")]
		public bool IsSelected(int tid)
		{
			return default(bool);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A31")]
		[Address(RVA = "0x1F1F6B0", Offset = "0x1F1DCB0", VA = "0x181F1F6B0")]
		public void Select(int tid)
		{
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x1F1F700", Offset = "0x1F1DD00", VA = "0x181F1F700")]
		public void Select(int[] triangles)
		{
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x1F1F850", Offset = "0x1F1DE50", VA = "0x181F1F850")]
		public void Select(List<int> triangles)
		{
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x1F1F9D0", Offset = "0x1F1DFD0", VA = "0x181F1F9D0")]
		public void Select(IEnumerable<int> triangles)
		{
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x1F1FC90", Offset = "0x1F1E290", VA = "0x181F1FC90")]
		public void Select(Func<int, bool> selectF)
		{
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x1F1FE80", Offset = "0x1F1E480", VA = "0x181F1FE80")]
		public void SelectVertexOneRing(int vid)
		{
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x1F20090", Offset = "0x1F1E690", VA = "0x181F20090")]
		public void SelectVertexOneRings(int[] vertices)
		{
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x1F20240", Offset = "0x1F1E840", VA = "0x181F20240")]
		public void SelectVertexOneRings(IEnumerable<int> vertices)
		{
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A39")]
		[Address(RVA = "0x1F20480", Offset = "0x1F1EA80", VA = "0x181F20480")]
		public void SelectEdgeTris(int eid)
		{
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0x1F1F5B0", Offset = "0x1F1DBB0", VA = "0x181F1F5B0")]
		public void Deselect(int tid)
		{
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A3B")]
		[Address(RVA = "0x1F20510", Offset = "0x1F1EB10", VA = "0x181F20510")]
		public void Deselect(int[] triangles)
		{
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x1F205A0", Offset = "0x1F1EBA0", VA = "0x181F205A0")]
		public void Deselect(IEnumerable<int> triangles)
		{
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0x1F20790", Offset = "0x1F1ED90", VA = "0x181F20790")]
		public void DeselectAll()
		{
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x1F20810", Offset = "0x1F1EE10", VA = "0x181F20810")]
		public void SelectGroup(int gid)
		{
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A3F")]
		[Address(RVA = "0x1F209A0", Offset = "0x1F1EFA0", VA = "0x181F209A0")]
		public void SelectGroupInverse(int gid)
		{
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x1F20B30", Offset = "0x1F1F130", VA = "0x181F20B30")]
		public void DeselectGroup(int gid)
		{
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x1F20CC0", Offset = "0x1F1F2C0", VA = "0x181F20CC0")]
		public int[] ToArray()
		{
			return null;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x1F20E70", Offset = "0x1F1F470", VA = "0x181F20E70")]
		public List<int> FindNeighbourTris()
		{
			return null;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x1F210D0", Offset = "0x1F1F6D0", VA = "0x181F210D0")]
		public List<int> FindBorderTris()
		{
			return null;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A44")]
		[Address(RVA = "0x1F21340", Offset = "0x1F1F940", VA = "0x181F21340")]
		public void ExpandToFaceNeighbours([Optional] Func<int, bool> FilterF)
		{
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x1F21680", Offset = "0x1F1FC80", VA = "0x181F21680")]
		public void ExpandToFaceNeighbours(int rounds, [Optional] Func<int, bool> FilterF)
		{
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x1F216D0", Offset = "0x1F1FCD0", VA = "0x181F216D0")]
		public void ExpandToOneRingNeighbours([Optional] Func<int, bool> FilterF)
		{
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x1F21B20", Offset = "0x1F20120", VA = "0x181F21B20")]
		public void ExpandToOneRingNeighbours(int nRings, [Optional] Func<int, bool> FilterF)
		{
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x1F22220", Offset = "0x1F20820", VA = "0x181F22220")]
		public void ContractBorderByOneRingNeighbours()
		{
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x1F228A0", Offset = "0x1F20EA0", VA = "0x181F228A0")]
		public void FloodFill(int tSeed, [Optional] Func<int, bool> TriFilterF, [Optional] Func<int, bool> EdgeFilterF)
		{
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x1F22940", Offset = "0x1F20F40", VA = "0x181F22940")]
		public void FloodFill(int[] Seeds, [Optional] Func<int, bool> TriFilterF, [Optional] Func<int, bool> EdgeFilterF)
		{
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00012FD4 File Offset: 0x000111D4
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x1F22C20", Offset = "0x1F21220", VA = "0x181F22C20")]
		public bool ClipFins(bool bClipLoners)
		{
			return default(bool);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00012FEC File Offset: 0x000111EC
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x1F230F0", Offset = "0x1F216F0", VA = "0x181F230F0")]
		public bool FillEars(bool bFillTinyHoles)
		{
			return default(bool);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00013004 File Offset: 0x00011204
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x1F23560", Offset = "0x1F21B60", VA = "0x181F23560")]
		public bool LocalOptimize(bool bClipFins, bool bFillEars, bool bFillTinyHoles = true, bool bClipLoners = true, bool bRemoveBowties = false)
		{
			return default(bool);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0001301C File Offset: 0x0001121C
		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x1F23690", Offset = "0x1F21C90", VA = "0x181F23690")]
		public bool LocalOptimize(bool bRemoveBowties = true)
		{
			return default(bool);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00013034 File Offset: 0x00011234
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x1F23790", Offset = "0x1F21D90", VA = "0x181F23790")]
		public bool RemoveBowties()
		{
			return default(bool);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0001304C File Offset: 0x0001124C
		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x1F237A0", Offset = "0x1F21DA0", VA = "0x181F237A0")]
		public bool remove_bowties(HashSet<int> tempHash)
		{
			return default(bool);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00013064 File Offset: 0x00011264
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x1F23BF0", Offset = "0x1F221F0", VA = "0x181F23BF0")]
		private bool is_bowtie_vtx(int vid)
		{
			return default(bool);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x1F23E30", Offset = "0x1F22430", VA = "0x181F23E30")]
		private void count_nbrs(int tid, out int nbr_in, out int nbr_out, out int bdry_e)
		{
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0001307C File Offset: 0x0001127C
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x1F23F10", Offset = "0x1F22510", VA = "0x181F23F10")]
		private bool is_ear(int tid, bool include_tiny_holes)
		{
			return default(bool);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00013094 File Offset: 0x00011294
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x1F24060", Offset = "0x1F22660", VA = "0x181F24060")]
		private bool is_fin(int tid, bool include_loners)
		{
			return default(bool);
		}

		// Token: 0x04000DD1 RID: 3537
		[Token(Token = "0x4000DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000DD2 RID: 3538
		[Token(Token = "0x4000DD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HashSet<int> Selected;

		// Token: 0x04000DD3 RID: 3539
		[Token(Token = "0x4000DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<int> temp;

		// Token: 0x04000DD4 RID: 3540
		[Token(Token = "0x4000DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<int> temp2;

		// Token: 0x04000DD5 RID: 3541
		[Token(Token = "0x4000DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BitArray tempBits;
	}
}
