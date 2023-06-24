using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_animation_link.php")]
	public class AnimationLink : NodeLink2
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x643890", Offset = "0x641E90", VA = "0x180643890")]
		private static Transform SearchRec(Transform tr, string name)
		{
			return null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x643A90", Offset = "0x642090", VA = "0x180643A90")]
		public void CalculateOffsets(List<Vector3> trace, out Vector3 endPosition)
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x644B30", Offset = "0x643130", VA = "0x180644B30", Slot = "19")]
		public override void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x644D50", Offset = "0x643350", VA = "0x180644D50")]
		public AnimationLink()
		{
		}

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x90")]
		public string clip;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x98")]
		public float animSpeed;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x9C")]
		public bool reverseAnim;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject referenceMesh;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0xA8")]
		public AnimationLink.LinkClip[] sequence;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0xB0")]
		public string boneRoot;

		// Token: 0x0200004C RID: 76
		[Token(Token = "0x200004C")]
		[Serializable]
		public class LinkClip
		{
			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700009F")]
			public string name
			{
				[Token(Token = "0x60002DC")]
				[Address(RVA = "0x644E10", Offset = "0x643410", VA = "0x180644E10")]
				get
				{
					return null;
				}
			}

			// Token: 0x060002DD RID: 733 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x644F00", Offset = "0x643500", VA = "0x180644F00")]
			public LinkClip()
			{
			}

			// Token: 0x040001DF RID: 479
			[Token(Token = "0x40001DF")]
			[FieldOffset(Offset = "0x10")]
			public AnimationClip clip;

			// Token: 0x040001E0 RID: 480
			[Token(Token = "0x40001E0")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 velocity;

			// Token: 0x040001E1 RID: 481
			[Token(Token = "0x40001E1")]
			[FieldOffset(Offset = "0x24")]
			public int loopCount;
		}
	}
}
