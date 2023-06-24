using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
public class FMOD_StudioEventEmitterManager : MonoBehaviour
{
	// Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2F6FF40", Offset = "0x2F6E540", VA = "0x182F6FF40")]
	private void Awake()
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2F70220", Offset = "0x2F6E820", VA = "0x182F70220")]
	private void OnDestroy()
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x2F703E0", Offset = "0x2F6E9E0", VA = "0x182F703E0")]
	public static void Add(FMOD_StudioEventEmitter emitter)
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x2F70710", Offset = "0x2F6ED10", VA = "0x182F70710")]
	public static void Remove(FMOD_StudioEventEmitter emitter)
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2F70990", Offset = "0x2F6EF90", VA = "0x182F70990")]
	private void LateUpdate()
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public FMOD_StudioEventEmitterManager()
	{
	}

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x0")]
	private static FMOD_StudioEventEmitterManager Instance;

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x8")]
	private static List<FMOD_StudioEventEmitterManager.EmitterInfo> emitters;

	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	private class EmitterInfo
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x9BAF10", Offset = "0x9B9510", VA = "0x1809BAF10")]
		public EmitterInfo(FMOD_StudioEventEmitter emitter)
		{
		}

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		public int framesSinceLastMovement;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x18")]
		public FMOD_StudioEventEmitter emitter;
	}
}
