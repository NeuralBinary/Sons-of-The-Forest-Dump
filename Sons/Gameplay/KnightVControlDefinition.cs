using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000813 RID: 2067
	[Token(Token = "0x2000813")]
	[CreateAssetMenu(menuName = "Sons/KnightV/ControlDefinition", fileName = "KnightVControlDefinition", order = 0)]
	public class KnightVControlDefinition : ScriptableObject
	{
		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06003852 RID: 14418 RVA: 0x00010C68 File Offset: 0x0000EE68
		// (set) Token: 0x06003853 RID: 14419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E3")]
		public Vector3 VelocityFade
		{
			[Token(Token = "0x6003852")]
			[Address(RVA = "0xA6DCA0", Offset = "0xA6C2A0", VA = "0x180A6DCA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003853")]
			[Address(RVA = "0x1676010", Offset = "0x1674610", VA = "0x181676010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x00010C80 File Offset: 0x0000EE80
		// (set) Token: 0x06003855 RID: 14421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E4")]
		public float MaxVelocity
		{
			[Token(Token = "0x6003854")]
			[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003855")]
			[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x00010C98 File Offset: 0x0000EE98
		// (set) Token: 0x06003857 RID: 14423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E5")]
		public float AccelerationInputRate
		{
			[Token(Token = "0x6003856")]
			[Address(RVA = "0x623B80", Offset = "0x622180", VA = "0x180623B80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003857")]
			[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06003858 RID: 14424 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		// (set) Token: 0x06003859 RID: 14425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E6")]
		public float MaxForwardAcceleration
		{
			[Token(Token = "0x6003858")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003859")]
			[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600385A RID: 14426 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		// (set) Token: 0x0600385B RID: 14427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E7")]
		public float MaxReverseAcceleration
		{
			[Token(Token = "0x600385A")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600385B")]
			[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600385C RID: 14428 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		// (set) Token: 0x0600385D RID: 14429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E8")]
		public float AccelerationFade
		{
			[Token(Token = "0x600385C")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600385D")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600385E RID: 14430 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600385F RID: 14431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E9")]
		public AnimationCurve ShapedAccelerationFactorCurve
		{
			[Token(Token = "0x600385E")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600385F")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06003860 RID: 14432 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		// (set) Token: 0x06003861 RID: 14433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EA")]
		public float WheelRotationRate
		{
			[Token(Token = "0x6003860")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003861")]
			[Address(RVA = "0x781580", Offset = "0x77FB80", VA = "0x180781580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06003862 RID: 14434 RVA: 0x00010D10 File Offset: 0x0000EF10
		// (set) Token: 0x06003863 RID: 14435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EB")]
		public float LeanInputRate
		{
			[Token(Token = "0x6003862")]
			[Address(RVA = "0x23B72F0", Offset = "0x23B58F0", VA = "0x1823B72F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003863")]
			[Address(RVA = "0x2D54950", Offset = "0x2D52F50", VA = "0x182D54950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06003864 RID: 14436 RVA: 0x00010D28 File Offset: 0x0000EF28
		// (set) Token: 0x06003865 RID: 14437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EC")]
		public float LeanFade
		{
			[Token(Token = "0x6003864")]
			[Address(RVA = "0x5F1D00", Offset = "0x5F0300", VA = "0x1805F1D00")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003865")]
			[Address(RVA = "0x2D635A0", Offset = "0x2D61BA0", VA = "0x182D635A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06003866 RID: 14438 RVA: 0x00010D40 File Offset: 0x0000EF40
		// (set) Token: 0x06003867 RID: 14439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006ED")]
		public float LeanVelocityReduction
		{
			[Token(Token = "0x6003866")]
			[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003867")]
			[Address(RVA = "0x2D635B0", Offset = "0x2D61BB0", VA = "0x182D635B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06003868 RID: 14440 RVA: 0x00010D58 File Offset: 0x0000EF58
		// (set) Token: 0x06003869 RID: 14441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EE")]
		public float MinMaxLean
		{
			[Token(Token = "0x6003868")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003869")]
			[Address(RVA = "0x290B500", Offset = "0x2909B00", VA = "0x18290B500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600386A RID: 14442 RVA: 0x00010D70 File Offset: 0x0000EF70
		// (set) Token: 0x0600386B RID: 14443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EF")]
		public float LeanVelocityThreshold
		{
			[Token(Token = "0x600386A")]
			[Address(RVA = "0x23FC6E0", Offset = "0x23FACE0", VA = "0x1823FC6E0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600386B")]
			[Address(RVA = "0x2B89DD0", Offset = "0x2B883D0", VA = "0x182B89DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600386C RID: 14444 RVA: 0x00010D88 File Offset: 0x0000EF88
		// (set) Token: 0x0600386D RID: 14445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F0")]
		public float LeanForwardBackwardBlendMinMax
		{
			[Token(Token = "0x600386C")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600386D")]
			[Address(RVA = "0x2FBB2B0", Offset = "0x2FB98B0", VA = "0x182FBB2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		// (set) Token: 0x0600386F RID: 14447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F1")]
		public float LeanRightLeftBlendMinMax
		{
			[Token(Token = "0x600386E")]
			[Address(RVA = "0x23BB670", Offset = "0x23B9C70", VA = "0x1823BB670")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600386F")]
			[Address(RVA = "0x35535B0", Offset = "0x3551BB0", VA = "0x1835535B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06003870 RID: 14448 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		// (set) Token: 0x06003871 RID: 14449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F2")]
		public float LeanForwardBackwardBlendSmoothing
		{
			[Token(Token = "0x6003870")]
			[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003871")]
			[Address(RVA = "0x200ACE0", Offset = "0x20092E0", VA = "0x18200ACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06003872 RID: 14450 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		// (set) Token: 0x06003873 RID: 14451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F3")]
		public float LeanRightLeftBlendSmoothing
		{
			[Token(Token = "0x6003872")]
			[Address(RVA = "0x1F05980", Offset = "0x1F03F80", VA = "0x181F05980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003873")]
			[Address(RVA = "0x28D8B70", Offset = "0x28D7170", VA = "0x1828D8B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06003874 RID: 14452 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		// (set) Token: 0x06003875 RID: 14453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F4")]
		public float SlopeHelpMultiplier
		{
			[Token(Token = "0x6003874")]
			[Address(RVA = "0xA53160", Offset = "0xA51760", VA = "0x180A53160")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003875")]
			[Address(RVA = "0x2B40070", Offset = "0x2B3E670", VA = "0x182B40070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06003876 RID: 14454 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003877 RID: 14455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F5")]
		public AnimationCurve SlopeHelpCurve
		{
			[Token(Token = "0x6003876")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003877")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06003878 RID: 14456 RVA: 0x00010E00 File Offset: 0x0000F000
		// (set) Token: 0x06003879 RID: 14457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F6")]
		public float LookXRange
		{
			[Token(Token = "0x6003878")]
			[Address(RVA = "0x23C2640", Offset = "0x23C0C40", VA = "0x1823C2640")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003879")]
			[Address(RVA = "0x28D8B80", Offset = "0x28D7180", VA = "0x1828D8B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x00010E18 File Offset: 0x0000F018
		// (set) Token: 0x0600387B RID: 14459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F7")]
		public float LookYRange
		{
			[Token(Token = "0x600387A")]
			[Address(RVA = "0x6124A0", Offset = "0x610AA0", VA = "0x1806124A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600387B")]
			[Address(RVA = "0x6124B0", Offset = "0x610AB0", VA = "0x1806124B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600387C RID: 14460 RVA: 0x00010E30 File Offset: 0x0000F030
		// (set) Token: 0x0600387D RID: 14461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F8")]
		public float JumpForce
		{
			[Token(Token = "0x600387C")]
			[Address(RVA = "0x6124C0", Offset = "0x610AC0", VA = "0x1806124C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600387D")]
			[Address(RVA = "0x6124D0", Offset = "0x610AD0", VA = "0x1806124D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x00010E48 File Offset: 0x0000F048
		// (set) Token: 0x0600387F RID: 14463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F9")]
		public float DismountForce
		{
			[Token(Token = "0x600387E")]
			[Address(RVA = "0x23BB730", Offset = "0x23B9D30", VA = "0x1823BB730")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600387F")]
			[Address(RVA = "0x28E2200", Offset = "0x28E0800", VA = "0x1828E2200")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06003880 RID: 14464 RVA: 0x00010E60 File Offset: 0x0000F060
		// (set) Token: 0x06003881 RID: 14465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FA")]
		public float JumpDelay
		{
			[Token(Token = "0x6003880")]
			[Address(RVA = "0x179D730", Offset = "0x179BD30", VA = "0x18179D730")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003881")]
			[Address(RVA = "0x179D740", Offset = "0x179BD40", VA = "0x18179D740")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x00010E78 File Offset: 0x0000F078
		// (set) Token: 0x06003883 RID: 14467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FB")]
		public float JumpGroundCheckDelay
		{
			[Token(Token = "0x6003882")]
			[Address(RVA = "0x7282C0", Offset = "0x7268C0", VA = "0x1807282C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003883")]
			[Address(RVA = "0x7282D0", Offset = "0x7268D0", VA = "0x1807282D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x00010E90 File Offset: 0x0000F090
		// (set) Token: 0x06003885 RID: 14469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FC")]
		public float FallDismountMinTime
		{
			[Token(Token = "0x6003884")]
			[Address(RVA = "0x2403EB0", Offset = "0x24024B0", VA = "0x182403EB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003885")]
			[Address(RVA = "0x26FA8A0", Offset = "0x26F8EA0", VA = "0x1826FA8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06003886 RID: 14470 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		// (set) Token: 0x06003887 RID: 14471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FD")]
		public float FallDismountMinDistance
		{
			[Token(Token = "0x6003886")]
			[Address(RVA = "0x728300", Offset = "0x726900", VA = "0x180728300")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003887")]
			[Address(RVA = "0x728310", Offset = "0x726910", VA = "0x180728310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		// (set) Token: 0x06003889 RID: 14473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FE")]
		public float InMidAirGroundDistanceThreshold
		{
			[Token(Token = "0x6003888")]
			[Address(RVA = "0x728320", Offset = "0x726920", VA = "0x180728320")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003889")]
			[Address(RVA = "0x728330", Offset = "0x726930", VA = "0x180728330")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600388A RID: 14474 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		// (set) Token: 0x0600388B RID: 14475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FF")]
		public float WipeoutMinVelocity
		{
			[Token(Token = "0x600388A")]
			[Address(RVA = "0x728340", Offset = "0x726940", VA = "0x180728340")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600388B")]
			[Address(RVA = "0x728350", Offset = "0x726950", VA = "0x180728350")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600388C RID: 14476 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		// (set) Token: 0x0600388D RID: 14477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000700")]
		public float FallWipeoutMinChangeInVelocity
		{
			[Token(Token = "0x600388C")]
			[Address(RVA = "0x727F30", Offset = "0x726530", VA = "0x180727F30")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600388D")]
			[Address(RVA = "0x728360", Offset = "0x726960", VA = "0x180728360")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x00010F08 File Offset: 0x0000F108
		// (set) Token: 0x0600388F RID: 14479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000701")]
		public float CollisionWipeoutMinChangeInVelocity
		{
			[Token(Token = "0x600388E")]
			[Address(RVA = "0x2403F10", Offset = "0x2402510", VA = "0x182403F10")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600388F")]
			[Address(RVA = "0x35535C0", Offset = "0x3551BC0", VA = "0x1835535C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x00010F20 File Offset: 0x0000F120
		// (set) Token: 0x06003891 RID: 14481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000702")]
		public Vector3 WipeoutVelocityShape
		{
			[Token(Token = "0x6003890")]
			[Address(RVA = "0x2A224C0", Offset = "0x2A20AC0", VA = "0x182A224C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003891")]
			[Address(RVA = "0x35535D0", Offset = "0x3551BD0", VA = "0x1835535D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06003892 RID: 14482 RVA: 0x00010F38 File Offset: 0x0000F138
		// (set) Token: 0x06003893 RID: 14483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000703")]
		public float WipeoutVelocityMultiplier
		{
			[Token(Token = "0x6003892")]
			[Address(RVA = "0x728440", Offset = "0x726A40", VA = "0x180728440")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003893")]
			[Address(RVA = "0x728450", Offset = "0x726A50", VA = "0x180728450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x00010F50 File Offset: 0x0000F150
		// (set) Token: 0x06003895 RID: 14485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000704")]
		public float MinVelocityCameraShake
		{
			[Token(Token = "0x6003894")]
			[Address(RVA = "0x2BA8CE0", Offset = "0x2BA72E0", VA = "0x182BA8CE0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003895")]
			[Address(RVA = "0x2B47450", Offset = "0x2B45A50", VA = "0x182B47450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000705")]
		public AnimationCurve VelocityChangeShakeCurve
		{
			[Token(Token = "0x6003896")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003897")]
			[Address(RVA = "0x8ECC90", Offset = "0x8EB290", VA = "0x1808ECC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x00010F68 File Offset: 0x0000F168
		// (set) Token: 0x06003899 RID: 14489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000706")]
		public float VelocityChangeShakeSmoothing
		{
			[Token(Token = "0x6003898")]
			[Address(RVA = "0x27399D0", Offset = "0x2737FD0", VA = "0x1827399D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003899")]
			[Address(RVA = "0x2E0D9D0", Offset = "0x2E0BFD0", VA = "0x182E0D9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x00010F80 File Offset: 0x0000F180
		// (set) Token: 0x0600389B RID: 14491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000707")]
		public float BushBreakerVelocityThreshold
		{
			[Token(Token = "0x600389A")]
			[Address(RVA = "0x2805EE0", Offset = "0x28044E0", VA = "0x182805EE0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600389B")]
			[Address(RVA = "0x2E0D9E0", Offset = "0x2E0BFE0", VA = "0x182E0D9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600389C RID: 14492 RVA: 0x00010F98 File Offset: 0x0000F198
		// (set) Token: 0x0600389D RID: 14493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000708")]
		public float MinPowerUsage
		{
			[Token(Token = "0x600389C")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600389D")]
			[Address(RVA = "0x270E6C0", Offset = "0x270CCC0", VA = "0x18270E6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x0600389E RID: 14494 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		// (set) Token: 0x0600389F RID: 14495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000709")]
		public float MaxPowerUsage
		{
			[Token(Token = "0x600389E")]
			[Address(RVA = "0x2739A50", Offset = "0x2738050", VA = "0x182739A50")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600389F")]
			[Address(RVA = "0x35535F0", Offset = "0x3551BF0", VA = "0x1835535F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060038A0 RID: 14496 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038A1 RID: 14497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070A")]
		public string AudioEventPath
		{
			[Token(Token = "0x60038A0")]
			[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038A1")]
			[Address(RVA = "0x784AB0", Offset = "0x7830B0", VA = "0x180784AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060038A2 RID: 14498 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038A3 RID: 14499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070B")]
		public string BackupAudioEventPath
		{
			[Token(Token = "0x60038A2")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038A3")]
			[Address(RVA = "0x784BB0", Offset = "0x7831B0", VA = "0x180784BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060038A4 RID: 14500 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038A5 RID: 14501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070C")]
		public string BatteryDeadAudioEvent
		{
			[Token(Token = "0x60038A4")]
			[Address(RVA = "0x691530", Offset = "0x68FB30", VA = "0x180691530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038A5")]
			[Address(RVA = "0xA2FF40", Offset = "0xA2E540", VA = "0x180A2FF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060038A6 RID: 14502 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038A7 RID: 14503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070D")]
		public string BatteryLowAudioEvent
		{
			[Token(Token = "0x60038A6")]
			[Address(RVA = "0xA3F1B0", Offset = "0xA3D7B0", VA = "0x180A3F1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038A7")]
			[Address(RVA = "0xA3F1C0", Offset = "0xA3D7C0", VA = "0x180A3F1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060038A8 RID: 14504 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		// (set) Token: 0x060038A9 RID: 14505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070E")]
		public float LowBatteryNotificationFactor
		{
			[Token(Token = "0x60038A8")]
			[Address(RVA = "0x2739540", Offset = "0x2737B40", VA = "0x182739540")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60038A9")]
			[Address(RVA = "0x2B6FC40", Offset = "0x2B6E240", VA = "0x182B6FC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060038AA RID: 14506 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038AB RID: 14507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070F")]
		public string TurnOnAudioEvent
		{
			[Token(Token = "0x60038AA")]
			[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038AB")]
			[Address(RVA = "0x8DF490", Offset = "0x8DDA90", VA = "0x1808DF490")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060038AC RID: 14508 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038AD RID: 14509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000710")]
		public string SuspensionAudioEvent
		{
			[Token(Token = "0x60038AC")]
			[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038AD")]
			[Address(RVA = "0x8DF500", Offset = "0x8DDB00", VA = "0x1808DF500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060038AE RID: 14510 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038AF RID: 14511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000711")]
		public string ImpactAudioEvent
		{
			[Token(Token = "0x60038AE")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038AF")]
			[Address(RVA = "0x8DF570", Offset = "0x8DDB70", VA = "0x1808DF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060038B0 RID: 14512 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		// (set) Token: 0x060038B1 RID: 14513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000712")]
		public float WaterLevelDismountThreshold
		{
			[Token(Token = "0x60038B0")]
			[Address(RVA = "0x3553600", Offset = "0x3551C00", VA = "0x183553600")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60038B1")]
			[Address(RVA = "0x3553610", Offset = "0x3551C10", VA = "0x183553610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060038B2 RID: 14514 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		// (set) Token: 0x060038B3 RID: 14515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000713")]
		public float SuspensionHitsEventThreshold
		{
			[Token(Token = "0x60038B2")]
			[Address(RVA = "0x3553620", Offset = "0x3551C20", VA = "0x183553620")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60038B3")]
			[Address(RVA = "0x3553630", Offset = "0x3551C30", VA = "0x183553630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060038B4 RID: 14516 RVA: 0x00011010 File Offset: 0x0000F210
		// (set) Token: 0x060038B5 RID: 14517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000714")]
		public float SuspensionHitsEventMaxThreshold
		{
			[Token(Token = "0x60038B4")]
			[Address(RVA = "0x2640F00", Offset = "0x263F500", VA = "0x182640F00")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60038B5")]
			[Address(RVA = "0x3553640", Offset = "0x3551C40", VA = "0x183553640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B6")]
		[Address(RVA = "0x3553650", Offset = "0x3551C50", VA = "0x183553650")]
		public KnightVControlDefinition()
		{
		}
	}
}
