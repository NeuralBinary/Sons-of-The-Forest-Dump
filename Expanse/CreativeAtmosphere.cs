using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	[Serializable]
	public class CreativeAtmosphere : MonoBehaviour
	{
		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		[Address(RVA = "0xAC0DC0", Offset = "0xABF3C0", VA = "0x180AC0DC0")]
		private void Update()
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xAC0F20", Offset = "0xABF520", VA = "0x180AC0F20")]
		public CreativeAtmosphere()
		{
		}

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x20")]
		public AtmosphereLayerBlock m_airBlock;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x28")]
		public AtmosphereLayerBlock m_ozoneBlock;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Color of the sky at daytime.")]
		public Color m_daytimeColor;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Color of the sky at sunset.")]
		public Color m_sunsetColor;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 10f)]
		[Tooltip("Amount of ozone gas. Increasing will make the sky more purple at sunset.")]
		public float m_ozone;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x54")]
		[Range(0f, 4f)]
		[Tooltip("How thick and dense the atmosphere is. Good for alien planets.")]
		public float m_thickness;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		private const float kNormalizationConstant = 6.6199995E-05f;
	}
}
