using System;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200081C RID: 2076
	[Token(Token = "0x200081C")]
	[Serializable]
	public class PlayerKnightVState
	{
		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x00011958 File Offset: 0x0000FB58
		// (set) Token: 0x060039E3 RID: 14819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700076F")]
		public bool ShowVelocityIndicator
		{
			[Token(Token = "0x60039E2")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039E3")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060039E4 RID: 14820 RVA: 0x00011970 File Offset: 0x0000FB70
		// (set) Token: 0x060039E5 RID: 14821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000770")]
		public Vector2 CurrentInput
		{
			[Token(Token = "0x60039E4")]
			[Address(RVA = "0x1850C30", Offset = "0x184F230", VA = "0x181850C30")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60039E5")]
			[Address(RVA = "0x3565050", Offset = "0x3563650", VA = "0x183565050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060039E7 RID: 14823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000771")]
		public Transform ControllerTransform
		{
			[Token(Token = "0x60039E6")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60039E7")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060039E8 RID: 14824 RVA: 0x00011988 File Offset: 0x0000FB88
		// (set) Token: 0x060039E9 RID: 14825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000772")]
		public bool IsRiding
		{
			[Token(Token = "0x60039E8")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039E9")]
			[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060039EA RID: 14826 RVA: 0x000119A0 File Offset: 0x0000FBA0
		// (set) Token: 0x060039EB RID: 14827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000773")]
		public float Lean
		{
			[Token(Token = "0x60039EA")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039EB")]
			[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060039EC RID: 14828 RVA: 0x000119B8 File Offset: 0x0000FBB8
		// (set) Token: 0x060039ED RID: 14829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000774")]
		public float Acceleration
		{
			[Token(Token = "0x60039EC")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039ED")]
			[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060039EE RID: 14830 RVA: 0x000119D0 File Offset: 0x0000FBD0
		// (set) Token: 0x060039EF RID: 14831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000775")]
		public float AccelerationFactor
		{
			[Token(Token = "0x60039EE")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039EF")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060039F0 RID: 14832 RVA: 0x000119E8 File Offset: 0x0000FBE8
		// (set) Token: 0x060039F1 RID: 14833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000776")]
		public bool HasAccelerationInput
		{
			[Token(Token = "0x60039F0")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039F1")]
			[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060039F2 RID: 14834 RVA: 0x00011A00 File Offset: 0x0000FC00
		// (set) Token: 0x060039F3 RID: 14835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000777")]
		public bool HasLeanInput
		{
			[Token(Token = "0x60039F2")]
			[Address(RVA = "0x98F610", Offset = "0x98DC10", VA = "0x18098F610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039F3")]
			[Address(RVA = "0x98F620", Offset = "0x98DC20", VA = "0x18098F620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060039F4 RID: 14836 RVA: 0x00011A18 File Offset: 0x0000FC18
		// (set) Token: 0x060039F5 RID: 14837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000778")]
		public Vector3 LocalVelocity
		{
			[Token(Token = "0x60039F4")]
			[Address(RVA = "0x2D59F20", Offset = "0x2D58520", VA = "0x182D59F20")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60039F5")]
			[Address(RVA = "0x2DDE4D0", Offset = "0x2DDCAD0", VA = "0x182DDE4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060039F6 RID: 14838 RVA: 0x00011A30 File Offset: 0x0000FC30
		// (set) Token: 0x060039F7 RID: 14839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000779")]
		public Vector3 PreviousTrackedVelocity
		{
			[Token(Token = "0x60039F6")]
			[Address(RVA = "0x2DDE4E0", Offset = "0x2DDCAE0", VA = "0x182DDE4E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60039F7")]
			[Address(RVA = "0x2DDE500", Offset = "0x2DDCB00", VA = "0x182DDE500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060039F8 RID: 14840 RVA: 0x00011A48 File Offset: 0x0000FC48
		// (set) Token: 0x060039F9 RID: 14841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077A")]
		public float PreviousTrackedVelocityMagnitude
		{
			[Token(Token = "0x60039F8")]
			[Address(RVA = "0x23FC6E0", Offset = "0x23FACE0", VA = "0x1823FC6E0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039F9")]
			[Address(RVA = "0x2B89DD0", Offset = "0x2B883D0", VA = "0x182B89DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060039FA RID: 14842 RVA: 0x00011A60 File Offset: 0x0000FC60
		// (set) Token: 0x060039FB RID: 14843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077B")]
		public float DebugFallMaxChangeInVelocityMagnitude
		{
			[Token(Token = "0x60039FA")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039FB")]
			[Address(RVA = "0x2FBB2B0", Offset = "0x2FB98B0", VA = "0x182FBB2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060039FC RID: 14844 RVA: 0x00011A78 File Offset: 0x0000FC78
		// (set) Token: 0x060039FD RID: 14845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077C")]
		public float DebugCollisionMaxChangeInVelocityMagnitude
		{
			[Token(Token = "0x60039FC")]
			[Address(RVA = "0x23BB670", Offset = "0x23B9C70", VA = "0x1823BB670")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039FD")]
			[Address(RVA = "0x35535B0", Offset = "0x3551BB0", VA = "0x1835535B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060039FE RID: 14846 RVA: 0x00011A90 File Offset: 0x0000FC90
		// (set) Token: 0x060039FF RID: 14847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077D")]
		public float DebugPowerDrain
		{
			[Token(Token = "0x60039FE")]
			[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60039FF")]
			[Address(RVA = "0x200ACE0", Offset = "0x20092E0", VA = "0x18200ACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06003A00 RID: 14848 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		// (set) Token: 0x06003A01 RID: 14849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077E")]
		public float DebugMaxPowerDrain
		{
			[Token(Token = "0x6003A00")]
			[Address(RVA = "0x1F05980", Offset = "0x1F03F80", VA = "0x181F05980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A01")]
			[Address(RVA = "0x28D8B70", Offset = "0x28D7170", VA = "0x1828D8B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06003A02 RID: 14850 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003A03 RID: 14851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077F")]
		public KnightVItemController KnightVController
		{
			[Token(Token = "0x6003A02")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A03")]
			[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06003A04 RID: 14852 RVA: 0x00011AC0 File Offset: 0x0000FCC0
		// (set) Token: 0x06003A05 RID: 14853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000780")]
		public Quaternion MoveRotation
		{
			[Token(Token = "0x6003A04")]
			[Address(RVA = "0x25A7220", Offset = "0x25A5820", VA = "0x1825A7220")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6003A05")]
			[Address(RVA = "0x25A7230", Offset = "0x25A5830", VA = "0x1825A7230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06003A06 RID: 14854 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		// (set) Token: 0x06003A07 RID: 14855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000781")]
		public float TargetForwardBackwardLean
		{
			[Token(Token = "0x6003A06")]
			[Address(RVA = "0x6124C0", Offset = "0x610AC0", VA = "0x1806124C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A07")]
			[Address(RVA = "0x6124D0", Offset = "0x610AD0", VA = "0x1806124D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06003A08 RID: 14856 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		// (set) Token: 0x06003A09 RID: 14857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000782")]
		public float TargetRightLeftLean
		{
			[Token(Token = "0x6003A08")]
			[Address(RVA = "0x23BB730", Offset = "0x23B9D30", VA = "0x1823BB730")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A09")]
			[Address(RVA = "0x28E2200", Offset = "0x28E0800", VA = "0x1828E2200")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06003A0A RID: 14858 RVA: 0x00011B08 File Offset: 0x0000FD08
		// (set) Token: 0x06003A0B RID: 14859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000783")]
		public Vector3 FadedVelocity
		{
			[Token(Token = "0x6003A0A")]
			[Address(RVA = "0x179DC20", Offset = "0x179C220", VA = "0x18179DC20")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003A0B")]
			[Address(RVA = "0x179DC40", Offset = "0x179C240", VA = "0x18179DC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06003A0C RID: 14860 RVA: 0x00011B20 File Offset: 0x0000FD20
		// (set) Token: 0x06003A0D RID: 14861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000784")]
		public float JumpTriggeredTime
		{
			[Token(Token = "0x6003A0C")]
			[Address(RVA = "0x728300", Offset = "0x726900", VA = "0x180728300")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A0D")]
			[Address(RVA = "0x728310", Offset = "0x726910", VA = "0x180728310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06003A0E RID: 14862 RVA: 0x00011B38 File Offset: 0x0000FD38
		// (set) Token: 0x06003A0F RID: 14863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000785")]
		public Vector3 FadedLocalVelocity
		{
			[Token(Token = "0x6003A0E")]
			[Address(RVA = "0x3565060", Offset = "0x3563660", VA = "0x183565060")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003A0F")]
			[Address(RVA = "0x3565080", Offset = "0x3563680", VA = "0x183565080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06003A10 RID: 14864 RVA: 0x00011B50 File Offset: 0x0000FD50
		// (set) Token: 0x06003A11 RID: 14865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000786")]
		public bool SetJumpBool
		{
			[Token(Token = "0x6003A10")]
			[Address(RVA = "0xA50BE0", Offset = "0xA4F1E0", VA = "0x180A50BE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A11")]
			[Address(RVA = "0xA50BF0", Offset = "0xA4F1F0", VA = "0x180A50BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x00011B68 File Offset: 0x0000FD68
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000787")]
		public float JumpForceAppliedTime
		{
			[Token(Token = "0x6003A12")]
			[Address(RVA = "0x2403F30", Offset = "0x2402530", VA = "0x182403F30")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A13")]
			[Address(RVA = "0x2BAD3E0", Offset = "0x2BAB9E0", VA = "0x182BAD3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x00011B80 File Offset: 0x0000FD80
		// (set) Token: 0x06003A15 RID: 14869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000788")]
		public float NotGroundedTimer
		{
			[Token(Token = "0x6003A14")]
			[Address(RVA = "0x2739890", Offset = "0x2737E90", VA = "0x182739890")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A15")]
			[Address(RVA = "0x35650A0", Offset = "0x35636A0", VA = "0x1835650A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06003A16 RID: 14870 RVA: 0x00011B98 File Offset: 0x0000FD98
		// (set) Token: 0x06003A17 RID: 14871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000789")]
		public bool SetIsInMidAirBool
		{
			[Token(Token = "0x6003A16")]
			[Address(RVA = "0x12433D0", Offset = "0x12419D0", VA = "0x1812433D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A17")]
			[Address(RVA = "0x12433E0", Offset = "0x12419E0", VA = "0x1812433E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06003A18 RID: 14872 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		// (set) Token: 0x06003A19 RID: 14873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078A")]
		public bool WipeoutTriggered
		{
			[Token(Token = "0x6003A18")]
			[Address(RVA = "0x12433F0", Offset = "0x12419F0", VA = "0x1812433F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A19")]
			[Address(RVA = "0x1243400", Offset = "0x1241A00", VA = "0x181243400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		// (set) Token: 0x06003A1B RID: 14875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078B")]
		public bool BlockFullBodyInteraction
		{
			[Token(Token = "0x6003A1A")]
			[Address(RVA = "0x35650B0", Offset = "0x35636B0", VA = "0x1835650B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A1B")]
			[Address(RVA = "0x35650C0", Offset = "0x35636C0", VA = "0x1835650C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06003A1C RID: 14876 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		// (set) Token: 0x06003A1D RID: 14877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078C")]
		public float LastChangeInVelocityMagnitude
		{
			[Token(Token = "0x6003A1C")]
			[Address(RVA = "0x728440", Offset = "0x726A40", VA = "0x180728440")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A1D")]
			[Address(RVA = "0x728450", Offset = "0x726A50", VA = "0x180728450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06003A1E RID: 14878 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		// (set) Token: 0x06003A1F RID: 14879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078D")]
		public float CurrentVelocityShakeTarget
		{
			[Token(Token = "0x6003A1E")]
			[Address(RVA = "0x2BA8CE0", Offset = "0x2BA72E0", VA = "0x182BA8CE0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A1F")]
			[Address(RVA = "0x2B47450", Offset = "0x2B45A50", VA = "0x182B47450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06003A20 RID: 14880 RVA: 0x00011C10 File Offset: 0x0000FE10
		// (set) Token: 0x06003A21 RID: 14881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078E")]
		public float CurrentVelocityShakeTargetVelocity
		{
			[Token(Token = "0x6003A20")]
			[Address(RVA = "0x2739940", Offset = "0x2737F40", VA = "0x182739940")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A21")]
			[Address(RVA = "0x35650D0", Offset = "0x35636D0", VA = "0x1835650D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06003A22 RID: 14882 RVA: 0x00011C28 File Offset: 0x0000FE28
		// (set) Token: 0x06003A23 RID: 14883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078F")]
		public Vector3 ForceApplied
		{
			[Token(Token = "0x6003A22")]
			[Address(RVA = "0x26D78B0", Offset = "0x26D5EB0", VA = "0x1826D78B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003A23")]
			[Address(RVA = "0x35650E0", Offset = "0x35636E0", VA = "0x1835650E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06003A24 RID: 14884 RVA: 0x00011C40 File Offset: 0x0000FE40
		// (set) Token: 0x06003A25 RID: 14885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000790")]
		public float ImpactFactor
		{
			[Token(Token = "0x6003A24")]
			[Address(RVA = "0x2805EE0", Offset = "0x28044E0", VA = "0x182805EE0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A25")]
			[Address(RVA = "0x2E0D9E0", Offset = "0x2E0BFE0", VA = "0x182E0D9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A26")]
		[Address(RVA = "0x3565100", Offset = "0x3563700", VA = "0x183565100")]
		public void InitializeAudioEvent(string audioEventPath, Transform audioSourceTransform)
		{
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A27")]
		[Address(RVA = "0x35655A0", Offset = "0x3563BA0", VA = "0x1835655A0")]
		private void ReleaseAudioEventInstance()
		{
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x00011C58 File Offset: 0x0000FE58
		[Token(Token = "0x6003A28")]
		[Address(RVA = "0x35656B0", Offset = "0x3563CB0", VA = "0x1835656B0")]
		public bool HasEngineAudioEventInstance()
		{
			return default(bool);
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003A2A RID: 14890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000791")]
		public Transform AudioSourceTransform
		{
			[Token(Token = "0x6003A29")]
			[Address(RVA = "0x2866A50", Offset = "0x2865050", VA = "0x182866A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A2A")]
			[Address(RVA = "0x2866A60", Offset = "0x2865060", VA = "0x182866A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x00011C70 File Offset: 0x0000FE70
		// (set) Token: 0x06003A2C RID: 14892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000792")]
		public EventInstance EngineAudioEventInstance
		{
			[Token(Token = "0x6003A2B")]
			[Address(RVA = "0x2638550", Offset = "0x2636B50", VA = "0x182638550")]
			[CompilerGenerated]
			get
			{
				return default(EventInstance);
			}
			[Token(Token = "0x6003A2C")]
			[Address(RVA = "0x3565740", Offset = "0x3563D40", VA = "0x183565740")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x00011C88 File Offset: 0x0000FE88
		// (set) Token: 0x06003A2E RID: 14894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000793")]
		public float AudioParamInMidAir
		{
			[Token(Token = "0x6003A2D")]
			[Address(RVA = "0x3565750", Offset = "0x3563D50", VA = "0x183565750")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A2E")]
			[Address(RVA = "0x3565760", Offset = "0x3563D60", VA = "0x183565760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06003A2F RID: 14895 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		// (set) Token: 0x06003A30 RID: 14896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000794")]
		public float AudioParamSpeed
		{
			[Token(Token = "0x6003A2F")]
			[Address(RVA = "0x3565770", Offset = "0x3563D70", VA = "0x183565770")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A30")]
			[Address(RVA = "0x3565780", Offset = "0x3563D80", VA = "0x183565780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06003A31 RID: 14897 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		// (set) Token: 0x06003A32 RID: 14898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000795")]
		public int AudioParamTerrain
		{
			[Token(Token = "0x6003A31")]
			[Address(RVA = "0x2638FB0", Offset = "0x26375B0", VA = "0x182638FB0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003A32")]
			[Address(RVA = "0x2866D70", Offset = "0x2865370", VA = "0x182866D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06003A33 RID: 14899 RVA: 0x00011CD0 File Offset: 0x0000FED0
		// (set) Token: 0x06003A34 RID: 14900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000796")]
		public float AudioParamAccelerate
		{
			[Token(Token = "0x6003A33")]
			[Address(RVA = "0x3565790", Offset = "0x3563D90", VA = "0x183565790")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A34")]
			[Address(RVA = "0x35657A0", Offset = "0x3563DA0", VA = "0x1835657A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		// (set) Token: 0x06003A36 RID: 14902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000797")]
		public bool PendingReactivateLocalPlayerRiding
		{
			[Token(Token = "0x6003A35")]
			[Address(RVA = "0x35657B0", Offset = "0x3563DB0", VA = "0x1835657B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A36")]
			[Address(RVA = "0x35657C0", Offset = "0x3563DC0", VA = "0x1835657C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A37")]
		[Address(RVA = "0x35657D0", Offset = "0x3563DD0", VA = "0x1835657D0")]
		public void UpdateEngineAudioEvent()
		{
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A38")]
		[Address(RVA = "0x3565C20", Offset = "0x3564220", VA = "0x183565C20")]
		private void StopEngineAudioEvent()
		{
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A39")]
		[Address(RVA = "0x3565E50", Offset = "0x3564450", VA = "0x183565E50")]
		public void StopAllAudioEvents()
		{
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06003A3A RID: 14906 RVA: 0x00011D00 File Offset: 0x0000FF00
		// (set) Token: 0x06003A3B RID: 14907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000798")]
		private EventInstance BackupAudioEventInstance
		{
			[Token(Token = "0x6003A3A")]
			[Address(RVA = "0x2AA2FD0", Offset = "0x2AA15D0", VA = "0x182AA2FD0")]
			[CompilerGenerated]
			get
			{
				return default(EventInstance);
			}
			[Token(Token = "0x6003A3B")]
			[Address(RVA = "0x3566090", Offset = "0x3564690", VA = "0x183566090")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00011D18 File Offset: 0x0000FF18
		[Token(Token = "0x6003A3C")]
		[Address(RVA = "0x35660A0", Offset = "0x35646A0", VA = "0x1835660A0")]
		public bool HasBackupAudioEventInstance()
		{
			return default(bool);
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3D")]
		[Address(RVA = "0x3566130", Offset = "0x3564730", VA = "0x183566130")]
		public void InitializeBackupAudioEvent(string audioEventPath)
		{
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3E")]
		[Address(RVA = "0x3566280", Offset = "0x3564880", VA = "0x183566280")]
		private void InitializeAudioEventInstance(string audioEventPath, ref EventInstance eventInstance)
		{
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A3F")]
		[Address(RVA = "0x3566470", Offset = "0x3564A70", VA = "0x183566470")]
		private void ReleaseBackupEventInstance()
		{
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x3566580", Offset = "0x3564B80", VA = "0x183566580")]
		public void StopBackupAudioEvent()
		{
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A41")]
		[Address(RVA = "0x3566620", Offset = "0x3564C20", VA = "0x183566620")]
		public void UpdateBackupAudioEvent(bool shouldPlay)
		{
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06003A42 RID: 14914 RVA: 0x00011D30 File Offset: 0x0000FF30
		// (set) Token: 0x06003A43 RID: 14915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000799")]
		private EventInstance SuspensionHitsAudioEventInstance
		{
			[Token(Token = "0x6003A42")]
			[Address(RVA = "0x3566970", Offset = "0x3564F70", VA = "0x183566970")]
			[CompilerGenerated]
			get
			{
				return default(EventInstance);
			}
			[Token(Token = "0x6003A43")]
			[Address(RVA = "0x3566980", Offset = "0x3564F80", VA = "0x183566980")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x00011D48 File Offset: 0x0000FF48
		[Token(Token = "0x6003A44")]
		[Address(RVA = "0x3566990", Offset = "0x3564F90", VA = "0x183566990")]
		public bool HasSuspensionHitsAudioEventInstance()
		{
			return default(bool);
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A45")]
		[Address(RVA = "0x3566A20", Offset = "0x3565020", VA = "0x183566A20")]
		public void InitializeSuspensionHitsAudioEvent(string audioEventPath)
		{
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A46")]
		[Address(RVA = "0x3566CF0", Offset = "0x35652F0", VA = "0x183566CF0")]
		private void ReleaseSuspensionHitsEventInstance()
		{
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A47")]
		[Address(RVA = "0x3566E00", Offset = "0x3565400", VA = "0x183566E00")]
		public void StopSuspensionHitsAudioEvent()
		{
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A48")]
		[Address(RVA = "0x3566EA0", Offset = "0x35654A0", VA = "0x183566EA0")]
		public void PlayImpactAudio(float impactFactor)
		{
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A49")]
		[Address(RVA = "0x3567100", Offset = "0x3565700", VA = "0x183567100")]
		public PlayerKnightVState()
		{
		}

		// Token: 0x04003181 RID: 12673
		[Token(Token = "0x4003181")]
		private const string InMidAirParamName = "InMidAir";

		// Token: 0x04003182 RID: 12674
		[Token(Token = "0x4003182")]
		private const string SpeedParamName = "Speed";

		// Token: 0x04003183 RID: 12675
		[Token(Token = "0x4003183")]
		private const string TerrainParamName = "Terrain";

		// Token: 0x04003184 RID: 12676
		[Token(Token = "0x4003184")]
		private const string AccelerateParamName = "Accelerate";

		// Token: 0x04003185 RID: 12677
		[Token(Token = "0x4003185")]
		private const string ForceParamName = "force";

		// Token: 0x040031A8 RID: 12712
		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0xD0")]
		public PARAMETER_DESCRIPTION InMidAirParamDescription;

		// Token: 0x040031A9 RID: 12713
		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0xF8")]
		public PARAMETER_DESCRIPTION AccelerateParamDescription;

		// Token: 0x040031AA RID: 12714
		[Token(Token = "0x40031AA")]
		[FieldOffset(Offset = "0x120")]
		public PARAMETER_DESCRIPTION TerrainParamDescription;

		// Token: 0x040031AB RID: 12715
		[Token(Token = "0x40031AB")]
		[FieldOffset(Offset = "0x148")]
		public PARAMETER_DESCRIPTION SpeedParamDescription;

		// Token: 0x040031AC RID: 12716
		[Token(Token = "0x40031AC")]
		[FieldOffset(Offset = "0x170")]
		public PARAMETER_DESCRIPTION ForceParamDescription;

		// Token: 0x040031B5 RID: 12725
		[Token(Token = "0x40031B5")]
		[FieldOffset(Offset = "0x1C8")]
		private float _lastBeepSwitchTime;
	}
}
