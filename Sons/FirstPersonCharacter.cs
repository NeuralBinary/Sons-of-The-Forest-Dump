using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Utilities.Timer;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Environment;
using Sons.Physics;
using TheForest.Utils.Physics;
using TheForest.VR;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000223 RID: 547
[Token(Token = "0x2000223")]
public class FirstPersonCharacter : MonoBehaviour, IOnCollisionEnterProxy, IOnCollisionStayProxy, IEnvironmentWetnessReceiver
{
	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00005850 File Offset: 0x00003A50
	[Token(Token = "0x170001A8")]
	public bool IsInMidAction
	{
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x2FC3F80", Offset = "0x2FC2580", VA = "0x182FC3F80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00005868 File Offset: 0x00003A68
	[Token(Token = "0x170001A9")]
	public bool BlockFullBodyInteraction
	{
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x2FC3F90", Offset = "0x2FC2590", VA = "0x182FC3F90")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x371C620", Offset = "0x371AC20", VA = "0x18371C620")]
	public void SetBlockFullBodyInteraction(bool value)
	{
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x371C630", Offset = "0x371AC30", VA = "0x18371C630")]
	public void SetIsInMidAction(bool value)
	{
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00005880 File Offset: 0x00003A80
	// (set) Token: 0x06000EB5 RID: 3765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AA")]
	public bool IsCrouchActive
	{
		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x2B98900", Offset = "0x2B96F00", VA = "0x182B98900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x3333E70", Offset = "0x3332470", VA = "0x183333E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x00005898 File Offset: 0x00003A98
	// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AB")]
	public bool BlockCrouch
	{
		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x30AEC60", Offset = "0x30AD260", VA = "0x1830AEC60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x30B0E90", Offset = "0x30AF490", VA = "0x1830B0E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1400000F RID: 15
	// (add) Token: 0x06000EB8 RID: 3768 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000EB9 RID: 3769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1400000F")]
	public event Action<Vector2> OnInputMovementChanged
	{
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x371C7C0", Offset = "0x371ADC0", VA = "0x18371C7C0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x371C930", Offset = "0x371AF30", VA = "0x18371C930")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06000EBA RID: 3770 RVA: 0x000058B0 File Offset: 0x00003AB0
	// (set) Token: 0x06000EBB RID: 3771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AC")]
	public bool Grounded
	{
		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0x623AB0", Offset = "0x6220B0", VA = "0x180623AB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x371CAA0", Offset = "0x371B0A0", VA = "0x18371CAA0")]
		private set
		{
		}
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06000EBC RID: 3772 RVA: 0x000058C8 File Offset: 0x00003AC8
	// (set) Token: 0x06000EBD RID: 3773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AD")]
	private int CurrentFixedFrame
	{
		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x371CAD0", Offset = "0x371B0D0", VA = "0x18371CAD0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0x371CAE0", Offset = "0x371B0E0", VA = "0x18371CAE0")]
		set
		{
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06000EBE RID: 3774 RVA: 0x000058E0 File Offset: 0x00003AE0
	// (set) Token: 0x06000EBF RID: 3775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AE")]
	public int GroundedFrame
	{
		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0x371CAF0", Offset = "0x371B0F0", VA = "0x18371CAF0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x371CB00", Offset = "0x371B100", VA = "0x18371CB00")]
		private set
		{
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x000058F8 File Offset: 0x00003AF8
	// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AF")]
	public float LandingVelocityY
	{
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x371CB10", Offset = "0x371B110", VA = "0x18371CB10")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x371CB20", Offset = "0x371B120", VA = "0x18371CB20")]
		private set
		{
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00005910 File Offset: 0x00003B10
	[Token(Token = "0x170001B0")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x371CB30", Offset = "0x371B130", VA = "0x18371CB30")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00005928 File Offset: 0x00003B28
	// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B1")]
	public bool Sitting
	{
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x371CB50", Offset = "0x371B150", VA = "0x18371CB50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x371CB60", Offset = "0x371B160", VA = "0x18371CB60")]
		set
		{
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00005940 File Offset: 0x00003B40
	// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B2")]
	public bool MovementLocked
	{
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x371CB70", Offset = "0x371B170", VA = "0x18371CB70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x371CB80", Offset = "0x371B180", VA = "0x18371CB80")]
		set
		{
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00005958 File Offset: 0x00003B58
	[Token(Token = "0x170001B3")]
	public bool IsRunSpeedActive
	{
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x371CB90", Offset = "0x371B190", VA = "0x18371CB90")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00005970 File Offset: 0x00003B70
	[Token(Token = "0x170001B4")]
	public bool IsRunning
	{
		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x371CBA0", Offset = "0x371B1A0", VA = "0x18371CBA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00005988 File Offset: 0x00003B88
	[Token(Token = "0x170001B5")]
	public bool IsRunInputActive
	{
		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x2A1FB00", Offset = "0x2A1E100", VA = "0x182A1FB00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06000ECA RID: 3786 RVA: 0x000059A0 File Offset: 0x00003BA0
	[Token(Token = "0x170001B6")]
	public bool CanRun
	{
		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x623B00", Offset = "0x622100", VA = "0x180623B00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06000ECB RID: 3787 RVA: 0x000059B8 File Offset: 0x00003BB8
	[Token(Token = "0x170001B7")]
	public float RunSpeedMultiplier
	{
		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x371CBB0", Offset = "0x371B1B0", VA = "0x18371CBB0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000ECD RID: 3789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B8")]
	public PhysicMaterial PlayerPhysicMaterial
	{
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x371CBC0", Offset = "0x371B1C0", VA = "0x18371CBC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x371CBD0", Offset = "0x371B1D0", VA = "0x18371CBD0")]
		private set
		{
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06000ECE RID: 3790 RVA: 0x000059D0 File Offset: 0x00003BD0
	// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B9")]
	public float recoveringFromRun
	{
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x3367FB0", Offset = "0x33665B0", VA = "0x183367FB0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x371CC30", Offset = "0x371B230", VA = "0x18371CC30")]
		set
		{
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x000059E8 File Offset: 0x00003BE8
	[Token(Token = "0x170001BA")]
	public float WalkSpeed
	{
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00005A00 File Offset: 0x00003C00
	[Token(Token = "0x170001BB")]
	public float RunSpeed
	{
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00005A18 File Offset: 0x00003C18
	[Token(Token = "0x170001BC")]
	public float SwimSpeed
	{
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00005A30 File Offset: 0x00003C30
	[Token(Token = "0x170001BD")]
	public float StrafeSpeed
	{
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00005A48 File Offset: 0x00003C48
	// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001BE")]
	public float JumpMultiplier
	{
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x371CC40", Offset = "0x371B240", VA = "0x18371CC40")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x371CC50", Offset = "0x371B250", VA = "0x18371CC50")]
		private set
		{
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x00005A60 File Offset: 0x00003C60
	[Token(Token = "0x170001BF")]
	public bool JumpTriggered
	{
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x371CC60", Offset = "0x371B260", VA = "0x18371CC60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00005A78 File Offset: 0x00003C78
	// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C0")]
	public bool IsJumping
	{
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x371CCA0", Offset = "0x371B2A0", VA = "0x18371CCA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x371CCB0", Offset = "0x371B2B0", VA = "0x18371CCB0")]
		set
		{
		}
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x2AE23B0", Offset = "0x2AE09B0", VA = "0x182AE23B0")]
	public void SetAllowJump(bool value)
	{
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00005A90 File Offset: 0x00003C90
	[Token(Token = "0x170001C1")]
	public bool CanJump
	{
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x2A88DE0", Offset = "0x2A873E0", VA = "0x182A88DE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0x371CCC0", Offset = "0x371B2C0", VA = "0x18371CCC0")]
	public void SetCanJump(bool value)
	{
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x371CCE0", Offset = "0x371B2E0", VA = "0x18371CCE0")]
	private void Awake()
	{
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0x371CFF0", Offset = "0x371B5F0", VA = "0x18371CFF0")]
	private void Start()
	{
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x371D5E0", Offset = "0x371BBE0", VA = "0x18371D5E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0x371D650", Offset = "0x371BC50", VA = "0x18371D650")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x371D650", Offset = "0x371BC50", VA = "0x18371D650")]
	private void ClearSubFixedFrameCount()
	{
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x371D760", Offset = "0x371BD60", VA = "0x18371D760")]
	private void Update()
	{
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00005AA8 File Offset: 0x00003CA8
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x371E370", Offset = "0x371C970", VA = "0x18371E370")]
	private static bool IsConnectedToLogSled()
	{
		return default(bool);
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00005AC0 File Offset: 0x00003CC0
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x371E3C0", Offset = "0x371C9C0", VA = "0x18371E3C0")]
	private float GroundAngleSlideFactor()
	{
		return 0f;
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x371E470", Offset = "0x371CA70", VA = "0x18371E470")]
	private void OnJumpInput(bool applyJumpVel)
	{
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00005AD8 File Offset: 0x00003CD8
	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0x371E860", Offset = "0x371CE60", VA = "0x18371E860")]
	private bool CanCrouch()
	{
		return default(bool);
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0x371E940", Offset = "0x371CF40", VA = "0x18371E940")]
	public void StandUp()
	{
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0x371E940", Offset = "0x371CF40", VA = "0x18371E940")]
	private void TriggerDisableCrouch()
	{
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0x371E9A0", Offset = "0x371CFA0", VA = "0x18371E9A0")]
	public void SetEnabled(bool isEnabled)
	{
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x371EA60", Offset = "0x371D060", VA = "0x18371EA60")]
	private void HandleSwimmingJumpInput(bool jumpInput)
	{
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x371ED80", Offset = "0x371D380", VA = "0x18371ED80")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x371FBF0", Offset = "0x371E1F0", VA = "0x18371FBF0")]
	private void CheckGroundedSwimmingChange()
	{
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x371FC50", Offset = "0x371E250", VA = "0x18371FC50")]
	private void OnEnable()
	{
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x371FE50", Offset = "0x371E450", VA = "0x18371FE50")]
	private void UpdateStepHelper(Vector2 obj)
	{
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x371FF40", Offset = "0x371E540", VA = "0x18371FF40")]
	private void OnDisable()
	{
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x3720540", Offset = "0x371EB40", VA = "0x183720540", Slot = "6")]
	public void UpdateWetness(float wetness)
	{
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0x3720560", Offset = "0x371EB60", VA = "0x183720560", Slot = "4")]
	public void OnCollisionEnterProxied(Collision coll)
	{
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF1")]
	[Address(RVA = "0x37209D0", Offset = "0x371EFD0", VA = "0x1837209D0", Slot = "5")]
	public void OnCollisionStayProxied(Collision col)
	{
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
	public void SetWalkSpeed(float value)
	{
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
	public void SetRunSpeed(float value)
	{
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0x2D63590", Offset = "0x2D61B90", VA = "0x182D63590")]
	public void SetSwimSpeed(float value)
	{
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0x3268B10", Offset = "0x3267110", VA = "0x183268B10")]
	public void SetDisabledGravity(bool value)
	{
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00005AF0 File Offset: 0x00003CF0
	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0x3721560", Offset = "0x371FB60", VA = "0x183721560")]
	public bool IsPrimaryCollider(Collider source)
	{
		return default(bool);
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00005B08 File Offset: 0x00003D08
	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0x3721590", Offset = "0x371FB90", VA = "0x183721590")]
	public Bounds GetPrimaryColliderBounds()
	{
		return default(Bounds);
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00005B20 File Offset: 0x00003D20
	[Token(Token = "0x6000EF8")]
	[Address(RVA = "0x3721630", Offset = "0x371FC30", VA = "0x183721630")]
	public Bounds GetHeadColliderBounds()
	{
		return default(Bounds);
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x00005B38 File Offset: 0x00003D38
	[Token(Token = "0x6000EF9")]
	[Address(RVA = "0x37216D0", Offset = "0x371FCD0", VA = "0x1837216D0")]
	public float GetPrimaryColliderHeight()
	{
		return 0f;
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00005B50 File Offset: 0x00003D50
	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0x3721730", Offset = "0x371FD30", VA = "0x183721730")]
	public Vector3 GetPrimaryColliderCenter()
	{
		return default(Vector3);
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00005B68 File Offset: 0x00003D68
	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0x37217C0", Offset = "0x371FDC0", VA = "0x1837217C0")]
	private float GetPrimaryColliderRadius()
	{
		return 0f;
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0x3721820", Offset = "0x371FE20", VA = "0x183721820")]
	private void SetupCollision()
	{
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFD")]
	[Address(RVA = "0x3721AF0", Offset = "0x37200F0", VA = "0x183721AF0")]
	public void IgnoreCollision(Collider source)
	{
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFE")]
	[Address(RVA = "0x3721B70", Offset = "0x3720170", VA = "0x183721B70")]
	public void ApplyCrouchPrimaryCollider()
	{
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EFF")]
	[Address(RVA = "0x3721C20", Offset = "0x3720220", VA = "0x183721C20")]
	public void ResetPrimaryColliderHeight()
	{
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F00")]
	[Address(RVA = "0x3721C30", Offset = "0x3720230", VA = "0x183721C30")]
	public void SetPrimaryCollider(Vector3 center, float height)
	{
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F01")]
	[Address(RVA = "0x3721CC0", Offset = "0x37202C0", VA = "0x183721CC0")]
	public void SetPrimaryCollider(bool enabledValue)
	{
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F02")]
	[Address(RVA = "0x3722060", Offset = "0x3720660", VA = "0x183722060")]
	private void SetStepHelperEnabled(bool enabledValue)
	{
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F03")]
	[Address(RVA = "0x3722080", Offset = "0x3720680", VA = "0x183722080")]
	private void UpdateStepHelperEnabled()
	{
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F04")]
	[Address(RVA = "0x3722270", Offset = "0x3720870", VA = "0x183722270")]
	private void SetPrimaryColliderHeight(float height)
	{
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x00005B80 File Offset: 0x00003D80
	[Token(Token = "0x6000F05")]
	[Address(RVA = "0x37222E0", Offset = "0x37208E0", VA = "0x1837222E0")]
	private static bool IsSet(float value)
	{
		return default(bool);
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F06")]
	[Address(RVA = "0x3722300", Offset = "0x3720900", VA = "0x183722300")]
	public void SetHeadColliderCenter(float xPos = float.NaN, float yPos = float.NaN, float zPos = float.NaN)
	{
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F07")]
	[Address(RVA = "0x3722370", Offset = "0x3720970", VA = "0x183722370")]
	public void SetPrimaryColliderCenter(Vector3 center)
	{
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F08")]
	[Address(RVA = "0x37223F0", Offset = "0x37209F0", VA = "0x1837223F0")]
	public void ResetPrimaryColliderCenter(bool xPos = false, bool yPos = false, bool zPos = false)
	{
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F09")]
	[Address(RVA = "0x3722580", Offset = "0x3720B80", VA = "0x183722580")]
	private void UpdateRun()
	{
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F0A")]
	[Address(RVA = "0x37227A0", Offset = "0x3720DA0", VA = "0x1837227A0")]
	public void SpawnStepNoiseStimuli()
	{
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x00005B98 File Offset: 0x00003D98
	[Token(Token = "0x6000F0B")]
	[Address(RVA = "0x37228E0", Offset = "0x3720EE0", VA = "0x1837228E0")]
	private bool IsCrouchHeightBlocked(float standingUpHeight, Vector3 position)
	{
		return default(bool);
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x00005BB0 File Offset: 0x00003DB0
	[Token(Token = "0x6000F0C")]
	[Address(RVA = "0x3722A80", Offset = "0x3721080", VA = "0x183722A80")]
	private static bool GetStandUpInput()
	{
		return default(bool);
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x00005BC8 File Offset: 0x00003DC8
	[Token(Token = "0x6000F0D")]
	[Address(RVA = "0x3722BC0", Offset = "0x37211C0", VA = "0x183722BC0")]
	private static bool GetCrouchInput()
	{
		return default(bool);
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x00005BE0 File Offset: 0x00003DE0
	[Token(Token = "0x6000F0E")]
	[Address(RVA = "0x3722C50", Offset = "0x3721250", VA = "0x183722C50")]
	public static bool GetJumpInput()
	{
		return default(bool);
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F0F")]
	[Address(RVA = "0x3722D10", Offset = "0x3721310", VA = "0x183722D10")]
	public void disableToggledCrouch()
	{
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F10")]
	[Address(RVA = "0x3722D60", Offset = "0x3721360", VA = "0x183722D60")]
	private void CheckStandingOnExtremeSlope()
	{
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F11")]
	[Address(RVA = "0x3722DE0", Offset = "0x37213E0", VA = "0x183722DE0")]
	private void HandleFrictionParams()
	{
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F12")]
	[Address(RVA = "0x3723010", Offset = "0x3721610", VA = "0x183723010")]
	private void UpdatePlayerPhysics(float staticFriction, float dynamicFriction, PhysicMaterialCombine materialCombine, float bounciness = 0f, PhysicMaterialCombine bounceMaterialCombine = PhysicMaterialCombine.Minimum)
	{
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F13")]
	[Address(RVA = "0x37233B0", Offset = "0x37219B0", VA = "0x1837233B0")]
	private void UpdateSleddingFriction()
	{
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F14")]
	[Address(RVA = "0x3723480", Offset = "0x3721A80", VA = "0x183723480")]
	private void HandleStartJumping()
	{
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00005BF8 File Offset: 0x00003DF8
	[Token(Token = "0x6000F15")]
	[Address(RVA = "0x3723660", Offset = "0x3721C60", VA = "0x183723660")]
	private Vector3 GetTargetVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00005C10 File Offset: 0x00003E10
	[Token(Token = "0x6000F16")]
	[Address(RVA = "0x3723970", Offset = "0x3721F70", VA = "0x183723970")]
	private Vector3 DetermineVelocityChange()
	{
		return default(Vector3);
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00005C28 File Offset: 0x00003E28
	[Token(Token = "0x6000F17")]
	[Address(RVA = "0x3723B60", Offset = "0x3722160", VA = "0x183723B60")]
	private Vector2 GetMovementInput()
	{
		return default(Vector2);
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F18")]
	[Address(RVA = "0x3723B80", Offset = "0x3722180", VA = "0x183723B80")]
	private void HandleSwimmingSpeed(Vector3 velocityChange)
	{
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F19")]
	[Address(RVA = "0x3723DB0", Offset = "0x37223B0", VA = "0x183723DB0")]
	private void ClampSwimVelocity()
	{
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1A")]
	[Address(RVA = "0x3723FD0", Offset = "0x37225D0", VA = "0x183723FD0")]
	private void ClampVelocity()
	{
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0x3724220", Offset = "0x3722820", VA = "0x183724220")]
	private void ApplyGroundingForce()
	{
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1C")]
	[Address(RVA = "0x37243E0", Offset = "0x37229E0", VA = "0x1837243E0")]
	private void HandleJumpSpeed(Vector3 velocityChange)
	{
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0x3724B30", Offset = "0x3723130", VA = "0x183724B30")]
	private void HandleRunningStaminaAndSpeed()
	{
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0x3724F50", Offset = "0x3723550", VA = "0x183724F50")]
	public void ApplyRunStaminaCost()
	{
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0x3725090", Offset = "0x3723690", VA = "0x183725090")]
	private void HandleWalkingSpeedOptions()
	{
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F20")]
	[Address(RVA = "0x3725250", Offset = "0x3723850", VA = "0x183725250")]
	private void ApplySwimmingForce()
	{
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F21")]
	[Address(RVA = "0x3725730", Offset = "0x3723D30", VA = "0x183725730")]
	private void StabilizeSwimmingForce(float normVal)
	{
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x3725900", Offset = "0x3723F00", VA = "0x183725900")]
	private void RbAddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
	{
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F23")]
	[Address(RVA = "0x3725A30", Offset = "0x3724030", VA = "0x183725A30")]
	private void ResetVariables()
	{
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F24")]
	[Address(RVA = "0x36B0100", Offset = "0x36AE700", VA = "0x1836B0100")]
	private void DisableAllowJump()
	{
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F25")]
	[Address(RVA = "0x3725AD0", Offset = "0x37240D0", VA = "0x183725AD0")]
	private void SetGroundedParams(Collision col)
	{
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F26")]
	[Address(RVA = "0x3725DB0", Offset = "0x37243B0", VA = "0x183725DB0")]
	private void resetJumpInputBlock()
	{
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F27")]
	[Address(RVA = "0x3725DC0", Offset = "0x37243C0", VA = "0x183725DC0")]
	private void StickToGroundHelper()
	{
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F28")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void ResetRotations()
	{
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00005C40 File Offset: 0x00003E40
	[Token(Token = "0x6000F29")]
	[Address(RVA = "0x37262A0", Offset = "0x37248A0", VA = "0x1837262A0")]
	private float CalculateJumpVerticalSpeed()
	{
		return 0f;
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x00005C58 File Offset: 0x00003E58
	[Token(Token = "0x6000F2A")]
	[Address(RVA = "0x3726370", Offset = "0x3724970", VA = "0x183726370")]
	private float CalculateWaterJumpVerticalSpeed()
	{
		return 0f;
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2B")]
	[Address(RVA = "0x3726390", Offset = "0x3724990", VA = "0x183726390")]
	public void ScaleCapsuleForCrouching(float alpha)
	{
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2C")]
	[Address(RVA = "0x3726680", Offset = "0x3724C80", VA = "0x183726680")]
	private void ResetCapsule()
	{
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F2D")]
	[Address(RVA = "0x3726690", Offset = "0x3724C90", VA = "0x183726690")]
	private IEnumerator EnableCrouch()
	{
		return null;
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0x3726720", Offset = "0x3724D20", VA = "0x183726720")]
	private IEnumerator DisableCrouch()
	{
		return null;
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0x37267B0", Offset = "0x3724DB0", VA = "0x1837267B0")]
	public void StopCrouch()
	{
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F30")]
	[Address(RVA = "0x3726900", Offset = "0x3724F00", VA = "0x183726900")]
	private void ClearCrouchInternal(bool updateRun = true)
	{
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x00005C70 File Offset: 0x00003E70
	[Token(Token = "0x6000F31")]
	[Address(RVA = "0x3726A20", Offset = "0x3725020", VA = "0x183726A20")]
	private bool IsChainSawAttack()
	{
		return default(bool);
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F32")]
	[Address(RVA = "0x3726AC0", Offset = "0x37250C0", VA = "0x183726AC0")]
	public void LockView(bool rigidbodyLock = true, bool ignoreGrounded = false, bool showMouse = true)
	{
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F33")]
	[Address(RVA = "0x3726C50", Offset = "0x3725250", VA = "0x183726C50")]
	public void UnLockView()
	{
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F34")]
	[Address(RVA = "0x3726DB0", Offset = "0x37253B0", VA = "0x183726DB0")]
	public void enablePaddleOnRaft(bool set)
	{
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x00005C88 File Offset: 0x00003E88
	[Token(Token = "0x6000F35")]
	[Address(RVA = "0x3726E10", Offset = "0x3725410", VA = "0x183726E10")]
	public float CalculateWaterDepthParameter()
	{
		return 0f;
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x00005CA0 File Offset: 0x00003EA0
	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x37270C0", Offset = "0x37256C0", VA = "0x1837270C0")]
	public float CalculateSpeedParameter(float flatVelocity)
	{
		return 0f;
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x3727140", Offset = "0x3725740", VA = "0x183727140")]
	private void EnableAnimatorJumpBool()
	{
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F38")]
	[Address(RVA = "0x3727150", Offset = "0x3725750", VA = "0x183727150")]
	public void SetAnimatorJumpBool(bool value)
	{
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F39")]
	[Address(RVA = "0x3727210", Offset = "0x3725810", VA = "0x183727210")]
	private void resetAnimSpine()
	{
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void allowJumpingAttack()
	{
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void blockJumpAttack()
	{
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3C")]
	[Address(RVA = "0x3727260", Offset = "0x3725860", VA = "0x183727260")]
	private IEnumerator smoothEnableSpine()
	{
		return null;
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x37272F0", Offset = "0x37258F0", VA = "0x1837272F0")]
	public void resetPhysicMaterial()
	{
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0x37274C0", Offset = "0x3725AC0", VA = "0x1837274C0")]
	private void disableHighDrag()
	{
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0x37274D0", Offset = "0x3725AD0", VA = "0x1837274D0")]
	private IEnumerator DoForceStopRun()
	{
		return null;
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x3727560", Offset = "0x3725B60", VA = "0x183727560")]
	private IEnumerator DisconnectedSledRoutine()
	{
		return null;
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x37275F0", Offset = "0x3725BF0", VA = "0x1837275F0")]
	public void RestartJumpTimer()
	{
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F42")]
	[Address(RVA = "0x3727690", Offset = "0x3725C90", VA = "0x183727690")]
	private IEnumerator startJumpTimer()
	{
		return null;
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F43")]
	[Address(RVA = "0x3727720", Offset = "0x3725D20", VA = "0x183727720")]
	private IEnumerator clampInput()
	{
		return null;
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F44")]
	[Address(RVA = "0x37277B0", Offset = "0x3725DB0", VA = "0x1837277B0")]
	private void resetBlockWaterJump()
	{
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x37277C0", Offset = "0x3725DC0", VA = "0x1837277C0")]
	private void resetFauxJump()
	{
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F46")]
	[Address(RVA = "0x37277D0", Offset = "0x3725DD0", VA = "0x1837277D0")]
	public void AddMovement(Vector2 movement)
	{
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F47")]
	[Address(RVA = "0x625BE0", Offset = "0x6241E0", VA = "0x180625BE0")]
	public void SetRunning(bool value)
	{
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F48")]
	[Address(RVA = "0x37277F0", Offset = "0x3725DF0", VA = "0x1837277F0")]
	public void SetJumping(bool value)
	{
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F49")]
	[Address(RVA = "0x3727830", Offset = "0x3725E30", VA = "0x183727830")]
	public void SetSuperJump(float value)
	{
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0x3727850", Offset = "0x3725E50", VA = "0x183727850")]
	public void ResetJumpMultiplierAfterNextJump(float value)
	{
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0x3727860", Offset = "0x3725E60", VA = "0x183727860")]
	public void SetOverrideMovement(Vector2 value)
	{
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F4C")]
	[Address(RVA = "0x3727870", Offset = "0x3725E70", VA = "0x183727870")]
	public void EnableMovementSlow(float speed = 1.2f)
	{
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F4D")]
	[Address(RVA = "0x37278C0", Offset = "0x3725EC0", VA = "0x1837278C0")]
	public void DisableMovementSlow()
	{
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00005CB8 File Offset: 0x00003EB8
	[Token(Token = "0x6000F4E")]
	[Address(RVA = "0x3727980", Offset = "0x3725F80", VA = "0x183727980")]
	public bool WasGrounded()
	{
		return default(bool);
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F4F")]
	[Address(RVA = "0x37279A0", Offset = "0x3725FA0", VA = "0x1837279A0")]
	public void SetOverrideClampInput(float value)
	{
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F50")]
	[Address(RVA = "0x37279B0", Offset = "0x3725FB0", VA = "0x1837279B0")]
	public void HandleLanded()
	{
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F51")]
	[Address(RVA = "0x3727C00", Offset = "0x3726200", VA = "0x183727C00")]
	public void ClearFallDamageFlag()
	{
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F52")]
	[Address(RVA = "0x3727C90", Offset = "0x3726290", VA = "0x183727C90")]
	private void DoFallDamage()
	{
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F53")]
	[Address(RVA = "0x3728140", Offset = "0x3726740", VA = "0x183728140")]
	private void fallDamageTimer()
	{
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F54")]
	[Address(RVA = "0x3728150", Offset = "0x3726750", VA = "0x183728150")]
	public void PlayLandingSound()
	{
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F55")]
	[Address(RVA = "0x3728550", Offset = "0x3726B50", VA = "0x183728550")]
	private void PlayLandVocals(string landVocals)
	{
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F56")]
	[Address(RVA = "0x3728810", Offset = "0x3726E10", VA = "0x183728810")]
	public FirstPersonCharacter()
	{
	}

	// Token: 0x04000D92 RID: 3474
	[Token(Token = "0x4000D92")]
	public const float HARD_FALL_THRESHOLD = 28.5f;

	// Token: 0x04000D93 RID: 3475
	[Token(Token = "0x4000D93")]
	private const float WetnessFadePerSecond = 0.033333335f;

	// Token: 0x04000D94 RID: 3476
	[Token(Token = "0x4000D94")]
	private const float WET_GROUND_END = 1f;

	// Token: 0x04000D95 RID: 3477
	[Token(Token = "0x4000D95")]
	private const float IMMERSION_START = 5f;

	// Token: 0x04000D96 RID: 3478
	[Token(Token = "0x4000D96")]
	private const float IMMERSION_END = 10f;

	// Token: 0x04000D97 RID: 3479
	[Token(Token = "0x4000D97")]
	private const float IMMERSION_RANGE = 5f;

	// Token: 0x04000D98 RID: 3480
	[Token(Token = "0x4000D98")]
	private const float Unset = float.NaN;

	// Token: 0x04000D99 RID: 3481
	[Token(Token = "0x4000D99")]
	[FieldOffset(Offset = "0x0")]
	private static bool _jumpTriggered;

	// Token: 0x04000D9A RID: 3482
	[Token(Token = "0x4000D9A")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 InputHack;

	// Token: 0x04000D9B RID: 3483
	[Token(Token = "0x4000D9B")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask CollisionLayers;

	// Token: 0x04000D9C RID: 3484
	[Token(Token = "0x4000D9C")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[FormerlySerializedAs("walkSpeed")]
	private float _walkSpeed;

	// Token: 0x04000D9D RID: 3485
	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[FormerlySerializedAs("runSpeed")]
	private float _runSpeed;

	// Token: 0x04000D9E RID: 3486
	[Token(Token = "0x4000D9E")]
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("strafeSpeed")]
	[SerializeField]
	private float _strafeSpeed;

	// Token: 0x04000D9F RID: 3487
	[Token(Token = "0x4000D9F")]
	[FieldOffset(Offset = "0x38")]
	public float crouchSpeed;

	// Token: 0x04000DA0 RID: 3488
	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("swimmingSpeed")]
	[SerializeField]
	private float _swimSpeed;

	// Token: 0x04000DA1 RID: 3489
	[Token(Token = "0x4000DA1")]
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("staminaCostPerSec")]
	[SerializeField]
	private float _runStaminaCostPerSec;

	// Token: 0x04000DA2 RID: 3490
	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _staminaMinNeededToRun;

	// Token: 0x04000DA3 RID: 3491
	[Token(Token = "0x4000DA3")]
	[FieldOffset(Offset = "0x48")]
	public float minCamRotationRange;

	// Token: 0x04000DA4 RID: 3492
	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0x4C")]
	public bool standingOnRaft;

	// Token: 0x04000DA5 RID: 3493
	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0x4D")]
	public bool StandingOnDynamicObject;

	// Token: 0x04000DA6 RID: 3494
	[Token(Token = "0x4000DA6")]
	[FieldOffset(Offset = "0x4E")]
	public bool Locked;

	// Token: 0x04000DA7 RID: 3495
	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0x50")]
	public float gravity;

	// Token: 0x04000DA8 RID: 3496
	[Token(Token = "0x4000DA8")]
	[FieldOffset(Offset = "0x54")]
	public float maxVelocityChange;

	// Token: 0x04000DA9 RID: 3497
	[Token(Token = "0x4000DA9")]
	[FieldOffset(Offset = "0x58")]
	public float maximumVelocity;

	// Token: 0x04000DAA RID: 3498
	[Token(Token = "0x4000DAA")]
	[FieldOffset(Offset = "0x5C")]
	[FormerlySerializedAs("jumpHeight")]
	[SerializeField]
	private float _jumpHeight;

	// Token: 0x04000DAB RID: 3499
	[Token(Token = "0x4000DAB")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _edgeWaterJumpMultiplier;

	// Token: 0x04000DAC RID: 3500
	[Token(Token = "0x4000DAC")]
	[FieldOffset(Offset = "0x64")]
	private bool _allowJump;

	// Token: 0x04000DAD RID: 3501
	[Token(Token = "0x4000DAD")]
	[FieldOffset(Offset = "0x65")]
	private bool _canJump;

	// Token: 0x04000DAE RID: 3502
	[Token(Token = "0x4000DAE")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private StepHelper _stepHelper;

	// Token: 0x04000DAF RID: 3503
	[Token(Token = "0x4000DAF")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Collider _wallPusherCollider;

	// Token: 0x04000DB0 RID: 3504
	[Token(Token = "0x4000DB0")]
	[FieldOffset(Offset = "0x78")]
	public float stickToGroundHelperDistance;

	// Token: 0x04000DB1 RID: 3505
	[Token(Token = "0x4000DB1")]
	[FieldOffset(Offset = "0x7C")]
	public float groundStableForce;

	// Token: 0x04000DB2 RID: 3506
	[Token(Token = "0x4000DB2")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float _extremeAngleGroundedLimitStart;

	// Token: 0x04000DB3 RID: 3507
	[Token(Token = "0x4000DB3")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float _extremeAngleGroundedLimitMax;

	// Token: 0x04000DB4 RID: 3508
	[Token(Token = "0x4000DB4")]
	[FieldOffset(Offset = "0x88")]
	public float maxDiveVelocity;

	// Token: 0x04000DB5 RID: 3509
	[Token(Token = "0x4000DB5")]
	[FieldOffset(Offset = "0x8C")]
	[FormerlySerializedAs("maxSwimVelocity")]
	public float _maxSwimVelocity;

	// Token: 0x04000DB6 RID: 3510
	[Token(Token = "0x4000DB6")]
	[FieldOffset(Offset = "0x90")]
	private float _nextSwimNoiseTime;

	// Token: 0x04000DB7 RID: 3511
	[Token(Token = "0x4000DB7")]
	[FieldOffset(Offset = "0x94")]
	private bool _isInMidAction;

	// Token: 0x04000DB8 RID: 3512
	[Token(Token = "0x4000DB8")]
	[FieldOffset(Offset = "0x95")]
	private bool _blockFullBodyInteraction;

	// Token: 0x04000DB9 RID: 3513
	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0x96")]
	public bool IsBlockingActive;

	// Token: 0x04000DBA RID: 3514
	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x97")]
	public bool IsGroundAttackActive;

	// Token: 0x04000DBB RID: 3515
	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0x98")]
	[Min(0f)]
	[SerializeField]
	private float _walkToRunThreshold;

	// Token: 0x04000DBC RID: 3516
	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x9C")]
	private bool _runInputActive;

	// Token: 0x04000DBD RID: 3517
	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0x9D")]
	private bool _isRunSpeedActive;

	// Token: 0x04000DBE RID: 3518
	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x9E")]
	private bool _isRunning;

	// Token: 0x04000DBF RID: 3519
	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x9F")]
	private bool _crouchHeightBlocked;

	// Token: 0x04000DC0 RID: 3520
	[Token(Token = "0x4000DC0")]
	[FieldOffset(Offset = "0xA0")]
	public bool _doingExitVelocity;

	// Token: 0x04000DC1 RID: 3521
	[Token(Token = "0x4000DC1")]
	[FieldOffset(Offset = "0xA8")]
	public RigidBodyCollisionFlags collFlags;

	// Token: 0x04000DC2 RID: 3522
	[Token(Token = "0x4000DC2")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[FormerlySerializedAs("capsule")]
	private CapsuleCollider _primaryCollider;

	// Token: 0x04000DC3 RID: 3523
	[Token(Token = "0x4000DC3")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[FormerlySerializedAs("originalHeight")]
	private float _defaultPrimaryColliderHeight;

	// Token: 0x04000DC4 RID: 3524
	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0xBC")]
	[FormerlySerializedAs("originalYPos")]
	[SerializeField]
	private Vector3 _defaultPrimaryColliderCenter;

	// Token: 0x04000DC5 RID: 3525
	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0xC8")]
	[FormerlySerializedAs("crouchCapsuleCenter")]
	[SerializeField]
	private float _crouchColliderCenter;

	// Token: 0x04000DC6 RID: 3526
	[Token(Token = "0x4000DC6")]
	[FieldOffset(Offset = "0xD0")]
	[FormerlySerializedAs("rb")]
	public Rigidbody _rigidbody;

	// Token: 0x04000DC7 RID: 3527
	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0xD8")]
	private bool _prevGrounded;

	// Token: 0x04000DC8 RID: 3528
	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0xD9")]
	private bool _primaryColliderEnabled;

	// Token: 0x04000DC9 RID: 3529
	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0xDA")]
	private bool _stepHelperEnabled;

	// Token: 0x04000DCA RID: 3530
	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0xDB")]
	[FormerlySerializedAs("allowFallDamage")]
	private bool _allowFallDamage;

	// Token: 0x04000DCB RID: 3531
	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0xDC")]
	public bool jumpCoolDown;

	// Token: 0x04000DCC RID: 3532
	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0xDD")]
	public bool checkGrounded;

	// Token: 0x04000DCD RID: 3533
	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0xDE")]
	public bool checkSwimming;

	// Token: 0x04000DCE RID: 3534
	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0xDF")]
	public bool terrainContact;

	// Token: 0x04000DCF RID: 3535
	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0xE0")]
	public Vector3 inputVelocity;

	// Token: 0x04000DD0 RID: 3536
	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0xEC")]
	private Vector3 _velocity;

	// Token: 0x04000DD3 RID: 3539
	[Token(Token = "0x4000DD3")]
	[FieldOffset(Offset = "0xFA")]
	private bool _shouldCrouch;

	// Token: 0x04000DD4 RID: 3540
	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0xFB")]
	private bool _standUp;

	// Token: 0x04000DD5 RID: 3541
	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0xFC")]
	public bool inSnow;

	// Token: 0x04000DD6 RID: 3542
	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0x100")]
	public float crouchHeight;

	// Token: 0x04000DD7 RID: 3543
	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x104")]
	private bool _canRun;

	// Token: 0x04000DD8 RID: 3544
	[Token(Token = "0x4000DD8")]
	[FieldOffset(Offset = "0x105")]
	public bool allowWaterJump;

	// Token: 0x04000DD9 RID: 3545
	[Token(Token = "0x4000DD9")]
	[FieldOffset(Offset = "0x106")]
	public bool hitByEnemy;

	// Token: 0x04000DDA RID: 3546
	[Token(Token = "0x4000DDA")]
	[FieldOffset(Offset = "0x108")]
	private float _clampInputVal;

	// Token: 0x04000DDB RID: 3547
	[Token(Token = "0x4000DDB")]
	[FieldOffset(Offset = "0x10C")]
	public bool doingClampInput;

	// Token: 0x04000DDC RID: 3548
	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0x110")]
	public float clampInputDelay;

	// Token: 0x04000DDD RID: 3549
	[Token(Token = "0x4000DDD")]
	[FieldOffset(Offset = "0x114")]
	public float defaultMass;

	// Token: 0x04000DDE RID: 3550
	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0x118")]
	public float timeToRecoverFromRun;

	// Token: 0x04000DDF RID: 3551
	[Token(Token = "0x4000DDF")]
	[FieldOffset(Offset = "0x11C")]
	public bool onSlipperySlope;

	// Token: 0x04000DE0 RID: 3552
	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x11D")]
	public bool enforceHighDrag;

	// Token: 0x04000DE1 RID: 3553
	[Token(Token = "0x4000DE1")]
	[FieldOffset(Offset = "0x11E")]
	public bool VerboseAddForce;

	// Token: 0x04000DE2 RID: 3554
	[Token(Token = "0x4000DE2")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private float _swimSpeedMultiplier;

	// Token: 0x04000DE3 RID: 3555
	[Token(Token = "0x4000DE3")]
	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	private bool _verboseStatusChange;

	// Token: 0x04000DE4 RID: 3556
	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x125")]
	[SerializeField]
	private bool _debugJumping;

	// Token: 0x04000DE5 RID: 3557
	[Token(Token = "0x4000DE5")]
	[FieldOffset(Offset = "0x128")]
	private float _speed;

	// Token: 0x04000DE6 RID: 3558
	[Token(Token = "0x4000DE6")]
	[FieldOffset(Offset = "0x12C")]
	private Vector3 _targetVelocity;

	// Token: 0x04000DE7 RID: 3559
	[Token(Token = "0x4000DE7")]
	[FieldOffset(Offset = "0x138")]
	private readonly float backwardSpeedMult;

	// Token: 0x04000DE8 RID: 3560
	[Token(Token = "0x4000DE8")]
	[FieldOffset(Offset = "0x13C")]
	private bool _buildInputActive;

	// Token: 0x04000DE9 RID: 3561
	[Token(Token = "0x4000DE9")]
	[FieldOffset(Offset = "0x140")]
	private readonly List<ContactPoint> _contacts;

	// Token: 0x04000DEA RID: 3562
	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x148")]
	private Vector2 _currentInputMovement;

	// Token: 0x04000DEB RID: 3563
	[Token(Token = "0x4000DEB")]
	[FieldOffset(Offset = "0x150")]
	private bool _disableGravity;

	// Token: 0x04000DEC RID: 3564
	[Token(Token = "0x4000DEC")]
	[FieldOffset(Offset = "0x151")]
	private bool _hasOverrideMovement;

	// Token: 0x04000DED RID: 3565
	[Token(Token = "0x4000DED")]
	[FieldOffset(Offset = "0x158")]
	private SphereCollider _headCollider;

	// Token: 0x04000DEE RID: 3566
	[Token(Token = "0x4000DEE")]
	[FieldOffset(Offset = "0x160")]
	private bool _isGrounded;

	// Token: 0x04000DEF RID: 3567
	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0x161")]
	private bool _movementSlowIsActive;

	// Token: 0x04000DF0 RID: 3568
	[Token(Token = "0x4000DF0")]
	[FieldOffset(Offset = "0x164")]
	private Vector2 _overrideMovement;

	// Token: 0x04000DF1 RID: 3569
	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0x16C")]
	private Vector3 _prevVelocity;

	// Token: 0x04000DF2 RID: 3570
	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0x178")]
	private bool _runningOverride;

	// Token: 0x04000DF3 RID: 3571
	[Token(Token = "0x4000DF3")]
	[FieldOffset(Offset = "0x17C")]
	private float _runSpeedBeforeSlow;

	// Token: 0x04000DF4 RID: 3572
	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x180")]
	private float _setJumpMultiplierAfterJump;

	// Token: 0x04000DF5 RID: 3573
	[Token(Token = "0x4000DF5")]
	[FieldOffset(Offset = "0x184")]
	private Vector2 _storedMovementInput;

	// Token: 0x04000DF6 RID: 3574
	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0x18C")]
	private float _strafeSpeedBeforeSlow;

	// Token: 0x04000DF7 RID: 3575
	[Token(Token = "0x4000DF7")]
	[FieldOffset(Offset = "0x190")]
	private float _swimSpeedBeforeSlow;

	// Token: 0x04000DF8 RID: 3576
	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x198")]
	private Vitals _vitals;

	// Token: 0x04000DF9 RID: 3577
	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x1A0")]
	private bool _vrHandTrackingGoalValue;

	// Token: 0x04000DFA RID: 3578
	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0x1A4")]
	private int _jumpPressFixedFrame;

	// Token: 0x04000DFB RID: 3579
	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0x1A8")]
	private float _jumpingTimer;

	// Token: 0x04000DFC RID: 3580
	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x1AC")]
	private float _walkSpeedBeforeSlow;

	// Token: 0x04000DFD RID: 3581
	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x1B0")]
	private float _wetnessCurrent;

	// Token: 0x04000DFE RID: 3582
	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0x1B4")]
	private bool allowFauxGrounded;

	// Token: 0x04000DFF RID: 3583
	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0x1B8")]
	private Animator animator;

	// Token: 0x04000E00 RID: 3584
	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0x1C0")]
	private bool blockFauxJump;

	// Token: 0x04000E01 RID: 3585
	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x1C1")]
	private bool blockWaterJump;

	// Token: 0x04000E02 RID: 3586
	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0x1C4")]
	private float clampAirTouch;

	// Token: 0x04000E03 RID: 3587
	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0x1C8")]
	private bool crouchBlock;

	// Token: 0x04000E04 RID: 3588
	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0x1C9")]
	private bool fallShakeBlock;

	// Token: 0x04000E05 RID: 3589
	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0x1CA")]
	private bool FauxGrounded;

	// Token: 0x04000E06 RID: 3590
	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0x1CC")]
	private float fauxGroundedTimer;

	// Token: 0x04000E07 RID: 3591
	[Token(Token = "0x4000E07")]
	[FieldOffset(Offset = "0x1D0")]
	private bool forceStopRun;

	// Token: 0x04000E08 RID: 3592
	[Token(Token = "0x4000E08")]
	[FieldOffset(Offset = "0x1D4")]
	private float _defaultExtremeAngleGroundedLimitStart;

	// Token: 0x04000E09 RID: 3593
	[Token(Token = "0x4000E09")]
	[FieldOffset(Offset = "0x1D8")]
	private float _defaultExtremeAngleGroundedLimitMax;

	// Token: 0x04000E0A RID: 3594
	[Token(Token = "0x4000E0A")]
	[FieldOffset(Offset = "0x1DC")]
	private RaycastHit hitInfo;

	// Token: 0x04000E0B RID: 3595
	[Token(Token = "0x4000E0B")]
	[FieldOffset(Offset = "0x208")]
	private Vector2 input;

	// Token: 0x04000E0C RID: 3596
	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0x210")]
	private bool inSand;

	// Token: 0x04000E0D RID: 3597
	[Token(Token = "0x4000E0D")]
	[FieldOffset(Offset = "0x211")]
	private bool jumpFuzzyDelay;

	// Token: 0x04000E0E RID: 3598
	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x212")]
	private bool jumpInputBlock;

	// Token: 0x04000E0F RID: 3599
	[Token(Token = "0x4000E0F")]
	[FieldOffset(Offset = "0x213")]
	private bool jumpLand;

	// Token: 0x04000E10 RID: 3600
	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0x214")]
	private bool _jumpTimerIsRunning;

	// Token: 0x04000E11 RID: 3601
	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0x218")]
	private float lastUpdateTime;

	// Token: 0x04000E12 RID: 3602
	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0x21C")]
	private float modExtremeAngleLimit;

	// Token: 0x04000E13 RID: 3603
	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x220")]
	private bool multisledContact;

	// Token: 0x04000E14 RID: 3604
	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0x224")]
	private float prevMouseXSpeed;

	// Token: 0x04000E15 RID: 3605
	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0x228")]
	private float prevYPos;

	// Token: 0x04000E16 RID: 3606
	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0x22C")]
	private bool recentlyDisabledSled;

	// Token: 0x04000E17 RID: 3607
	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0x230")]
	private playerScriptSetup setup;

	// Token: 0x04000E18 RID: 3608
	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0x238")]
	private bool stamRechargeDelay;

	// Token: 0x04000E19 RID: 3609
	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0x240")]
	private PlayerStats Stats;

	// Token: 0x04000E1A RID: 3610
	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0x248")]
	private float storeMaxVelocity;

	// Token: 0x04000E1B RID: 3611
	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0x24C")]
	private Vector3 storeTargetVelocity;

	// Token: 0x04000E1C RID: 3612
	[Token(Token = "0x4000E1C")]
	[FieldOffset(Offset = "0x258")]
	private bool validateGrounded;

	// Token: 0x04000E1D RID: 3613
	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0x260")]
	private VRPlayerAdapter vrAdapter;

	// Token: 0x04000E1E RID: 3614
	[Token(Token = "0x4000E1E")]
	[FieldOffset(Offset = "0x268")]
	private float yChange;

	// Token: 0x04000E1F RID: 3615
	[Token(Token = "0x4000E1F")]
	[FieldOffset(Offset = "0x26C")]
	private int _currentFixedFrame;

	// Token: 0x04000E20 RID: 3616
	[Token(Token = "0x4000E20")]
	[FieldOffset(Offset = "0x270")]
	private int _groundedFrame;

	// Token: 0x04000E21 RID: 3617
	[Token(Token = "0x4000E21")]
	[FieldOffset(Offset = "0x274")]
	private bool _forceGrounded;

	// Token: 0x04000E22 RID: 3618
	[Token(Token = "0x4000E22")]
	[FieldOffset(Offset = "0x278")]
	private float _landingVelocityY;

	// Token: 0x04000E23 RID: 3619
	[Token(Token = "0x4000E23")]
	[FieldOffset(Offset = "0x27C")]
	private int _landingFrame;

	// Token: 0x04000E24 RID: 3620
	[Token(Token = "0x4000E24")]
	[FieldOffset(Offset = "0x280")]
	private bool _sitting;

	// Token: 0x04000E25 RID: 3621
	[Token(Token = "0x4000E25")]
	[FieldOffset(Offset = "0x281")]
	private bool _movementLocked;

	// Token: 0x04000E26 RID: 3622
	[Token(Token = "0x4000E26")]
	[FieldOffset(Offset = "0x288")]
	private PhysicMaterial _playerPhysicMaterial;

	// Token: 0x04000E27 RID: 3623
	[Token(Token = "0x4000E27")]
	[FieldOffset(Offset = "0x290")]
	private float _recoveringFromRun;

	// Token: 0x04000E28 RID: 3624
	[Token(Token = "0x4000E28")]
	[FieldOffset(Offset = "0x294")]
	private float _jumpMultiplier;

	// Token: 0x04000E29 RID: 3625
	[Token(Token = "0x4000E29")]
	[FieldOffset(Offset = "0x298")]
	private bool _isJumping;

	// Token: 0x04000E2A RID: 3626
	[Token(Token = "0x4000E2A")]
	[FieldOffset(Offset = "0x299")]
	private bool _cachedJumpBoolHash;

	// Token: 0x04000E2B RID: 3627
	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x2A0")]
	private AutoTimer _swimmingJumpTimer;

	// Token: 0x04000E2C RID: 3628
	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x2A8")]
	private float _overrideClampInput;

	// Token: 0x04000E2D RID: 3629
	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x2AC")]
	private int _subFixedFrameCount;

	// Token: 0x04000E2E RID: 3630
	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x2B0")]
	private int _subFixedFrameCountId;

	// Token: 0x04000E2F RID: 3631
	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0x2B8")]
	private Collision[] _trackedCollisions;

	// Token: 0x04000E30 RID: 3632
	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0x2C0")]
	private int _trackedCollisionIndex;

	// Token: 0x04000E31 RID: 3633
	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0x2C4")]
	private float _prevLandingVelocityY;

	// Token: 0x04000E32 RID: 3634
	[Token(Token = "0x4000E32")]
	private const float WaterDepthParamMaxHeightSampled = 1.2f;

	// Token: 0x04000E33 RID: 3635
	[Token(Token = "0x4000E33")]
	private const float WaterDepthParamMaxHeightResult = 10f;

	// Token: 0x04000E35 RID: 3637
	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	private float _fallDamageVelocity;

	// Token: 0x04000E36 RID: 3638
	[Token(Token = "0x4000E36")]
	[FieldOffset(Offset = "0x2D4")]
	[SerializeField]
	private float _baseFallDamage;

	// Token: 0x04000E37 RID: 3639
	[Token(Token = "0x4000E37")]
	[FieldOffset(Offset = "0x2D8")]
	[SerializeField]
	private float _fallDamagePower;

	// Token: 0x04000E38 RID: 3640
	[Token(Token = "0x4000E38")]
	[FieldOffset(Offset = "0x2E0")]
	[SerializeField]
	[EventRef]
	private string _landVocals;

	// Token: 0x04000E39 RID: 3641
	[Token(Token = "0x4000E39")]
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	[Tooltip("Air time required for landing SFX to be played")]
	private float _airTimeThreshold;

	// Token: 0x04000E3A RID: 3642
	[Token(Token = "0x4000E3A")]
	[FieldOffset(Offset = "0x2EC")]
	[SerializeField]
	private float _landSpeedThreshold;

	// Token: 0x04000E3B RID: 3643
	[Token(Token = "0x4000E3B")]
	[FieldOffset(Offset = "0x2F0")]
	private bool _activeHandlingLanded;
}
