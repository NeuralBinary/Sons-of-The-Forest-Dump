using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gameplay.GPS;
using UnityEngine;
using UnityEngine.UI;

namespace Construction
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	[AddComponentMenu("Sons/Constructions/FreeFormGpsLocator")]
	public class FreeFormGpsLocator : MonoBehaviour
	{
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x000076AC File Offset: 0x000058AC
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002DD")]
		public int IconId
		{
			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0x8F80C0", Offset = "0x8F66C0", VA = "0x1808F80C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x2EADAF0", Offset = "0x2EAC0F0", VA = "0x182EADAF0")]
		protected void Start()
		{
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000076C4 File Offset: 0x000058C4
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x2EADC60", Offset = "0x2EAC260", VA = "0x182EADC60")]
		private int GetEncodedIconId()
		{
			return 0;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x2EADD40", Offset = "0x2EAC340", VA = "0x182EADD40")]
		private void SetIcon(int iconId)
		{
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FreeFormGpsLocator()
		{
		}

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage _locatorIcon;

		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RawImage _locatorIconOutline;

		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RawImage _locatorColor;

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GPSLocatorIcons _locatorIcons;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x40")]
		private GPSLocator _locator;
	}
}
