using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Steamworks;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class DedicatedServerPingRequest
{
	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x30CFCA0", Offset = "0x30CE2A0", VA = "0x1830CFCA0")]
	public static void RunAsync(uint ip, ushort port, Action<gameserveritem_t> onSuccess, Action onFail)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x30CFD30", Offset = "0x30CE330", VA = "0x1830CFD30")]
	private Task<gameserveritem_t> InternalRunAsync(uint ip, ushort port, Action<gameserveritem_t> onSuccess, Action onFail)
	{
		return null;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x30CFFA0", Offset = "0x30CE5A0", VA = "0x1830CFFA0")]
	private void OnServerPingResponseSuccess(gameserveritem_t server)
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x30CFFF0", Offset = "0x30CE5F0", VA = "0x1830CFFF0")]
	private void OnServerPingResponseFailed()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x30D0080", Offset = "0x30CE680", VA = "0x1830D0080")]
	private void Cleanup()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public DedicatedServerPingRequest()
	{
	}

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x10")]
	private ISteamMatchmakingPingResponse _dedicatedServerPingResponse;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x18")]
	private HServerQuery _serverQuery;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x20")]
	private TaskCompletionSource<gameserveritem_t> _tcs;
}
