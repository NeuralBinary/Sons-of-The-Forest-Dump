using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003FA RID: 1018
	[Token(Token = "0x20003FA")]
	[Obsolete]
	public class SheenBillboardManager : MonoBehaviour
	{
		// Token: 0x06001B54 RID: 6996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B54")]
		[Address(RVA = "0x32B6000", Offset = "0x32B4600", VA = "0x1832B6000")]
		private void Awake()
		{
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B55")]
		[Address(RVA = "0x32B6040", Offset = "0x32B4640", VA = "0x1832B6040")]
		private void Update()
		{
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B56")]
		[Address(RVA = "0x32B6500", Offset = "0x32B4B00", VA = "0x1832B6500")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B57")]
		[Address(RVA = "0x32B66B0", Offset = "0x32B4CB0", VA = "0x1832B66B0")]
		public static void Register(SheenBillboard sb)
		{
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B58")]
		[Address(RVA = "0x32B6870", Offset = "0x32B4E70", VA = "0x1832B6870")]
		public static void Unregister(SheenBillboard sb)
		{
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C6")]
		private static SheenBillboardManager Instance
		{
			[Token(Token = "0x6001B59")]
			[Address(RVA = "0x32B6A80", Offset = "0x32B5080", VA = "0x1832B6A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x32B6C20", Offset = "0x32B5220", VA = "0x1832B6C20")]
		public SheenBillboardManager()
		{
		}

		// Token: 0x04001A89 RID: 6793
		[Token(Token = "0x4001A89")]
		[FieldOffset(Offset = "0x20")]
		public float _offshootRatio;

		// Token: 0x04001A8A RID: 6794
		[Token(Token = "0x4001A8A")]
		[FieldOffset(Offset = "0x24")]
		public float _hFovRatio;

		// Token: 0x04001A8B RID: 6795
		[Token(Token = "0x4001A8B")]
		[FieldOffset(Offset = "0x28")]
		public float _groupingRange;

		// Token: 0x04001A8C RID: 6796
		[Token(Token = "0x4001A8C")]
		[FieldOffset(Offset = "0x2C")]
		public float _dotUpdateThreshold;

		// Token: 0x04001A8D RID: 6797
		[Token(Token = "0x4001A8D")]
		[FieldOffset(Offset = "0x30")]
		public bool _legacy;

		// Token: 0x04001A8E RID: 6798
		[Token(Token = "0x4001A8E")]
		[FieldOffset(Offset = "0x34")]
		private int _lastInactiveIconsIndex;

		// Token: 0x04001A8F RID: 6799
		[Token(Token = "0x4001A8F")]
		[FieldOffset(Offset = "0x38")]
		private int _lastActiveIconsIndex;

		// Token: 0x04001A90 RID: 6800
		[Token(Token = "0x4001A90")]
		[FieldOffset(Offset = "0x40")]
		private List<SheenBillboard> _inactiveIcons;

		// Token: 0x04001A91 RID: 6801
		[Token(Token = "0x4001A91")]
		[FieldOffset(Offset = "0x48")]
		private List<SheenBillboard> _activeIcons;

		// Token: 0x04001A92 RID: 6802
		[Token(Token = "0x4001A92")]
		[FieldOffset(Offset = "0x0")]
		private static SheenBillboardManager _instance;
	}
}
