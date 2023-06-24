using System;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Sons.Crafting
{
	// Token: 0x020006C7 RID: 1735
	[Token(Token = "0x20006C7")]
	public class HeldBookInteraction : MonoBehaviour
	{
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x0000D860 File Offset: 0x0000BA60
		[Token(Token = "0x17000617")]
		public HeldBookInteraction.LayoutType LayoutItemType
		{
			[Token(Token = "0x6002DCB")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return HeldBookInteraction.LayoutType.Blueprint;
			}
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCC")]
		[Address(RVA = "0x343EF90", Offset = "0x343D590", VA = "0x18343EF90")]
		private void OnEnable()
		{
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCD")]
		[Address(RVA = "0x343F330", Offset = "0x343D930", VA = "0x18343F330")]
		private void OnDisable()
		{
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCE")]
		[Address(RVA = "0x343F4A0", Offset = "0x343DAA0", VA = "0x18343F4A0")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCF")]
		[Address(RVA = "0x343F5C0", Offset = "0x343DBC0", VA = "0x18343F5C0")]
		private void OnMouseExit()
		{
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD0")]
		[Address(RVA = "0x343F6E0", Offset = "0x343DCE0", VA = "0x18343F6E0")]
		private void OnMouseOver()
		{
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD1")]
		[Address(RVA = "0x343F730", Offset = "0x343DD30", VA = "0x18343F730")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD2")]
		[Address(RVA = "0x343F780", Offset = "0x343DD80", VA = "0x18343F780")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD3")]
		[Address(RVA = "0x343F820", Offset = "0x343DE20", VA = "0x18343F820")]
		public HeldBookInteraction()
		{
		}

		// Token: 0x0400280F RID: 10255
		[Token(Token = "0x400280F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HeldBookInteraction.LayoutType _layoutType;

		// Token: 0x04002810 RID: 10256
		[Token(Token = "0x4002810")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002811 RID: 10257
		[Token(Token = "0x4002811")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent<HeldBookInteraction> OnInteract;

		// Token: 0x04002812 RID: 10258
		[Token(Token = "0x4002812")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<HeldBookInteraction> OnMouseEnterEvent;

		// Token: 0x04002813 RID: 10259
		[Token(Token = "0x4002813")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent<HeldBookInteraction> OnMouseExitEvent;

		// Token: 0x04002814 RID: 10260
		[Token(Token = "0x4002814")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent<HeldBookInteraction> OnMouseOverEvent;

		// Token: 0x04002815 RID: 10261
		[Token(Token = "0x4002815")]
		[FieldOffset(Offset = "0x50")]
		private bool _isMouseOver;

		// Token: 0x04002816 RID: 10262
		[Token(Token = "0x4002816")]
		[FieldOffset(Offset = "0x58")]
		private MouseEventsProxy _mouseEventsProxy;

		// Token: 0x020006C8 RID: 1736
		[Token(Token = "0x20006C8")]
		public enum LayoutType
		{
			// Token: 0x04002818 RID: 10264
			[Token(Token = "0x4002818")]
			Blueprint,
			// Token: 0x04002819 RID: 10265
			[Token(Token = "0x4002819")]
			Tab
		}
	}
}
