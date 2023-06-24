using System;
using System.Collections;
using Il2CppDummyDll;
using NGUI.Interaction;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003F6 RID: 1014
	[Token(Token = "0x20003F6")]
	public class OptionMenuTweens : MonoBehaviour
	{
		// Token: 0x06001B43 RID: 6979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x32B4980", Offset = "0x32B2F80", VA = "0x1832B4980")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public OptionMenuTweens()
		{
		}

		// Token: 0x04001A77 RID: 6775
		[Token(Token = "0x4001A77")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] _refreshOnStart;

		// Token: 0x04001A78 RID: 6776
		[Token(Token = "0x4001A78")]
		[FieldOffset(Offset = "0x28")]
		public UIPlayTween[] _forwardTweener;

		// Token: 0x04001A79 RID: 6777
		[Token(Token = "0x4001A79")]
		[FieldOffset(Offset = "0x30")]
		public UIPlayTween[] _backwardTweener;

		// Token: 0x04001A7A RID: 6778
		[Token(Token = "0x4001A7A")]
		[FieldOffset(Offset = "0x38")]
		public bool _centerOnScreen;
	}
}
