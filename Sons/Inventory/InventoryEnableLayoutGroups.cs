using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005E9 RID: 1513
	[Token(Token = "0x20005E9")]
	public class InventoryEnableLayoutGroups : MonoBehaviour
	{
		// Token: 0x06002757 RID: 10071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002757")]
		[Address(RVA = "0xA71C70", Offset = "0xA70270", VA = "0x180A71C70")]
		private void Awake()
		{
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002758")]
		[Address(RVA = "0x33C3AB0", Offset = "0x33C20B0", VA = "0x1833C3AB0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x33C3AC0", Offset = "0x33C20C0", VA = "0x1833C3AC0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x33C3AD0", Offset = "0x33C20D0", VA = "0x1833C3AD0")]
		private void EnableGroups(bool enable)
		{
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275B")]
		[Address(RVA = "0x33C3D80", Offset = "0x33C2380", VA = "0x1833C3D80")]
		public InventoryEnableLayoutGroups()
		{
		}

		// Token: 0x04002394 RID: 9108
		[Token(Token = "0x4002394")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<InventoryLayoutItemGroup> _layoutGroups;
	}
}
