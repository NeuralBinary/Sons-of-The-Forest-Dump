using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	public class MeshVertexSelection : IEnumerable<int>, IEnumerable
	{
		// Token: 0x06001A7C RID: 6780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x1F29540", Offset = "0x1F27B40", VA = "0x181F29540")]
		public MeshVertexSelection(DMesh3 mesh)
		{
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x1F296D0", Offset = "0x1F27CD0", VA = "0x181F296D0")]
		public MeshVertexSelection(DMesh3 mesh, MeshFaceSelection convertT)
		{
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0x1F299A0", Offset = "0x1F27FA0", VA = "0x181F299A0")]
		public MeshVertexSelection(DMesh3 mesh, MeshEdgeSelection convertE)
		{
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x1F29CE0", Offset = "0x1F282E0", VA = "0x181F29CE0")]
		public HashSet<int> ExtractSelected()
		{
			return null;
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x1F29DA0", Offset = "0x1F283A0", VA = "0x181F29DA0", Slot = "4")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x1F29E80", Offset = "0x1F28480", VA = "0x181F29E80", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x1F29F60", Offset = "0x1F28560", VA = "0x181F29F60")]
		private void add(int vID)
		{
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x1F29FD0", Offset = "0x1F285D0", VA = "0x181F29FD0")]
		private void remove(int vID)
		{
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0001325C File Offset: 0x0001145C
		[Token(Token = "0x170003F4")]
		public int Count
		{
			[Token(Token = "0x6001A84")]
			[Address(RVA = "0x1F2A030", Offset = "0x1F28630", VA = "0x181F2A030")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00013274 File Offset: 0x00011474
		[Token(Token = "0x6001A85")]
		[Address(RVA = "0x1F2A070", Offset = "0x1F28670", VA = "0x181F2A070")]
		public bool IsSelected(int vID)
		{
			return default(bool);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A86")]
		[Address(RVA = "0x1F2A0D0", Offset = "0x1F286D0", VA = "0x181F2A0D0")]
		public void Select(int vID)
		{
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x1F2A120", Offset = "0x1F28720", VA = "0x181F2A120")]
		public void Select(int[] vertices)
		{
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A88")]
		[Address(RVA = "0x1F2A270", Offset = "0x1F28870", VA = "0x181F2A270")]
		public void Select(IEnumerable<int> vertices)
		{
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x1F2A530", Offset = "0x1F28B30", VA = "0x181F2A530")]
		public void SelectTriangleVertices(int[] triangles)
		{
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x1F2A6B0", Offset = "0x1F28CB0", VA = "0x181F2A6B0")]
		public void SelectTriangleVertices(IEnumerable<int> triangles)
		{
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x1F2A990", Offset = "0x1F28F90", VA = "0x181F2A990")]
		public void SelectTriangleVertices(MeshFaceSelection triangles)
		{
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x1F2AC60", Offset = "0x1F29260", VA = "0x181F2AC60")]
		public void SelectInteriorVertices(MeshFaceSelection triangles)
		{
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x1F2B020", Offset = "0x1F29620", VA = "0x181F2B020")]
		public void SelectConnectedBoundaryV(int vSeed)
		{
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x1F2B5C0", Offset = "0x1F29BC0", VA = "0x181F2B5C0")]
		public void SelectEdgeVertices(int[] edges)
		{
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x1F2B6F0", Offset = "0x1F29CF0", VA = "0x181F2B6F0")]
		public void SelectEdgeVertices(IEnumerable<int> edges)
		{
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A90")]
		[Address(RVA = "0x1F29FD0", Offset = "0x1F285D0", VA = "0x181F29FD0")]
		public void Deselect(int vID)
		{
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x1F2B960", Offset = "0x1F29F60", VA = "0x181F2B960")]
		public void Deselect(int[] vertices)
		{
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A92")]
		[Address(RVA = "0x1F2B9F0", Offset = "0x1F29FF0", VA = "0x181F2B9F0")]
		public void Deselect(IEnumerable<int> vertices)
		{
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x1F2BBE0", Offset = "0x1F2A1E0", VA = "0x181F2BBE0")]
		public void DeselectEdge(int eid)
		{
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x1F2BC90", Offset = "0x1F2A290", VA = "0x181F2BC90")]
		public void DeselectEdges(IEnumerable<int> edges)
		{
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x1F2BEE0", Offset = "0x1F2A4E0", VA = "0x181F2BEE0")]
		public int[] ToArray()
		{
			return null;
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x1F2C090", Offset = "0x1F2A690", VA = "0x181F2C090")]
		public void ExpandToOneRingNeighbours([Optional] Func<int, bool> FilterF)
		{
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x1F2C480", Offset = "0x1F2AA80", VA = "0x181F2C480")]
		public void ExpandToOneRingNeighbours(int nRings, [Optional] Func<int, bool> FilterF)
		{
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x1F2C4D0", Offset = "0x1F2AAD0", VA = "0x181F2C4D0")]
		public void FloodFill(int vSeed, [Optional] Func<int, bool> VertIncludedF)
		{
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x1F2C550", Offset = "0x1F2AB50", VA = "0x181F2C550")]
		public void FloodFill(int[] Seeds, [Optional] Func<int, bool> VertIncludedF)
		{
		}

		// Token: 0x04000DE7 RID: 3559
		[Token(Token = "0x4000DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000DE8 RID: 3560
		[Token(Token = "0x4000DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HashSet<int> Selected;

		// Token: 0x04000DE9 RID: 3561
		[Token(Token = "0x4000DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<int> temp;
	}
}
