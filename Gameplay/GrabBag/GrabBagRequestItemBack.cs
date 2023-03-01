using System;
using Endnight.Utilities;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x02000701 RID: 1793
	[Token(Token = "0x2000701")]
	[AddComponentMenu("Sons/Gameplay/GrabBag/GrabBagRequestItemBack")]
	public class GrabBagRequestItemBack : MonoBehaviour
	{
		// Token: 0x06002E99 RID: 11929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E99")]
		[Address(RVA = "0x2E34AB0", Offset = "0x2E33AB0", VA = "0x182E34AB0")]
		private void Awake()
		{
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E9A")]
		[Address(RVA = "0x2E34E20", Offset = "0x2E33E20", VA = "0x182E34E20")]
		private void Update()
		{
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E9B")]
		[Address(RVA = "0x2E34BD0", Offset = "0x2E33BD0", VA = "0x182E34BD0")]
		private void OnMouseEnter()
		{
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E9C")]
		[Address(RVA = "0x2E34CE0", Offset = "0x2E33CE0", VA = "0x182E34CE0")]
		private void OnMouseExit()
		{
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E9D")]
		[Address(RVA = "0x2E34DF0", Offset = "0x2E33DF0", VA = "0x182E34DF0")]
		private void OnRequestItemBack(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E9E")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public GrabBagRequestItemBack()
		{
		}

		// Token: 0x04002947 RID: 10567
		[Token(Token = "0x4002947")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker(true)]
		[SerializeField]
		private int _itemId;

		// Token: 0x04002948 RID: 10568
		[Token(Token = "0x4002948")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GrabBagController _grabBagController;

		// Token: 0x04002949 RID: 10569
		[Token(Token = "0x4002949")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _decalIcon;

		// Token: 0x0400294A RID: 10570
		[Token(Token = "0x400294A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _decalIconOutline;

		// Token: 0x0400294B RID: 10571
		[Token(Token = "0x400294B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GrabBagLayoutItem _layoutItem;

		// Token: 0x0400294C RID: 10572
		[Token(Token = "0x400294C")]
		[FieldOffset(Offset = "0x48")]
		private bool _isMouseOver;

		// Token: 0x0400294D RID: 10573
		[Token(Token = "0x400294D")]
		[FieldOffset(Offset = "0x50")]
		private MouseEventsProxy _mouseEventsProxy;
	}
}
