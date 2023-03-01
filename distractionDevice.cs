using System;
using System.Runtime.CompilerServices;
using Bolt;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Items.Core;

// Token: 0x02000114 RID: 276
[Token(Token = "0x2000114")]
[Obsolete]
public class distractionDevice : EntityBehaviour<IDistractionDevice>
{
	// Token: 0x17000108 RID: 264
	// (get) Token: 0x0600082C RID: 2092 RVA: 0x000042F0 File Offset: 0x000024F0
	// (set) Token: 0x0600082D RID: 2093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000108")]
	public static bool IsActive
	{
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x2F477C0", Offset = "0x2F467C0", VA = "0x182F477C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2F47800", Offset = "0x2F46800", VA = "0x182F47800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082E")]
	[Address(RVA = "0x2F473F0", Offset = "0x2F463F0", VA = "0x182F473F0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082F")]
	[Address(RVA = "0x2F47720", Offset = "0x2F46720", VA = "0x182F47720", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000830")]
	[Address(RVA = "0x2F47730", Offset = "0x2F46730", VA = "0x182F47730")]
	private void MusicTrackChanged()
	{
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000831")]
	[Address(RVA = "0x2F472A0", Offset = "0x2F462A0", VA = "0x182F472A0")]
	private void ActivateDevice(EventInstance evt)
	{
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000832")]
	[Address(RVA = "0x2F475F0", Offset = "0x2F465F0", VA = "0x182F475F0")]
	private void DeactivateDevice()
	{
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000833")]
	[Address(RVA = "0x541260", Offset = "0x540260", VA = "0x180541260")]
	private void SetPlayerSfx(PlayerSfx sfx)
	{
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000834")]
	[Address(RVA = "0x2F47720", Offset = "0x2F46720", VA = "0x182F47720")]
	private void OnDespawned()
	{
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000835")]
	[Address(RVA = "0x2F47720", Offset = "0x2F46720", VA = "0x182F47720")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000836")]
	[Address(RVA = "0x2F47780", Offset = "0x2F46780", VA = "0x182F47780")]
	public distractionDevice()
	{
	}

	// Token: 0x0400069E RID: 1694
	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x28")]
	[ItemIdPicker]
	public int _itemId;

	// Token: 0x0400069F RID: 1695
	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x2C")]
	public EquipmentSlot _slot;

	// Token: 0x040006A0 RID: 1696
	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x30")]
	private EventInstance MusicEvent;

	// Token: 0x040006A1 RID: 1697
	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x38")]
	private PlayerSfx playerSfx;
}
