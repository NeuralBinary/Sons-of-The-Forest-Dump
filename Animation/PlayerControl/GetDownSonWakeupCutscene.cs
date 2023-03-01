using System;
using System.Collections.Generic;
using Assemblies.Sons.Cinematics;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008D8 RID: 2264
	[Token(Token = "0x20008D8")]
	[AddComponentMenu("Sons/Animation/GetDownSonWakeupCutscene")]
	public class GetDownSonWakeupCutscene : EndGameCutscene
	{
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06003D82 RID: 15746 RVA: 0x00012030 File Offset: 0x00010230
		[Token(Token = "0x170007BE")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x6003D82")]
			[Address(RVA = "0x2F1D970", Offset = "0x2F1C970", VA = "0x182F1D970", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00012048 File Offset: 0x00010248
		[Token(Token = "0x170007BF")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x6003D83")]
			[Address(RVA = "0x2F1D9D0", Offset = "0x2F1C9D0", VA = "0x182F1D9D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06003D84 RID: 15748 RVA: 0x00012060 File Offset: 0x00010260
		[Token(Token = "0x170007C0")]
		public override bool HideRemotePlayers
		{
			[Token(Token = "0x6003D84")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D85")]
		[Address(RVA = "0x2F1D890", Offset = "0x2F1C890", VA = "0x182F1D890")]
		private void ShowTacticalAxe()
		{
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D86")]
		[Address(RVA = "0x2F1D230", Offset = "0x2F1C230", VA = "0x182F1D230")]
		private void HideTacticalAxe()
		{
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x00012078 File Offset: 0x00010278
		[Token(Token = "0x6003D87")]
		[Address(RVA = "0x2F1D360", Offset = "0x2F1C360", VA = "0x182F1D360", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D88")]
		[Address(RVA = "0x2F1D4F0", Offset = "0x2F1C4F0", VA = "0x182F1D4F0")]
		private void SetupEvents()
		{
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D89")]
		[Address(RVA = "0x2F1D240", Offset = "0x2F1C240", VA = "0x182F1D240", Slot = "23")]
		internal override void OnNormalizedTimeChanged(float value)
		{
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8A")]
		[Address(RVA = "0x2F1CF20", Offset = "0x2F1BF20", VA = "0x182F1CF20", Slot = "29")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8B")]
		[Address(RVA = "0x2F1D4E0", Offset = "0x2F1C4E0", VA = "0x182F1D4E0", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D8C")]
		[Address(RVA = "0x2F1D8C0", Offset = "0x2F1C8C0", VA = "0x182F1D8C0")]
		public GetDownSonWakeupCutscene()
		{
		}

		// Token: 0x0400414F RID: 16719
		[Token(Token = "0x400414F")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[FormerlySerializedAs("_cutsceneAnimators")]
		private List<Animator> _animators;

		// Token: 0x04004150 RID: 16720
		[Token(Token = "0x4004150")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Quaternion _tacticalAxeRotation;

		// Token: 0x04004151 RID: 16721
		[Token(Token = "0x4004151")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private float _fadeFromBlackStartTime;

		// Token: 0x04004152 RID: 16722
		[Token(Token = "0x4004152")]
		[FieldOffset(Offset = "0x188")]
		private FadeToBlack _playerFadeToBlackCached;

		// Token: 0x04004153 RID: 16723
		[Token(Token = "0x4004153")]
		[FieldOffset(Offset = "0x190")]
		private AnimationEventReceiver _animationEventReceiver;

		// Token: 0x04004154 RID: 16724
		[Token(Token = "0x4004154")]
		[FieldOffset(Offset = "0x198")]
		private ItemInstance _axeItemInstance;

		// Token: 0x04004155 RID: 16725
		[Token(Token = "0x4004155")]
		[FieldOffset(Offset = "0x1A0")]
		private GameObject _axeGameObject;

		// Token: 0x04004156 RID: 16726
		[Token(Token = "0x4004156")]
		[FieldOffset(Offset = "0x1A8")]
		private bool _startedFadeFromBlack;
	}
}
