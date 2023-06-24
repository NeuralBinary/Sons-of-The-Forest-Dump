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
	// Token: 0x0200094E RID: 2382
	[Token(Token = "0x200094E")]
	[AddComponentMenu("Sons/Animation/GetDownSonWakeupCutscene")]
	public class GetDownSonWakeupCutscene : EndGameCutscene
	{
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x00014FE8 File Offset: 0x000131E8
		[Token(Token = "0x170008ED")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x60044E6")]
			[Address(RVA = "0x365A910", Offset = "0x3658F10", VA = "0x18365A910", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x00015000 File Offset: 0x00013200
		[Token(Token = "0x170008EE")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x60044E7")]
			[Address(RVA = "0x365A970", Offset = "0x3658F70", VA = "0x18365A970", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x00015018 File Offset: 0x00013218
		[Token(Token = "0x170008EF")]
		public override bool HideRemotePlayers
		{
			[Token(Token = "0x60044E8")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E9")]
		[Address(RVA = "0x365A9D0", Offset = "0x3658FD0", VA = "0x18365A9D0")]
		private void ShowTacticalAxe()
		{
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EA")]
		[Address(RVA = "0x365AA00", Offset = "0x3659000", VA = "0x18365AA00")]
		private void HideTacticalAxe()
		{
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x00015030 File Offset: 0x00013230
		[Token(Token = "0x60044EB")]
		[Address(RVA = "0x365AA70", Offset = "0x3659070", VA = "0x18365AA70", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EC")]
		[Address(RVA = "0x365AC70", Offset = "0x3659270", VA = "0x18365AC70")]
		private void SetupEvents()
		{
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044ED")]
		[Address(RVA = "0x365B1D0", Offset = "0x36597D0", VA = "0x18365B1D0", Slot = "26")]
		internal override void OnNormalizedTimeChanged(float value)
		{
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0x365B320", Offset = "0x3659920", VA = "0x18365B320", Slot = "32")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0x365B860", Offset = "0x3659E60", VA = "0x18365B860", Slot = "14")]
		protected override void ResetCutscene()
		{
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F0")]
		[Address(RVA = "0x365B870", Offset = "0x3659E70", VA = "0x18365B870")]
		public GetDownSonWakeupCutscene()
		{
		}

		// Token: 0x04004798 RID: 18328
		[Token(Token = "0x4004798")]
		[FieldOffset(Offset = "0x180")]
		[FormerlySerializedAs("_cutsceneAnimators")]
		[SerializeField]
		private List<Animator> _animators;

		// Token: 0x04004799 RID: 18329
		[Token(Token = "0x4004799")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Quaternion _tacticalAxeRotation;

		// Token: 0x0400479A RID: 18330
		[Token(Token = "0x400479A")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private float _fadeFromBlackStartTime;

		// Token: 0x0400479B RID: 18331
		[Token(Token = "0x400479B")]
		[FieldOffset(Offset = "0x1A0")]
		private FadeToBlack _playerFadeToBlackCached;

		// Token: 0x0400479C RID: 18332
		[Token(Token = "0x400479C")]
		[FieldOffset(Offset = "0x1A8")]
		private AnimationEventReceiver _animationEventReceiver;

		// Token: 0x0400479D RID: 18333
		[Token(Token = "0x400479D")]
		[FieldOffset(Offset = "0x1B0")]
		private ItemInstance _axeItemInstance;

		// Token: 0x0400479E RID: 18334
		[Token(Token = "0x400479E")]
		[FieldOffset(Offset = "0x1B8")]
		private GameObject _axeGameObject;

		// Token: 0x0400479F RID: 18335
		[Token(Token = "0x400479F")]
		[FieldOffset(Offset = "0x1C0")]
		private bool _startedFadeFromBlack;
	}
}
