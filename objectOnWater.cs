using System;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;

// Token: 0x02000263 RID: 611
[Token(Token = "0x2000263")]
public class objectOnWater : MonoBehaviour
{
	// Token: 0x06001084 RID: 4228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001084")]
	[Address(RVA = "0x2FBFD80", Offset = "0x2FBED80", VA = "0x182FBFD80")]
	private void OnEnable()
	{
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001085")]
	[Address(RVA = "0x2FBFE80", Offset = "0x2FBEE80", VA = "0x182FBFE80")]
	private void Update()
	{
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001086")]
	[Address(RVA = "0x2FBFD40", Offset = "0x2FBED40", VA = "0x182FBFD40")]
	private void OnDisable()
	{
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001087")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public objectOnWater()
	{
	}

	// Token: 0x04000F8D RID: 3981
	[Token(Token = "0x4000F8D")]
	[FieldOffset(Offset = "0x20")]
	[Header("FMOD EVENT")]
	public string onWaterEvent;

	// Token: 0x04000F8E RID: 3982
	[Token(Token = "0x4000F8E")]
	[FieldOffset(Offset = "0x28")]
	public Buoyancy _bouyancy;

	// Token: 0x04000F8F RID: 3983
	[Token(Token = "0x4000F8F")]
	[FieldOffset(Offset = "0x30")]
	private EventInstance onWater;
}
