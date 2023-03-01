using System;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Sons.Crafting
{
	// Token: 0x020007BC RID: 1980
	[Token(Token = "0x20007BC")]
	public class HeldBookInteraction : MonoBehaviour
	{
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x0000EF88 File Offset: 0x0000D188
		[Token(Token = "0x170006AA")]
		public HeldBookInteraction.LayoutType LayoutItemType
		{
			[Token(Token = "0x6003451")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return HeldBookInteraction.LayoutType.Blueprint;
			}
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003452")]
		[Address(RVA = "0x2E600E0", Offset = "0x2E5F0E0", VA = "0x182E600E0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003453")]
		[Address(RVA = "0x2E5FFD0", Offset = "0x2E5EFD0", VA = "0x182E5FFD0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003454")]
		[Address(RVA = "0x2E603C0", Offset = "0x2E5F3C0", VA = "0x182E603C0")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003455")]
		[Address(RVA = "0x2E60480", Offset = "0x2E5F480", VA = "0x182E60480")]
		private void OnMouseExit()
		{
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003456")]
		[Address(RVA = "0x2E60540", Offset = "0x2E5F540", VA = "0x182E60540")]
		private void OnMouseOver()
		{
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003457")]
		[Address(RVA = "0x2E60370", Offset = "0x2E5F370", VA = "0x182E60370")]
		private void OnInteractWithItem(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003458")]
		[Address(RVA = "0x2E60590", Offset = "0x2E5F590", VA = "0x182E60590")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003459")]
		[Address(RVA = "0x2E605F0", Offset = "0x2E5F5F0", VA = "0x182E605F0")]
		public HeldBookInteraction()
		{
		}

		// Token: 0x04002D3B RID: 11579
		[Token(Token = "0x4002D3B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HeldBookInteraction.LayoutType _layoutType;

		// Token: 0x04002D3C RID: 11580
		[Token(Token = "0x4002D3C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002D3D RID: 11581
		[Token(Token = "0x4002D3D")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent<HeldBookInteraction> OnInteract;

		// Token: 0x04002D3E RID: 11582
		[Token(Token = "0x4002D3E")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<HeldBookInteraction> OnMouseEnterEvent;

		// Token: 0x04002D3F RID: 11583
		[Token(Token = "0x4002D3F")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent<HeldBookInteraction> OnMouseExitEvent;

		// Token: 0x04002D40 RID: 11584
		[Token(Token = "0x4002D40")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent<HeldBookInteraction> OnMouseOverEvent;

		// Token: 0x04002D41 RID: 11585
		[Token(Token = "0x4002D41")]
		[FieldOffset(Offset = "0x50")]
		private bool _isMouseOver;

		// Token: 0x04002D42 RID: 11586
		[Token(Token = "0x4002D42")]
		[FieldOffset(Offset = "0x58")]
		private MouseEventsProxy _mouseEventsProxy;

		// Token: 0x020007BD RID: 1981
		[Token(Token = "0x20007BD")]
		public enum LayoutType
		{
			// Token: 0x04002D44 RID: 11588
			[Token(Token = "0x4002D44")]
			Blueprint,
			// Token: 0x04002D45 RID: 11589
			[Token(Token = "0x4002D45")]
			Tab
		}
	}
}
