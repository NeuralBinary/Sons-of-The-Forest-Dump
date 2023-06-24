using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Cutscenes;
using Sons.Gameplay;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x0200094D RID: 2381
	[Token(Token = "0x200094D")]
	[AddComponentMenu("Sons/Animation/GetDownSonCutscene")]
	public class GetDownSonCutscene : EndGameTriggeredCutscene
	{
		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060044D3 RID: 17619 RVA: 0x00014F58 File Offset: 0x00013158
		[Token(Token = "0x170008E9")]
		public override bool ShouldEquipPreviouslyHeldItems
		{
			[Token(Token = "0x60044D3")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x00014F70 File Offset: 0x00013170
		[Token(Token = "0x170008EA")]
		public override bool HideRemotePlayers
		{
			[Token(Token = "0x60044D4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060044D5 RID: 17621 RVA: 0x00014F88 File Offset: 0x00013188
		[Token(Token = "0x170008EB")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x60044D5")]
			[Address(RVA = "0x3659240", Offset = "0x3657840", VA = "0x183659240", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x00014FA0 File Offset: 0x000131A0
		[Token(Token = "0x170008EC")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x60044D6")]
			[Address(RVA = "0x36592A0", Offset = "0x36578A0", VA = "0x1836592A0", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D7")]
		[Address(RVA = "0x3659300", Offset = "0x3657900", VA = "0x183659300", Slot = "5")]
		internal override void OnValidate()
		{
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D8")]
		[Address(RVA = "0x3659440", Offset = "0x3657A40", VA = "0x183659440", Slot = "26")]
		internal override void OnNormalizedTimeChanged(float value)
		{
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D9")]
		[Address(RVA = "0x3659560", Offset = "0x3657B60", VA = "0x183659560", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DA")]
		[Address(RVA = "0x3659720", Offset = "0x3657D20", VA = "0x183659720")]
		private void SetupEvents()
		{
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DB")]
		[Address(RVA = "0x3659A30", Offset = "0x3658030", VA = "0x183659A30", Slot = "34")]
		internal override void InteractionTriggered()
		{
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x00014FB8 File Offset: 0x000131B8
		[Token(Token = "0x60044DC")]
		[Address(RVA = "0x3659B20", Offset = "0x3658120", VA = "0x183659B20", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x00014FD0 File Offset: 0x000131D0
		[Token(Token = "0x60044DD")]
		[Address(RVA = "0x3659BB0", Offset = "0x36581B0", VA = "0x183659BB0", Slot = "30")]
		internal override bool IsCutsceneReady()
		{
			return default(bool);
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DE")]
		[Address(RVA = "0x3659BC0", Offset = "0x36581C0", VA = "0x183659BC0", Slot = "31")]
		internal override void OnCutsceneReady()
		{
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DF")]
		[Address(RVA = "0x3659DA0", Offset = "0x36583A0", VA = "0x183659DA0", Slot = "32")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E0")]
		[Address(RVA = "0x365A230", Offset = "0x3658830", VA = "0x18365A230")]
		public static void InitializeAxeProp(out GameObject axeGameObject, out ItemInstance axeItemInstance)
		{
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E1")]
		[Address(RVA = "0x365A2F0", Offset = "0x36588F0", VA = "0x18365A2F0")]
		private void ShowTacticalAxe()
		{
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E2")]
		[Address(RVA = "0x365A320", Offset = "0x3658920", VA = "0x18365A320")]
		private void HideTacticalAxe()
		{
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E3")]
		[Address(RVA = "0x365A390", Offset = "0x3658990", VA = "0x18365A390")]
		public static void ShowTacticalAxe(ref GameObject axeGameObject, out ItemInstance axeItemInstance, Quaternion transformLocalRotation)
		{
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E4")]
		[Address(RVA = "0x365A7D0", Offset = "0x3658DD0", VA = "0x18365A7D0")]
		public static void HideTacticalAxe(ref GameObject axeGameObject)
		{
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E5")]
		[Address(RVA = "0x365A840", Offset = "0x3658E40", VA = "0x18365A840")]
		public GetDownSonCutscene()
		{
		}

		// Token: 0x0400478F RID: 18319
		[Token(Token = "0x400478F")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[FormerlySerializedAs("_cutsceneAnimators")]
		private List<Animator> _animators;

		// Token: 0x04004790 RID: 18320
		[Token(Token = "0x4004790")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GenericInteraction _startCutsceneTrigger;

		// Token: 0x04004791 RID: 18321
		[Token(Token = "0x4004791")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Cutscene _nextCutscene;

		// Token: 0x04004792 RID: 18322
		[Token(Token = "0x4004792")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private GameObject _blackScreenCutGroup;

		// Token: 0x04004793 RID: 18323
		[Token(Token = "0x4004793")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private Quaternion _tacticalAxeRotation;

		// Token: 0x04004794 RID: 18324
		[Token(Token = "0x4004794")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private float _blackCutNormalizedTime;

		// Token: 0x04004795 RID: 18325
		[Token(Token = "0x4004795")]
		[FieldOffset(Offset = "0x1C0")]
		private ItemInstance _axeItemInstance;

		// Token: 0x04004796 RID: 18326
		[Token(Token = "0x4004796")]
		[FieldOffset(Offset = "0x1C8")]
		private GameObject _axeGameObject;

		// Token: 0x04004797 RID: 18327
		[Token(Token = "0x4004797")]
		[FieldOffset(Offset = "0x1D0")]
		private AnimationEventReceiver _animationEventReceiver;
	}
}
