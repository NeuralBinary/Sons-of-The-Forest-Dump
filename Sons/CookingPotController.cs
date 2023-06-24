using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Gameplay.Cooking;
using Sons.Inventory;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.InputSystem;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
[AddComponentMenu("Sons/Items/CookingPotController")]
public class CookingPotController : HeldControllerBase, IItemInstanceModuleConsumer
{
	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600003F RID: 63 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x17000006")]
	public int NumberOfUses
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0xAFF270", Offset = "0xAFD870", VA = "0x180AFF270")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2F663D0", Offset = "0x2F649D0", VA = "0x182F663D0", Slot = "5")]
	public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2F668F0", Offset = "0x2F64EF0", VA = "0x182F668F0", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2F66D10", Offset = "0x2F65310", VA = "0x182F66D10")]
	private void OnVolumeChanged(float currentVolume)
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2F66F20", Offset = "0x2F65520", VA = "0x182F66F20", Slot = "10")]
	public void ModuleRefreshed(ItemInstanceModule module)
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2F67310", Offset = "0x2F65910", VA = "0x182F67310")]
	private void UpdateStewVisuals()
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2F67550", Offset = "0x2F65B50", VA = "0x182F67550")]
	private void OnActivated()
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2F67700", Offset = "0x2F65D00", VA = "0x182F67700")]
	private void OnTryDrink(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2F67940", Offset = "0x2F65F40", VA = "0x182F67940")]
	private void OnDumpOut(InputAction.CallbackContext obj)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2F67AE0", Offset = "0x2F660E0", VA = "0x182F67AE0")]
	private void OnDrinkComplete()
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2F67B20", Offset = "0x2F66120", VA = "0x182F67B20", Slot = "7")]
	public override bool IsItemIdle()
	{
		return default(bool);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2F67C40", Offset = "0x2F66240", VA = "0x182F67C40")]
	private bool IsInInventory()
	{
		return default(bool);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2F67C80", Offset = "0x2F66280", VA = "0x182F67C80")]
	public CookingPotController()
	{
	}

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _emptyVolumeHeight;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float _fullVolumeHeight;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform _liquidSurfaceModel;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Min(0f)]
	private int _numberOfUses;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x80")]
	private VolumeContainerItemInstanceModule _volumeModule;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x88")]
	private CookingPotStewVisuals _stewVisuals;
}
