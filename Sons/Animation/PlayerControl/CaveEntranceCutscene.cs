using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Areas;
using Sons.Cutscenes;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x02000930 RID: 2352
	[Token(Token = "0x2000930")]
	[AddComponentMenu("Sons/Animation/PlayerControl/Cave Entrance Cutscene")]
	public class CaveEntranceCutscene : Cutscene
	{
		// Token: 0x0600439D RID: 17309 RVA: 0x00014880 File Offset: 0x00012A80
		[Token(Token = "0x600439D")]
		[Address(RVA = "0x3647FB0", Offset = "0x36465B0", VA = "0x183647FB0")]
		private bool CaveIsOpen()
		{
			return default(bool);
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x00014898 File Offset: 0x00012A98
		// (set) Token: 0x0600439F RID: 17311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700089E")]
		public bool ForceDisabled
		{
			[Token(Token = "0x600439E")]
			[Address(RVA = "0x2A22CA0", Offset = "0x2A212A0", VA = "0x182A22CA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600439F")]
			[Address(RVA = "0x3648070", Offset = "0x3646670", VA = "0x183648070")]
			set
			{
			}
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x000148B0 File Offset: 0x00012AB0
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x3648130", Offset = "0x3646730", VA = "0x183648130")]
		private bool CaveEntranceEnabled()
		{
			return default(bool);
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x3648220", Offset = "0x3646820", VA = "0x183648220")]
		private void Update()
		{
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A2")]
		[Address(RVA = "0x36482A0", Offset = "0x36468A0", VA = "0x1836482A0", Slot = "15")]
		public virtual void GrabEnter()
		{
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A3")]
		[Address(RVA = "0x3648420", Offset = "0x3646A20", VA = "0x183648420", Slot = "16")]
		public virtual void GrabExit()
		{
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A4")]
		[Address(RVA = "0x3648630", Offset = "0x3646C30", VA = "0x183648630")]
		private void OnEnterCaveEntrance(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x000148C8 File Offset: 0x00012AC8
		[Token(Token = "0x60043A5")]
		[Address(RVA = "0x3648670", Offset = "0x3646C70", VA = "0x183648670", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A6")]
		[Address(RVA = "0x36487F0", Offset = "0x3646DF0", VA = "0x1836487F0")]
		private IEnumerator WaitForEmptyHandsAndStartSequence()
		{
			return null;
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x000148E0 File Offset: 0x00012AE0
		[Token(Token = "0x60043A7")]
		[Address(RVA = "0x3648880", Offset = "0x3646E80", VA = "0x183648880")]
		private static int GetCaveIntAnimationHash(CaveEntranceCutscene.PathingDirection direction)
		{
			return 0;
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x000148F8 File Offset: 0x00012AF8
		[Token(Token = "0x60043A8")]
		[Address(RVA = "0x3648920", Offset = "0x3646F20", VA = "0x183648920")]
		private static int GetCaveBoolAnimationHash(CaveEntranceCutscene.PathingDirection direction)
		{
			return 0;
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A9")]
		[Address(RVA = "0x36489C0", Offset = "0x3646FC0", VA = "0x1836489C0")]
		private IEnumerator PlayerCaveEntranceSequenceComplete(int animationHash)
		{
			return null;
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AA")]
		[Address(RVA = "0x3648A80", Offset = "0x3647080", VA = "0x183648A80")]
		private void FinalizeSequence()
		{
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AB")]
		[Address(RVA = "0x3648F30", Offset = "0x3647530", VA = "0x183648F30")]
		public CaveEntranceCutscene()
		{
		}

		// Token: 0x040046CC RID: 18124
		[Token(Token = "0x40046CC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CaveEntranceCutscene.PathingDirection _direction;

		// Token: 0x040046CD RID: 18125
		[Token(Token = "0x40046CD")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _alignmentTransform;

		// Token: 0x040046CE RID: 18126
		[Token(Token = "0x40046CE")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _interactionUi;

		// Token: 0x040046CF RID: 18127
		[Token(Token = "0x40046CF")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AreaMask _caveBoardsAreaMask;

		// Token: 0x040046D0 RID: 18128
		[Token(Token = "0x40046D0")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool _isDemonBossCaveExit;

		// Token: 0x040046D1 RID: 18129
		[Token(Token = "0x40046D1")]
		[FieldOffset(Offset = "0xCD")]
		private bool _forceDisabled;

		// Token: 0x02000931 RID: 2353
		[Token(Token = "0x2000931")]
		private enum PathingDirection
		{
			// Token: 0x040046D3 RID: 18131
			[Token(Token = "0x40046D3")]
			Entering,
			// Token: 0x040046D4 RID: 18132
			[Token(Token = "0x40046D4")]
			Exiting
		}
	}
}
