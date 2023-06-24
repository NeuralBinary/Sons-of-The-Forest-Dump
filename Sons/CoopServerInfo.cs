using System;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Interfaces;
using Sons.Multiplayer;
using TheForest.Player;

// Token: 0x020000D0 RID: 208
[Token(Token = "0x20000D0")]
public class CoopServerInfo : EntityBehaviour<ICoopServerInfo>
{
	// Token: 0x14000007 RID: 7
	// (add) Token: 0x06000666 RID: 1638 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000667 RID: 1639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000007")]
	public static event Action OnClientsUpdated
	{
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x3519450", Offset = "0x3517A50", VA = "0x183519450")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x3519560", Offset = "0x3517B60", VA = "0x183519560")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x06000668 RID: 1640 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000669 RID: 1641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000008")]
	public static event Action OnRolesUpdated
	{
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x3519670", Offset = "0x3517C70", VA = "0x183519670")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x3519780", Offset = "0x3517D80", VA = "0x183519780")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066A")]
	[Address(RVA = "0x3519890", Offset = "0x3517E90", VA = "0x183519890", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066B")]
	[Address(RVA = "0x351B850", Offset = "0x3519E50", VA = "0x18351B850")]
	private void OnFinishedLoadingMainScene(object o)
	{
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00003E70 File Offset: 0x00002070
	[Token(Token = "0x600066C")]
	[Address(RVA = "0x351B890", Offset = "0x3519E90", VA = "0x18351B890")]
	public static bool TryGetIdObjectStateFromNetwork(int objectId, out int result)
	{
		return default(bool);
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00003E88 File Offset: 0x00002088
	[Token(Token = "0x600066D")]
	[Address(RVA = "0x351B9B0", Offset = "0x3519FB0", VA = "0x18351B9B0")]
	private bool TryGetIdObjectStateInternal(int objectId, out int result)
	{
		return default(bool);
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066E")]
	[Address(RVA = "0x351BB70", Offset = "0x351A170", VA = "0x18351BB70")]
	public static void UpdateIdObjectStateFromServer(int objectId, int objectStateValue)
	{
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600066F")]
	[Address(RVA = "0x351BC90", Offset = "0x351A290", VA = "0x18351BC90")]
	public static void UpdateIdObjectStateFromClient(int objectId, int objectStateValue)
	{
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000670")]
	[Address(RVA = "0x351BDB0", Offset = "0x351A3B0", VA = "0x18351BDB0")]
	private void UpdateIdObjectStateInternal(int objectId, int objectStateValue, bool fromClient = true)
	{
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000671")]
	[Address(RVA = "0x351BFB0", Offset = "0x351A5B0", VA = "0x18351BFB0")]
	private void UpdateIdObjectStates(IState state1, string propertyPath, ArrayIndices arrayIndices)
	{
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000672")]
	[Address(RVA = "0x351C1E0", Offset = "0x351A7E0", VA = "0x18351C1E0")]
	private void UpdateIdObjectState(int index, int stateValue)
	{
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000673")]
	[Address(RVA = "0x351C300", Offset = "0x351A900", VA = "0x18351C300")]
	private void ClientsChanged()
	{
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000674")]
	[Address(RVA = "0x351C350", Offset = "0x351A950", VA = "0x18351C350")]
	private void PlayerRolesChanged()
	{
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000675")]
	[Address(RVA = "0x351C3A0", Offset = "0x351A9A0", VA = "0x18351C3A0")]
	private void UpdatePlayerRoles()
	{
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000676")]
	[Address(RVA = "0x351C6F0", Offset = "0x351ACF0", VA = "0x18351C6F0")]
	private void UpdateStartingSeasonSetting()
	{
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000677")]
	[Address(RVA = "0x351C990", Offset = "0x351AF90", VA = "0x18351C990")]
	private void UpdateSeasonDurationSetting()
	{
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000678")]
	[Address(RVA = "0x351CB00", Offset = "0x351B100", VA = "0x18351CB00")]
	private void UpdateDayLengthSetting()
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000679")]
	[Address(RVA = "0x351CC70", Offset = "0x351B270", VA = "0x18351CC70")]
	private void UpdateSurvivalDamageSetting()
	{
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067A")]
	[Address(RVA = "0x351CDE0", Offset = "0x351B3E0", VA = "0x18351CDE0")]
	private void UpdateConsumableEffectsSetting()
	{
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067B")]
	[Address(RVA = "0x351CF50", Offset = "0x351B550", VA = "0x18351CF50")]
	private void UpdateColdPenaltySetting()
	{
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067C")]
	[Address(RVA = "0x351D0C0", Offset = "0x351B6C0", VA = "0x18351D0C0")]
	private void UpdateReducedFoodInContainersSetting()
	{
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067D")]
	[Address(RVA = "0x351D1D0", Offset = "0x351B7D0", VA = "0x18351D1D0")]
	private void UpdateSingleUseContainersSetting()
	{
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067E")]
	[Address(RVA = "0x351D2E0", Offset = "0x351B8E0", VA = "0x18351D2E0")]
	private void UpdateEnemyDamageSetting()
	{
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067F")]
	[Address(RVA = "0x351D450", Offset = "0x351BA50", VA = "0x18351D450")]
	private void UpdateEnemyHealthSetting()
	{
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000680")]
	[Address(RVA = "0x351D5C0", Offset = "0x351BBC0", VA = "0x18351D5C0")]
	private void UpdateCrashIndex()
	{
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000681")]
	[Address(RVA = "0x351D6C0", Offset = "0x351BCC0", VA = "0x18351D6C0", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000682")]
	[Address(RVA = "0x351DA30", Offset = "0x351C030", VA = "0x18351DA30")]
	private void OnCrashIndexChanged(int value)
	{
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000683")]
	[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
	private void SetGameModeInternal(IGameMode gm)
	{
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000684")]
	[Address(RVA = "0x351DB10", Offset = "0x351C110", VA = "0x18351DB10")]
	private void OnGameSettingsChanged(object o)
	{
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000685")]
	[Address(RVA = "0x351DB20", Offset = "0x351C120", VA = "0x18351DB20")]
	private void RefreshServerInfo()
	{
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000686")]
	[Address(RVA = "0x351E3D0", Offset = "0x351C9D0", VA = "0x18351E3D0")]
	private void UpdateGameModes()
	{
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000687")]
	[Address(RVA = "0x351E6E0", Offset = "0x351CCE0", VA = "0x18351E6E0")]
	private void UpdateDifficulty()
	{
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000688")]
	[Address(RVA = "0x351E8C0", Offset = "0x351CEC0", VA = "0x18351E8C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000689")]
	[Address(RVA = "0x351ECC0", Offset = "0x351D2C0", VA = "0x18351ECC0")]
	public static void SetState(ServerState state)
	{
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00003EA0 File Offset: 0x000020A0
	[Token(Token = "0x600068A")]
	[Address(RVA = "0x351EEA0", Offset = "0x351D4A0", VA = "0x18351EEA0")]
	public static ServerState GetState()
	{
		return ServerState.Unknown;
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00003EB8 File Offset: 0x000020B8
	[Token(Token = "0x600068B")]
	[Address(RVA = "0x351F020", Offset = "0x351D620", VA = "0x18351F020")]
	private static bool IsValidServer()
	{
		return default(bool);
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068C")]
	[Address(RVA = "0x351F190", Offset = "0x351D790", VA = "0x18351F190")]
	public static void Freeze(bool newValue)
	{
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600068D")]
	[Address(RVA = "0x351F2A0", Offset = "0x351D8A0", VA = "0x18351F2A0")]
	public static NetworkArray_Integer GetClients()
	{
		return null;
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600068E")]
	[Address(RVA = "0x351F3F0", Offset = "0x351D9F0", VA = "0x18351F3F0")]
	public static NetworkArray_Integer GetClientsColor()
	{
		return null;
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600068F")]
	[Address(RVA = "0x351F540", Offset = "0x351DB40", VA = "0x18351F540")]
	public static NetworkArray_ProtocolToken GetSteamIds()
	{
		return null;
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000690")]
	[Address(RVA = "0x351F680", Offset = "0x351DC80", VA = "0x18351F680")]
	public static NetworkArray_Integer GetPlayerRoles()
	{
		return null;
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000691")]
	[Address(RVA = "0x351F7D0", Offset = "0x351DDD0", VA = "0x18351F7D0")]
	public static void SetGameMode(GameMode_Creative mode)
	{
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000692")]
	[Address(RVA = "0x351F870", Offset = "0x351DE70", VA = "0x18351F870")]
	public static void SetPlayerCount(int count)
	{
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00003ED0 File Offset: 0x000020D0
	[Token(Token = "0x6000693")]
	[Address(RVA = "0x351F930", Offset = "0x351DF30", VA = "0x18351F930")]
	public static NetworkId GetNetworkId()
	{
		return default(NetworkId);
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000694")]
	[Address(RVA = "0x351FA40", Offset = "0x351E040", VA = "0x18351FA40")]
	public CoopServerInfo()
	{
	}

	// Token: 0x04000575 RID: 1397
	[Token(Token = "0x4000575")]
	private const bool DefaultMultiplayerCheatSetting = true;

	// Token: 0x04000576 RID: 1398
	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0x0")]
	private static CoopServerInfo _instance;

	// Token: 0x04000577 RID: 1399
	[Token(Token = "0x4000577")]
	[FieldOffset(Offset = "0x28")]
	private IGameMode _gameMode;

	// Token: 0x04000578 RID: 1400
	[Token(Token = "0x4000578")]
	[FieldOffset(Offset = "0x30")]
	private bool _registeredCallback;
}
