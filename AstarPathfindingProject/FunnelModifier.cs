using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_funnel_modifier.php")]
	[AddComponentMenu("Pathfinding/Modifiers/Funnel")]
	[Serializable]
	public class FunnelModifier : MonoModifier
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0000590C File Offset: 0x00003B0C
		[Token(Token = "0x1700012D")]
		public override int Order
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x6C1D40", Offset = "0x6C0340", VA = "0x1806C1D40", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x6C23C0", Offset = "0x6C09C0", VA = "0x1806C23C0", Slot = "17")]
		public override void Apply(Path p)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x6C2910", Offset = "0x6C0F10", VA = "0x1806C2910")]
		public FunnelModifier()
		{
		}

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x30")]
		public bool unwrap;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x31")]
		public bool splitAtEveryPortal;
	}
}
