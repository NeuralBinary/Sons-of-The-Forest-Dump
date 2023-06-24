using System;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x020000F1 RID: 241
[Token(Token = "0x20000F1")]
public class DedicatedServerTest : MonoBehaviour
{
	// Token: 0x06000756 RID: 1878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000756")]
	[Address(RVA = "0x3674F80", Offset = "0x3673580", VA = "0x183674F80")]
	private void Start()
	{
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000757")]
	[Address(RVA = "0x3675960", Offset = "0x3673F60", VA = "0x183675960")]
	private void OnDisable()
	{
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000758")]
	[Address(RVA = "0x3675A00", Offset = "0x3674000", VA = "0x183675A00")]
	private void Update()
	{
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000759")]
	[Address(RVA = "0x3675A70", Offset = "0x3674070", VA = "0x183675A70")]
	private void OnSteamServersConnected(SteamServersConnected_t pLogonSuccess)
	{
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075A")]
	[Address(RVA = "0x3675AE0", Offset = "0x36740E0", VA = "0x183675AE0")]
	private void OnSteamServersConnectFailure(SteamServerConnectFailure_t pConnectFailure)
	{
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075B")]
	[Address(RVA = "0x3675B40", Offset = "0x3674140", VA = "0x183675B40")]
	private void OnSteamServersDisconnected(SteamServersDisconnected_t pLoggedOff)
	{
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075C")]
	[Address(RVA = "0x3675BA0", Offset = "0x36741A0", VA = "0x183675BA0")]
	private void OnPolicyResponse(GSPolicyResponse_t pPolicyResponse)
	{
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075D")]
	[Address(RVA = "0x3675D20", Offset = "0x3674320", VA = "0x183675D20")]
	private void OnValidateAuthTicketResponse(ValidateAuthTicketResponse_t pResponse)
	{
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075E")]
	[Address(RVA = "0x3675DB0", Offset = "0x36743B0", VA = "0x183675DB0")]
	private void OnP2PSessionRequest(P2PSessionRequest_t pCallback)
	{
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600075F")]
	[Address(RVA = "0x3675E80", Offset = "0x3674480", VA = "0x183675E80")]
	private void OnP2PSessionConnectFail(P2PSessionConnectFail_t pCallback)
	{
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000760")]
	[Address(RVA = "0x3675F00", Offset = "0x3674500", VA = "0x183675F00")]
	private void SendUpdatedServerDetailsToSteam()
	{
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000761")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public DedicatedServerTest()
	{
	}

	// Token: 0x040005E8 RID: 1512
	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x20")]
	protected Callback<SteamServersConnected_t> m_CallbackSteamServersConnected;

	// Token: 0x040005E9 RID: 1513
	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0x28")]
	protected Callback<SteamServerConnectFailure_t> m_CallbackSteamServersConnectFailure;

	// Token: 0x040005EA RID: 1514
	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0x30")]
	protected Callback<SteamServersDisconnected_t> m_CallbackSteamServersDisconnected;

	// Token: 0x040005EB RID: 1515
	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x38")]
	protected Callback<GSPolicyResponse_t> m_CallbackPolicyResponse;

	// Token: 0x040005EC RID: 1516
	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0x40")]
	protected Callback<ValidateAuthTicketResponse_t> m_CallbackGSAuthTicketResponse;

	// Token: 0x040005ED RID: 1517
	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0x48")]
	protected Callback<P2PSessionRequest_t> m_CallbackP2PSessionRequest;

	// Token: 0x040005EE RID: 1518
	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0x50")]
	protected Callback<P2PSessionConnectFail_t> m_CallbackP2PSessionConnectFail;

	// Token: 0x040005EF RID: 1519
	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0x58")]
	private bool m_bInitialized;

	// Token: 0x040005F0 RID: 1520
	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0x59")]
	private bool m_bConnectedToSteam;
}
