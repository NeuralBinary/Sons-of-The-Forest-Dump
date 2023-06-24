using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Gui;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Construction
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	public static class ItemPicker
	{
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000241")]
		public static RawImageCarousel Carousel
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x2E3AE60", Offset = "0x2E39460", VA = "0x182E3AE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x2E3AEA0", Offset = "0x2E394A0", VA = "0x182E3AEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000242")]
		private static string ButtonName
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x2E3AF30", Offset = "0x2E39530", VA = "0x182E3AF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x2E3AF70", Offset = "0x2E39570", VA = "0x182E3AF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x2E3B010", Offset = "0x2E39610", VA = "0x182E3B010")]
		public static void Show(Vector3 worldPosition, [Optional] string buttonName)
		{
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x2E3B320", Offset = "0x2E39920", VA = "0x182E3B320")]
		public static void Hide()
		{
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00005204 File Offset: 0x00003404
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x2E3B610", Offset = "0x2E39C10", VA = "0x182E3B610")]
		public static bool IsInitialized()
		{
			return default(bool);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x2E3B750", Offset = "0x2E39D50", VA = "0x182E3B750")]
		public static void InitializeOptions(IEnumerable<ItemData> itemSource)
		{
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x2E3BAA0", Offset = "0x2E3A0A0", VA = "0x182E3BAA0")]
		public static void SetSelectedOption(int selectedItemId)
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x2E3BBD0", Offset = "0x2E3A1D0", VA = "0x182E3BBD0")]
		private static void OnRotateItemPicker(InputAction.CallbackContext context)
		{
		}
	}
}
