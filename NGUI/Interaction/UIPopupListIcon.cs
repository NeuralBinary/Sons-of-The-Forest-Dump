using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	[AddComponentMenu("NGUI/Interaction/Popup List")]
	[ExecuteInEditMode]
	public class UIPopupListIcon : UIPopupList
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000163")]
		public new string value
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x26C8580", Offset = "0x26C6B80", VA = "0x1826C8580")]
			set
			{
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x17000164")]
		private bool isValid
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x26CE960", Offset = "0x26CCF60", VA = "0x1826CE960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x17000165")]
		private int activeFontSize
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x26CEAC0", Offset = "0x26CD0C0", VA = "0x1826CEAC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x17000166")]
		private float activeFontScale
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x26CEC30", Offset = "0x26CD230", VA = "0x1826CEC30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x26CEDC0", Offset = "0x26CD3C0", VA = "0x1826CEDC0")]
		public new void Clear()
		{
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x26CEEA0", Offset = "0x26CD4A0", VA = "0x1826CEEA0")]
		public void AddItem(string text, Texture icon, object data)
		{
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x26CF020", Offset = "0x26CD620", VA = "0x1826CF020")]
		public new void RemoveItem(string text)
		{
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x26CF110", Offset = "0x26CD710", VA = "0x1826CF110")]
		public void SetSelection()
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x26CF360", Offset = "0x26CD960", VA = "0x1826CF360", Slot = "5")]
		public override void Show()
		{
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x26D1610", Offset = "0x26CFC10", VA = "0x1826D1610", Slot = "4")]
		protected override Vector3 GetHighlightPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x26D1920", Offset = "0x26CFF20", VA = "0x1826D1920")]
		public UIPopupListIcon()
		{
		}

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x138")]
		public UITexture icon;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x140")]
		public List<Texture> itemsIcon;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x148")]
		public float iconWidth;
	}
}
