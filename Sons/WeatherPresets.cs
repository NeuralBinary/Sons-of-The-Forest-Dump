using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002CA RID: 714
[Token(Token = "0x20002CA")]
public class WeatherPresets : MonoBehaviour
{
	// Token: 0x060012F3 RID: 4851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Start()
	{
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public WeatherPresets()
	{
	}

	// Token: 0x040012D5 RID: 4821
	[Token(Token = "0x40012D5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public WeatherPresets.WeatherConfig[] WeatherConfigPresets;

	// Token: 0x020002CB RID: 715
	[Token(Token = "0x20002CB")]
	[Serializable]
	public class WeatherConfig
	{
		// Token: 0x060012F5 RID: 4853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public WeatherConfig()
		{
		}

		// Token: 0x040012D6 RID: 4822
		[Token(Token = "0x40012D6")]
		[FieldOffset(Offset = "0x10")]
		public float AlphaSaturation;

		// Token: 0x040012D7 RID: 4823
		[Token(Token = "0x40012D7")]
		[FieldOffset(Offset = "0x14")]
		public float CloudOpacityScale;

		// Token: 0x040012D8 RID: 4824
		[Token(Token = "0x40012D8")]
		[FieldOffset(Offset = "0x18")]
		public float SkyColorMultiplyer;

		// Token: 0x040012D9 RID: 4825
		[Token(Token = "0x40012D9")]
		[FieldOffset(Offset = "0x1C")]
		public float OvercastAmount;
	}
}
