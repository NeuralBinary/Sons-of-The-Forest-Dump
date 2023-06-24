using System;
using System.Runtime.CompilerServices;
using Bolt;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Items.Core;

// Token: 0x02000111 RID: 273
[Token(Token = "0x2000111")]
[Obsolete]
public class distractionDevice : EntityBehaviour<IDistractionDevice>
{
	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000873 RID: 2163 RVA: 0x00004500 File Offset: 0x00002700
	// (set) Token: 0x06000874 RID: 2164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000110")]
	public static bool IsActive
	{
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x3687FC0", Offset = "0x36865C0", VA = "0x183687FC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x3688000", Offset = "0x3686600", VA = "0x183688000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000875")]
	[Address(RVA = "0x3688040", Offset = "0x3686640", VA = "0x183688040", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000876")]
	[Address(RVA = "0x36881E0", Offset = "0x36867E0", VA = "0x1836881E0", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000877")]
	[Address(RVA = "0x36881F0", Offset = "0x36867F0", VA = "0x1836881F0")]
	private void MusicTrackChanged()
	{
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000878")]
	[Address(RVA = "0x3688280", Offset = "0x3686880", VA = "0x183688280")]
	private void ActivateDevice(EventInstance evt)
	{
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000879")]
	[Address(RVA = "0x36884A0", Offset = "0x3686AA0", VA = "0x1836884A0")]
	private void DeactivateDevice()
	{
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087A")]
	[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
	private void SetPlayerSfx(PlayerSfx sfx)
	{
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087B")]
	[Address(RVA = "0x36881E0", Offset = "0x36867E0", VA = "0x1836881E0")]
	private void OnDespawned()
	{
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087C")]
	[Address(RVA = "0x36881E0", Offset = "0x36867E0", VA = "0x1836881E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087D")]
	[Address(RVA = "0x3688630", Offset = "0x3686C30", VA = "0x183688630")]
	public distractionDevice()
	{
	}

	// Token: 0x040006BA RID: 1722
	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x28")]
	[ItemIdPicker]
	public int _itemId;

	// Token: 0x040006BB RID: 1723
	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x2C")]
	public EquipmentSlot _slot;

	// Token: 0x040006BC RID: 1724
	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x30")]
	private EventInstance MusicEvent;

	// Token: 0x040006BD RID: 1725
	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x38")]
	private PlayerSfx playerSfx;
}
