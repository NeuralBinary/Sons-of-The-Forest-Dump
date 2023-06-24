using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Gameplay
{
	// Token: 0x02000811 RID: 2065
	[Token(Token = "0x2000811")]
	[AddComponentMenu("Sons/Gameplay/NightVisionGoggles")]
	public class NightVisionGoggles : MonoBehaviour
	{
		// Token: 0x0600384A RID: 14410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x3552F50", Offset = "0x3551550", VA = "0x183552F50")]
		public void Activate(bool activate)
		{
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x35531C0", Offset = "0x35517C0", VA = "0x1835531C0")]
		private void Start()
		{
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384C")]
		[Address(RVA = "0x35531D0", Offset = "0x35517D0", VA = "0x1835531D0")]
		private void UpdateVolume(bool onOff)
		{
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384D")]
		[Address(RVA = "0x3553360", Offset = "0x3551960", VA = "0x183553360")]
		private void Update()
		{
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384E")]
		[Address(RVA = "0x31B5290", Offset = "0x31B3890", VA = "0x1831B5290")]
		private void UpdatePadding()
		{
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600384F")]
		[Address(RVA = "0x3553480", Offset = "0x3551A80", VA = "0x183553480")]
		public void SetPowerLevel(float percent)
		{
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003850")]
		[Address(RVA = "0x3061CF0", Offset = "0x30602F0", VA = "0x183061CF0")]
		public NightVisionGoggles()
		{
		}

		// Token: 0x040030B0 RID: 12464
		[Token(Token = "0x40030B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Volume _volume;

		// Token: 0x040030B1 RID: 12465
		[Token(Token = "0x40030B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _nightVisionGogglesOutline;

		// Token: 0x040030B2 RID: 12466
		[Token(Token = "0x40030B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _leftPad;

		// Token: 0x040030B3 RID: 12467
		[Token(Token = "0x40030B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rightPad;

		// Token: 0x040030B4 RID: 12468
		[Token(Token = "0x40030B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _fadeSpeed;

		// Token: 0x040030B5 RID: 12469
		[Token(Token = "0x40030B5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BatteryIndicator _batteryIndicator;

		// Token: 0x040030B6 RID: 12470
		[Token(Token = "0x40030B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040030B7 RID: 12471
		[Token(Token = "0x40030B7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _batteryIndicatorCanvasGroup;
	}
}
