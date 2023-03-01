using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Input;
using TheForest.UI;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Token: 0x020002A3 RID: 675
[Token(Token = "0x20002A3")]
[Obsolete]
public class SheenBillboard : MonoBehaviour, IThreadSafeTask
{
	// Token: 0x0600116A RID: 4458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600116A")]
	[Address(RVA = "0x2FB9590", Offset = "0x2FB8590", VA = "0x182FB9590")]
	private static Mesh GetSharedQuad()
	{
		return null;
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116B")]
	[Address(RVA = "0x5E9630", Offset = "0x5E8630", VA = "0x1805E9630")]
	public void SetRigidbody(Rigidbody source)
	{
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x0600116C RID: 4460 RVA: 0x000061C8 File Offset: 0x000043C8
	// (set) Token: 0x0600116D RID: 4461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000205")]
	public bool UseFillSprite
	{
		[Token(Token = "0x600116C")]
		[Address(RVA = "0x6743F0", Offset = "0x6733F0", VA = "0x1806743F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x674510", Offset = "0x673510", VA = "0x180674510")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x0600116E RID: 4462 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600116F RID: 4463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000206")]
	public DelayedAction FillSpriteAction
	{
		[Token(Token = "0x600116E")]
		[Address(RVA = "0x6AC8B0", Offset = "0x6AB8B0", VA = "0x1806AC8B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600116F")]
		[Address(RVA = "0x1A52F60", Offset = "0x1A51F60", VA = "0x181A52F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001170")]
	[Address(RVA = "0x2FB8B70", Offset = "0x2FB7B70", VA = "0x182FB8B70")]
	public void Awake()
	{
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001171")]
	[Address(RVA = "0x2FB9BB0", Offset = "0x2FB8BB0", VA = "0x182FB9BB0")]
	public void SetShowMesh(bool value)
	{
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001172")]
	[Address(RVA = "0x2FB9DC0", Offset = "0x2FB8DC0", VA = "0x182FB9DC0")]
	private void Start()
	{
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001173")]
	[Address(RVA = "0x2FB9980", Offset = "0x2FB8980", VA = "0x182FB9980")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001174")]
	[Address(RVA = "0x2FB99D0", Offset = "0x2FB89D0", VA = "0x182FB99D0", Slot = "9")]
	public virtual void OnEnable()
	{
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001175")]
	[Address(RVA = "0x2FB99C0", Offset = "0x2FB89C0", VA = "0x182FB99C0", Slot = "10")]
	public virtual void OnDisable()
	{
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001176")]
	[Address(RVA = "0x2FB96A0", Offset = "0x2FB86A0", VA = "0x182FB96A0")]
	public void LateUpdate()
	{
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001177")]
	[Address(RVA = "0x2FB9BC0", Offset = "0x2FB8BC0", VA = "0x182FB9BC0")]
	private void ShowIcon(bool show)
	{
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001178")]
	[Address(RVA = "0x2FB9130", Offset = "0x2FB8130", VA = "0x182FB9130")]
	private static void GenerateMesh(Mesh mesh)
	{
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001179")]
	[Address(RVA = "0x2FB9000", Offset = "0x2FB8000", VA = "0x182FB9000")]
	public void CheckWsToken2()
	{
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117A")]
	[Address(RVA = "0x2FB90B0", Offset = "0x2FB80B0", VA = "0x182FB90B0")]
	public void CheckWsTokenSafe()
	{
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117B")]
	[Address(RVA = "0x2FB9FF0", Offset = "0x2FB8FF0", VA = "0x182FB9FF0")]
	private void WSRegistration()
	{
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x0600117C RID: 4476 RVA: 0x000061E0 File Offset: 0x000043E0
	// (set) Token: 0x0600117D RID: 4477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000207")]
	public bool ShouldDoMainThreadRefresh
	{
		[Token(Token = "0x600117C")]
		[Address(RVA = "0x2FBA0B0", Offset = "0x2FB90B0", VA = "0x182FBA0B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600117D")]
		[Address(RVA = "0x2FBA0C0", Offset = "0x2FB90C0", VA = "0x182FBA0C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117E")]
	[Address(RVA = "0x2FB9E50", Offset = "0x2FB8E50", VA = "0x182FB9E50", Slot = "6")]
	public void ThreadedRefresh()
	{
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117F")]
	[Address(RVA = "0x2FB9970", Offset = "0x2FB8970", VA = "0x182FB9970", Slot = "7")]
	public void MainThreadRefresh()
	{
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001180")]
	[Address(RVA = "0x2FB9670", Offset = "0x2FB8670", VA = "0x182FB9670", Slot = "8")]
	public string GetTaskName()
	{
		return null;
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001181")]
	[Address(RVA = "0x2FBA040", Offset = "0x2FB9040", VA = "0x182FBA040")]
	public SheenBillboard()
	{
	}

	// Token: 0x04001137 RID: 4407
	[Token(Token = "0x4001137")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _dontRender;

	// Token: 0x04001138 RID: 4408
	[Token(Token = "0x4001138")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh QuadMesh;

	// Token: 0x04001139 RID: 4409
	[Token(Token = "0x4001139")]
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("_ambientColor")]
	public Color _ambientLight;

	// Token: 0x0400113A RID: 4410
	[Token(Token = "0x400113A")]
	[FieldOffset(Offset = "0x34")]
	public float ambientIntensity;

	// Token: 0x0400113B RID: 4411
	[Token(Token = "0x400113B")]
	[FieldOffset(Offset = "0x38")]
	public InputSystem.ActionId _action;

	// Token: 0x0400113C RID: 4412
	[Token(Token = "0x400113C")]
	[FieldOffset(Offset = "0x3C")]
	public ActionIcon.SideIconTypes _sideIcon;

	// Token: 0x0400113D RID: 4413
	[Token(Token = "0x400113D")]
	[FieldOffset(Offset = "0x40")]
	public string ActionTextOverride;

	// Token: 0x0400113E RID: 4414
	[Token(Token = "0x400113E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _showUiAfterAwakeDelay;

	// Token: 0x0400113F RID: 4415
	[Token(Token = "0x400113F")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _uiAwakeDelay;

	// Token: 0x04001140 RID: 4416
	[Token(Token = "0x4001140")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _disableUiIfPickupIsMoving;

	// Token: 0x04001141 RID: 4417
	[Token(Token = "0x4001141")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Rigidbody _rigidbody;

	// Token: 0x04001142 RID: 4418
	[Token(Token = "0x4001142")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _speed;

	// Token: 0x04001143 RID: 4419
	[Token(Token = "0x4001143")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private bool _showIcon;

	// Token: 0x04001144 RID: 4420
	[Token(Token = "0x4001144")]
	[FieldOffset(Offset = "0x65")]
	[SerializeField]
	private bool _showMesh;

	// Token: 0x04001145 RID: 4421
	[Token(Token = "0x4001145")]
	[FieldOffset(Offset = "0x66")]
	private bool shouldBeEnabled;

	// Token: 0x04001146 RID: 4422
	[Token(Token = "0x4001146")]
	[FieldOffset(Offset = "0x68")]
	private int wsToken;

	// Token: 0x04001147 RID: 4423
	[Token(Token = "0x4001147")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 _position;

	// Token: 0x04001148 RID: 4424
	[Token(Token = "0x4001148")]
	[FieldOffset(Offset = "0x78")]
	private Renderer _render;

	// Token: 0x04001149 RID: 4425
	[Token(Token = "0x4001149")]
	private const float ShowDistance = 10f;

	// Token: 0x0400114A RID: 4426
	[Token(Token = "0x400114A")]
	[FieldOffset(Offset = "0x80")]
	private Texture2D _vrIconCache;

	// Token: 0x0400114B RID: 4427
	[Token(Token = "0x400114B")]
	[FieldOffset(Offset = "0x88")]
	private Transform _ourTransform;

	// Token: 0x0400114E RID: 4430
	[Token(Token = "0x400114E")]
	[FieldOffset(Offset = "0x8")]
	private static int _baseMapID;

	// Token: 0x0400114F RID: 4431
	[Token(Token = "0x400114F")]
	[FieldOffset(Offset = "0xC")]
	private static int _mainTexID;

	// Token: 0x04001150 RID: 4432
	[Token(Token = "0x4001150")]
	[FieldOffset(Offset = "0xA0")]
	private SphericalHarmonicsL2 ambientProbe;

	// Token: 0x04001151 RID: 4433
	[Token(Token = "0x4001151")]
	[FieldOffset(Offset = "0x110")]
	private ActionIcon _actionIcon;

	// Token: 0x04001152 RID: 4434
	[Token(Token = "0x4001152")]
	[FieldOffset(Offset = "0x118")]
	private float _awakeTime;
}
