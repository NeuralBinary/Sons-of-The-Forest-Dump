using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_block_manager.php")]
	public class BlockManager : VersionedMonoBehaviour
	{
		// Token: 0x06000870 RID: 2160 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x6DD600", Offset = "0x6DBC00", VA = "0x1806DD600")]
		private void Start()
		{
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00005CB4 File Offset: 0x00003EB4
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x6DD730", Offset = "0x6DBD30", VA = "0x1806DD730")]
		public bool NodeContainsAnyOf(GraphNode node, List<SingleNodeBlocker> selector)
		{
			return default(bool);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00005CCC File Offset: 0x00003ECC
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x6DD840", Offset = "0x6DBE40", VA = "0x1806DD840")]
		public bool NodeContainsAnyExcept(GraphNode node, List<SingleNodeBlocker> selector)
		{
			return default(bool);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x6DD950", Offset = "0x6DBF50", VA = "0x1806DD950")]
		public void InternalBlock(GraphNode node, SingleNodeBlocker blocker)
		{
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x6DDB70", Offset = "0x6DC170", VA = "0x1806DDB70")]
		public void InternalUnblock(GraphNode node, SingleNodeBlocker blocker)
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x6DDD90", Offset = "0x6DC390", VA = "0x1806DDD90")]
		public BlockManager()
		{
		}

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<GraphNode, List<SingleNodeBlocker>> blocked;

		// Token: 0x020000FA RID: 250
		[Token(Token = "0x20000FA")]
		public enum BlockMode
		{
			// Token: 0x040005BA RID: 1466
			[Token(Token = "0x40005BA")]
			AllExceptSelector,
			// Token: 0x040005BB RID: 1467
			[Token(Token = "0x40005BB")]
			OnlySelector
		}

		// Token: 0x020000FB RID: 251
		[Token(Token = "0x20000FB")]
		public class TraversalProvider : ITraversalProvider
		{
			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000876 RID: 2166 RVA: 0x00005CE4 File Offset: 0x00003EE4
			// (set) Token: 0x06000877 RID: 2167 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x17000143")]
			public BlockManager.BlockMode mode
			{
				[Token(Token = "0x6000876")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				[CompilerGenerated]
				get
				{
					return BlockManager.BlockMode.AllExceptSelector;
				}
				[Token(Token = "0x6000877")]
				[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000878 RID: 2168 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x6DDE80", Offset = "0x6DC480", VA = "0x1806DDE80")]
			public TraversalProvider(BlockManager blockManager, BlockManager.BlockMode mode, List<SingleNodeBlocker> selector)
			{
			}

			// Token: 0x06000879 RID: 2169 RVA: 0x00005CFC File Offset: 0x00003EFC
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x6DE0A0", Offset = "0x6DC6A0", VA = "0x1806DE0A0", Slot = "4")]
			public bool CanTraverse(Path path, GraphNode node)
			{
				return default(bool);
			}

			// Token: 0x0600087A RID: 2170 RVA: 0x00005D14 File Offset: 0x00003F14
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x6DE250", Offset = "0x6DC850", VA = "0x1806DE250", Slot = "5")]
			public uint GetTraversalCost(Path path, GraphNode node)
			{
				return 0U;
			}

			// Token: 0x040005BC RID: 1468
			[Token(Token = "0x40005BC")]
			[FieldOffset(Offset = "0x10")]
			private readonly BlockManager blockManager;

			// Token: 0x040005BE RID: 1470
			[Token(Token = "0x40005BE")]
			[FieldOffset(Offset = "0x20")]
			private readonly List<SingleNodeBlocker> selector;
		}
	}
}
