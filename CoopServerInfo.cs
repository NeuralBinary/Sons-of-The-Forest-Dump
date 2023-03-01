using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Interfaces;
using Sons.Multiplayer;
using TheForest.Player;

// Token: 0x020000D2 RID: 210
[Token(Token = "0x20000D2")]
public class CoopServerInfo : EntityBehaviour<ICoopServerInfo>
{
	// Token: 0x0600062E RID: 1582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062E")]
	[Address(RVA = "0x2E7BB80", Offset = "0x2E7AB80", VA = "0x182E7BB80", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062F")]
	[Address(RVA = "0x2E7DEC0", Offset = "0x2E7CEC0", VA = "0x182E7DEC0")]
	public static void UpdateIdObjectStateFromServer(int objectId, int objectStateValue)
	{
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000630")]
	[Address(RVA = "0x2E7DE00", Offset = "0x2E7CE00", VA = "0x182E7DE00")]
	public static void UpdateIdObjectStateFromClient(int objectId, int objectStateValue)
	{
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000631")]
	[Address(RVA = "0x2E7DF80", Offset = "0x2E7CF80", VA = "0x182E7DF80")]
	private void UpdateIdObjectStateInternal(int objectId, int objectStateValue, bool fromClient = true)
	{
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000632")]
	[Address(RVA = "0x2E7E1B0", Offset = "0x2E7D1B0", VA = "0x182E7E1B0")]
	private void UpdateIdObjectStates(IState state1, string propertyPath, ArrayIndices arrayIndices)
	{
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000633")]
	[Address(RVA = "0x2E7E130", Offset = "0x2E7D130", VA = "0x182E7E130")]
	private void UpdateIdObjectState(int index, int stateValue)
	{
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000634")]
	[Address(RVA = "0x2E7E390", Offset = "0x2E7D390", VA = "0x182E7E390")]
	private void UpdatePlayerRoles()
	{
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000635")]
	[Address(RVA = "0x2E7E6D0", Offset = "0x2E7D6D0", VA = "0x182E7E6D0")]
	private void UpdateStartingSeasonSettings()
	{
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000636")]
	[Address(RVA = "0x2E7D970", Offset = "0x2E7C970", VA = "0x182E7D970")]
	private void UpdateCrashIndex()
	{
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000637")]
	[Address(RVA = "0x2E7C8F0", Offset = "0x2E7B8F0", VA = "0x182E7C8F0", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000638")]
	[Address(RVA = "0x2E7D060", Offset = "0x2E7C060", VA = "0x182E7D060")]
	private void OnCrashIndexChanged(int value)
	{
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000639")]
	[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
	private void SetGameModeInternal(IGameMode gm)
	{
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063A")]
	[Address(RVA = "0x2E7D3B0", Offset = "0x2E7C3B0", VA = "0x182E7D3B0")]
	private void OnGameSettingsChanged(object o)
	{
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063B")]
	[Address(RVA = "0x2E7D3C0", Offset = "0x2E7C3C0", VA = "0x182E7D3C0")]
	private void RefreshServerInfo()
	{
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063C")]
	[Address(RVA = "0x2E7DB70", Offset = "0x2E7CB70", VA = "0x182E7DB70")]
	private void UpdateGameModes()
	{
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063D")]
	[Address(RVA = "0x2E7DA40", Offset = "0x2E7CA40", VA = "0x182E7DA40")]
	private void UpdateDifficulty()
	{
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063E")]
	[Address(RVA = "0x2E7D0F0", Offset = "0x2E7C0F0", VA = "0x182E7D0F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063F")]
	[Address(RVA = "0x2E7D840", Offset = "0x2E7C840", VA = "0x182E7D840")]
	public static void SetState(ServerState state)
	{
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00003CA8 File Offset: 0x00001EA8
	[Token(Token = "0x6000640")]
	[Address(RVA = "0x2E7CE90", Offset = "0x2E7BE90", VA = "0x182E7CE90")]
	public static ServerState GetState()
	{
		return ServerState.Unknown;
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00003CC0 File Offset: 0x00001EC0
	[Token(Token = "0x6000641")]
	[Address(RVA = "0x2E7CFA0", Offset = "0x2E7BFA0", VA = "0x182E7CFA0")]
	private static bool IsValidServer()
	{
		return default(bool);
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000642")]
	[Address(RVA = "0x2E7CA40", Offset = "0x2E7BA40", VA = "0x182E7CA40")]
	public static void Freeze(bool newValue)
	{
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000643")]
	[Address(RVA = "0x2E7CAF0", Offset = "0x2E7BAF0", VA = "0x182E7CAF0")]
	public static NetworkArray_Integer GetClients()
	{
		return null;
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000644")]
	[Address(RVA = "0x2E7CC70", Offset = "0x2E7BC70", VA = "0x182E7CC70")]
	public static NetworkArray_String GetPlayerNames()
	{
		return null;
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000645")]
	[Address(RVA = "0x2E7CDC0", Offset = "0x2E7BDC0", VA = "0x182E7CDC0")]
	public static NetworkArray_Integer GetPlayerRoles()
	{
		return null;
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000646")]
	[Address(RVA = "0x2E7D730", Offset = "0x2E7C730", VA = "0x182E7D730")]
	public static void SetGameMode(GameMode_Creative mode)
	{
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000647")]
	[Address(RVA = "0x2E7D7A0", Offset = "0x2E7C7A0", VA = "0x182E7D7A0")]
	public static void SetPlayerCount(int count)
	{
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[Token(Token = "0x6000648")]
	[Address(RVA = "0x2E7CBC0", Offset = "0x2E7BBC0", VA = "0x182E7CBC0")]
	public static NetworkId GetNetworkId()
	{
		return default(NetworkId);
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000649")]
	[Address(RVA = "0x2E7E830", Offset = "0x2E7D830", VA = "0x182E7E830")]
	public CoopServerInfo()
	{
	}

	// Token: 0x0400055B RID: 1371
	[Token(Token = "0x400055B")]
	private const bool DefaultMultiplayerCheatSetting = true;

	// Token: 0x0400055C RID: 1372
	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x0")]
	private static CoopServerInfo _instance;

	// Token: 0x0400055D RID: 1373
	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x28")]
	private IGameMode _gameMode;
}
