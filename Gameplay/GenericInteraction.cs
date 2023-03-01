using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Input;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x02000657 RID: 1623
	[Token(Token = "0x2000657")]
	public class GenericInteraction : MonoBehaviour
	{
		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600299C RID: 10652 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600299D RID: 10653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000020")]
		private event Action _actionPerformed
		{
			[Token(Token = "0x600299C")]
			[Address(RVA = "0x2DCDAC0", Offset = "0x2DCCAC0", VA = "0x182DCDAC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600299D")]
			[Address(RVA = "0x2DCDD10", Offset = "0x2DCCD10", VA = "0x182DCDD10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000567")]
		private List<string> GetActionsMenuDropdown
		{
			[Token(Token = "0x600299E")]
			[Address(RVA = "0x2DCDF80", Offset = "0x2DCCF80", VA = "0x182DCDF80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[Token(Token = "0x17000568")]
		public bool InteractionBlocked
		{
			[Token(Token = "0x600299F")]
			[Address(RVA = "0x1DD5070", Offset = "0x1DD4070", VA = "0x181DD5070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x0000C000 File Offset: 0x0000A200
		[Token(Token = "0x17000569")]
		public bool InteractionFocused
		{
			[Token(Token = "0x60029A0")]
			[Address(RVA = "0x576470", Offset = "0x575470", VA = "0x180576470")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x2DCDAC0", Offset = "0x2DCCAC0", VA = "0x182DCDAC0")]
		public void RegisterActionPerformed(Action handler)
		{
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x2DCDD10", Offset = "0x2DCCD10", VA = "0x182DCDD10")]
		public void UnregisterActionPerformed(Action handler)
		{
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A3")]
		[Address(RVA = "0x2DCDAB0", Offset = "0x2DCCAB0", VA = "0x182DCDAB0")]
		private void OnDisable()
		{
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x0000C018 File Offset: 0x0000A218
		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x2DCDCA0", Offset = "0x2DCCCA0", VA = "0x182DCDCA0")]
		private bool ShouldShowGui()
		{
			return default(bool);
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A5")]
		[Address(RVA = "0x2DCDDB0", Offset = "0x2DCCDB0", VA = "0x182DCDDB0")]
		private void Update()
		{
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A6")]
		[Address(RVA = "0x2DCD8B0", Offset = "0x2DCC8B0", VA = "0x182DCD8B0")]
		private void CheckInputAction()
		{
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x2DCDB60", Offset = "0x2DCCB60", VA = "0x182DCDB60")]
		private void SetInteractGuiShow(bool value)
		{
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x2DCDA00", Offset = "0x2DCCA00", VA = "0x182DCDA00", Slot = "4")]
		public virtual void GrabEnter()
		{
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A9")]
		[Address(RVA = "0x2DCDA90", Offset = "0x2DCCA90", VA = "0x182DCDA90", Slot = "5")]
		public virtual void GrabExit()
		{
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AA")]
		[Address(RVA = "0x2DCDC60", Offset = "0x2DCCC60", VA = "0x182DCDC60")]
		public void SetInteractionBlocked(bool value)
		{
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AB")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public GenericInteraction()
		{
		}

		// Token: 0x04002554 RID: 9556
		[Token(Token = "0x4002554")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _idleGui;

		// Token: 0x04002555 RID: 9557
		[Token(Token = "0x4002555")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _interactGui;

		// Token: 0x04002556 RID: 9558
		[Token(Token = "0x4002556")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _actionPerformedUnityEvent;

		// Token: 0x04002557 RID: 9559
		[Token(Token = "0x4002557")]
		[FieldOffset(Offset = "0x38")]
		private bool _grabberFocused;

		// Token: 0x04002558 RID: 9560
		[Token(Token = "0x4002558")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_buttonId")]
		private string _actionId;

		// Token: 0x04002559 RID: 9561
		[Token(Token = "0x4002559")]
		[FieldOffset(Offset = "0x48")]
		private string _cachedActionString;

		// Token: 0x0400255A RID: 9562
		[Token(Token = "0x400255A")]
		[FieldOffset(Offset = "0x50")]
		private InputSystem.Action _cachedAction;

		// Token: 0x0400255B RID: 9563
		[Token(Token = "0x400255B")]
		[FieldOffset(Offset = "0x60")]
		private bool _interactionBlocked;
	}
}
