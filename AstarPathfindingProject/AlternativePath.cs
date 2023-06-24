using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_alternative_path.php")]
	[AddComponentMenu("Pathfinding/Modifiers/Alternative Path")]
	[Serializable]
	public class AlternativePath : MonoModifier
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x000058F4 File Offset: 0x00003AF4
		[Token(Token = "0x1700012C")]
		public override int Order
		{
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x6C1D40", Offset = "0x6C0340", VA = "0x1806C1D40", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x6C1D50", Offset = "0x6C0350", VA = "0x1806C1D50", Slot = "17")]
		public override void Apply(Path p)
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x6C1E30", Offset = "0x6C0430", VA = "0x1806C1E30")]
		protected void OnDestroy()
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x6C1E40", Offset = "0x6C0440", VA = "0x1806C1E40")]
		private void ClearOnDestroy()
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x6C1E50", Offset = "0x6C0450", VA = "0x1806C1E50")]
		private void InversePrevious()
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x6C2010", Offset = "0x6C0610", VA = "0x1806C2010")]
		private void ApplyNow(List<GraphNode> nodes)
		{
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x6C2210", Offset = "0x6C0810", VA = "0x1806C2210")]
		public AlternativePath()
		{
		}

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x30")]
		public int penalty;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x34")]
		public int randomStep;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x38")]
		private List<GraphNode> prevNodes;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x40")]
		private int prevPenalty;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x48")]
		private readonly System.Random rnd;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x50")]
		private bool destroyed;
	}
}
