using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000305 RID: 773
	[Token(Token = "0x2000305")]
	public class MeshConnectedComponents : IEnumerable<MeshConnectedComponents.Component>, IEnumerable
	{
		// Token: 0x060019F8 RID: 6648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x1F1A100", Offset = "0x1F18700", VA = "0x181F1A100")]
		public MeshConnectedComponents(DMesh3 mesh)
		{
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x00012E9C File Offset: 0x0001109C
		[Token(Token = "0x170003E8")]
		public int Count
		{
			[Token(Token = "0x60019F9")]
			[Address(RVA = "0x1F1A220", Offset = "0x1F18820", VA = "0x181F1A220")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003E9 RID: 1001
		[Token(Token = "0x170003E9")]
		public MeshConnectedComponents.Component this[int index]
		{
			[Token(Token = "0x60019FA")]
			[Address(RVA = "0x1F1A260", Offset = "0x1F18860", VA = "0x181F1A260")]
			get
			{
				return default(MeshConnectedComponents.Component);
			}
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60019FB")]
		[Address(RVA = "0x1F1A2D0", Offset = "0x1F188D0", VA = "0x181F1A2D0", Slot = "4")]
		public IEnumerator<MeshConnectedComponents.Component> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60019FC")]
		[Address(RVA = "0x1F1A3B0", Offset = "0x1F189B0", VA = "0x181F1A3B0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00012ECC File Offset: 0x000110CC
		[Token(Token = "0x170003EA")]
		public int LargestByCount
		{
			[Token(Token = "0x60019FD")]
			[Address(RVA = "0x1F1A490", Offset = "0x1F18A90", VA = "0x181F1A490")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019FE")]
		[Address(RVA = "0x1F1A590", Offset = "0x1F18B90", VA = "0x181F1A590")]
		public void SortByCount(bool bIncreasing = true)
		{
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019FF")]
		[Address(RVA = "0x1F1A7F0", Offset = "0x1F18DF0", VA = "0x181F1A7F0")]
		public void SortByValue(Func<MeshConnectedComponents.Component, double> valueF, bool bIncreasing = true)
		{
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x1F1AB90", Offset = "0x1F19190", VA = "0x181F1AB90")]
		public void FindConnectedT()
		{
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A01")]
		[Address(RVA = "0x1F1B670", Offset = "0x1F19C70", VA = "0x181F1B670")]
		public static DMesh3[] Separate(DMesh3 meshIn)
		{
			return null;
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A02")]
		[Address(RVA = "0x1F1B9B0", Offset = "0x1F19FB0", VA = "0x181F1B9B0")]
		public static DMesh3 LargestT(DMesh3 meshIn)
		{
			return null;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A03")]
		[Address(RVA = "0x1F1BB10", Offset = "0x1F1A110", VA = "0x181F1BB10")]
		public static HashSet<int> FindConnectedT(DMesh3 mesh, int tSeed)
		{
			return null;
		}

		// Token: 0x04000DC3 RID: 3523
		[Token(Token = "0x4000DC3")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000DC4 RID: 3524
		[Token(Token = "0x4000DC4")]
		[FieldOffset(Offset = "0x18")]
		public IEnumerable<int> FilterSet;

		// Token: 0x04000DC5 RID: 3525
		[Token(Token = "0x4000DC5")]
		[FieldOffset(Offset = "0x20")]
		public Func<int, bool> FilterF;

		// Token: 0x04000DC6 RID: 3526
		[Token(Token = "0x4000DC6")]
		[FieldOffset(Offset = "0x28")]
		public Func<int, bool> SeedFilterF;

		// Token: 0x04000DC7 RID: 3527
		[Token(Token = "0x4000DC7")]
		[FieldOffset(Offset = "0x30")]
		public List<MeshConnectedComponents.Component> Components;

		// Token: 0x02000306 RID: 774
		[Token(Token = "0x2000306")]
		public struct Component
		{
			// Token: 0x04000DC8 RID: 3528
			[Token(Token = "0x4000DC8")]
			[FieldOffset(Offset = "0x0")]
			public int[] Indices;
		}
	}
}
