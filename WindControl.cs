using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000197 RID: 407
[Token(Token = "0x2000197")]
public class WindControl : MonoBehaviour
{
	// Token: 0x06000BD8 RID: 3032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x2F73950", Offset = "0x2F72950", VA = "0x182F73950")]
	public void Start()
	{
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x2CE8500", Offset = "0x2CE7500", VA = "0x182CE8500")]
	public WindControl()
	{
	}

	// Token: 0x04000A99 RID: 2713
	[Token(Token = "0x4000A99")]
	[FieldOffset(Offset = "0x20")]
	public WindControl.WindD windDirection;

	// Token: 0x04000A9A RID: 2714
	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0x24")]
	public float windSpeed;

	// Token: 0x04000A9B RID: 2715
	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x0")]
	public static int windV;

	// Token: 0x04000A9C RID: 2716
	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0x4")]
	public static float windS;

	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	public enum WindD
	{
		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4000A9E")]
		NoWind,
		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4000A9F")]
		North,
		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		West,
		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		East,
		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4000AA2")]
		South
	}
}
