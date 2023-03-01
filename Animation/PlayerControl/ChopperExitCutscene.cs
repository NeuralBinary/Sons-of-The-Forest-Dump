using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using UnityEngine;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008C0 RID: 2240
	[Token(Token = "0x20008C0")]
	[AddComponentMenu("Sons/Animation/ChopperExitCutscene")]
	public class ChopperExitCutscene : EndGameCutscene
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06003C72 RID: 15474 RVA: 0x00011A48 File Offset: 0x0000FC48
		[Token(Token = "0x17000778")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6003C72")]
			[Address(RVA = "0x2F132F0", Offset = "0x2F122F0", VA = "0x182F132F0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06003C73 RID: 15475 RVA: 0x00011A60 File Offset: 0x0000FC60
		[Token(Token = "0x17000779")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6003C73")]
			[Address(RVA = "0x2F13350", Offset = "0x2F12350", VA = "0x182F13350", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06003C74 RID: 15476 RVA: 0x00011A78 File Offset: 0x0000FC78
		[Token(Token = "0x1700077A")]
		public override bool ShouldAlignPlayer
		{
			[Token(Token = "0x6003C74")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x00011A90 File Offset: 0x0000FC90
		[Token(Token = "0x1700077B")]
		public override bool ShouldStashHeldItems
		{
			[Token(Token = "0x6003C75")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		[Token(Token = "0x6003C76")]
		[Address(RVA = "0x2F130F0", Offset = "0x2F120F0", VA = "0x182F130F0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C77")]
		[Address(RVA = "0x2F12F30", Offset = "0x2F11F30", VA = "0x182F12F30", Slot = "29")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C78")]
		[Address(RVA = "0x2F13250", Offset = "0x2F12250", VA = "0x182F13250")]
		public ChopperExitCutscene()
		{
		}

		// Token: 0x040040A8 RID: 16552
		[Token(Token = "0x40040A8")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private List<Animator> _animators;

		// Token: 0x040040A9 RID: 16553
		[Token(Token = "0x40040A9")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _blackScreenCutGroup;
	}
}
