using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000196 RID: 406
[Token(Token = "0x2000196")]
public class WindControl : MonoBehaviour
{
	// Token: 0x06000C32 RID: 3122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x36E1FA0", Offset = "0x36E05A0", VA = "0x1836E1FA0")]
	public void Start()
	{
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x32BB890", Offset = "0x32B9E90", VA = "0x1832BB890")]
	public WindControl()
	{
	}

	// Token: 0x04000AC4 RID: 2756
	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x20")]
	public WindControl.WindD windDirection;

	// Token: 0x04000AC5 RID: 2757
	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x24")]
	public float windSpeed;

	// Token: 0x04000AC6 RID: 2758
	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x0")]
	public static int windV;

	// Token: 0x04000AC7 RID: 2759
	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x4")]
	public static float windS;

	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	public enum WindD
	{
		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		NoWind,
		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		North,
		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		West,
		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		East,
		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		South
	}
}
