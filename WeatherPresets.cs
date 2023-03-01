using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D6 RID: 726
[Token(Token = "0x20002D6")]
public class WeatherPresets : MonoBehaviour
{
	// Token: 0x060012BD RID: 4797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BD")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Start()
	{
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public WeatherPresets()
	{
	}

	// Token: 0x040012AD RID: 4781
	[Token(Token = "0x40012AD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public WeatherPresets.WeatherConfig[] WeatherConfigPresets;

	// Token: 0x020002D7 RID: 727
	[Token(Token = "0x20002D7")]
	[Serializable]
	public class WeatherConfig
	{
		// Token: 0x060012BF RID: 4799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public WeatherConfig()
		{
		}

		// Token: 0x040012AE RID: 4782
		[Token(Token = "0x40012AE")]
		[FieldOffset(Offset = "0x10")]
		public float AlphaSaturation;

		// Token: 0x040012AF RID: 4783
		[Token(Token = "0x40012AF")]
		[FieldOffset(Offset = "0x14")]
		public float CloudOpacityScale;

		// Token: 0x040012B0 RID: 4784
		[Token(Token = "0x40012B0")]
		[FieldOffset(Offset = "0x18")]
		public float SkyColorMultiplyer;

		// Token: 0x040012B1 RID: 4785
		[Token(Token = "0x40012B1")]
		[FieldOffset(Offset = "0x1C")]
		public float OvercastAmount;
	}
}
