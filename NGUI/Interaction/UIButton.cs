using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[AddComponentMenu("NGUI/Interaction/Button")]
	public class UIButton : UIButtonColor
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x000044A0 File Offset: 0x000026A0
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000143")]
		public override bool isEnabled
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x26A92C0", Offset = "0x26A78C0", VA = "0x1826A92C0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x26A9550", Offset = "0x26A7B50", VA = "0x1826A9550", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000144")]
		public string normalSprite
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x26A9860", Offset = "0x26A7E60", VA = "0x1826A9860")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x26A98A0", Offset = "0x26A7EA0", VA = "0x1826A98A0")]
			set
			{
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000145")]
		public Sprite normalSprite2D
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x26A9AA0", Offset = "0x26A80A0", VA = "0x1826A9AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x26A9AE0", Offset = "0x26A80E0", VA = "0x1826A9AE0")]
			set
			{
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x26A9DD0", Offset = "0x26A83D0", VA = "0x1826A9DD0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x26AA1A0", Offset = "0x26A87A0", VA = "0x1826AA1A0", Slot = "7")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x26AA380", Offset = "0x26A8980", VA = "0x1826AA380", Slot = "11")]
		protected override void OnDragOver()
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x26AA650", Offset = "0x26A8C50", VA = "0x1826AA650", Slot = "12")]
		protected override void OnDragOut()
		{
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x26AA920", Offset = "0x26A8F20", VA = "0x1826AA920", Slot = "14")]
		protected virtual void OnClick()
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x26AAB30", Offset = "0x26A9130", VA = "0x1826AAB30", Slot = "13")]
		public override void SetState(UIButtonColor.State state, bool immediate)
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x26AAE60", Offset = "0x26A9460", VA = "0x1826AAE60")]
		protected void SetSprite(string sp)
		{
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x26AAFC0", Offset = "0x26A95C0", VA = "0x1826AAFC0")]
		protected void SetSprite(Sprite sp)
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x26AB210", Offset = "0x26A9810", VA = "0x1826AB210")]
		public UIButton()
		{
		}

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x0")]
		public static UIButton current;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x90")]
		public bool dragHighlight;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x98")]
		public string hoverSprite;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0xA0")]
		public string pressedSprite;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0xA8")]
		public string disabledSprite;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0xB0")]
		public Sprite hoverSprite2D;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0xB8")]
		public Sprite pressedSprite2D;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0xC0")]
		public Sprite disabledSprite2D;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0xC8")]
		public bool pixelSnap;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0xD0")]
		public List<EventDelegate> onClick;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		private UISprite mSprite;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0xE0")]
		[NonSerialized]
		private UI2DSprite mSprite2D;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		private string mNormalSprite;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		private Sprite mNormalSprite2D;
	}
}
