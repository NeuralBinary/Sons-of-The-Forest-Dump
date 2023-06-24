using System;
using Il2CppDummyDll;

// Token: 0x02000084 RID: 132
[Token(Token = "0x2000084")]
[Serializable]
public class ThirstSettingsData
{
	// Token: 0x06000462 RID: 1122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000462")]
	[Address(RVA = "0x336BA20", Offset = "0x336A020", VA = "0x18336BA20")]
	public ThirstSettingsData()
	{
	}

	// Token: 0x040003D2 RID: 978
	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x10")]
	public float ThirstyNotificationThreshold;

	// Token: 0x040003D3 RID: 979
	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x14")]
	public float SleepThirstProtectionThreshold;
}
