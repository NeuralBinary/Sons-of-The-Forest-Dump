using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C6 RID: 454
[Token(Token = "0x20001C6")]
[ExecuteInEditMode]
public class GreebleZonesSceneProxy : MonoBehaviour
{
	// Token: 0x06000D39 RID: 3385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D39")]
	[Address(RVA = "0x36FB0E0", Offset = "0x36F96E0", VA = "0x1836FB0E0")]
	private void Awake()
	{
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0x36FB320", Offset = "0x36F9920", VA = "0x1836FB320")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0x36FB560", Offset = "0x36F9B60", VA = "0x1836FB560")]
	public void RefreshGreebleZones()
	{
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3C")]
	[Address(RVA = "0x72C600", Offset = "0x72AC00", VA = "0x18072C600")]
	public GreebleZonesSceneProxy()
	{
	}

	// Token: 0x04000BED RID: 3053
	[Token(Token = "0x4000BED")]
	[FieldOffset(Offset = "0x20")]
	public GreebleZone[] _greebleZones;

	// Token: 0x04000BEE RID: 3054
	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x28")]
	public int _currentVersion;

	// Token: 0x04000BEF RID: 3055
	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x30")]
	private GreebleZonesManager _gmz;
}
