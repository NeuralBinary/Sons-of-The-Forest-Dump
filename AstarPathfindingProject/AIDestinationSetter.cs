using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_a_i_destination_setter.php")]
	[UniqueComponent(tag = "ai.destination")]
	public class AIDestinationSetter : VersionedMonoBehaviour
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x61B510", Offset = "0x619B10", VA = "0x18061B510")]
		private void OnEnable()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x61B670", Offset = "0x619C70", VA = "0x18061B670")]
		private void OnDisable()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x61B760", Offset = "0x619D60", VA = "0x18061B760")]
		private void Update()
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AIDestinationSetter()
		{
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x30")]
		private IAstarAI ai;
	}
}
