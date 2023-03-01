using System;
using System.Collections;
using Il2CppDummyDll;
using NGUI.Interaction;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000404 RID: 1028
	[Token(Token = "0x2000404")]
	public class OptionMenuTweens : MonoBehaviour
	{
		// Token: 0x06001B05 RID: 6917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x2CE7C80", Offset = "0x2CE6C80", VA = "0x182CE7C80")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public OptionMenuTweens()
		{
		}

		// Token: 0x04001A53 RID: 6739
		[Token(Token = "0x4001A53")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] _refreshOnStart;

		// Token: 0x04001A54 RID: 6740
		[Token(Token = "0x4001A54")]
		[FieldOffset(Offset = "0x28")]
		public UIPlayTween[] _forwardTweener;

		// Token: 0x04001A55 RID: 6741
		[Token(Token = "0x4001A55")]
		[FieldOffset(Offset = "0x30")]
		public UIPlayTween[] _backwardTweener;

		// Token: 0x04001A56 RID: 6742
		[Token(Token = "0x4001A56")]
		[FieldOffset(Offset = "0x38")]
		public bool _centerOnScreen;
	}
}
