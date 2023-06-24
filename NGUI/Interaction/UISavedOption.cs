using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	[AddComponentMenu("NGUI/Interaction/Saved Option")]
	public class UISavedOption : MonoBehaviour
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000170")]
		private string key
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x26D4B60", Offset = "0x26D3160", VA = "0x1826D4B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x26D4BC0", Offset = "0x26D31C0", VA = "0x1826D4BC0")]
		private void Awake()
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x26D4D40", Offset = "0x26D3340", VA = "0x1826D4D40")]
		private void OnEnable()
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x26D5370", Offset = "0x26D3970", VA = "0x1826D5370")]
		private void OnDisable()
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x26D56E0", Offset = "0x26D3CE0", VA = "0x1826D56E0")]
		public void SaveSelection()
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x26D5780", Offset = "0x26D3D80", VA = "0x1826D5780")]
		public void SaveState()
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x26D5860", Offset = "0x26D3E60", VA = "0x1826D5860")]
		public void SaveProgress()
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UISavedOption()
		{
		}

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x20")]
		public string keyName;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x28")]
		private UIPopupList mList;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x30")]
		private UIToggle mCheck;

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x38")]
		private UIProgressBar mSlider;
	}
}
