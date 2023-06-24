using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003FE RID: 1022
	[Token(Token = "0x20003FE")]
	public class TogglePosition : MonoBehaviour
	{
		// Token: 0x06001B64 RID: 7012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x32B6F90", Offset = "0x32B5590", VA = "0x1832B6F90")]
		private void OnEnable()
		{
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x32B7230", Offset = "0x32B5830", VA = "0x1832B7230")]
		private void OnDisable()
		{
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TogglePosition()
		{
		}

		// Token: 0x04001A97 RID: 6807
		[Token(Token = "0x4001A97")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget _target;

		// Token: 0x04001A98 RID: 6808
		[Token(Token = "0x4001A98")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _originalPosition;

		// Token: 0x04001A99 RID: 6809
		[Token(Token = "0x4001A99")]
		[FieldOffset(Offset = "0x34")]
		private UIRect.AnchorUpdate _anchorUpdate;
	}
}
