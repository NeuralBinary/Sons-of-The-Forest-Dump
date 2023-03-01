using System;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
[AddComponentMenu("Sons/Items/CookingPotController")]
public class CookingPotController : HeldControllerBase, IItemInstanceModuleConsumer
{
	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600003E RID: 62 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x17000006")]
	public int NumberOfUses
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x986680", Offset = "0x985680", VA = "0x180986680")]
		get
		{
			return default(int);
		}
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x299E0C0", Offset = "0x299D0C0", VA = "0x18299E0C0")]
	private void OnVolumeChanged(float currentVolume)
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x299DE40", Offset = "0x299CE40", VA = "0x18299DE40", Slot = "10")]
	public void ModuleRefreshed(ItemInstanceModule module)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x299DD70", Offset = "0x299CD70", VA = "0x18299DD70", Slot = "7")]
	public override bool IsItemIdle()
	{
		return default(bool);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x299E1D0", Offset = "0x299D1D0", VA = "0x18299E1D0")]
	public CookingPotController()
	{
	}

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float _emptyVolumeHeight;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float _fullVolumeHeight;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _liquidSurfaceModel;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Min(0f)]
	private int _numberOfUses;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x88")]
	private ItemInstance _itemInstance;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x90")]
	private VolumeContainerItemInstanceModule _volumeModule;
}
