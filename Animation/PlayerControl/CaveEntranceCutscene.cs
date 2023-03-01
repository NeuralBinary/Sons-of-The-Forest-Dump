using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Areas;
using Sons.Cutscenes;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008BB RID: 2235
	[Token(Token = "0x20008BB")]
	[AddComponentMenu("Sons/Animation/PlayerControl/Cave Entrance Cutscene")]
	public class CaveEntranceCutscene : Cutscene
	{
		// Token: 0x06003C48 RID: 15432 RVA: 0x00011910 File Offset: 0x0000FB10
		[Token(Token = "0x6003C48")]
		[Address(RVA = "0x2F11860", Offset = "0x2F10860", VA = "0x182F11860")]
		private bool CaveIsOpen()
		{
			return default(bool);
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06003C49 RID: 15433 RVA: 0x00011928 File Offset: 0x0000FB28
		// (set) Token: 0x06003C4A RID: 15434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000770")]
		public bool ForceDisabled
		{
			[Token(Token = "0x6003C49")]
			[Address(RVA = "0x22E9820", Offset = "0x22E8820", VA = "0x1822E9820")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003C4A")]
			[Address(RVA = "0x2F12380", Offset = "0x2F11380", VA = "0x182F12380")]
			set
			{
			}
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x00011940 File Offset: 0x0000FB40
		[Token(Token = "0x6003C4B")]
		[Address(RVA = "0x2F117D0", Offset = "0x2F107D0", VA = "0x182F117D0")]
		private bool CaveEntranceEnabled()
		{
			return default(bool);
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4C")]
		[Address(RVA = "0x2F122C0", Offset = "0x2F112C0", VA = "0x182F122C0")]
		private void Update()
		{
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4D")]
		[Address(RVA = "0x2F11DA0", Offset = "0x2F10DA0", VA = "0x182F11DA0", Slot = "15")]
		public virtual void GrabEnter()
		{
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4E")]
		[Address(RVA = "0x2F11F70", Offset = "0x2F10F70", VA = "0x182F11F70", Slot = "16")]
		public virtual void GrabExit()
		{
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4F")]
		[Address(RVA = "0x2F120B0", Offset = "0x2F110B0", VA = "0x182F120B0")]
		private void OnEnterCaveEntrance(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x00011958 File Offset: 0x0000FB58
		[Token(Token = "0x6003C50")]
		[Address(RVA = "0x2F120F0", Offset = "0x2F110F0", VA = "0x182F120F0", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C51")]
		[Address(RVA = "0x2F12300", Offset = "0x2F11300", VA = "0x182F12300")]
		private IEnumerator WaitForEmptyHandsAndStartSequence()
		{
			return null;
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x00011970 File Offset: 0x0000FB70
		[Token(Token = "0x6003C52")]
		[Address(RVA = "0x2F11D00", Offset = "0x2F10D00", VA = "0x182F11D00")]
		private static int GetCaveIntAnimationHash(CaveEntranceCutscene.PathingDirection direction)
		{
			return default(int);
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x00011988 File Offset: 0x0000FB88
		[Token(Token = "0x6003C53")]
		[Address(RVA = "0x2F11C60", Offset = "0x2F10C60", VA = "0x182F11C60")]
		private static int GetCaveBoolAnimationHash(CaveEntranceCutscene.PathingDirection direction)
		{
			return default(int);
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C54")]
		[Address(RVA = "0x2F12240", Offset = "0x2F11240", VA = "0x182F12240")]
		private IEnumerator PlayerCaveEntranceSequenceComplete(int animationHash)
		{
			return null;
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C55")]
		[Address(RVA = "0x2F118E0", Offset = "0x2F108E0", VA = "0x182F118E0")]
		private void FinalizeSequence()
		{
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C56")]
		[Address(RVA = "0x2F12370", Offset = "0x2F11370", VA = "0x182F12370")]
		public CaveEntranceCutscene()
		{
		}

		// Token: 0x04004087 RID: 16519
		[Token(Token = "0x4004087")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CaveEntranceCutscene.PathingDirection _direction;

		// Token: 0x04004088 RID: 16520
		[Token(Token = "0x4004088")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _alignmentTransform;

		// Token: 0x04004089 RID: 16521
		[Token(Token = "0x4004089")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _interactionUi;

		// Token: 0x0400408A RID: 16522
		[Token(Token = "0x400408A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AreaMask _caveBoardsAreaMask;

		// Token: 0x0400408B RID: 16523
		[Token(Token = "0x400408B")]
		[FieldOffset(Offset = "0xCC")]
		private bool _forceDisabled;

		// Token: 0x020008BC RID: 2236
		[Token(Token = "0x20008BC")]
		private enum PathingDirection
		{
			// Token: 0x0400408D RID: 16525
			[Token(Token = "0x400408D")]
			Entering,
			// Token: 0x0400408E RID: 16526
			[Token(Token = "0x400408E")]
			Exiting
		}
	}
}
