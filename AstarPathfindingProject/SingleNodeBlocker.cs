using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_single_node_blocker.php")]
	public class SingleNodeBlocker : VersionedMonoBehaviour
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000144")]
		public GraphNode lastBlocked
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x6DE550", Offset = "0x6DCB50", VA = "0x1806DE550")]
		public void BlockAtCurrentPosition()
		{
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x6DE770", Offset = "0x6DCD70", VA = "0x1806DE770")]
		public void BlockAt(Vector3 position)
		{
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x6DE8F0", Offset = "0x6DCEF0", VA = "0x1806DE8F0")]
		public void Block(GraphNode node)
		{
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x6DE9C0", Offset = "0x6DCFC0", VA = "0x1806DE9C0")]
		public void Unblock()
		{
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SingleNodeBlocker()
		{
		}

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x30")]
		public BlockManager manager;
	}
}
