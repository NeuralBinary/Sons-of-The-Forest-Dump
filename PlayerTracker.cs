using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000152 RID: 338
[Token(Token = "0x2000152")]
public class PlayerTracker : MonoBehaviour
{
	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000142")]
	public static PlayerTracker Instance
	{
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x2F4B340", Offset = "0x2F4A340", VA = "0x182F4B340")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00004848 File Offset: 0x00002A48
	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x2F4AF40", Offset = "0x2F49F40", VA = "0x182F4AF40")]
	public static int GetPlayerCount()
	{
		return default(int);
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x2F4ACC0", Offset = "0x2F49CC0", VA = "0x182F4ACC0")]
	private void Awake()
	{
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x2F4B050", Offset = "0x2F4A050", VA = "0x182F4B050")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x2F4B1C0", Offset = "0x2F4A1C0", VA = "0x182F4B1C0")]
	private void Start()
	{
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x2F4B240", Offset = "0x2F4A240", VA = "0x182F4B240")]
	private void Update()
	{
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x2F4ABE0", Offset = "0x2F49BE0", VA = "0x182F4ABE0")]
	public void AddPlayer(GameObject playerGo)
	{
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x2F4B160", Offset = "0x2F4A160", VA = "0x182F4B160")]
	public void RemovePlayer(GameObject playerGo)
	{
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x2F4AB00", Offset = "0x2F49B00", VA = "0x182F4AB00")]
	public void AddPlayerEntity(BoltEntity playerEntity)
	{
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x2F4B100", Offset = "0x2F4A100", VA = "0x182F4B100")]
	public void RemovePlayerEntity(BoltEntity playerEntity)
	{
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x2F4ADF0", Offset = "0x2F49DF0", VA = "0x182F4ADF0")]
	private void CleanupPlayerLists()
	{
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A15")]
	[Address(RVA = "0x2F4B280", Offset = "0x2F4A280", VA = "0x182F4B280")]
	public PlayerTracker()
	{
	}

	// Token: 0x0400089A RID: 2202
	[Token(Token = "0x400089A")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("netPlayer")]
	public GameObject NetPlayer;

	// Token: 0x0400089B RID: 2203
	[Token(Token = "0x400089B")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("allPlayers")]
	public List<GameObject> AllPlayers;

	// Token: 0x0400089C RID: 2204
	[Token(Token = "0x400089C")]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("allPlayerEntities")]
	public List<BoltEntity> AllPlayerEntities;

	// Token: 0x0400089D RID: 2205
	[Token(Token = "0x400089D")]
	[FieldOffset(Offset = "0x0")]
	private static PlayerTracker _instance;
}
