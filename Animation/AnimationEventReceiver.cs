using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000884 RID: 2180
	[Token(Token = "0x2000884")]
	public class AnimationEventReceiver : MonoBehaviour
	{
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06003A79 RID: 14969 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A7A RID: 14970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000027")]
		public event Action OnGoToCombo
		{
			[Token(Token = "0x6003A79")]
			[Address(RVA = "0x2EF3ED0", Offset = "0x2EF2ED0", VA = "0x182EF3ED0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A7A")]
			[Address(RVA = "0x2EF56F0", Offset = "0x2EF46F0", VA = "0x182EF56F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06003A7B RID: 14971 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A7C RID: 14972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000028")]
		public event Action OnCheckComboStart
		{
			[Token(Token = "0x6003A7B")]
			[Address(RVA = "0x2EF3A70", Offset = "0x2EF2A70", VA = "0x182EF3A70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A7C")]
			[Address(RVA = "0x2EF5290", Offset = "0x2EF4290", VA = "0x182EF5290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06003A7D RID: 14973 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A7E RID: 14974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000029")]
		public event Action OnCheckComboEnd
		{
			[Token(Token = "0x6003A7D")]
			[Address(RVA = "0x2EF39D0", Offset = "0x2EF29D0", VA = "0x182EF39D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A7E")]
			[Address(RVA = "0x2EF51F0", Offset = "0x2EF41F0", VA = "0x182EF51F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06003A7F RID: 14975 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A80 RID: 14976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002A")]
		public event Action OnAttackStart
		{
			[Token(Token = "0x6003A7F")]
			[Address(RVA = "0x2EF3690", Offset = "0x2EF2690", VA = "0x182EF3690")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A80")]
			[Address(RVA = "0x2EF4EB0", Offset = "0x2EF3EB0", VA = "0x182EF4EB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06003A81 RID: 14977 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A82 RID: 14978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002B")]
		public event Action OnDigStart
		{
			[Token(Token = "0x6003A81")]
			[Address(RVA = "0x2EF3E30", Offset = "0x2EF2E30", VA = "0x182EF3E30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A82")]
			[Address(RVA = "0x2EF5650", Offset = "0x2EF4650", VA = "0x182EF5650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06003A83 RID: 14979 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A84 RID: 14980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002C")]
		public event Action OnDigEnd
		{
			[Token(Token = "0x6003A83")]
			[Address(RVA = "0x2EF3D90", Offset = "0x2EF2D90", VA = "0x182EF3D90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A84")]
			[Address(RVA = "0x2EF55B0", Offset = "0x2EF45B0", VA = "0x182EF55B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06003A85 RID: 14981 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A86 RID: 14982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002D")]
		public event Action OnDigDirtAttach
		{
			[Token(Token = "0x6003A85")]
			[Address(RVA = "0x2EF3C50", Offset = "0x2EF2C50", VA = "0x182EF3C50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A86")]
			[Address(RVA = "0x2EF5470", Offset = "0x2EF4470", VA = "0x182EF5470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06003A87 RID: 14983 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A88 RID: 14984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002E")]
		public event Action OnDigDirtDetach
		{
			[Token(Token = "0x6003A87")]
			[Address(RVA = "0x2EF3CF0", Offset = "0x2EF2CF0", VA = "0x182EF3CF0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A88")]
			[Address(RVA = "0x2EF5510", Offset = "0x2EF4510", VA = "0x182EF5510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06003A89 RID: 14985 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A8A RID: 14986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002F")]
		public event Action OnLockedStart
		{
			[Token(Token = "0x6003A89")]
			[Address(RVA = "0x2EF46F0", Offset = "0x2EF36F0", VA = "0x182EF46F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A8A")]
			[Address(RVA = "0x2EF5F10", Offset = "0x2EF4F10", VA = "0x182EF5F10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06003A8B RID: 14987 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A8C RID: 14988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000030")]
		public event Action OnLockedEnd
		{
			[Token(Token = "0x6003A8B")]
			[Address(RVA = "0x2EF4650", Offset = "0x2EF3650", VA = "0x182EF4650")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A8C")]
			[Address(RVA = "0x2EF5E70", Offset = "0x2EF4E70", VA = "0x182EF5E70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06003A8D RID: 14989 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A8E RID: 14990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000031")]
		public event Action OnAttackEnd
		{
			[Token(Token = "0x6003A8D")]
			[Address(RVA = "0x2EF35F0", Offset = "0x2EF25F0", VA = "0x182EF35F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A8E")]
			[Address(RVA = "0x2EF4E10", Offset = "0x2EF3E10", VA = "0x182EF4E10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06003A8F RID: 14991 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A90 RID: 14992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000032")]
		public event Action OnGoToReset
		{
			[Token(Token = "0x6003A8F")]
			[Address(RVA = "0x2EF3F70", Offset = "0x2EF2F70", VA = "0x182EF3F70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A90")]
			[Address(RVA = "0x2EF5790", Offset = "0x2EF4790", VA = "0x182EF5790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06003A91 RID: 14993 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A92 RID: 14994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000033")]
		public event Action OnItemLeavesHand
		{
			[Token(Token = "0x6003A91")]
			[Address(RVA = "0x2EF4290", Offset = "0x2EF3290", VA = "0x182EF4290")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A92")]
			[Address(RVA = "0x2EF5AB0", Offset = "0x2EF4AB0", VA = "0x182EF5AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06003A93 RID: 14995 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A94 RID: 14996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000034")]
		public event Action OnProjectileReleased
		{
			[Token(Token = "0x6003A93")]
			[Address(RVA = "0x2EF48E0", Offset = "0x2EF38E0", VA = "0x182EF48E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A94")]
			[Address(RVA = "0x2EF6100", Offset = "0x2EF5100", VA = "0x182EF6100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06003A95 RID: 14997 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A96 RID: 14998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000035")]
		public event Action OnRangeReload
		{
			[Token(Token = "0x6003A95")]
			[Address(RVA = "0x2EF4980", Offset = "0x2EF3980", VA = "0x182EF4980")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A96")]
			[Address(RVA = "0x2EF61A0", Offset = "0x2EF51A0", VA = "0x182EF61A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06003A97 RID: 14999 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A98 RID: 15000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000036")]
		public event Action OnRangeShoot
		{
			[Token(Token = "0x6003A97")]
			[Address(RVA = "0x2EF4A20", Offset = "0x2EF3A20", VA = "0x182EF4A20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A98")]
			[Address(RVA = "0x2EF6240", Offset = "0x2EF5240", VA = "0x182EF6240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06003A99 RID: 15001 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A9A RID: 15002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000037")]
		public event Action OnGroundAttackStart
		{
			[Token(Token = "0x6003A99")]
			[Address(RVA = "0x2EF40B0", Offset = "0x2EF30B0", VA = "0x182EF40B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A9A")]
			[Address(RVA = "0x2EF58D0", Offset = "0x2EF48D0", VA = "0x182EF58D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06003A9B RID: 15003 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A9C RID: 15004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000038")]
		public event Action OnGroundAttackEnd
		{
			[Token(Token = "0x6003A9B")]
			[Address(RVA = "0x2EF4010", Offset = "0x2EF3010", VA = "0x182EF4010")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A9C")]
			[Address(RVA = "0x2EF5830", Offset = "0x2EF4830", VA = "0x182EF5830")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06003A9D RID: 15005 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003A9E RID: 15006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000039")]
		public event Action OnTreeAttackStart
		{
			[Token(Token = "0x6003A9D")]
			[Address(RVA = "0x2EF4D50", Offset = "0x2EF3D50", VA = "0x182EF4D50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A9E")]
			[Address(RVA = "0x2EF6570", Offset = "0x2EF5570", VA = "0x182EF6570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06003A9F RID: 15007 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AA0 RID: 15008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003A")]
		public event Action OnTreeAttackEnd
		{
			[Token(Token = "0x6003A9F")]
			[Address(RVA = "0x2EF4CB0", Offset = "0x2EF3CB0", VA = "0x182EF4CB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AA0")]
			[Address(RVA = "0x2EF64D0", Offset = "0x2EF54D0", VA = "0x182EF64D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06003AA1 RID: 15009 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AA2 RID: 15010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003B")]
		public event Action OnChargeAttackStart
		{
			[Token(Token = "0x6003AA1")]
			[Address(RVA = "0x2EF3930", Offset = "0x2EF2930", VA = "0x182EF3930")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AA2")]
			[Address(RVA = "0x2EF5150", Offset = "0x2EF4150", VA = "0x182EF5150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06003AA3 RID: 15011 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AA4 RID: 15012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003C")]
		public event Action OnChargeAttackEnd
		{
			[Token(Token = "0x6003AA3")]
			[Address(RVA = "0x2EF3890", Offset = "0x2EF2890", VA = "0x182EF3890")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AA4")]
			[Address(RVA = "0x2EF50B0", Offset = "0x2EF40B0", VA = "0x182EF50B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06003AA5 RID: 15013 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AA6 RID: 15014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003D")]
		public event Action<bool> OnParryActive
		{
			[Token(Token = "0x6003AA5")]
			[Address(RVA = "0x2EF4830", Offset = "0x2EF3830", VA = "0x182EF4830")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AA6")]
			[Address(RVA = "0x2EF6050", Offset = "0x2EF5050", VA = "0x182EF6050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06003AA7 RID: 15015 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AA8 RID: 15016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003E")]
		public event Action<bool> OnBlockActive
		{
			[Token(Token = "0x6003AA7")]
			[Address(RVA = "0x2EF3730", Offset = "0x2EF2730", VA = "0x182EF3730")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AA8")]
			[Address(RVA = "0x2EF4F50", Offset = "0x2EF3F50", VA = "0x182EF4F50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06003AA9 RID: 15017 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AAA RID: 15018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003F")]
		public event Action OnMeleeAttackEvent
		{
			[Token(Token = "0x6003AA9")]
			[Address(RVA = "0x2EF4790", Offset = "0x2EF3790", VA = "0x182EF4790")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AAA")]
			[Address(RVA = "0x2EF5FB0", Offset = "0x2EF4FB0", VA = "0x182EF5FB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06003AAB RID: 15019 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AAC RID: 15020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000040")]
		public event Action<bool> OnChainSawHold
		{
			[Token(Token = "0x6003AAB")]
			[Address(RVA = "0x2EF37E0", Offset = "0x2EF27E0", VA = "0x182EF37E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AAC")]
			[Address(RVA = "0x2EF5000", Offset = "0x2EF4000", VA = "0x182EF5000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06003AAD RID: 15021 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AAE RID: 15022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000041")]
		public event Action OnItemActivated
		{
			[Token(Token = "0x6003AAD")]
			[Address(RVA = "0x2EF4150", Offset = "0x2EF3150", VA = "0x182EF4150")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AAE")]
			[Address(RVA = "0x2EF5970", Offset = "0x2EF4970", VA = "0x182EF5970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06003AAF RID: 15023 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AB0 RID: 15024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000042")]
		public event Action OnItemDeactivated
		{
			[Token(Token = "0x6003AAF")]
			[Address(RVA = "0x2EF41F0", Offset = "0x2EF31F0", VA = "0x182EF41F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AB0")]
			[Address(RVA = "0x2EF5A10", Offset = "0x2EF4A10", VA = "0x182EF5A10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06003AB1 RID: 15025 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AB2 RID: 15026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000043")]
		public event Action OnLeanForwardEnter
		{
			[Token(Token = "0x6003AB1")]
			[Address(RVA = "0x2EF4330", Offset = "0x2EF3330", VA = "0x182EF4330")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AB2")]
			[Address(RVA = "0x2EF5B50", Offset = "0x2EF4B50", VA = "0x182EF5B50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06003AB3 RID: 15027 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AB4 RID: 15028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000044")]
		public event Action OnLeanForwardLightLeavesUp
		{
			[Token(Token = "0x6003AB3")]
			[Address(RVA = "0x2EF4470", Offset = "0x2EF3470", VA = "0x182EF4470")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AB4")]
			[Address(RVA = "0x2EF5C90", Offset = "0x2EF4C90", VA = "0x182EF5C90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06003AB5 RID: 15029 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AB6 RID: 15030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000045")]
		public event Action OnLeanForwardThrowLeaves
		{
			[Token(Token = "0x6003AB5")]
			[Address(RVA = "0x2EF4510", Offset = "0x2EF3510", VA = "0x182EF4510")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AB6")]
			[Address(RVA = "0x2EF5D30", Offset = "0x2EF4D30", VA = "0x182EF5D30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06003AB7 RID: 15031 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AB8 RID: 15032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000046")]
		public event Action OnLeanForwardToLight
		{
			[Token(Token = "0x6003AB7")]
			[Address(RVA = "0x2EF45B0", Offset = "0x2EF35B0", VA = "0x182EF45B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AB8")]
			[Address(RVA = "0x2EF5DD0", Offset = "0x2EF4DD0", VA = "0x182EF5DD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06003AB9 RID: 15033 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003ABA RID: 15034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000047")]
		public event Action OnLeanForwardExit
		{
			[Token(Token = "0x6003AB9")]
			[Address(RVA = "0x2EF43D0", Offset = "0x2EF33D0", VA = "0x182EF43D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003ABA")]
			[Address(RVA = "0x2EF5BF0", Offset = "0x2EF4BF0", VA = "0x182EF5BF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06003ABB RID: 15035 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003ABC RID: 15036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000048")]
		public event Action OnCombatKnifeShow
		{
			[Token(Token = "0x6003ABB")]
			[Address(RVA = "0x2EF3BB0", Offset = "0x2EF2BB0", VA = "0x182EF3BB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003ABC")]
			[Address(RVA = "0x2EF53D0", Offset = "0x2EF43D0", VA = "0x182EF53D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06003ABD RID: 15037 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003ABE RID: 15038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000049")]
		public event Action OnCombatKnifeHide
		{
			[Token(Token = "0x6003ABD")]
			[Address(RVA = "0x2EF3B10", Offset = "0x2EF2B10", VA = "0x182EF3B10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003ABE")]
			[Address(RVA = "0x2EF5330", Offset = "0x2EF4330", VA = "0x182EF5330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06003ABF RID: 15039 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AC0 RID: 15040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004A")]
		public event Action OnTacticalAxeShow
		{
			[Token(Token = "0x6003ABF")]
			[Address(RVA = "0x2EF4C10", Offset = "0x2EF3C10", VA = "0x182EF4C10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AC0")]
			[Address(RVA = "0x2EF6430", Offset = "0x2EF5430", VA = "0x182EF6430")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06003AC1 RID: 15041 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AC2 RID: 15042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004B")]
		public event Action OnTacticalAxeHide
		{
			[Token(Token = "0x6003AC1")]
			[Address(RVA = "0x2EF4B70", Offset = "0x2EF3B70", VA = "0x182EF4B70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AC2")]
			[Address(RVA = "0x2EF6390", Offset = "0x2EF5390", VA = "0x182EF6390")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06003AC3 RID: 15043 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003AC4 RID: 15044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004C")]
		public event Action<int> OnStandUpPropHide
		{
			[Token(Token = "0x6003AC3")]
			[Address(RVA = "0x2EF4AC0", Offset = "0x2EF3AC0", VA = "0x182EF4AC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003AC4")]
			[Address(RVA = "0x2EF62E0", Offset = "0x2EF52E0", VA = "0x182EF62E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC5")]
		[Address(RVA = "0x2EF3320", Offset = "0x2EF2320", VA = "0x182EF3320")]
		private void OnValidate()
		{
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC6")]
		[Address(RVA = "0x2EF3430", Offset = "0x2EF2430", VA = "0x182EF3430")]
		[UsedImplicitly]
		public void RangeReload()
		{
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC7")]
		[Address(RVA = "0x2EF3450", Offset = "0x2EF2450", VA = "0x182EF3450")]
		[UsedImplicitly]
		public void RangeShoot()
		{
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC8")]
		[Address(RVA = "0x2DB5980", Offset = "0x2DB4980", VA = "0x182DB5980")]
		public void AttackStart()
		{
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AC9")]
		[Address(RVA = "0x2425100", Offset = "0x2424100", VA = "0x182425100")]
		public void AttackEnd()
		{
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACA")]
		[Address(RVA = "0x2EF3160", Offset = "0x2EF2160", VA = "0x182EF3160")]
		public void GroundAttackStart()
		{
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACB")]
		[Address(RVA = "0x673CA0", Offset = "0x672CA0", VA = "0x180673CA0")]
		public void GroundAttackEnd()
		{
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACC")]
		[Address(RVA = "0x2EF35D0", Offset = "0x2EF25D0", VA = "0x182EF35D0")]
		public void TreeAttackStart()
		{
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACD")]
		[Address(RVA = "0x2EF35B0", Offset = "0x2EF25B0", VA = "0x182EF35B0")]
		public void TreeAttackEnd()
		{
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACE")]
		[Address(RVA = "0x2EF2FE0", Offset = "0x2EF1FE0", VA = "0x182EF2FE0")]
		public void ChargeAttackStart()
		{
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ACF")]
		[Address(RVA = "0x2EF2FC0", Offset = "0x2EF1FC0", VA = "0x182EF2FC0")]
		public void ChargeAttackEnd()
		{
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD0")]
		[Address(RVA = "0x2EF30C0", Offset = "0x2EF20C0", VA = "0x182EF30C0")]
		public void DigStart()
		{
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD1")]
		[Address(RVA = "0x2EF30A0", Offset = "0x2EF20A0", VA = "0x182EF30A0")]
		public void DigEnd()
		{
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD2")]
		[Address(RVA = "0x2A1D900", Offset = "0x2A1C900", VA = "0x182A1D900")]
		public void DigDirtAttach()
		{
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD3")]
		[Address(RVA = "0x2EF3080", Offset = "0x2EF2080", VA = "0x182EF3080")]
		public void DigDirtDetach()
		{
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD4")]
		[Address(RVA = "0x2EF32A0", Offset = "0x2EF22A0", VA = "0x182EF32A0")]
		public void LockedStart()
		{
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD5")]
		[Address(RVA = "0x2EF3280", Offset = "0x2EF2280", VA = "0x182EF3280")]
		public void LockedEnd()
		{
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD6")]
		[Address(RVA = "0x2EF3000", Offset = "0x2EF2000", VA = "0x182EF3000")]
		[UsedImplicitly]
		public void CheckComboStart()
		{
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD7")]
		[Address(RVA = "0x2DB59C0", Offset = "0x2DB49C0", VA = "0x182DB59C0")]
		public void CheckComboEnd()
		{
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD8")]
		[Address(RVA = "0x2EF2FA0", Offset = "0x2EF1FA0", VA = "0x182EF2FA0")]
		public void BlockRangeEnabled(bool value)
		{
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD9")]
		[Address(RVA = "0x8E6560", Offset = "0x8E5560", VA = "0x1808E6560")]
		public void SetBlockActive(bool value)
		{
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADA")]
		[Address(RVA = "0x8E6540", Offset = "0x8E5540", VA = "0x1808E6540")]
		public void SetParryActive(bool value)
		{
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADB")]
		[Address(RVA = "0x2EF3470", Offset = "0x2EF2470", VA = "0x182EF3470")]
		public void SetChainSawHold(bool value)
		{
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADC")]
		[Address(RVA = "0x2EF3120", Offset = "0x2EF2120", VA = "0x182EF3120")]
		public void EnableMeleeCollision()
		{
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADD")]
		[Address(RVA = "0x2EF30E0", Offset = "0x2EF20E0", VA = "0x182EF30E0")]
		public void DisableMeleeCollision()
		{
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADE")]
		[Address(RVA = "0x2EF32C0", Offset = "0x2EF22C0", VA = "0x182EF32C0")]
		public void MeleeAttackEvent()
		{
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADF")]
		[Address(RVA = "0x2EF3300", Offset = "0x2EF2300", VA = "0x182EF3300")]
		public void MeleeSwingAudio()
		{
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE0")]
		[Address(RVA = "0x2EF32E0", Offset = "0x2EF22E0", VA = "0x182EF32E0")]
		public void MeleeResetDamage()
		{
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE1")]
		[Address(RVA = "0x2EF34B0", Offset = "0x2EF24B0", VA = "0x182EF34B0")]
		public void SetHitDirection(int dir)
		{
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE2")]
		[Address(RVA = "0x2EF3490", Offset = "0x2EF2490", VA = "0x182EF3490")]
		public void SetComboTransition(int value)
		{
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE3")]
		[Address(RVA = "0x2EF3140", Offset = "0x2EF2140", VA = "0x182EF3140")]
		public void EnableSmashCollision()
		{
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE4")]
		[Address(RVA = "0x2EF3100", Offset = "0x2EF2100", VA = "0x182EF3100")]
		public void DisableSmashCollision()
		{
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE5")]
		[Address(RVA = "0x2EF3530", Offset = "0x2EF2530", VA = "0x182EF3530")]
		public void StepLeft()
		{
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE6")]
		[Address(RVA = "0x2EF3550", Offset = "0x2EF2550", VA = "0x182EF3550")]
		public void StepRight()
		{
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE7")]
		[Address(RVA = "0x2EF31C0", Offset = "0x2EF21C0", VA = "0x182EF31C0")]
		public void LandLight()
		{
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE8")]
		[Address(RVA = "0x2EF31C0", Offset = "0x2EF21C0", VA = "0x182EF31C0")]
		public void LandHeavy()
		{
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE9")]
		[Address(RVA = "0x2EF34D0", Offset = "0x2EF24D0", VA = "0x182EF34D0")]
		public void SetSpineBlendOff(bool value)
		{
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEA")]
		[Address(RVA = "0x2EF34F0", Offset = "0x2EF24F0", VA = "0x182EF34F0")]
		public void SetUseHeadCollider(bool value)
		{
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEB")]
		[Address(RVA = "0x2EF3510", Offset = "0x2EF2510", VA = "0x182EF3510")]
		public void StandUpPropHide(int propId)
		{
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEC")]
		[Address(RVA = "0x2A0D0C0", Offset = "0x2A0C0C0", VA = "0x182A0D0C0")]
		[UsedImplicitly]
		private void goToCombo()
		{
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AED")]
		[Address(RVA = "0x2A0D0C0", Offset = "0x2A0C0C0", VA = "0x182A0D0C0")]
		[UsedImplicitly]
		private void goToStickCombo()
		{
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEE")]
		[Address(RVA = "0x2EF4DF0", Offset = "0x2EF3DF0", VA = "0x182EF4DF0")]
		[UsedImplicitly]
		private void goToReset()
		{
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEF")]
		[Address(RVA = "0x2424F70", Offset = "0x2423F70", VA = "0x182424F70")]
		[UsedImplicitly]
		public void ItemLeavesHand()
		{
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF0")]
		[Address(RVA = "0x2EF3410", Offset = "0x2EF2410", VA = "0x182EF3410")]
		[UsedImplicitly]
		public void ProjectileReleased()
		{
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF1")]
		[Address(RVA = "0x2EF3180", Offset = "0x2EF2180", VA = "0x182EF3180")]
		[UsedImplicitly]
		public void ItemActivated()
		{
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF2")]
		[Address(RVA = "0x2EF31A0", Offset = "0x2EF21A0", VA = "0x182EF31A0")]
		[UsedImplicitly]
		public void ItemDeactivated()
		{
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF3")]
		[Address(RVA = "0x2EF31E0", Offset = "0x2EF21E0", VA = "0x182EF31E0")]
		public void LeanForwardEnter()
		{
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF4")]
		[Address(RVA = "0x2EF3220", Offset = "0x2EF2220", VA = "0x182EF3220")]
		public void LeanForwardLightLeavesUp()
		{
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF5")]
		[Address(RVA = "0x2EF3240", Offset = "0x2EF2240", VA = "0x182EF3240")]
		public void LeanForwardThrowLeaves()
		{
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF6")]
		[Address(RVA = "0x2EF3260", Offset = "0x2EF2260", VA = "0x182EF3260")]
		public void LeanForwardToLight()
		{
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF7")]
		[Address(RVA = "0x2EF3200", Offset = "0x2EF2200", VA = "0x182EF3200")]
		public void LeanForwardExit()
		{
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF8")]
		[Address(RVA = "0x2EF3060", Offset = "0x2EF2060", VA = "0x182EF3060")]
		public void CombatKnifeShow()
		{
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF9")]
		[Address(RVA = "0x2EF3040", Offset = "0x2EF2040", VA = "0x182EF3040")]
		public void CombatKnifeHide()
		{
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFA")]
		[Address(RVA = "0x2EF3590", Offset = "0x2EF2590", VA = "0x182EF3590")]
		public void TacticalAxeShow()
		{
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFB")]
		[Address(RVA = "0x2EF3570", Offset = "0x2EF2570", VA = "0x182EF3570")]
		public void TacticalAxeHide()
		{
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AFC")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public AnimationEventReceiver()
		{
		}

		// Token: 0x0400319B RID: 12699
		[Token(Token = "0x400319B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private animEventsManager _animEventsManager;

		// Token: 0x0400319C RID: 12700
		[Token(Token = "0x400319C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlayerAnimatorControl _playerAnimatorControl;
	}
}
