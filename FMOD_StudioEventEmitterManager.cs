using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
public class FMOD_StudioEventEmitterManager : MonoBehaviour
{
	// Token: 0x060000BE RID: 190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x29A26E0", Offset = "0x29A16E0", VA = "0x1829A26E0")]
	private void Awake()
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x29A2B20", Offset = "0x29A1B20", VA = "0x1829A2B20")]
	private void OnDestroy()
	{
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x29A2480", Offset = "0x29A1480", VA = "0x1829A2480")]
	public static void Add(FMOD_StudioEventEmitter emitter)
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x29A2C00", Offset = "0x29A1C00", VA = "0x1829A2C00")]
	public static void Remove(FMOD_StudioEventEmitter emitter)
	{
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x29A2870", Offset = "0x29A1870", VA = "0x1829A2870")]
	private void LateUpdate()
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public FMOD_StudioEventEmitterManager()
	{
	}

	// Token: 0x040000D7 RID: 215
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x0")]
	private static FMOD_StudioEventEmitterManager Instance;

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x8")]
	private static List<FMOD_StudioEventEmitterManager.EmitterInfo> emitters;

	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	private class EmitterInfo
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x88AC50", Offset = "0x889C50", VA = "0x18088AC50")]
		public EmitterInfo(FMOD_StudioEventEmitter emitter)
		{
		}

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x10")]
		public int framesSinceLastMovement;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x18")]
		public FMOD_StudioEventEmitter emitter;
	}
}
