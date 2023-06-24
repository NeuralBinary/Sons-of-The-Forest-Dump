using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_animation_link_traverser.php")]
	public class AnimationLinkTraverser : VersionedMonoBehaviour
	{
		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x656FC0", Offset = "0x6555C0", VA = "0x180656FC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x657220", Offset = "0x655820", VA = "0x180657220")]
		private void OnDisable()
		{
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x657400", Offset = "0x655A00", VA = "0x180657400", Slot = "10")]
		protected virtual IEnumerator TraverseOffMeshLink(RichSpecial rs)
		{
			return null;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AnimationLinkTraverser()
		{
		}

		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		[FieldOffset(Offset = "0x28")]
		public Animation anim;

		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x40008CB")]
		[FieldOffset(Offset = "0x30")]
		private RichAI ai;
	}
}
