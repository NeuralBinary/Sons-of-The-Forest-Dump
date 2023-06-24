using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_mine_bot_animation.php")]
	public class MineBotAnimation : VersionedMonoBehaviour
	{
		// Token: 0x06000BE3 RID: 3043 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x655890", Offset = "0x653E90", VA = "0x180655890", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x6559B0", Offset = "0x653FB0", VA = "0x1806559B0")]
		private void OnTargetReached()
		{
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x655D30", Offset = "0x654330", VA = "0x180655D30")]
		protected void Update()
		{
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MineBotAnimation()
		{
		}

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x28")]
		public Animator anim;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x30")]
		public GameObject endOfPathEffect;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x38")]
		private bool isAtDestination;

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x40")]
		private IAstarAI ai;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x48")]
		private Transform tr;

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x50")]
		protected Vector3 lastTarget;
	}
}
