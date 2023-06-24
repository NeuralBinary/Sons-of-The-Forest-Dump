using System;
using System.Runtime.CompilerServices;
using Endnight.Types;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000815 RID: 2069
	[Token(Token = "0x2000815")]
	[Serializable]
	public class LogSledControllerState : ClearOnDisposeBase
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600391A RID: 14618 RVA: 0x00011478 File Offset: 0x0000F678
		// (set) Token: 0x0600391B RID: 14619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000746")]
		[ClearOnDispose(false)]
		public bool IsConnected
		{
			[Token(Token = "0x600391A")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600391B")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600391C RID: 14620 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600391D RID: 14621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000747")]
		[ClearOnDispose(null)]
		public LogSledControllerDefinition Definition
		{
			[Token(Token = "0x600391C")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600391D")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600391F RID: 14623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000748")]
		[ClearOnDispose(null)]
		public LogSledController LogSledController
		{
			[Token(Token = "0x600391E")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600391F")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06003920 RID: 14624 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003921 RID: 14625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000749")]
		[ClearOnDispose(null)]
		public Transform PushPivot
		{
			[Token(Token = "0x6003920")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003921")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x00011490 File Offset: 0x0000F690
		// (set) Token: 0x06003923 RID: 14627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074A")]
		[ClearOnDispose]
		public Vector2 MovementInput
		{
			[Token(Token = "0x6003922")]
			[Address(RVA = "0x35541E0", Offset = "0x35527E0", VA = "0x1835541E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6003923")]
			[Address(RVA = "0x25A71E0", Offset = "0x25A57E0", VA = "0x1825A71E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06003924 RID: 14628 RVA: 0x000114A8 File Offset: 0x0000F6A8
		// (set) Token: 0x06003925 RID: 14629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074B")]
		[ClearOnDispose]
		public Vector2 AccumulatedMovementInput
		{
			[Token(Token = "0x6003924")]
			[Address(RVA = "0x3554200", Offset = "0x3552800", VA = "0x183554200")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6003925")]
			[Address(RVA = "0x75C1B0", Offset = "0x75A7B0", VA = "0x18075C1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06003926 RID: 14630 RVA: 0x000114C0 File Offset: 0x0000F6C0
		// (set) Token: 0x06003927 RID: 14631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074C")]
		[ClearOnDispose]
		public Vector2 LastInputMovement
		{
			[Token(Token = "0x6003926")]
			[Address(RVA = "0x3554220", Offset = "0x3552820", VA = "0x183554220")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6003927")]
			[Address(RVA = "0x151E630", Offset = "0x151CC30", VA = "0x18151E630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06003928 RID: 14632 RVA: 0x000114D8 File Offset: 0x0000F6D8
		// (set) Token: 0x06003929 RID: 14633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074D")]
		[ClearOnDispose(0f)]
		public float LastVelocityMultiplier
		{
			[Token(Token = "0x6003928")]
			[Address(RVA = "0x5F1D00", Offset = "0x5F0300", VA = "0x1805F1D00")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003929")]
			[Address(RVA = "0x2D635A0", Offset = "0x2D61BA0", VA = "0x182D635A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x0600392A RID: 14634 RVA: 0x000114F0 File Offset: 0x0000F6F0
		// (set) Token: 0x0600392B RID: 14635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074E")]
		[ClearOnDispose]
		public Vector3 AppliedVelocityChange
		{
			[Token(Token = "0x600392A")]
			[Address(RVA = "0x28D17F0", Offset = "0x28CFDF0", VA = "0x1828D17F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600392B")]
			[Address(RVA = "0x301B050", Offset = "0x3019650", VA = "0x18301B050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600392C RID: 14636 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600392D RID: 14637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074F")]
		[ClearOnDispose(null)]
		public GameObject BlockerCollidersInstance
		{
			[Token(Token = "0x600392C")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600392D")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x00011508 File Offset: 0x0000F708
		// (set) Token: 0x0600392F RID: 14639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000750")]
		[ClearOnDispose]
		public Quaternion HandlePivotRotationGoal
		{
			[Token(Token = "0x600392E")]
			[Address(RVA = "0x24FCA30", Offset = "0x24FB030", VA = "0x1824FCA30")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600392F")]
			[Address(RVA = "0x25A7210", Offset = "0x25A5810", VA = "0x1825A7210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x00011520 File Offset: 0x0000F720
		// (set) Token: 0x06003931 RID: 14641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000751")]
		[ClearOnDispose]
		public Quaternion CurrentHandlePivotLocalRotation
		{
			[Token(Token = "0x6003930")]
			[Address(RVA = "0x25A7220", Offset = "0x25A5820", VA = "0x1825A7220")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6003931")]
			[Address(RVA = "0x25A7230", Offset = "0x25A5830", VA = "0x1825A7230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06003932 RID: 14642 RVA: 0x00011538 File Offset: 0x0000F738
		// (set) Token: 0x06003933 RID: 14643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000752")]
		[ClearOnDispose(0f)]
		public float TwistRotationAngle
		{
			[Token(Token = "0x6003932")]
			[Address(RVA = "0x6124C0", Offset = "0x610AC0", VA = "0x1806124C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003933")]
			[Address(RVA = "0x6124D0", Offset = "0x610AD0", VA = "0x1806124D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06003934 RID: 14644 RVA: 0x00011550 File Offset: 0x0000F750
		// (set) Token: 0x06003935 RID: 14645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000753")]
		[ClearOnDispose(0f)]
		public float TiltRotationAngle
		{
			[Token(Token = "0x6003934")]
			[Address(RVA = "0x23BB730", Offset = "0x23B9D30", VA = "0x1823BB730")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003935")]
			[Address(RVA = "0x28E2200", Offset = "0x28E0800", VA = "0x1828E2200")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06003936 RID: 14646 RVA: 0x00011568 File Offset: 0x0000F768
		// (set) Token: 0x06003937 RID: 14647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000754")]
		[ClearOnDispose]
		public Vector3 RigidbodyVelocity
		{
			[Token(Token = "0x6003936")]
			[Address(RVA = "0x179DC20", Offset = "0x179C220", VA = "0x18179DC20")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003937")]
			[Address(RVA = "0x179DC40", Offset = "0x179C240", VA = "0x18179DC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x00011580 File Offset: 0x0000F780
		// (set) Token: 0x06003939 RID: 14649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000755")]
		[ClearOnDispose(0f)]
		public float AirStartTime
		{
			[Token(Token = "0x6003938")]
			[Address(RVA = "0x728300", Offset = "0x726900", VA = "0x180728300")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003939")]
			[Address(RVA = "0x728310", Offset = "0x726910", VA = "0x180728310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x0600393A RID: 14650 RVA: 0x00011598 File Offset: 0x0000F798
		// (set) Token: 0x0600393B RID: 14651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000756")]
		[ClearOnDispose(-1)]
		public int InitializedFrame
		{
			[Token(Token = "0x600393A")]
			[Address(RVA = "0xAFF330", Offset = "0xAFD930", VA = "0x180AFF330")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600393B")]
			[Address(RVA = "0xAFF340", Offset = "0xAFD940", VA = "0x180AFF340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600393C RID: 14652 RVA: 0x000115B0 File Offset: 0x0000F7B0
		// (set) Token: 0x0600393D RID: 14653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000757")]
		[ClearOnDispose(-1f)]
		public float InitializedTime
		{
			[Token(Token = "0x600393C")]
			[Address(RVA = "0x728340", Offset = "0x726940", VA = "0x180728340")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600393D")]
			[Address(RVA = "0x728350", Offset = "0x726950", VA = "0x180728350")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600393E RID: 14654 RVA: 0x000115C8 File Offset: 0x0000F7C8
		// (set) Token: 0x0600393F RID: 14655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000758")]
		[ClearOnDispose(false)]
		public bool SetupBindings
		{
			[Token(Token = "0x600393E")]
			[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600393F")]
			[Address(RVA = "0x6124F0", Offset = "0x610AF0", VA = "0x1806124F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06003940 RID: 14656 RVA: 0x000115E0 File Offset: 0x0000F7E0
		// (set) Token: 0x06003941 RID: 14657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000759")]
		[ClearOnDispose(1f)]
		public float RunningMultiplier
		{
			[Token(Token = "0x6003940")]
			[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003941")]
			[Address(RVA = "0x35535C0", Offset = "0x3551BC0", VA = "0x1835535C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06003942 RID: 14658 RVA: 0x000115F8 File Offset: 0x0000F7F8
		// (set) Token: 0x06003943 RID: 14659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075A")]
		[ClearOnDispose]
		public Vector3 LastForwardDirection
		{
			[Token(Token = "0x6003942")]
			[Address(RVA = "0x2A224C0", Offset = "0x2A20AC0", VA = "0x182A224C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003943")]
			[Address(RVA = "0x35535D0", Offset = "0x3551BD0", VA = "0x1835535D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06003944 RID: 14660 RVA: 0x00011610 File Offset: 0x0000F810
		// (set) Token: 0x06003945 RID: 14661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075B")]
		[ClearOnDispose]
		public Vector3 LerpForwardDirectionVelocity
		{
			[Token(Token = "0x6003944")]
			[Address(RVA = "0x2A22570", Offset = "0x2A20B70", VA = "0x182A22570")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003945")]
			[Address(RVA = "0x3554240", Offset = "0x3552840", VA = "0x183554240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06003946 RID: 14662 RVA: 0x00011628 File Offset: 0x0000F828
		// (set) Token: 0x06003947 RID: 14663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075C")]
		[ClearOnDispose(0f)]
		public float PlayerGroundHeightOffset
		{
			[Token(Token = "0x6003946")]
			[Address(RVA = "0x2739970", Offset = "0x2737F70", VA = "0x182739970")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003947")]
			[Address(RVA = "0x3553E30", Offset = "0x3552430", VA = "0x183553E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x00011640 File Offset: 0x0000F840
		// (set) Token: 0x06003949 RID: 14665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075D")]
		[ClearOnDispose]
		public Vector3 PlayerGroundHitPoint
		{
			[Token(Token = "0x6003948")]
			[Address(RVA = "0x623610", Offset = "0x621C10", VA = "0x180623610")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003949")]
			[Address(RVA = "0x29628F0", Offset = "0x2960EF0", VA = "0x1829628F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x00011658 File Offset: 0x0000F858
		// (set) Token: 0x0600394B RID: 14667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075E")]
		[ClearOnDispose(0f)]
		public float SledGroundHeightOffset
		{
			[Token(Token = "0x600394A")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600394B")]
			[Address(RVA = "0x270E6C0", Offset = "0x270CCC0", VA = "0x18270E6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x00011670 File Offset: 0x0000F870
		// (set) Token: 0x0600394D RID: 14669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075F")]
		[ClearOnDispose]
		public Vector3 SledGGroundHitPoint
		{
			[Token(Token = "0x600394C")]
			[Address(RVA = "0x13429A0", Offset = "0x1340FA0", VA = "0x1813429A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600394D")]
			[Address(RVA = "0x13429C0", Offset = "0x1340FC0", VA = "0x1813429C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600394E RID: 14670 RVA: 0x00011688 File Offset: 0x0000F888
		// (set) Token: 0x0600394F RID: 14671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000760")]
		[ClearOnDispose]
		public EventInstance SledEventInstance
		{
			[Token(Token = "0x600394E")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			[CompilerGenerated]
			get
			{
				return default(EventInstance);
			}
			[Token(Token = "0x600394F")]
			[Address(RVA = "0x3554260", Offset = "0x3552860", VA = "0x183554260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x000116A0 File Offset: 0x0000F8A0
		// (set) Token: 0x06003951 RID: 14673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000761")]
		[ClearOnDispose]
		public Vector3 SledGroundHitOrigin
		{
			[Token(Token = "0x6003950")]
			[Address(RVA = "0x3554270", Offset = "0x3552870", VA = "0x183554270")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003951")]
			[Address(RVA = "0x3554290", Offset = "0x3552890", VA = "0x183554290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x000116B8 File Offset: 0x0000F8B8
		// (set) Token: 0x06003953 RID: 14675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000762")]
		[ClearOnDispose(0f)]
		public float LogSledPushAudioEventSpeed
		{
			[Token(Token = "0x6003952")]
			[Address(RVA = "0x2739540", Offset = "0x2737B40", VA = "0x182739540")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003953")]
			[Address(RVA = "0x2B6FC40", Offset = "0x2B6E240", VA = "0x182B6FC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06003954 RID: 14676 RVA: 0x000116D0 File Offset: 0x0000F8D0
		// (set) Token: 0x06003955 RID: 14677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000763")]
		[ClearOnDispose(false)]
		public bool IsStrafing
		{
			[Token(Token = "0x6003954")]
			[Address(RVA = "0x30AED30", Offset = "0x30AD330", VA = "0x1830AED30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003955")]
			[Address(RVA = "0x30B1D00", Offset = "0x30B0300", VA = "0x1830B1D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06003956 RID: 14678 RVA: 0x000116E8 File Offset: 0x0000F8E8
		// (set) Token: 0x06003957 RID: 14679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000764")]
		[ClearOnDispose]
		public Quaternion HeightAdjustmentRotationOffset
		{
			[Token(Token = "0x6003956")]
			[Address(RVA = "0x35542B0", Offset = "0x35528B0", VA = "0x1835542B0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6003957")]
			[Address(RVA = "0x35542C0", Offset = "0x35528C0", VA = "0x1835542C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06003958 RID: 14680 RVA: 0x00011700 File Offset: 0x0000F900
		// (set) Token: 0x06003959 RID: 14681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000765")]
		[ClearOnDispose(0)]
		public int FailedTargetTransformRaycastCount
		{
			[Token(Token = "0x6003958")]
			[Address(RVA = "0xAFF620", Offset = "0xAFDC20", VA = "0x180AFF620")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003959")]
			[Address(RVA = "0xAFF630", Offset = "0xAFDC30", VA = "0x180AFF630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600395A RID: 14682 RVA: 0x00011718 File Offset: 0x0000F918
		// (set) Token: 0x0600395B RID: 14683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000766")]
		[ClearOnDispose(false)]
		public bool ShouldDisconnectFromAirTime
		{
			[Token(Token = "0x600395A")]
			[Address(RVA = "0x35542D0", Offset = "0x35528D0", VA = "0x1835542D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600395B")]
			[Address(RVA = "0x35542E0", Offset = "0x35528E0", VA = "0x1835542E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395C")]
		[Address(RVA = "0x35542F0", Offset = "0x35528F0", VA = "0x1835542F0", Slot = "5")]
		protected override void PreDispose()
		{
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395D")]
		[Address(RVA = "0x35543D0", Offset = "0x35529D0", VA = "0x1835543D0")]
		public LogSledControllerState()
		{
		}

		// Token: 0x04003140 RID: 12608
		[Token(Token = "0x4003140")]
		[FieldOffset(Offset = "0xF4")]
		[ClearOnDispose(0f)]
		public float LogSledPushAudioEventSpeedVelocity;
	}
}
