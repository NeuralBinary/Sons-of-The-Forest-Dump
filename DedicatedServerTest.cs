using System;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x020000F3 RID: 243
[Token(Token = "0x20000F3")]
public class DedicatedServerTest : MonoBehaviour
{
	// Token: 0x06000709 RID: 1801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000709")]
	[Address(RVA = "0x2E849C0", Offset = "0x2E839C0", VA = "0x182E849C0")]
	private void Start()
	{
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070A")]
	[Address(RVA = "0x2E844E0", Offset = "0x2E834E0", VA = "0x182E844E0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070B")]
	[Address(RVA = "0x2E85090", Offset = "0x2E84090", VA = "0x182E85090")]
	private void Update()
	{
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070C")]
	[Address(RVA = "0x2E847D0", Offset = "0x2E837D0", VA = "0x182E847D0")]
	private void OnSteamServersConnected(SteamServersConnected_t pLogonSuccess)
	{
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070D")]
	[Address(RVA = "0x2E84770", Offset = "0x2E83770", VA = "0x182E84770")]
	private void OnSteamServersConnectFailure(SteamServerConnectFailure_t pConnectFailure)
	{
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070E")]
	[Address(RVA = "0x2E84840", Offset = "0x2E83840", VA = "0x182E84840")]
	private void OnSteamServersDisconnected(SteamServersDisconnected_t pLoggedOff)
	{
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070F")]
	[Address(RVA = "0x2E84690", Offset = "0x2E83690", VA = "0x182E84690")]
	private void OnPolicyResponse(GSPolicyResponse_t pPolicyResponse)
	{
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000710")]
	[Address(RVA = "0x2E848A0", Offset = "0x2E838A0", VA = "0x182E848A0")]
	private void OnValidateAuthTicketResponse(ValidateAuthTicketResponse_t pResponse)
	{
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000711")]
	[Address(RVA = "0x2E84600", Offset = "0x2E83600", VA = "0x182E84600")]
	private void OnP2PSessionRequest(P2PSessionRequest_t pCallback)
	{
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000712")]
	[Address(RVA = "0x2E84580", Offset = "0x2E83580", VA = "0x182E84580")]
	private void OnP2PSessionConnectFail(P2PSessionConnectFail_t pCallback)
	{
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000713")]
	[Address(RVA = "0x2E84930", Offset = "0x2E83930", VA = "0x182E84930")]
	private void SendUpdatedServerDetailsToSteam()
	{
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000714")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public DedicatedServerTest()
	{
	}

	// Token: 0x040005C9 RID: 1481
	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0x20")]
	protected Callback<SteamServersConnected_t> m_CallbackSteamServersConnected;

	// Token: 0x040005CA RID: 1482
	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x28")]
	protected Callback<SteamServerConnectFailure_t> m_CallbackSteamServersConnectFailure;

	// Token: 0x040005CB RID: 1483
	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x30")]
	protected Callback<SteamServersDisconnected_t> m_CallbackSteamServersDisconnected;

	// Token: 0x040005CC RID: 1484
	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x38")]
	protected Callback<GSPolicyResponse_t> m_CallbackPolicyResponse;

	// Token: 0x040005CD RID: 1485
	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x40")]
	protected Callback<ValidateAuthTicketResponse_t> m_CallbackGSAuthTicketResponse;

	// Token: 0x040005CE RID: 1486
	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x48")]
	protected Callback<P2PSessionRequest_t> m_CallbackP2PSessionRequest;

	// Token: 0x040005CF RID: 1487
	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x50")]
	protected Callback<P2PSessionConnectFail_t> m_CallbackP2PSessionConnectFail;

	// Token: 0x040005D0 RID: 1488
	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x58")]
	private bool m_bInitialized;

	// Token: 0x040005D1 RID: 1489
	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x59")]
	private bool m_bConnectedToSteam;
}
