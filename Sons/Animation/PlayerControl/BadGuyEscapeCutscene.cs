using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000929 RID: 2345
	[Token(Token = "0x2000929")]
	[AddComponentMenu("Sons/Animation/BadGuyEscapeCutscene")]
	public class BadGuyEscapeCutscene : EndGameTriggeredCutscene
	{
		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x00014640 File Offset: 0x00012840
		[Token(Token = "0x17000887")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6004350")]
			[Address(RVA = "0x36440F0", Offset = "0x36426F0", VA = "0x1836440F0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x00014658 File Offset: 0x00012858
		[Token(Token = "0x17000888")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6004351")]
			[Address(RVA = "0x3644150", Offset = "0x3642750", VA = "0x183644150", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x00014670 File Offset: 0x00012870
		[Token(Token = "0x17000889")]
		public override bool ShouldStashHeldItems
		{
			[Token(Token = "0x6004352")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06004353 RID: 17235 RVA: 0x00014688 File Offset: 0x00012888
		[Token(Token = "0x1700088A")]
		public override bool ShouldAlignPlayer
		{
			[Token(Token = "0x6004353")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x000146A0 File Offset: 0x000128A0
		[Token(Token = "0x1700088B")]
		public override bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x6004354")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004355")]
		[Address(RVA = "0x36441B0", Offset = "0x36427B0", VA = "0x1836441B0", Slot = "33")]
		protected override void OnTriggerEnterPassed(Collider other)
		{
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x000146B8 File Offset: 0x000128B8
		[Token(Token = "0x6004356")]
		[Address(RVA = "0x36443E0", Offset = "0x36429E0", VA = "0x1836443E0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004357")]
		[Address(RVA = "0x3644400", Offset = "0x3642A00", VA = "0x183644400")]
		public BadGuyEscapeCutscene()
		{
		}

		// Token: 0x0400468B RID: 18059
		[Token(Token = "0x400468B")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private List<Animator> _cutsceneAnimators;
	}
}
