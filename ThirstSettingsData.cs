using System;
using Il2CppDummyDll;

// Token: 0x02000086 RID: 134
[Token(Token = "0x2000086")]
[Serializable]
public class ThirstSettingsData
{
	// Token: 0x06000450 RID: 1104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000450")]
	[Address(RVA = "0x2D523C0", Offset = "0x2D513C0", VA = "0x182D523C0")]
	public ThirstSettingsData()
	{
	}

	// Token: 0x040003C1 RID: 961
	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x10")]
	public float ThirstyNotificationThreshold;

	// Token: 0x040003C2 RID: 962
	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x14")]
	public float SleepThirstProtectionThreshold;
}
