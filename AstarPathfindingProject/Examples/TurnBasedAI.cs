using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_turn_based_a_i.php")]
	public class TurnBasedAI : VersionedMonoBehaviour
	{
		// Token: 0x06000B44 RID: 2884 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x72C470", Offset = "0x72AA70", VA = "0x18072C470")]
		private void Start()
		{
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x72C490", Offset = "0x72AA90", VA = "0x18072C490", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x72C600", Offset = "0x72AC00", VA = "0x18072C600")]
		public TurnBasedAI()
		{
		}

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x28")]
		public int movementPoints;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x30")]
		public BlockManager blockManager;

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x38")]
		public SingleNodeBlocker blocker;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x40")]
		public GraphNode targetNode;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x48")]
		public BlockManager.TraversalProvider traversalProvider;
	}
}
