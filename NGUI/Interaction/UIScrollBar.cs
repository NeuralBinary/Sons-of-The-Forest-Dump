using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Interaction/NGUI Scroll Bar")]
	public class UIScrollBar : UISlider
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x000048A8 File Offset: 0x00002AA8
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000171")]
		[Obsolete("Use 'value' instead")]
		public float scrollValue
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x26D2030", Offset = "0x26D0630", VA = "0x1826D2030")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x26D5940", Offset = "0x26D3F40", VA = "0x1826D5940")]
			set
			{
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x000048C0 File Offset: 0x00002AC0
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000172")]
		public float barSize
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x179D730", Offset = "0x179BD30", VA = "0x18179D730")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x26D5950", Offset = "0x26D3F50", VA = "0x1826D5950")]
			set
			{
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x26D5B40", Offset = "0x26D4140", VA = "0x1826D5B40", Slot = "4")]
		protected override void Upgrade()
		{
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x26D5B90", Offset = "0x26D4190", VA = "0x1826D5B90", Slot = "5")]
		protected override void OnStart()
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x26D60F0", Offset = "0x26D46F0", VA = "0x1826D60F0", Slot = "6")]
		protected override float LocalToValue(Vector2 localPos)
		{
			return 0f;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x26D63F0", Offset = "0x26D49F0", VA = "0x1826D63F0", Slot = "7")]
		public override void ForceUpdate()
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x26D67D0", Offset = "0x26D4DD0", VA = "0x1826D67D0")]
		public UIScrollBar()
		{
		}

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0x88")]
		[HideInInspector]
		[SerializeField]
		protected float mSize;

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x8C")]
		[HideInInspector]
		[SerializeField]
		private float mScroll;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private UIScrollBar.Direction mDir;

		// Token: 0x020000D0 RID: 208
		[Token(Token = "0x20000D0")]
		private enum Direction
		{
			// Token: 0x0400057A RID: 1402
			[Token(Token = "0x400057A")]
			Horizontal,
			// Token: 0x0400057B RID: 1403
			[Token(Token = "0x400057B")]
			Vertical,
			// Token: 0x0400057C RID: 1404
			[Token(Token = "0x400057C")]
			Upgraded
		}
	}
}
