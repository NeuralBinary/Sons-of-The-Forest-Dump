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

// Token: 0x02000224 RID: 548
[Token(Token = "0x2000224")]
public class FirstPersonCharacter : MonoBehaviour, IOnCollisionEnterProxy, IOnCollisionStayProxy, IEnvironmentWetnessReceiver
{
	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00005610 File Offset: 0x00003810
	[Token(Token = "0x1700019F")]
	public bool IsInMidAction
	{
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x29E5500", Offset = "0x29E4500", VA = "0x1829E5500")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E56")]
	[Address(RVA = "0x2F980D0", Offset = "0x2F970D0", VA = "0x182F980D0")]
	public void SetIsInMidAction(bool value)
	{
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00005628 File Offset: 0x00003828
	// (set) Token: 0x06000E58 RID: 3672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A0")]
	public bool IsCrouchActive
	{
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x8C5EC0", Offset = "0x8C4EC0", VA = "0x1808C5EC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x2D57190", Offset = "0x2D56190", VA = "0x182D57190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00005640 File Offset: 0x00003840
	// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A1")]
	public bool BlockCrouch
	{
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x217C020", Offset = "0x217B020", VA = "0x18217C020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x2F9A730", Offset = "0x2F99730", VA = "0x182F9A730")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1400000C RID: 12
	// (add) Token: 0x06000E5B RID: 3675 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000E5C RID: 3676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1400000C")]
	public event Action<Vector2> OnInputMovementChanged
	{
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x2F9A2C0", Offset = "0x2F992C0", VA = "0x182F9A2C0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x2F9A560", Offset = "0x2F99560", VA = "0x182F9A560")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00005658 File Offset: 0x00003858
	// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A2")]
	public bool Grounded
	{
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x5A48B0", Offset = "0x5A38B0", VA = "0x1805A48B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x2F9A760", Offset = "0x2F99760", VA = "0x182F9A760")]
		private set
		{
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00005670 File Offset: 0x00003870
	// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A3")]
	private int CurrentFixedFrame
	{
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x2F9A4B0", Offset = "0x2F994B0", VA = "0x182F9A4B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x2F9A740", Offset = "0x2F99740", VA = "0x182F9A740")]
		set
		{
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00005688 File Offset: 0x00003888
	// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A4")]
	public int GroundedFrame
	{
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x2F9A4C0", Offset = "0x2F994C0", VA = "0x182F9A4C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x2F9A750", Offset = "0x2F99750", VA = "0x182F9A750")]
		private set
		{
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000E63 RID: 3683 RVA: 0x000056A0 File Offset: 0x000038A0
	// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A5")]
	public float LandingVelocityY
	{
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x2B72F10", Offset = "0x2B71F10", VA = "0x182B72F10")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x2F9A7B0", Offset = "0x2F997B0", VA = "0x182F9A7B0")]
		private set
		{
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x06000E65 RID: 3685 RVA: 0x000056B8 File Offset: 0x000038B8
	[Token(Token = "0x170001A6")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x2F9A530", Offset = "0x2F99530", VA = "0x182F9A530")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x06000E66 RID: 3686 RVA: 0x000056D0 File Offset: 0x000038D0
	// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A7")]
	public bool Sitting
	{
		[Token(Token = "0x6000E66")]
		[Address(RVA = "0x2F9A520", Offset = "0x2F99520", VA = "0x182F9A520")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x2F9A7E0", Offset = "0x2F997E0", VA = "0x182F9A7E0")]
		set
		{
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06000E68 RID: 3688 RVA: 0x000056E8 File Offset: 0x000038E8
	// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A8")]
	public bool MovementLocked
	{
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x2F9A500", Offset = "0x2F99500", VA = "0x182F9A500")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x2F9A7C0", Offset = "0x2F997C0", VA = "0x182F9A7C0")]
		set
		{
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00005700 File Offset: 0x00003900
	[Token(Token = "0x170001A9")]
	public bool IsSprintActive
	{
		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x2F9A4E0", Offset = "0x2F994E0", VA = "0x182F9A4E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00005718 File Offset: 0x00003918
	[Token(Token = "0x170001AA")]
	public bool IsSprintInputActive
	{
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x25551D0", Offset = "0x25541D0", VA = "0x1825551D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00005730 File Offset: 0x00003930
	[Token(Token = "0x170001AB")]
	public bool CanSprint
	{
		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x2F9A4A0", Offset = "0x2F994A0", VA = "0x182F9A4A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AC")]
	public PhysicMaterial PlayerPhysicMaterial
	{
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x2F9A510", Offset = "0x2F99510", VA = "0x182F9A510")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x2F9A7D0", Offset = "0x2F997D0", VA = "0x182F9A7D0")]
		private set
		{
		}
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00005748 File Offset: 0x00003948
	// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AD")]
	public float recoveringFromRun
	{
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x2F9A550", Offset = "0x2F99550", VA = "0x182F9A550")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x2F9A7F0", Offset = "0x2F997F0", VA = "0x182F9A7F0")]
		set
		{
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00005760 File Offset: 0x00003960
	[Token(Token = "0x170001AE")]
	public float WalkSpeed
	{
		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x5A46C0", Offset = "0x5A36C0", VA = "0x1805A46C0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000E72 RID: 3698 RVA: 0x00005778 File Offset: 0x00003978
	[Token(Token = "0x170001AF")]
	public float RunSpeed
	{
		[Token(Token = "0x6000E72")]
		[Address(RVA = "0x8A27B0", Offset = "0x8A17B0", VA = "0x1808A27B0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06000E73 RID: 3699 RVA: 0x00005790 File Offset: 0x00003990
	[Token(Token = "0x170001B0")]
	public float SwimSpeed
	{
		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x2004010", Offset = "0x2003010", VA = "0x182004010")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x06000E74 RID: 3700 RVA: 0x000057A8 File Offset: 0x000039A8
	[Token(Token = "0x170001B1")]
	public float StrafeSpeed
	{
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x5A1700", Offset = "0x5A0700", VA = "0x1805A1700")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06000E75 RID: 3701 RVA: 0x000057C0 File Offset: 0x000039C0
	// (set) Token: 0x06000E76 RID: 3702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B2")]
	public float JumpMultiplier
	{
		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x2F9A4F0", Offset = "0x2F994F0", VA = "0x182F9A4F0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x2F9A7A0", Offset = "0x2F997A0", VA = "0x182F9A7A0")]
		private set
		{
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06000E77 RID: 3703 RVA: 0x000057D8 File Offset: 0x000039D8
	// (set) Token: 0x06000E78 RID: 3704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B3")]
	public bool IsJumping
	{
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x2F9A4D0", Offset = "0x2F994D0", VA = "0x182F9A4D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x2F9A790", Offset = "0x2F99790", VA = "0x182F9A790")]
		set
		{
		}
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x2445CD0", Offset = "0x2444CD0", VA = "0x182445CD0")]
	public void SetAllowJump(bool value)
	{
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06000E7A RID: 3706 RVA: 0x000057F0 File Offset: 0x000039F0
	[Token(Token = "0x170001B4")]
	public bool CanJump
	{
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x1362FD0", Offset = "0x1361FD0", VA = "0x181362FD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x1363DB0", Offset = "0x1362DB0", VA = "0x181363DB0")]
	public void SetCanJump(bool value)
	{
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x2F91C60", Offset = "0x2F90C60", VA = "0x182F91C60")]
	private void Awake()
	{
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0x2F98860", Offset = "0x2F97860", VA = "0x182F98860")]
	private void Start()
	{
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0x2F96C20", Offset = "0x2F95C20", VA = "0x182F96C20")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0x2F92690", Offset = "0x2F91690", VA = "0x182F92690")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E80")]
	[Address(RVA = "0x2F92690", Offset = "0x2F91690", VA = "0x182F92690")]
	private void ClearSubFixedFrameCount()
	{
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E81")]
	[Address(RVA = "0x2F995C0", Offset = "0x2F985C0", VA = "0x182F995C0")]
	private void Update()
	{
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00005808 File Offset: 0x00003A08
	[Token(Token = "0x6000E82")]
	[Address(RVA = "0x2F946B0", Offset = "0x2F936B0", VA = "0x182F946B0")]
	private float GroundAngleSlideFactor()
	{
		return default(float);
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E83")]
	[Address(RVA = "0x2F96FF0", Offset = "0x2F95FF0", VA = "0x182F96FF0")]
	private void OnJumpInput(bool applyJumpVel)
	{
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00005820 File Offset: 0x00003A20
	[Token(Token = "0x6000E84")]
	[Address(RVA = "0x2F921A0", Offset = "0x2F911A0", VA = "0x182F921A0")]
	private bool CanCrouch()
	{
		return default(bool);
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E85")]
	[Address(RVA = "0x2F98810", Offset = "0x2F97810", VA = "0x182F98810")]
	public void StandUp()
	{
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E86")]
	[Address(RVA = "0x2F98810", Offset = "0x2F97810", VA = "0x182F98810")]
	private void TriggerDisableCrouch()
	{
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E87")]
	[Address(RVA = "0x2F97E90", Offset = "0x2F96E90", VA = "0x182F97E90")]
	public void SetEnabled(bool isEnabled)
	{
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E88")]
	[Address(RVA = "0x2F95710", Offset = "0x2F94710", VA = "0x182F95710")]
	private void HandleSwimmingJumpInput(bool jumpInput)
	{
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E89")]
	[Address(RVA = "0x2F93010", Offset = "0x2F92010", VA = "0x182F93010")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x2F922F0", Offset = "0x2F912F0", VA = "0x182F922F0")]
	private void CheckGroundedSwimmingChange()
	{
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x2F96EB0", Offset = "0x2F95EB0", VA = "0x182F96EB0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x2F99510", Offset = "0x2F98510", VA = "0x182F99510")]
	private void UpdateStepHelper(Vector2 obj)
	{
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0x2F96C90", Offset = "0x2F95C90", VA = "0x182F96C90")]
	private void OnDisable()
	{
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8E")]
	[Address(RVA = "0x2F995A0", Offset = "0x2F985A0", VA = "0x182F995A0", Slot = "6")]
	public void UpdateWetness(float wetness)
	{
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E8F")]
	[Address(RVA = "0x2F96150", Offset = "0x2F95150", VA = "0x182F96150", Slot = "4")]
	public void OnCollisionEnterProxied(Collision coll)
	{
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E90")]
	[Address(RVA = "0x2F96390", Offset = "0x2F95390", VA = "0x182F96390", Slot = "5")]
	public void OnCollisionStayProxied(Collision col)
	{
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E91")]
	[Address(RVA = "0x5A46E0", Offset = "0x5A36E0", VA = "0x1805A46E0")]
	public void SetWalkSpeed(float value)
	{
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E92")]
	[Address(RVA = "0x67DC20", Offset = "0x67CC20", VA = "0x18067DC20")]
	public void SetRunSpeed(float value)
	{
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E93")]
	[Address(RVA = "0x2874C50", Offset = "0x2873C50", VA = "0x182874C50")]
	public void SetSwimSpeed(float value)
	{
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E94")]
	[Address(RVA = "0x2CBDCF0", Offset = "0x2CBCCF0", VA = "0x182CBDCF0")]
	public void SetDisabledGravity(bool value)
	{
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x00005838 File Offset: 0x00003A38
	[Token(Token = "0x6000E95")]
	[Address(RVA = "0x2F96050", Offset = "0x2F95050", VA = "0x182F96050")]
	public bool IsPrimaryCollider(Collider source)
	{
		return default(bool);
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x00005850 File Offset: 0x00003A50
	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x2F94070", Offset = "0x2F93070", VA = "0x182F94070")]
	public Bounds GetPrimaryColliderBounds()
	{
		return default(Bounds);
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x00005868 File Offset: 0x00003A68
	[Token(Token = "0x6000E97")]
	[Address(RVA = "0x2F93F40", Offset = "0x2F92F40", VA = "0x182F93F40")]
	public Bounds GetHeadColliderBounds()
	{
		return default(Bounds);
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00005880 File Offset: 0x00003A80
	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x2F94100", Offset = "0x2F93100", VA = "0x182F94100")]
	public float GetPrimaryColliderHeight()
	{
		return default(float);
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00005898 File Offset: 0x00003A98
	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x2F940C0", Offset = "0x2F930C0", VA = "0x182F940C0")]
	public Vector3 GetPrimaryColliderCenter()
	{
		return default(Vector3);
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x000058B0 File Offset: 0x00003AB0
	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0x2F94130", Offset = "0x2F93130", VA = "0x182F94130")]
	private float GetPrimaryColliderRadius()
	{
		return default(float);
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x2F98520", Offset = "0x2F97520", VA = "0x182F98520")]
	private void SetupCollision()
	{
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x2F95DB0", Offset = "0x2F94DB0", VA = "0x182F95DB0")]
	public void IgnoreCollision(Collider source)
	{
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x2F91570", Offset = "0x2F90570", VA = "0x182F91570")]
	public void ApplyCrouchPrimaryCollider()
	{
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0x2F97B00", Offset = "0x2F96B00", VA = "0x182F97B00")]
	public void ResetPrimaryColliderHeight()
	{
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0x2F98470", Offset = "0x2F97470", VA = "0x182F98470")]
	public void SetPrimaryCollider(Vector3 center, float height)
	{
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0x2F98290", Offset = "0x2F97290", VA = "0x182F98290")]
	public void SetPrimaryCollider(bool enabledValue)
	{
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0x2F984E0", Offset = "0x2F974E0", VA = "0x182F984E0")]
	private void SetStepHelperEnabled(bool enabledValue)
	{
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0x2F99480", Offset = "0x2F98480", VA = "0x182F99480")]
	private void UpdateStepHelperEnabled()
	{
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x2F98260", Offset = "0x2F97260", VA = "0x182F98260")]
	private void SetPrimaryColliderHeight(float height)
	{
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x000058C8 File Offset: 0x00003AC8
	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0x2F96080", Offset = "0x2F95080", VA = "0x182F96080")]
	private static bool IsSet(float value)
	{
		return default(bool);
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0x2F980A0", Offset = "0x2F970A0", VA = "0x182F980A0")]
	public void SetHeadColliderCenter(float xPos = float.NaN, float yPos = float.NaN, float zPos = float.NaN)
	{
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA6")]
	[Address(RVA = "0x2F98220", Offset = "0x2F97220", VA = "0x182F98220")]
	public void SetPrimaryColliderCenter(Vector3 center)
	{
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA7")]
	[Address(RVA = "0x2F97A00", Offset = "0x2F96A00", VA = "0x182F97A00")]
	public void ResetPrimaryColliderCenter(bool xPos = false, bool yPos = false, bool zPos = false)
	{
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x2F99190", Offset = "0x2F98190", VA = "0x182F99190")]
	private void UpdateRun()
	{
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0x2F98640", Offset = "0x2F97640", VA = "0x182F98640")]
	public void SpawnStepNoiseStimuli()
	{
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x000058E0 File Offset: 0x00003AE0
	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0x2F95EE0", Offset = "0x2F94EE0", VA = "0x182F95EE0")]
	private bool IsCrouchHeightBlocked(float standingUpHeight, Vector3 position)
	{
		return default(bool);
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x000058F8 File Offset: 0x00003AF8
	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x2F94160", Offset = "0x2F93160", VA = "0x182F94160")]
	private static bool GetStandUpInput()
	{
		return default(bool);
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00005910 File Offset: 0x00003B10
	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x2F93EB0", Offset = "0x2F92EB0", VA = "0x182F93EB0")]
	private static bool GetCrouchInput()
	{
		return default(bool);
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00005928 File Offset: 0x00003B28
	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x2F93F90", Offset = "0x2F92F90", VA = "0x182F93F90")]
	public static bool GetJumpInput()
	{
		return default(bool);
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0x2F9A3F0", Offset = "0x2F993F0", VA = "0x182F9A3F0")]
	public void disableToggledCrouch()
	{
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0x2F92350", Offset = "0x2F91350", VA = "0x182F92350")]
	private void CheckStandingOnExtremeSlope()
	{
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x2F94760", Offset = "0x2F93760", VA = "0x182F94760")]
	private void HandleFrictionParams()
	{
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x2F98FC0", Offset = "0x2F97FC0", VA = "0x182F98FC0")]
	private void UpdatePlayerPhysics(float staticFriction, float dynamicFriction, PhysicMaterialCombine materialCombine, float bounciness = 0f, PhysicMaterialCombine bounceMaterialCombine = 2)
	{
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x2F993B0", Offset = "0x2F983B0", VA = "0x182F993B0")]
	private void UpdateSleddingFriction()
	{
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x2F95520", Offset = "0x2F94520", VA = "0x182F95520")]
	private void HandleStartJumping()
	{
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00005940 File Offset: 0x00003B40
	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x2F942A0", Offset = "0x2F932A0", VA = "0x182F942A0")]
	private Vector3 GetTargetVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00005958 File Offset: 0x00003B58
	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x2F92730", Offset = "0x2F91730", VA = "0x182F92730")]
	private Vector3 DetermineVelocityChange()
	{
		return default(Vector3);
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00005970 File Offset: 0x00003B70
	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x2F94050", Offset = "0x2F93050", VA = "0x182F94050")]
	private Vector2 GetMovementInput()
	{
		return default(Vector2);
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0x2F95980", Offset = "0x2F94980", VA = "0x182F95980")]
	private void HandleSwimmingSpeed(Vector3 velocityChange)
	{
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0x2F923D0", Offset = "0x2F913D0", VA = "0x182F923D0")]
	private void ClampSwimVelocity()
	{
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0x2F924F0", Offset = "0x2F914F0", VA = "0x182F924F0")]
	private void ClampVelocity()
	{
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x2F915F0", Offset = "0x2F905F0", VA = "0x182F915F0")]
	private void ApplyGroundingForce()
	{
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x2F94990", Offset = "0x2F93990", VA = "0x182F94990")]
	private void HandleJumpSpeed(Vector3 velocityChange)
	{
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x2F95140", Offset = "0x2F94140", VA = "0x182F95140")]
	private void HandleRunningStaminaAndSpeed()
	{
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x2F95BF0", Offset = "0x2F94BF0", VA = "0x182F95BF0")]
	private void HandleWalkingSpeedOptions()
	{
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0x2F91780", Offset = "0x2F90780", VA = "0x182F91780")]
	private void ApplySwimmingForce()
	{
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x2F98710", Offset = "0x2F97710", VA = "0x182F98710")]
	private void StabilizeSwimmingForce(float normVal)
	{
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x2F978E0", Offset = "0x2F968E0", VA = "0x182F978E0")]
	private void RbAddForce(Vector3 force, ForceMode forceMode = 0)
	{
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x2F97B30", Offset = "0x2F96B30", VA = "0x182F97B30")]
	private void ResetVariables()
	{
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0x2239030", Offset = "0x2238030", VA = "0x182239030")]
	private void DisableAllowJump()
	{
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0x2F97F10", Offset = "0x2F96F10", VA = "0x182F97F10")]
	private void SetGroundedParams(Collision col)
	{
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0x2F9A680", Offset = "0x2F99680", VA = "0x182F9A680")]
	private void resetJumpInputBlock()
	{
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0x2F98B30", Offset = "0x2F97B30", VA = "0x182F98B30")]
	private void StickToGroundHelper()
	{
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void ResetRotations()
	{
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00005988 File Offset: 0x00003B88
	[Token(Token = "0x6000EC7")]
	[Address(RVA = "0x2F91EA0", Offset = "0x2F90EA0", VA = "0x182F91EA0")]
	private float CalculateJumpVerticalSpeed()
	{
		return default(float);
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x000059A0 File Offset: 0x00003BA0
	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0x2F92180", Offset = "0x2F91180", VA = "0x182F92180")]
	private float CalculateWaterJumpVerticalSpeed()
	{
		return default(float);
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC9")]
	[Address(RVA = "0x2F97B90", Offset = "0x2F96B90", VA = "0x182F97B90")]
	public void ScaleCapsuleForCrouching(float alpha)
	{
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0x2F979E0", Offset = "0x2F969E0", VA = "0x182F979E0")]
	private void ResetCapsule()
	{
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ECB")]
	[Address(RVA = "0x2F92F50", Offset = "0x2F91F50", VA = "0x182F92F50")]
	private IEnumerator EnableCrouch()
	{
		return null;
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ECC")]
	[Address(RVA = "0x2F928D0", Offset = "0x2F918D0", VA = "0x182F928D0")]
	private IEnumerator DisableCrouch()
	{
		return null;
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x000059B8 File Offset: 0x00003BB8
	[Token(Token = "0x6000ECD")]
	[Address(RVA = "0x2F95E30", Offset = "0x2F94E30", VA = "0x182F95E30")]
	private bool IsChainSawAttack()
	{
		return default(bool);
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECE")]
	[Address(RVA = "0x2F960A0", Offset = "0x2F950A0", VA = "0x182F960A0")]
	public void LockView(bool rigidbodyLock = true, bool ignoreGrounded = false, bool showMouse = true)
	{
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0x2F98F20", Offset = "0x2F97F20", VA = "0x182F98F20")]
	public void UnLockView()
	{
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x2F9A440", Offset = "0x2F99440", VA = "0x182F9A440")]
	public void enablePaddleOnRaft(bool set)
	{
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x000059D0 File Offset: 0x00003BD0
	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x2F91FF0", Offset = "0x2F90FF0", VA = "0x182F91FF0")]
	public float CalculateWaterDepthParameter()
	{
		return default(float);
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x000059E8 File Offset: 0x00003BE8
	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0x2F91F70", Offset = "0x2F90F70", VA = "0x182F91F70")]
	public float CalculateSpeedParameter(float flatVelocity)
	{
		return default(float);
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x2F92F40", Offset = "0x2F91F40", VA = "0x182F92F40")]
	private void EnableAnimatorJumpBool()
	{
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x2F97DD0", Offset = "0x2F96DD0", VA = "0x182F97DD0")]
	public void SetAnimatorJumpBool(bool value)
	{
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x2F9A610", Offset = "0x2F99610", VA = "0x182F9A610")]
	private void resetAnimSpine()
	{
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void allowJumpingAttack()
	{
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void blockJumpAttack()
	{
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x2F9A800", Offset = "0x2F99800", VA = "0x182F9A800")]
	private IEnumerator smoothEnableSpine()
	{
		return null;
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x2F9A690", Offset = "0x2F99690", VA = "0x182F9A690")]
	public void resetPhysicMaterial()
	{
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x2F9A3E0", Offset = "0x2F993E0", VA = "0x182F9A3E0")]
	private void disableHighDrag()
	{
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0x2F92ED0", Offset = "0x2F91ED0", VA = "0x182F92ED0")]
	private IEnumerator DoForceStopRun()
	{
		return null;
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x2F929C0", Offset = "0x2F919C0", VA = "0x182F929C0")]
	private IEnumerator DisconnectedSledRoutine()
	{
		return null;
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0x2F9A870", Offset = "0x2F99870", VA = "0x182F9A870")]
	private IEnumerator startJumpTimer()
	{
		return null;
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x2F9A370", Offset = "0x2F99370", VA = "0x182F9A370")]
	private IEnumerator clampInput()
	{
		return null;
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0x2F9A660", Offset = "0x2F99660", VA = "0x182F9A660")]
	private void resetBlockWaterJump()
	{
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x2F9A670", Offset = "0x2F99670", VA = "0x182F9A670")]
	private void resetFauxJump()
	{
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x2F91550", Offset = "0x2F90550", VA = "0x182F91550")]
	public void AddMovement(Vector2 movement)
	{
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x5ADD50", Offset = "0x5ACD50", VA = "0x1805ADD50")]
	public void SetRunning(bool value)
	{
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x2F981C0", Offset = "0x2F971C0", VA = "0x182F981C0")]
	public void SetJumping(bool value)
	{
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x2F98500", Offset = "0x2F97500", VA = "0x182F98500")]
	public void SetSuperJump(float value)
	{
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE5")]
	[Address(RVA = "0x2F979F0", Offset = "0x2F969F0", VA = "0x182F979F0")]
	public void ResetJumpMultiplierAfterNextJump(float value)
	{
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE6")]
	[Address(RVA = "0x2F98210", Offset = "0x2F97210", VA = "0x182F98210")]
	public void SetOverrideMovement(Vector2 value)
	{
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE7")]
	[Address(RVA = "0x2F92FC0", Offset = "0x2F91FC0", VA = "0x182F92FC0")]
	public void EnableMovementSlow(float speed = 1.2f)
	{
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE8")]
	[Address(RVA = "0x2F92940", Offset = "0x2F91940", VA = "0x182F92940")]
	public void DisableMovementSlow()
	{
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00005A00 File Offset: 0x00003C00
	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x2F9A080", Offset = "0x2F99080", VA = "0x182F9A080")]
	public bool WasGrounded()
	{
		return default(bool);
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x2F98200", Offset = "0x2F97200", VA = "0x182F98200")]
	public void SetOverrideClampInput(float value)
	{
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x2F94F80", Offset = "0x2F93F80", VA = "0x182F94F80")]
	public void HandleLanded()
	{
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x2F92A30", Offset = "0x2F91A30", VA = "0x182F92A30")]
	private void DoFallDamage()
	{
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x2F9A490", Offset = "0x2F99490", VA = "0x182F9A490")]
	private void fallDamageTimer()
	{
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x2F974D0", Offset = "0x2F964D0", VA = "0x182F974D0")]
	public void PlayLandingSound()
	{
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x2F97290", Offset = "0x2F96290", VA = "0x182F97290")]
	private void PlayLandVocals(string landVocals)
	{
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0x2F9A0A0", Offset = "0x2F990A0", VA = "0x182F9A0A0")]
	public FirstPersonCharacter()
	{
	}

	// Token: 0x04000D63 RID: 3427
	[Token(Token = "0x4000D63")]
	public const float HARD_FALL_THRESHOLD = 28.5f;

	// Token: 0x04000D64 RID: 3428
	[Token(Token = "0x4000D64")]
	private const float WetnessFadePerSecond = 0.033333335f;

	// Token: 0x04000D65 RID: 3429
	[Token(Token = "0x4000D65")]
	private const float WET_GROUND_END = 1f;

	// Token: 0x04000D66 RID: 3430
	[Token(Token = "0x4000D66")]
	private const float IMMERSION_START = 5f;

	// Token: 0x04000D67 RID: 3431
	[Token(Token = "0x4000D67")]
	private const float IMMERSION_END = 10f;

	// Token: 0x04000D68 RID: 3432
	[Token(Token = "0x4000D68")]
	private const float IMMERSION_RANGE = 5f;

	// Token: 0x04000D69 RID: 3433
	[Token(Token = "0x4000D69")]
	private const float Unset = float.NaN;

	// Token: 0x04000D6A RID: 3434
	[Token(Token = "0x4000D6A")]
	[FieldOffset(Offset = "0x0")]
	private static bool _jumpTriggered;

	// Token: 0x04000D6B RID: 3435
	[Token(Token = "0x4000D6B")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 InputHack;

	// Token: 0x04000D6C RID: 3436
	[Token(Token = "0x4000D6C")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask CollisionLayers;

	// Token: 0x04000D6D RID: 3437
	[Token(Token = "0x4000D6D")]
	[FieldOffset(Offset = "0x2C")]
	[FormerlySerializedAs("walkSpeed")]
	[SerializeField]
	private float _walkSpeed;

	// Token: 0x04000D6E RID: 3438
	[Token(Token = "0x4000D6E")]
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("runSpeed")]
	[SerializeField]
	private float _runSpeed;

	// Token: 0x04000D6F RID: 3439
	[Token(Token = "0x4000D6F")]
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("strafeSpeed")]
	[SerializeField]
	private float _strafeSpeed;

	// Token: 0x04000D70 RID: 3440
	[Token(Token = "0x4000D70")]
	[FieldOffset(Offset = "0x38")]
	public float crouchSpeed;

	// Token: 0x04000D71 RID: 3441
	[Token(Token = "0x4000D71")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[FormerlySerializedAs("swimmingSpeed")]
	private float _swimSpeed;

	// Token: 0x04000D72 RID: 3442
	[Token(Token = "0x4000D72")]
	[FieldOffset(Offset = "0x40")]
	public float staminaCostPerSec;

	// Token: 0x04000D73 RID: 3443
	[Token(Token = "0x4000D73")]
	[FieldOffset(Offset = "0x44")]
	public float minCamRotationRange;

	// Token: 0x04000D74 RID: 3444
	[Token(Token = "0x4000D74")]
	[FieldOffset(Offset = "0x48")]
	public bool standingOnRaft;

	// Token: 0x04000D75 RID: 3445
	[Token(Token = "0x4000D75")]
	[FieldOffset(Offset = "0x49")]
	public bool StandingOnDynamicObject;

	// Token: 0x04000D76 RID: 3446
	[Token(Token = "0x4000D76")]
	[FieldOffset(Offset = "0x4A")]
	public bool Locked;

	// Token: 0x04000D77 RID: 3447
	[Token(Token = "0x4000D77")]
	[FieldOffset(Offset = "0x4C")]
	public float gravity;

	// Token: 0x04000D78 RID: 3448
	[Token(Token = "0x4000D78")]
	[FieldOffset(Offset = "0x50")]
	public float maxVelocityChange;

	// Token: 0x04000D79 RID: 3449
	[Token(Token = "0x4000D79")]
	[FieldOffset(Offset = "0x54")]
	public float maximumVelocity;

	// Token: 0x04000D7A RID: 3450
	[Token(Token = "0x4000D7A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[FormerlySerializedAs("jumpHeight")]
	private float _jumpHeight;

	// Token: 0x04000D7B RID: 3451
	[Token(Token = "0x4000D7B")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float _edgeWaterJumpMultiplier;

	// Token: 0x04000D7C RID: 3452
	[Token(Token = "0x4000D7C")]
	[FieldOffset(Offset = "0x60")]
	private bool _allowJump;

	// Token: 0x04000D7D RID: 3453
	[Token(Token = "0x4000D7D")]
	[FieldOffset(Offset = "0x61")]
	private bool _canJump;

	// Token: 0x04000D7E RID: 3454
	[Token(Token = "0x4000D7E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private StepHelper _stepHelper;

	// Token: 0x04000D7F RID: 3455
	[Token(Token = "0x4000D7F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Collider _wallPusherCollider;

	// Token: 0x04000D80 RID: 3456
	[Token(Token = "0x4000D80")]
	[FieldOffset(Offset = "0x78")]
	public float stickToGroundHelperDistance;

	// Token: 0x04000D81 RID: 3457
	[Token(Token = "0x4000D81")]
	[FieldOffset(Offset = "0x7C")]
	public float groundStableForce;

	// Token: 0x04000D82 RID: 3458
	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float _extremeAngleGroundedLimitStart;

	// Token: 0x04000D83 RID: 3459
	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float _extremeAngleGroundedLimitMax;

	// Token: 0x04000D84 RID: 3460
	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x88")]
	public float maxDiveVelocity;

	// Token: 0x04000D85 RID: 3461
	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0x8C")]
	[FormerlySerializedAs("maxSwimVelocity")]
	public float _maxSwimVelocity;

	// Token: 0x04000D86 RID: 3462
	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0x90")]
	private float _nextSwimNoiseTime;

	// Token: 0x04000D87 RID: 3463
	[Token(Token = "0x4000D87")]
	[FieldOffset(Offset = "0x94")]
	private bool _isInMidAction;

	// Token: 0x04000D88 RID: 3464
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0x95")]
	public bool IsBlockingActive;

	// Token: 0x04000D89 RID: 3465
	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Min(0f)]
	private float _walkToRunThreshold;

	// Token: 0x04000D8A RID: 3466
	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0x9C")]
	private bool _sprintInputActive;

	// Token: 0x04000D8B RID: 3467
	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0x9D")]
	private bool _sprintActive;

	// Token: 0x04000D8C RID: 3468
	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0x9E")]
	private bool _crouchHeightBlocked;

	// Token: 0x04000D8D RID: 3469
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0x9F")]
	public bool _doingExitVelocity;

	// Token: 0x04000D8E RID: 3470
	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0xA0")]
	public RigidBodyCollisionFlags collFlags;

	// Token: 0x04000D8F RID: 3471
	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[FormerlySerializedAs("capsule")]
	private CapsuleCollider _primaryCollider;

	// Token: 0x04000D90 RID: 3472
	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[FormerlySerializedAs("originalHeight")]
	private float _defaultPrimaryColliderHeight;

	// Token: 0x04000D91 RID: 3473
	[Token(Token = "0x4000D91")]
	[FieldOffset(Offset = "0xB4")]
	[FormerlySerializedAs("originalYPos")]
	[SerializeField]
	private Vector3 _defaultPrimaryColliderCenter;

	// Token: 0x04000D92 RID: 3474
	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0xC0")]
	[FormerlySerializedAs("crouchCapsuleCenter")]
	[SerializeField]
	private float _crouchColliderCenter;

	// Token: 0x04000D93 RID: 3475
	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0xC8")]
	[FormerlySerializedAs("rb")]
	public Rigidbody _rigidbody;

	// Token: 0x04000D94 RID: 3476
	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0xD0")]
	private bool _prevGrounded;

	// Token: 0x04000D95 RID: 3477
	[Token(Token = "0x4000D95")]
	[FieldOffset(Offset = "0xD1")]
	private bool _primaryColliderEnabled;

	// Token: 0x04000D96 RID: 3478
	[Token(Token = "0x4000D96")]
	[FieldOffset(Offset = "0xD2")]
	private bool _stepHelperEnabled;

	// Token: 0x04000D97 RID: 3479
	[Token(Token = "0x4000D97")]
	[FieldOffset(Offset = "0xD3")]
	public bool allowFallDamage;

	// Token: 0x04000D98 RID: 3480
	[Token(Token = "0x4000D98")]
	[FieldOffset(Offset = "0xD4")]
	public bool jumpCoolDown;

	// Token: 0x04000D99 RID: 3481
	[Token(Token = "0x4000D99")]
	[FieldOffset(Offset = "0xD5")]
	public bool checkGrounded;

	// Token: 0x04000D9A RID: 3482
	[Token(Token = "0x4000D9A")]
	[FieldOffset(Offset = "0xD6")]
	public bool checkSwimming;

	// Token: 0x04000D9B RID: 3483
	[Token(Token = "0x4000D9B")]
	[FieldOffset(Offset = "0xD7")]
	public bool terrainContact;

	// Token: 0x04000D9C RID: 3484
	[Token(Token = "0x4000D9C")]
	[FieldOffset(Offset = "0xD8")]
	public Vector3 inputVelocity;

	// Token: 0x04000D9D RID: 3485
	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0xE4")]
	public Vector3 velocity;

	// Token: 0x04000DA0 RID: 3488
	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0xF2")]
	private bool _shouldCrouch;

	// Token: 0x04000DA1 RID: 3489
	[Token(Token = "0x4000DA1")]
	[FieldOffset(Offset = "0xF3")]
	private bool _standUp;

	// Token: 0x04000DA2 RID: 3490
	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0xF4")]
	public bool inSnow;

	// Token: 0x04000DA3 RID: 3491
	[Token(Token = "0x4000DA3")]
	[FieldOffset(Offset = "0xF8")]
	public float crouchHeight;

	// Token: 0x04000DA4 RID: 3492
	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0xFC")]
	private bool _canSprint;

	// Token: 0x04000DA5 RID: 3493
	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0xFD")]
	public bool allowWaterJump;

	// Token: 0x04000DA6 RID: 3494
	[Token(Token = "0x4000DA6")]
	[FieldOffset(Offset = "0xFE")]
	public bool hitByEnemy;

	// Token: 0x04000DA7 RID: 3495
	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0x100")]
	public float jumpingTimer;

	// Token: 0x04000DA8 RID: 3496
	[Token(Token = "0x4000DA8")]
	[FieldOffset(Offset = "0x104")]
	private float _clampInputVal;

	// Token: 0x04000DA9 RID: 3497
	[Token(Token = "0x4000DA9")]
	[FieldOffset(Offset = "0x108")]
	public bool doingClampInput;

	// Token: 0x04000DAA RID: 3498
	[Token(Token = "0x4000DAA")]
	[FieldOffset(Offset = "0x10C")]
	public float clampInputDelay;

	// Token: 0x04000DAB RID: 3499
	[Token(Token = "0x4000DAB")]
	[FieldOffset(Offset = "0x110")]
	public float defaultMass;

	// Token: 0x04000DAC RID: 3500
	[Token(Token = "0x4000DAC")]
	[FieldOffset(Offset = "0x114")]
	public float timeToRecoverFromRun;

	// Token: 0x04000DAD RID: 3501
	[Token(Token = "0x4000DAD")]
	[FieldOffset(Offset = "0x118")]
	public bool onSlipperySlope;

	// Token: 0x04000DAE RID: 3502
	[Token(Token = "0x4000DAE")]
	[FieldOffset(Offset = "0x119")]
	public bool enforceHighDrag;

	// Token: 0x04000DAF RID: 3503
	[Token(Token = "0x4000DAF")]
	[FieldOffset(Offset = "0x11A")]
	public bool VerboseAddForce;

	// Token: 0x04000DB0 RID: 3504
	[Token(Token = "0x4000DB0")]
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	private float _swimSpeedMultiplier;

	// Token: 0x04000DB1 RID: 3505
	[Token(Token = "0x4000DB1")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private bool _verboseStatusChange;

	// Token: 0x04000DB2 RID: 3506
	[Token(Token = "0x4000DB2")]
	[FieldOffset(Offset = "0x121")]
	[SerializeField]
	private bool _debugJumping;

	// Token: 0x04000DB3 RID: 3507
	[Token(Token = "0x4000DB3")]
	[FieldOffset(Offset = "0x124")]
	private float _speed;

	// Token: 0x04000DB4 RID: 3508
	[Token(Token = "0x4000DB4")]
	[FieldOffset(Offset = "0x128")]
	private Vector3 _targetVelocity;

	// Token: 0x04000DB5 RID: 3509
	[Token(Token = "0x4000DB5")]
	[FieldOffset(Offset = "0x134")]
	private readonly float backwardSpeedMult;

	// Token: 0x04000DB6 RID: 3510
	[Token(Token = "0x4000DB6")]
	[FieldOffset(Offset = "0x138")]
	private bool _buildInputActive;

	// Token: 0x04000DB7 RID: 3511
	[Token(Token = "0x4000DB7")]
	[FieldOffset(Offset = "0x140")]
	private readonly List<ContactPoint> _contacts;

	// Token: 0x04000DB8 RID: 3512
	[Token(Token = "0x4000DB8")]
	[FieldOffset(Offset = "0x148")]
	private Vector2 _currentInputMovement;

	// Token: 0x04000DB9 RID: 3513
	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0x150")]
	private bool _disableGravity;

	// Token: 0x04000DBA RID: 3514
	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x151")]
	private bool _hasOverrideMovement;

	// Token: 0x04000DBB RID: 3515
	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0x158")]
	private SphereCollider _headCollider;

	// Token: 0x04000DBC RID: 3516
	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x160")]
	private bool _isGrounded;

	// Token: 0x04000DBD RID: 3517
	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0x161")]
	private bool _movementSlowIsActive;

	// Token: 0x04000DBE RID: 3518
	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x164")]
	private Vector2 _overrideMovement;

	// Token: 0x04000DBF RID: 3519
	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x16C")]
	private Vector3 _prevVelocity;

	// Token: 0x04000DC0 RID: 3520
	[Token(Token = "0x4000DC0")]
	[FieldOffset(Offset = "0x178")]
	private bool _runningOverride;

	// Token: 0x04000DC1 RID: 3521
	[Token(Token = "0x4000DC1")]
	[FieldOffset(Offset = "0x17C")]
	private float _runSpeedBeforeSlow;

	// Token: 0x04000DC2 RID: 3522
	[Token(Token = "0x4000DC2")]
	[FieldOffset(Offset = "0x180")]
	private float _setJumpMultiplierAfterJump;

	// Token: 0x04000DC3 RID: 3523
	[Token(Token = "0x4000DC3")]
	[FieldOffset(Offset = "0x184")]
	private Vector2 _storedMovementInput;

	// Token: 0x04000DC4 RID: 3524
	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0x18C")]
	private float _strafeSpeedBeforeSlow;

	// Token: 0x04000DC5 RID: 3525
	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0x190")]
	private float _swimSpeedBeforeSlow;

	// Token: 0x04000DC6 RID: 3526
	[Token(Token = "0x4000DC6")]
	[FieldOffset(Offset = "0x198")]
	private Vitals _vitals;

	// Token: 0x04000DC7 RID: 3527
	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0x1A0")]
	private bool _vrHandTrackingGoalValue;

	// Token: 0x04000DC8 RID: 3528
	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0x1A4")]
	private int _jumpPressFixedFrame;

	// Token: 0x04000DC9 RID: 3529
	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0x1A8")]
	private float _walkSpeedBeforeSlow;

	// Token: 0x04000DCA RID: 3530
	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0x1AC")]
	private float _wetnessCurrent;

	// Token: 0x04000DCB RID: 3531
	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0x1B0")]
	private bool allowFauxGrounded;

	// Token: 0x04000DCC RID: 3532
	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0x1B8")]
	private Animator animator;

	// Token: 0x04000DCD RID: 3533
	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0x1C0")]
	private bool blockFauxJump;

	// Token: 0x04000DCE RID: 3534
	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0x1C1")]
	private bool blockWaterJump;

	// Token: 0x04000DCF RID: 3535
	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0x1C4")]
	private float clampAirTouch;

	// Token: 0x04000DD0 RID: 3536
	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0x1C8")]
	private bool crouchBlock;

	// Token: 0x04000DD1 RID: 3537
	[Token(Token = "0x4000DD1")]
	[FieldOffset(Offset = "0x1C9")]
	private bool fallShakeBlock;

	// Token: 0x04000DD2 RID: 3538
	[Token(Token = "0x4000DD2")]
	[FieldOffset(Offset = "0x1CA")]
	private bool FauxGrounded;

	// Token: 0x04000DD3 RID: 3539
	[Token(Token = "0x4000DD3")]
	[FieldOffset(Offset = "0x1CC")]
	private float fauxGroundedTimer;

	// Token: 0x04000DD4 RID: 3540
	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0x1D0")]
	private bool forceStopRun;

	// Token: 0x04000DD5 RID: 3541
	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0x1D4")]
	private float _defaultExtremeAngleGroundedLimitStart;

	// Token: 0x04000DD6 RID: 3542
	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0x1D8")]
	private float _defaultExtremeAngleGroundedLimitMax;

	// Token: 0x04000DD7 RID: 3543
	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x1DC")]
	private RaycastHit hitInfo;

	// Token: 0x04000DD8 RID: 3544
	[Token(Token = "0x4000DD8")]
	[FieldOffset(Offset = "0x208")]
	private Vector2 input;

	// Token: 0x04000DD9 RID: 3545
	[Token(Token = "0x4000DD9")]
	[FieldOffset(Offset = "0x210")]
	private bool inSand;

	// Token: 0x04000DDA RID: 3546
	[Token(Token = "0x4000DDA")]
	[FieldOffset(Offset = "0x211")]
	private bool jumpFuzzyDelay;

	// Token: 0x04000DDB RID: 3547
	[Token(Token = "0x4000DDB")]
	[FieldOffset(Offset = "0x212")]
	private bool jumpInputBlock;

	// Token: 0x04000DDC RID: 3548
	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0x213")]
	private bool jumpLand;

	// Token: 0x04000DDD RID: 3549
	[Token(Token = "0x4000DDD")]
	[FieldOffset(Offset = "0x214")]
	private bool jumpTimerStarted;

	// Token: 0x04000DDE RID: 3550
	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0x218")]
	private float lastUpdateTime;

	// Token: 0x04000DDF RID: 3551
	[Token(Token = "0x4000DDF")]
	[FieldOffset(Offset = "0x21C")]
	private float modExtremeAngleLimit;

	// Token: 0x04000DE0 RID: 3552
	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x220")]
	private bool multisledContact;

	// Token: 0x04000DE1 RID: 3553
	[Token(Token = "0x4000DE1")]
	[FieldOffset(Offset = "0x224")]
	private float prevMouseXSpeed;

	// Token: 0x04000DE2 RID: 3554
	[Token(Token = "0x4000DE2")]
	[FieldOffset(Offset = "0x228")]
	private float prevYPos;

	// Token: 0x04000DE3 RID: 3555
	[Token(Token = "0x4000DE3")]
	[FieldOffset(Offset = "0x22C")]
	private bool recentlyDisabledSled;

	// Token: 0x04000DE4 RID: 3556
	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x230")]
	private playerScriptSetup setup;

	// Token: 0x04000DE5 RID: 3557
	[Token(Token = "0x4000DE5")]
	[FieldOffset(Offset = "0x238")]
	private bool stamRechargeDelay;

	// Token: 0x04000DE6 RID: 3558
	[Token(Token = "0x4000DE6")]
	[FieldOffset(Offset = "0x240")]
	private PlayerStats Stats;

	// Token: 0x04000DE7 RID: 3559
	[Token(Token = "0x4000DE7")]
	[FieldOffset(Offset = "0x248")]
	private float storeMaxVelocity;

	// Token: 0x04000DE8 RID: 3560
	[Token(Token = "0x4000DE8")]
	[FieldOffset(Offset = "0x24C")]
	private Vector3 storeTargetVelocity;

	// Token: 0x04000DE9 RID: 3561
	[Token(Token = "0x4000DE9")]
	[FieldOffset(Offset = "0x258")]
	private bool validateGrounded;

	// Token: 0x04000DEA RID: 3562
	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x260")]
	private VRPlayerAdapter vrAdapter;

	// Token: 0x04000DEB RID: 3563
	[Token(Token = "0x4000DEB")]
	[FieldOffset(Offset = "0x268")]
	private float yChange;

	// Token: 0x04000DEC RID: 3564
	[Token(Token = "0x4000DEC")]
	[FieldOffset(Offset = "0x26C")]
	private int _currentFixedFrame;

	// Token: 0x04000DED RID: 3565
	[Token(Token = "0x4000DED")]
	[FieldOffset(Offset = "0x270")]
	private int _groundedFrame;

	// Token: 0x04000DEE RID: 3566
	[Token(Token = "0x4000DEE")]
	[FieldOffset(Offset = "0x274")]
	private bool _forceGrounded;

	// Token: 0x04000DEF RID: 3567
	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0x278")]
	private float _landingVelocityY;

	// Token: 0x04000DF0 RID: 3568
	[Token(Token = "0x4000DF0")]
	[FieldOffset(Offset = "0x27C")]
	private int _landingFrame;

	// Token: 0x04000DF1 RID: 3569
	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0x280")]
	private bool _sitting;

	// Token: 0x04000DF2 RID: 3570
	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0x281")]
	private bool _movementLocked;

	// Token: 0x04000DF3 RID: 3571
	[Token(Token = "0x4000DF3")]
	[FieldOffset(Offset = "0x288")]
	private PhysicMaterial _playerPhysicMaterial;

	// Token: 0x04000DF4 RID: 3572
	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x290")]
	private float _recoveringFromRun;

	// Token: 0x04000DF5 RID: 3573
	[Token(Token = "0x4000DF5")]
	[FieldOffset(Offset = "0x294")]
	private float _jumpMultiplier;

	// Token: 0x04000DF6 RID: 3574
	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0x298")]
	private bool _isJumping;

	// Token: 0x04000DF7 RID: 3575
	[Token(Token = "0x4000DF7")]
	[FieldOffset(Offset = "0x299")]
	private bool _cachedJumpBoolHash;

	// Token: 0x04000DF8 RID: 3576
	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x2A0")]
	private AutoTimer _swimmingJumpTimer;

	// Token: 0x04000DF9 RID: 3577
	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x2A8")]
	private float _overrideClampInput;

	// Token: 0x04000DFA RID: 3578
	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0x2AC")]
	private int _subFixedFrameCount;

	// Token: 0x04000DFB RID: 3579
	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0x2B0")]
	private int _subFixedFrameCountId;

	// Token: 0x04000DFC RID: 3580
	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x2B8")]
	private Collision[] _trackedCollisions;

	// Token: 0x04000DFD RID: 3581
	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x2C0")]
	private int _trackedCollisionIndex;

	// Token: 0x04000DFE RID: 3582
	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0x2C4")]
	private float _prevLandingVelocityY;

	// Token: 0x04000E00 RID: 3584
	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	private float _fallDamageVelocity;

	// Token: 0x04000E01 RID: 3585
	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x2D4")]
	[SerializeField]
	private float _baseFallDamage;

	// Token: 0x04000E02 RID: 3586
	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0x2D8")]
	[SerializeField]
	private float _fallDamagePower;

	// Token: 0x04000E03 RID: 3587
	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0x2E0")]
	[SerializeField]
	[EventRef]
	private string _landVocals;

	// Token: 0x04000E04 RID: 3588
	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	[Tooltip("Air time required for landing SFX to be played")]
	private float _airTimeThreshold;

	// Token: 0x04000E05 RID: 3589
	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0x2EC")]
	[SerializeField]
	private float _landSpeedThreshold;

	// Token: 0x04000E06 RID: 3590
	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0x2F0")]
	private bool _activeHandlingLanded;
}
