using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	public class MeshEdgeSelection : IEnumerable<int>, IEnumerable
	{
		// Token: 0x06001A0D RID: 6669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x1F1C1C0", Offset = "0x1F1A7C0", VA = "0x181F1C1C0")]
		public MeshEdgeSelection(DMesh3 mesh)
		{
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x1F1C350", Offset = "0x1F1A950", VA = "0x181F1C350")]
		public MeshEdgeSelection(MeshEdgeSelection copy)
		{
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170003EB")]
		protected BitArray Bitmap
		{
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0x1F1C540", Offset = "0x1F1AB40", VA = "0x181F1C540")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A10")]
		[Address(RVA = "0x1F1C670", Offset = "0x1F1AC70", VA = "0x181F1C670")]
		public MeshEdgeSelection(DMesh3 mesh, MeshVertexSelection convertV, int minCount = 2)
		{
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x1F1C930", Offset = "0x1F1AF30", VA = "0x181F1C930")]
		public MeshEdgeSelection(DMesh3 mesh, MeshFaceSelection convertT, int minCount = 1)
		{
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A12")]
		[Address(RVA = "0x1F1CE50", Offset = "0x1F1B450", VA = "0x181F1CE50", Slot = "4")]
		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A13")]
		[Address(RVA = "0x1F1CF30", Offset = "0x1F1B530", VA = "0x181F1CF30", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x1F1D010", Offset = "0x1F1B610", VA = "0x181F1D010")]
		private void add(int eid)
		{
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x1F1D080", Offset = "0x1F1B680", VA = "0x181F1D080")]
		private void remove(int eid)
		{
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00012F74 File Offset: 0x00011174
		[Token(Token = "0x170003EC")]
		public int Count
		{
			[Token(Token = "0x6001A16")]
			[Address(RVA = "0x1F1D0E0", Offset = "0x1F1B6E0", VA = "0x181F1D0E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00012F8C File Offset: 0x0001118C
		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x1F1D120", Offset = "0x1F1B720", VA = "0x181F1D120")]
		public bool IsSelected(int eid)
		{
			return default(bool);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A18")]
		[Address(RVA = "0x1F1D180", Offset = "0x1F1B780", VA = "0x181F1D180")]
		public void Select(int eid)
		{
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A19")]
		[Address(RVA = "0x1F1D1D0", Offset = "0x1F1B7D0", VA = "0x181F1D1D0")]
		public void Select(int[] edges)
		{
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A1A")]
		[Address(RVA = "0x1F1D320", Offset = "0x1F1B920", VA = "0x181F1D320")]
		public void Select(List<int> edges)
		{
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A1B")]
		[Address(RVA = "0x1F1D4A0", Offset = "0x1F1BAA0", VA = "0x181F1D4A0")]
		public void Select(IEnumerable<int> edges)
		{
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A1C")]
		[Address(RVA = "0x1F1D760", Offset = "0x1F1BD60", VA = "0x181F1D760")]
		public void Select(Func<int, bool> selectF)
		{
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x1F1DA80", Offset = "0x1F1C080", VA = "0x181F1DA80")]
		public void SelectVertexEdges(int[] vertices)
		{
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A1E")]
		[Address(RVA = "0x1F1DC30", Offset = "0x1F1C230", VA = "0x181F1DC30")]
		public void SelectVertexEdges(IEnumerable<int> vertices)
		{
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x1F1DE70", Offset = "0x1F1C470", VA = "0x181F1DE70")]
		public void SelectTriangleEdges(IEnumerable<int> triangles)
		{
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x1F1E150", Offset = "0x1F1C750", VA = "0x181F1E150")]
		public void SelectBoundaryTriEdges(MeshFaceSelection triangles)
		{
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x1F1D080", Offset = "0x1F1B680", VA = "0x181F1D080")]
		public void Deselect(int tid)
		{
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x1F1E350", Offset = "0x1F1C950", VA = "0x181F1E350")]
		public void Deselect(int[] edges)
		{
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A23")]
		[Address(RVA = "0x1F1E3E0", Offset = "0x1F1C9E0", VA = "0x181F1E3E0")]
		public void Deselect(IEnumerable<int> edges)
		{
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x1F1E5D0", Offset = "0x1F1CBD0", VA = "0x181F1E5D0")]
		public void DeselectAll()
		{
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A25")]
		[Address(RVA = "0x1F1E650", Offset = "0x1F1CC50", VA = "0x181F1E650")]
		public int[] ToArray()
		{
			return null;
		}

		// Token: 0x04000DCD RID: 3533
		[Token(Token = "0x4000DCD")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000DCE RID: 3534
		[Token(Token = "0x4000DCE")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<int> Selected;

		// Token: 0x04000DCF RID: 3535
		[Token(Token = "0x4000DCF")]
		[FieldOffset(Offset = "0x20")]
		private List<int> temp;

		// Token: 0x04000DD0 RID: 3536
		[Token(Token = "0x4000DD0")]
		[FieldOffset(Offset = "0x28")]
		private BitArray tempBits;
	}
}
