using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008B7 RID: 2231
	[Token(Token = "0x20008B7")]
	[AddComponentMenu("Sons/Animation/BadGuyEscapeCutscene")]
	public class BadGuyEscapeCutscene : EndGameTriggeredCutscene
	{
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06003C1D RID: 15389 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[Token(Token = "0x17000762")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6003C1D")]
			[Address(RVA = "0x2F0D950", Offset = "0x2F0C950", VA = "0x182F0D950", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x17000763")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6003C1E")]
			[Address(RVA = "0x2F0D9B0", Offset = "0x2F0C9B0", VA = "0x182F0D9B0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06003C1F RID: 15391 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x17000764")]
		public override bool ShouldStashHeldItems
		{
			[Token(Token = "0x6003C1F")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06003C20 RID: 15392 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x17000765")]
		public override bool ShouldAlignPlayer
		{
			[Token(Token = "0x6003C20")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06003C21 RID: 15393 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x17000766")]
		public override bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x6003C21")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C22")]
		[Address(RVA = "0x2F0D740", Offset = "0x2F0C740", VA = "0x182F0D740", Slot = "30")]
		protected override void OnTriggerEnterPassed(Collider other)
		{
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x00011820 File Offset: 0x0000FA20
		[Token(Token = "0x6003C23")]
		[Address(RVA = "0x2F0D8B0", Offset = "0x2F0C8B0", VA = "0x182F0D8B0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C24")]
		[Address(RVA = "0x2F0D8D0", Offset = "0x2F0C8D0", VA = "0x182F0D8D0")]
		public BadGuyEscapeCutscene()
		{
		}

		// Token: 0x0400405C RID: 16476
		[Token(Token = "0x400405C")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private List<Animator> _cutsceneAnimators;
	}
}
