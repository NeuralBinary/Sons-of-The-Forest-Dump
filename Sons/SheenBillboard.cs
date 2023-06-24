using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Input;
using TheForest.UI;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Token: 0x02000298 RID: 664
[Token(Token = "0x2000298")]
[Obsolete]
public class SheenBillboard : MonoBehaviour, IThreadSafeTask
{
	// Token: 0x060011A9 RID: 4521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x37564F0", Offset = "0x3754AF0", VA = "0x1837564F0")]
	private static Mesh GetSharedQuad()
	{
		return null;
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
	public void SetRigidbody(Rigidbody source)
	{
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x060011AB RID: 4523 RVA: 0x00006468 File Offset: 0x00004668
	// (set) Token: 0x060011AC RID: 4524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700020E")]
	public bool UseFillSprite
	{
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x7282E0", Offset = "0x7268E0", VA = "0x1807282E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011AC")]
		[Address(RVA = "0x7282F0", Offset = "0x7268F0", VA = "0x1807282F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x060011AD RID: 4525 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060011AE RID: 4526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700020F")]
	public DelayedAction FillSpriteAction
	{
		[Token(Token = "0x60011AD")]
		[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x1D4F140", Offset = "0x1D4D740", VA = "0x181D4F140")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x3756670", Offset = "0x3754C70", VA = "0x183756670")]
	public void Awake()
	{
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x2AE23A0", Offset = "0x2AE09A0", VA = "0x182AE23A0")]
	public void SetShowMesh(bool value)
	{
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x3756E60", Offset = "0x3755460", VA = "0x183756E60")]
	private void Start()
	{
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x3756F50", Offset = "0x3755550", VA = "0x183756F50")]
	private void OnDestroy()
	{
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x3756F90", Offset = "0x3755590", VA = "0x183756F90", Slot = "9")]
	public virtual void OnEnable()
	{
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x37572C0", Offset = "0x37558C0", VA = "0x1837572C0", Slot = "10")]
	public virtual void OnDisable()
	{
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x37572D0", Offset = "0x37558D0", VA = "0x1837572D0")]
	public void LateUpdate()
	{
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x37577A0", Offset = "0x3755DA0", VA = "0x1837577A0")]
	private void ShowIcon(bool show)
	{
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x3757AF0", Offset = "0x37560F0", VA = "0x183757AF0")]
	private static void GenerateMesh(Mesh mesh)
	{
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x3758010", Offset = "0x3756610", VA = "0x183758010")]
	public void CheckWsToken2()
	{
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x37580E0", Offset = "0x37566E0", VA = "0x1837580E0")]
	public void CheckWsTokenSafe()
	{
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x3758130", Offset = "0x3756730", VA = "0x183758130")]
	private void WSRegistration()
	{
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x060011BB RID: 4539 RVA: 0x00006480 File Offset: 0x00004680
	// (set) Token: 0x060011BC RID: 4540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000210")]
	public bool ShouldDoMainThreadRefresh
	{
		[Token(Token = "0x60011BB")]
		[Address(RVA = "0x30AECF0", Offset = "0x30AD2F0", VA = "0x1830AECF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60011BC")]
		[Address(RVA = "0x37581E0", Offset = "0x37567E0", VA = "0x1837581E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x37581F0", Offset = "0x37567F0", VA = "0x1837581F0", Slot = "6")]
	public void ThreadedRefresh()
	{
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x3758360", Offset = "0x3756960", VA = "0x183758360", Slot = "7")]
	public void MainThreadRefresh()
	{
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x37583C0", Offset = "0x37569C0", VA = "0x1837583C0", Slot = "8")]
	public string GetTaskName()
	{
		return null;
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x37583F0", Offset = "0x37569F0", VA = "0x1837583F0")]
	public SheenBillboard()
	{
	}

	// Token: 0x0400115E RID: 4446
	[Token(Token = "0x400115E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _dontRender;

	// Token: 0x0400115F RID: 4447
	[Token(Token = "0x400115F")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh QuadMesh;

	// Token: 0x04001160 RID: 4448
	[Token(Token = "0x4001160")]
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("_ambientColor")]
	public Color _ambientLight;

	// Token: 0x04001161 RID: 4449
	[Token(Token = "0x4001161")]
	[FieldOffset(Offset = "0x34")]
	public float ambientIntensity;

	// Token: 0x04001162 RID: 4450
	[Token(Token = "0x4001162")]
	[FieldOffset(Offset = "0x38")]
	public InputSystem.ActionId _action;

	// Token: 0x04001163 RID: 4451
	[Token(Token = "0x4001163")]
	[FieldOffset(Offset = "0x3C")]
	public ActionIcon.SideIconTypes _sideIcon;

	// Token: 0x04001164 RID: 4452
	[Token(Token = "0x4001164")]
	[FieldOffset(Offset = "0x40")]
	public string ActionTextOverride;

	// Token: 0x04001165 RID: 4453
	[Token(Token = "0x4001165")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool _showUiAfterAwakeDelay;

	// Token: 0x04001166 RID: 4454
	[Token(Token = "0x4001166")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _uiAwakeDelay;

	// Token: 0x04001167 RID: 4455
	[Token(Token = "0x4001167")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _disableUiIfPickupIsMoving;

	// Token: 0x04001168 RID: 4456
	[Token(Token = "0x4001168")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Rigidbody _rigidbody;

	// Token: 0x04001169 RID: 4457
	[Token(Token = "0x4001169")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _speed;

	// Token: 0x0400116A RID: 4458
	[Token(Token = "0x400116A")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private bool _showIcon;

	// Token: 0x0400116B RID: 4459
	[Token(Token = "0x400116B")]
	[FieldOffset(Offset = "0x65")]
	[SerializeField]
	private bool _showMesh;

	// Token: 0x0400116C RID: 4460
	[Token(Token = "0x400116C")]
	[FieldOffset(Offset = "0x66")]
	private bool shouldBeEnabled;

	// Token: 0x0400116D RID: 4461
	[Token(Token = "0x400116D")]
	[FieldOffset(Offset = "0x68")]
	private int wsToken;

	// Token: 0x0400116E RID: 4462
	[Token(Token = "0x400116E")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 _position;

	// Token: 0x0400116F RID: 4463
	[Token(Token = "0x400116F")]
	[FieldOffset(Offset = "0x78")]
	private Renderer _render;

	// Token: 0x04001170 RID: 4464
	[Token(Token = "0x4001170")]
	private const float ShowDistance = 10f;

	// Token: 0x04001171 RID: 4465
	[Token(Token = "0x4001171")]
	[FieldOffset(Offset = "0x80")]
	private Texture2D _vrIconCache;

	// Token: 0x04001172 RID: 4466
	[Token(Token = "0x4001172")]
	[FieldOffset(Offset = "0x88")]
	private Transform _ourTransform;

	// Token: 0x04001175 RID: 4469
	[Token(Token = "0x4001175")]
	[FieldOffset(Offset = "0x8")]
	private static int _baseMapID;

	// Token: 0x04001176 RID: 4470
	[Token(Token = "0x4001176")]
	[FieldOffset(Offset = "0xC")]
	private static int _mainTexID;

	// Token: 0x04001177 RID: 4471
	[Token(Token = "0x4001177")]
	[FieldOffset(Offset = "0xA0")]
	private SphericalHarmonicsL2 ambientProbe;

	// Token: 0x04001178 RID: 4472
	[Token(Token = "0x4001178")]
	[FieldOffset(Offset = "0x110")]
	private ActionIcon _actionIcon;

	// Token: 0x04001179 RID: 4473
	[Token(Token = "0x4001179")]
	[FieldOffset(Offset = "0x118")]
	private float _awakeTime;
}
