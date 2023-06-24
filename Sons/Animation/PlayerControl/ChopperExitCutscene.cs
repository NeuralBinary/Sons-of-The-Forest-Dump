using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000935 RID: 2357
	[Token(Token = "0x2000935")]
	[AddComponentMenu("Sons/Animation/ChopperExitCutscene")]
	public class ChopperExitCutscene : EndGameCutscene
	{
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060043C7 RID: 17351 RVA: 0x000149B8 File Offset: 0x00012BB8
		[Token(Token = "0x170008A6")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x60043C7")]
			[Address(RVA = "0x364ADD0", Offset = "0x36493D0", VA = "0x18364ADD0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060043C8 RID: 17352 RVA: 0x000149D0 File Offset: 0x00012BD0
		[Token(Token = "0x170008A7")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x60043C8")]
			[Address(RVA = "0x364AE30", Offset = "0x3649430", VA = "0x18364AE30", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x000149E8 File Offset: 0x00012BE8
		[Token(Token = "0x170008A8")]
		public override bool ShouldAlignPlayer
		{
			[Token(Token = "0x60043C9")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060043CA RID: 17354 RVA: 0x00014A00 File Offset: 0x00012C00
		[Token(Token = "0x170008A9")]
		public override bool ShouldStashHeldItems
		{
			[Token(Token = "0x60043CA")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00014A18 File Offset: 0x00012C18
		[Token(Token = "0x60043CB")]
		[Address(RVA = "0x364AE90", Offset = "0x3649490", VA = "0x18364AE90", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043CC")]
		[Address(RVA = "0x364B070", Offset = "0x3649670", VA = "0x18364B070", Slot = "32")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043CD")]
		[Address(RVA = "0x364B220", Offset = "0x3649820", VA = "0x18364B220")]
		public ChopperExitCutscene()
		{
		}

		// Token: 0x040046EE RID: 18158
		[Token(Token = "0x40046EE")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private List<Animator> _animators;

		// Token: 0x040046EF RID: 18159
		[Token(Token = "0x40046EF")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private GameObject _blackScreenCutGroup;
	}
}
