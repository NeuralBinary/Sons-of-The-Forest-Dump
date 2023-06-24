using System;
using Endnight.Utilities;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x0200084F RID: 2127
	[Token(Token = "0x200084F")]
	[AddComponentMenu("Sons/Gameplay/GrabBag/GrabBagRequestItemBack")]
	public class GrabBagRequestItemBack : MonoBehaviour
	{
		// Token: 0x06003C90 RID: 15504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C90")]
		[Address(RVA = "0x35A9B90", Offset = "0x35A8190", VA = "0x1835A9B90")]
		private void Awake()
		{
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C91")]
		[Address(RVA = "0x35A9CF0", Offset = "0x35A82F0", VA = "0x1835A9CF0")]
		private void Update()
		{
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C92")]
		[Address(RVA = "0x35A9EA0", Offset = "0x35A84A0", VA = "0x1835A9EA0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C93")]
		[Address(RVA = "0x35A9FE0", Offset = "0x35A85E0", VA = "0x1835A9FE0")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C94")]
		[Address(RVA = "0x35AA160", Offset = "0x35A8760", VA = "0x1835AA160")]
		private void OnMouseExit()
		{
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C95")]
		[Address(RVA = "0x35AA2E0", Offset = "0x35A88E0", VA = "0x1835AA2E0")]
		private void OnRequestItemBack(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C96")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GrabBagRequestItemBack()
		{
		}

		// Token: 0x0400332E RID: 13102
		[Token(Token = "0x400332E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _itemId;

		// Token: 0x0400332F RID: 13103
		[Token(Token = "0x400332F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GrabBagController _grabBagController;

		// Token: 0x04003330 RID: 13104
		[Token(Token = "0x4003330")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _decalIcon;

		// Token: 0x04003331 RID: 13105
		[Token(Token = "0x4003331")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _decalIconOutline;

		// Token: 0x04003332 RID: 13106
		[Token(Token = "0x4003332")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GrabBagLayoutItem _layoutItem;

		// Token: 0x04003333 RID: 13107
		[Token(Token = "0x4003333")]
		[FieldOffset(Offset = "0x48")]
		private bool _isMouseOver;

		// Token: 0x04003334 RID: 13108
		[Token(Token = "0x4003334")]
		[FieldOffset(Offset = "0x50")]
		private MouseEventsProxy _mouseEventsProxy;
	}
}
