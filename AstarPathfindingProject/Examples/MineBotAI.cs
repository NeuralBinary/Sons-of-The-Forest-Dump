using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_mine_bot_a_i.php")]
	[RequireComponent(typeof(Seeker))]
	[Obsolete("This script has been replaced by Pathfinding.Examples.MineBotAnimation. Any uses of this script in the Unity editor will be automatically replaced by one AIPath component and one MineBotAnimation component.")]
	public class MineBotAI : AIPath
	{
		// Token: 0x06000BE2 RID: 3042 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x655830", Offset = "0x653E30", VA = "0x180655830")]
		public MineBotAI()
		{
		}

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x168")]
		public Animation anim;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x170")]
		public float sleepVelocity;

		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		[FieldOffset(Offset = "0x174")]
		public float animationSpeed;

		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x178")]
		public GameObject endOfPathEffect;
	}
}
