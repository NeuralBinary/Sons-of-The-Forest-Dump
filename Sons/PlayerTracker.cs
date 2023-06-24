using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000151 RID: 337
[Token(Token = "0x2000151")]
public class PlayerTracker : MonoBehaviour
{
	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700014B")]
	public static PlayerTracker Instance
	{
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x36B4320", Offset = "0x36B2920", VA = "0x1836B4320")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00004A58 File Offset: 0x00002C58
	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x36B4360", Offset = "0x36B2960", VA = "0x1836B4360")]
	public static int GetPlayerCount()
	{
		return 0;
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x36B44D0", Offset = "0x36B2AD0", VA = "0x1836B44D0")]
	private void Awake()
	{
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x36B4760", Offset = "0x36B2D60", VA = "0x1836B4760")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x36B48F0", Offset = "0x36B2EF0", VA = "0x1836B48F0")]
	private void Start()
	{
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x36B4A40", Offset = "0x36B3040", VA = "0x1836B4A40")]
	private void Update()
	{
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x36B4A80", Offset = "0x36B3080", VA = "0x1836B4A80")]
	public void AddPlayer(GameObject playerGo)
	{
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x36B4AF0", Offset = "0x36B30F0", VA = "0x1836B4AF0")]
	public void RemovePlayer(GameObject playerGo)
	{
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x36B4B50", Offset = "0x36B3150", VA = "0x1836B4B50")]
	public void AddPlayerEntity(BoltEntity playerEntity)
	{
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x36B4BC0", Offset = "0x36B31C0", VA = "0x1836B4BC0")]
	public void RemovePlayerEntity(BoltEntity playerEntity)
	{
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x36B4C20", Offset = "0x36B3220", VA = "0x1836B4C20")]
	private void CleanupPlayerLists()
	{
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x36B4DE0", Offset = "0x36B33E0", VA = "0x1836B4DE0")]
	public PlayerTracker()
	{
	}

	// Token: 0x040008BB RID: 2235
	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("netPlayer")]
	public GameObject NetPlayer;

	// Token: 0x040008BC RID: 2236
	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("allPlayers")]
	public List<GameObject> AllPlayers;

	// Token: 0x040008BD RID: 2237
	[Token(Token = "0x40008BD")]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("allPlayerEntities")]
	public List<BoltEntity> AllPlayerEntities;

	// Token: 0x040008BE RID: 2238
	[Token(Token = "0x40008BE")]
	[FieldOffset(Offset = "0x0")]
	private static PlayerTracker _instance;
}
