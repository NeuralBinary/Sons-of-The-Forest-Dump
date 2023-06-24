using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/Interaction/NGUI Slider")]
	public class UISlider : UIProgressBar
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x1700017C")]
		public bool isColliderEnabled
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x26DC610", Offset = "0x26DAC10", VA = "0x1826DC610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x000049F8 File Offset: 0x00002BF8
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017D")]
		[Obsolete("Use 'value' instead")]
		public float sliderValue
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x26D2030", Offset = "0x26D0630", VA = "0x1826D2030")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x26D5940", Offset = "0x26D3F40", VA = "0x1826D5940")]
			set
			{
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00004A10 File Offset: 0x00002C10
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017E")]
		[Obsolete("Use 'fillDirection' instead")]
		public bool inverted
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x26D2CE0", Offset = "0x26D12E0", VA = "0x1826D2CE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x26DC830", Offset = "0x26DAE30", VA = "0x1826DC830", Slot = "4")]
		protected override void Upgrade()
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x26DC990", Offset = "0x26DAF90", VA = "0x1826DC990", Slot = "5")]
		protected override void OnStart()
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x26DD3E0", Offset = "0x26DB9E0", VA = "0x1826DD3E0")]
		protected void OnPressBackground(GameObject go, bool isPressed)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x26DD4F0", Offset = "0x26DBAF0", VA = "0x1826DD4F0")]
		protected void OnDragBackground(GameObject go, Vector2 delta)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x26DD5F0", Offset = "0x26DBBF0", VA = "0x1826DD5F0")]
		protected void OnPressForeground(GameObject go, bool isPressed)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x26DD7D0", Offset = "0x26DBDD0", VA = "0x1826DD7D0")]
		protected void OnDragForeground(GameObject go, Vector2 delta)
		{
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x26DD8D0", Offset = "0x26DBED0", VA = "0x1826DD8D0", Slot = "8")]
		public override void OnPan(Vector2 delta)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x26DD950", Offset = "0x26DBF50", VA = "0x1826DD950")]
		public UISlider()
		{
		}

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		[SerializeField]
		private Transform foreground;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[HideInInspector]
		private float rawValue;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x7C")]
		[HideInInspector]
		[SerializeField]
		private UISlider.Direction direction;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x80")]
		[HideInInspector]
		[SerializeField]
		protected bool mInverted;

		// Token: 0x020000D9 RID: 217
		[Token(Token = "0x20000D9")]
		private enum Direction
		{
			// Token: 0x040005BD RID: 1469
			[Token(Token = "0x40005BD")]
			Horizontal,
			// Token: 0x040005BE RID: 1470
			[Token(Token = "0x40005BE")]
			Vertical,
			// Token: 0x040005BF RID: 1471
			[Token(Token = "0x40005BF")]
			Upgraded
		}
	}
}
