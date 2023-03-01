using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C7 RID: 455
[Token(Token = "0x20001C7")]
[ExecuteInEditMode]
public class GreebleZonesSceneProxy : MonoBehaviour
{
	// Token: 0x06000CDE RID: 3294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x2F8B230", Offset = "0x2F8A230", VA = "0x182F8B230")]
	private void Awake()
	{
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x2F8B320", Offset = "0x2F8A320", VA = "0x182F8B320")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x2F8B410", Offset = "0x2F8A410", VA = "0x182F8B410")]
	public void RefreshGreebleZones()
	{
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x2F8B4B0", Offset = "0x2F8A4B0", VA = "0x182F8B4B0")]
	public GreebleZonesSceneProxy()
	{
	}

	// Token: 0x04000BBE RID: 3006
	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0x20")]
	public GreebleZone[] _greebleZones;

	// Token: 0x04000BBF RID: 3007
	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0x28")]
	public int _currentVersion;

	// Token: 0x04000BC0 RID: 3008
	[Token(Token = "0x4000BC0")]
	[FieldOffset(Offset = "0x30")]
	private GreebleZonesManager _gmz;
}
