using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008F6 RID: 2294
	[Token(Token = "0x20008F6")]
	public class AnimationEventReceiver : MonoBehaviour
	{
		// Token: 0x1400002B RID: 43
		// (add) Token: 0x060041A3 RID: 16803 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041A4 RID: 16804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002B")]
		public event Action OnGoToCombo
		{
			[Token(Token = "0x60041A3")]
			[Address(RVA = "0x362BDB0", Offset = "0x362A3B0", VA = "0x18362BDB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041A4")]
			[Address(RVA = "0x362BEA0", Offset = "0x362A4A0", VA = "0x18362BEA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x060041A5 RID: 16805 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041A6 RID: 16806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002C")]
		public event Action OnCheckComboStart
		{
			[Token(Token = "0x60041A5")]
			[Address(RVA = "0x362BF90", Offset = "0x362A590", VA = "0x18362BF90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041A6")]
			[Address(RVA = "0x362C080", Offset = "0x362A680", VA = "0x18362C080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x060041A7 RID: 16807 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041A8 RID: 16808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002D")]
		public event Action OnCheckComboEnd
		{
			[Token(Token = "0x60041A7")]
			[Address(RVA = "0x362C170", Offset = "0x362A770", VA = "0x18362C170")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041A8")]
			[Address(RVA = "0x362C260", Offset = "0x362A860", VA = "0x18362C260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x060041A9 RID: 16809 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041AA RID: 16810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002E")]
		public event Action OnAttackStart
		{
			[Token(Token = "0x60041A9")]
			[Address(RVA = "0x362C350", Offset = "0x362A950", VA = "0x18362C350")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041AA")]
			[Address(RVA = "0x362C440", Offset = "0x362AA40", VA = "0x18362C440")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x060041AB RID: 16811 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041AC RID: 16812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002F")]
		public event Action OnDigStart
		{
			[Token(Token = "0x60041AB")]
			[Address(RVA = "0x362C530", Offset = "0x362AB30", VA = "0x18362C530")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041AC")]
			[Address(RVA = "0x362C620", Offset = "0x362AC20", VA = "0x18362C620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x060041AD RID: 16813 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041AE RID: 16814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000030")]
		public event Action OnDigEnd
		{
			[Token(Token = "0x60041AD")]
			[Address(RVA = "0x362C710", Offset = "0x362AD10", VA = "0x18362C710")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041AE")]
			[Address(RVA = "0x362C800", Offset = "0x362AE00", VA = "0x18362C800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x060041AF RID: 16815 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041B0 RID: 16816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000031")]
		public event Action OnDigDirtAttach
		{
			[Token(Token = "0x60041AF")]
			[Address(RVA = "0x362C8F0", Offset = "0x362AEF0", VA = "0x18362C8F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041B0")]
			[Address(RVA = "0x362C9E0", Offset = "0x362AFE0", VA = "0x18362C9E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x060041B1 RID: 16817 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041B2 RID: 16818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000032")]
		public event Action OnDigDirtDetach
		{
			[Token(Token = "0x60041B1")]
			[Address(RVA = "0x362CAD0", Offset = "0x362B0D0", VA = "0x18362CAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041B2")]
			[Address(RVA = "0x362CBC0", Offset = "0x362B1C0", VA = "0x18362CBC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x060041B3 RID: 16819 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041B4 RID: 16820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000033")]
		public event Action OnLockedStart
		{
			[Token(Token = "0x60041B3")]
			[Address(RVA = "0x362CCB0", Offset = "0x362B2B0", VA = "0x18362CCB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041B4")]
			[Address(RVA = "0x362CDA0", Offset = "0x362B3A0", VA = "0x18362CDA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x060041B5 RID: 16821 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041B6 RID: 16822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000034")]
		public event Action OnLockedEnd
		{
			[Token(Token = "0x60041B5")]
			[Address(RVA = "0x362CE90", Offset = "0x362B490", VA = "0x18362CE90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041B6")]
			[Address(RVA = "0x362CF80", Offset = "0x362B580", VA = "0x18362CF80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x060041B7 RID: 16823 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041B8 RID: 16824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000035")]
		public event Action OnAttackEnd
		{
			[Token(Token = "0x60041B7")]
			[Address(RVA = "0x362D070", Offset = "0x362B670", VA = "0x18362D070")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041B8")]
			[Address(RVA = "0x362D160", Offset = "0x362B760", VA = "0x18362D160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x060041B9 RID: 16825 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041BA RID: 16826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000036")]
		public event Action OnGoToReset
		{
			[Token(Token = "0x60041B9")]
			[Address(RVA = "0x362D250", Offset = "0x362B850", VA = "0x18362D250")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041BA")]
			[Address(RVA = "0x362D340", Offset = "0x362B940", VA = "0x18362D340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x060041BB RID: 16827 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041BC RID: 16828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000037")]
		public event Action OnItemLeavesHand
		{
			[Token(Token = "0x60041BB")]
			[Address(RVA = "0x362D430", Offset = "0x362BA30", VA = "0x18362D430")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041BC")]
			[Address(RVA = "0x362D520", Offset = "0x362BB20", VA = "0x18362D520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x060041BD RID: 16829 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041BE RID: 16830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000038")]
		public event Action OnProjectileReleased
		{
			[Token(Token = "0x60041BD")]
			[Address(RVA = "0x362D610", Offset = "0x362BC10", VA = "0x18362D610")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041BE")]
			[Address(RVA = "0x362D700", Offset = "0x362BD00", VA = "0x18362D700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x060041BF RID: 16831 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041C0 RID: 16832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000039")]
		public event Action OnRangeReload
		{
			[Token(Token = "0x60041BF")]
			[Address(RVA = "0x362D7F0", Offset = "0x362BDF0", VA = "0x18362D7F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041C0")]
			[Address(RVA = "0x362D8E0", Offset = "0x362BEE0", VA = "0x18362D8E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x060041C1 RID: 16833 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041C2 RID: 16834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003A")]
		public event Action OnRangeShoot
		{
			[Token(Token = "0x60041C1")]
			[Address(RVA = "0x362D9D0", Offset = "0x362BFD0", VA = "0x18362D9D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041C2")]
			[Address(RVA = "0x362DAC0", Offset = "0x362C0C0", VA = "0x18362DAC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x060041C3 RID: 16835 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041C4 RID: 16836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003B")]
		public event Action OnGroundAttackStart
		{
			[Token(Token = "0x60041C3")]
			[Address(RVA = "0x362DBB0", Offset = "0x362C1B0", VA = "0x18362DBB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041C4")]
			[Address(RVA = "0x362DCA0", Offset = "0x362C2A0", VA = "0x18362DCA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x060041C5 RID: 16837 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041C6 RID: 16838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003C")]
		public event Action OnGroundAttackEnd
		{
			[Token(Token = "0x60041C5")]
			[Address(RVA = "0x362DD90", Offset = "0x362C390", VA = "0x18362DD90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041C6")]
			[Address(RVA = "0x362DE80", Offset = "0x362C480", VA = "0x18362DE80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x060041C7 RID: 16839 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041C8 RID: 16840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003D")]
		public event Action OnTreeAttackStart
		{
			[Token(Token = "0x60041C7")]
			[Address(RVA = "0x362DF70", Offset = "0x362C570", VA = "0x18362DF70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041C8")]
			[Address(RVA = "0x362E060", Offset = "0x362C660", VA = "0x18362E060")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x060041C9 RID: 16841 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041CA RID: 16842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003E")]
		public event Action OnTreeAttackEnd
		{
			[Token(Token = "0x60041C9")]
			[Address(RVA = "0x362E150", Offset = "0x362C750", VA = "0x18362E150")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041CA")]
			[Address(RVA = "0x362E240", Offset = "0x362C840", VA = "0x18362E240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x060041CB RID: 16843 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041CC RID: 16844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003F")]
		public event Action OnChargeAttackStart
		{
			[Token(Token = "0x60041CB")]
			[Address(RVA = "0x362E330", Offset = "0x362C930", VA = "0x18362E330")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041CC")]
			[Address(RVA = "0x362E420", Offset = "0x362CA20", VA = "0x18362E420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x060041CD RID: 16845 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041CE RID: 16846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000040")]
		public event Action OnChargeAttackEnd
		{
			[Token(Token = "0x60041CD")]
			[Address(RVA = "0x362E510", Offset = "0x362CB10", VA = "0x18362E510")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041CE")]
			[Address(RVA = "0x362E600", Offset = "0x362CC00", VA = "0x18362E600")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x060041CF RID: 16847 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041D0 RID: 16848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000041")]
		public event Action<bool> OnParryActive
		{
			[Token(Token = "0x60041CF")]
			[Address(RVA = "0x362E6F0", Offset = "0x362CCF0", VA = "0x18362E6F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041D0")]
			[Address(RVA = "0x362E860", Offset = "0x362CE60", VA = "0x18362E860")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x060041D1 RID: 16849 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041D2 RID: 16850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000042")]
		public event Action<bool> OnBlockActive
		{
			[Token(Token = "0x60041D1")]
			[Address(RVA = "0x362E9D0", Offset = "0x362CFD0", VA = "0x18362E9D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041D2")]
			[Address(RVA = "0x362EB40", Offset = "0x362D140", VA = "0x18362EB40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x060041D3 RID: 16851 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041D4 RID: 16852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000043")]
		public event Action OnMeleeAttackEvent
		{
			[Token(Token = "0x60041D3")]
			[Address(RVA = "0x362ECB0", Offset = "0x362D2B0", VA = "0x18362ECB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041D4")]
			[Address(RVA = "0x362EDA0", Offset = "0x362D3A0", VA = "0x18362EDA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x060041D5 RID: 16853 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041D6 RID: 16854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000044")]
		public event Action OnHeavyMeleeAttackEvent
		{
			[Token(Token = "0x60041D5")]
			[Address(RVA = "0x362EE90", Offset = "0x362D490", VA = "0x18362EE90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041D6")]
			[Address(RVA = "0x362EF80", Offset = "0x362D580", VA = "0x18362EF80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x060041D7 RID: 16855 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041D8 RID: 16856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000045")]
		public event Action<bool> OnChainSawHold
		{
			[Token(Token = "0x60041D7")]
			[Address(RVA = "0x362F070", Offset = "0x362D670", VA = "0x18362F070")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041D8")]
			[Address(RVA = "0x362F1E0", Offset = "0x362D7E0", VA = "0x18362F1E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x060041D9 RID: 16857 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041DA RID: 16858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000046")]
		public event Action OnItemActivated
		{
			[Token(Token = "0x60041D9")]
			[Address(RVA = "0x362F350", Offset = "0x362D950", VA = "0x18362F350")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041DA")]
			[Address(RVA = "0x362F440", Offset = "0x362DA40", VA = "0x18362F440")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x060041DB RID: 16859 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041DC RID: 16860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000047")]
		public event Action OnItemDeactivated
		{
			[Token(Token = "0x60041DB")]
			[Address(RVA = "0x362F530", Offset = "0x362DB30", VA = "0x18362F530")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041DC")]
			[Address(RVA = "0x362F620", Offset = "0x362DC20", VA = "0x18362F620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x060041DD RID: 16861 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041DE RID: 16862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000048")]
		public event Action OnLeanForwardEnter
		{
			[Token(Token = "0x60041DD")]
			[Address(RVA = "0x362F710", Offset = "0x362DD10", VA = "0x18362F710")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041DE")]
			[Address(RVA = "0x362F800", Offset = "0x362DE00", VA = "0x18362F800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x060041DF RID: 16863 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041E0 RID: 16864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000049")]
		public event Action OnLeanForwardLightLeavesUp
		{
			[Token(Token = "0x60041DF")]
			[Address(RVA = "0x362F8F0", Offset = "0x362DEF0", VA = "0x18362F8F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041E0")]
			[Address(RVA = "0x362F9E0", Offset = "0x362DFE0", VA = "0x18362F9E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x060041E1 RID: 16865 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041E2 RID: 16866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004A")]
		public event Action OnLeanForwardThrowLeaves
		{
			[Token(Token = "0x60041E1")]
			[Address(RVA = "0x362FAD0", Offset = "0x362E0D0", VA = "0x18362FAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041E2")]
			[Address(RVA = "0x362FBC0", Offset = "0x362E1C0", VA = "0x18362FBC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x060041E3 RID: 16867 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041E4 RID: 16868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004B")]
		public event Action OnLeanForwardToLight
		{
			[Token(Token = "0x60041E3")]
			[Address(RVA = "0x362FCB0", Offset = "0x362E2B0", VA = "0x18362FCB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041E4")]
			[Address(RVA = "0x362FDA0", Offset = "0x362E3A0", VA = "0x18362FDA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x060041E5 RID: 16869 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041E6 RID: 16870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004C")]
		public event Action OnLeanForwardExit
		{
			[Token(Token = "0x60041E5")]
			[Address(RVA = "0x362FE90", Offset = "0x362E490", VA = "0x18362FE90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041E6")]
			[Address(RVA = "0x362FF80", Offset = "0x362E580", VA = "0x18362FF80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060041E7 RID: 16871 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041E8 RID: 16872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004D")]
		public event Action OnCombatKnifeShow
		{
			[Token(Token = "0x60041E7")]
			[Address(RVA = "0x3630070", Offset = "0x362E670", VA = "0x183630070")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041E8")]
			[Address(RVA = "0x3630160", Offset = "0x362E760", VA = "0x183630160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060041E9 RID: 16873 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041EA RID: 16874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004E")]
		public event Action OnCombatKnifeHide
		{
			[Token(Token = "0x60041E9")]
			[Address(RVA = "0x3630250", Offset = "0x362E850", VA = "0x183630250")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041EA")]
			[Address(RVA = "0x3630340", Offset = "0x362E940", VA = "0x183630340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060041EB RID: 16875 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041EC RID: 16876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400004F")]
		public event Action OnTacticalAxeShow
		{
			[Token(Token = "0x60041EB")]
			[Address(RVA = "0x3630430", Offset = "0x362EA30", VA = "0x183630430")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041EC")]
			[Address(RVA = "0x3630520", Offset = "0x362EB20", VA = "0x183630520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060041ED RID: 16877 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060041EE RID: 16878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000050")]
		public event Action OnTacticalAxeHide
		{
			[Token(Token = "0x60041ED")]
			[Address(RVA = "0x3630610", Offset = "0x362EC10", VA = "0x183630610")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60041EE")]
			[Address(RVA = "0x3630700", Offset = "0x362ED00", VA = "0x183630700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041EF")]
		[Address(RVA = "0x36307F0", Offset = "0x362EDF0", VA = "0x1836307F0")]
		private void OnValidate()
		{
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F0")]
		[Address(RVA = "0x3630A30", Offset = "0x362F030", VA = "0x183630A30")]
		[UsedImplicitly]
		public void RangeReload()
		{
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F1")]
		[Address(RVA = "0x3630A50", Offset = "0x362F050", VA = "0x183630A50")]
		[UsedImplicitly]
		public void RangeShoot()
		{
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F2")]
		[Address(RVA = "0x34ACF70", Offset = "0x34AB570", VA = "0x1834ACF70")]
		public void AttackStart()
		{
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F3")]
		[Address(RVA = "0x28C3DF0", Offset = "0x28C23F0", VA = "0x1828C3DF0")]
		public void AttackEnd()
		{
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F4")]
		[Address(RVA = "0x3630A70", Offset = "0x362F070", VA = "0x183630A70")]
		public void GroundAttackStart()
		{
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F5")]
		[Address(RVA = "0x728BE0", Offset = "0x7271E0", VA = "0x180728BE0")]
		public void GroundAttackEnd()
		{
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F6")]
		[Address(RVA = "0x3630A90", Offset = "0x362F090", VA = "0x183630A90")]
		public void TreeAttackStart()
		{
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F7")]
		[Address(RVA = "0x3630AB0", Offset = "0x362F0B0", VA = "0x183630AB0")]
		public void TreeAttackEnd()
		{
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F8")]
		[Address(RVA = "0x3630AD0", Offset = "0x362F0D0", VA = "0x183630AD0")]
		public void ChargeAttackStart()
		{
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F9")]
		[Address(RVA = "0x3630AF0", Offset = "0x362F0F0", VA = "0x183630AF0")]
		public void ChargeAttackEnd()
		{
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FA")]
		[Address(RVA = "0x3630B10", Offset = "0x362F110", VA = "0x183630B10")]
		public void DigStart()
		{
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FB")]
		[Address(RVA = "0x3630B30", Offset = "0x362F130", VA = "0x183630B30")]
		public void DigEnd()
		{
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FC")]
		[Address(RVA = "0x3630B50", Offset = "0x362F150", VA = "0x183630B50")]
		public void DigDirtAttach()
		{
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FD")]
		[Address(RVA = "0x3630B70", Offset = "0x362F170", VA = "0x183630B70")]
		public void DigDirtDetach()
		{
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FE")]
		[Address(RVA = "0x3630B90", Offset = "0x362F190", VA = "0x183630B90")]
		public void LockedStart()
		{
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041FF")]
		[Address(RVA = "0x30476B0", Offset = "0x3045CB0", VA = "0x1830476B0")]
		public void LockedEnd()
		{
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004200")]
		[Address(RVA = "0x3630BB0", Offset = "0x362F1B0", VA = "0x183630BB0")]
		[UsedImplicitly]
		public void CheckComboStart()
		{
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004201")]
		[Address(RVA = "0x34ACF50", Offset = "0x34AB550", VA = "0x1834ACF50")]
		public void CheckComboEnd()
		{
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004202")]
		[Address(RVA = "0x3630BF0", Offset = "0x362F1F0", VA = "0x183630BF0")]
		public void BlockRangeEnabled(bool value)
		{
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004203")]
		[Address(RVA = "0xA3FEF0", Offset = "0xA3E4F0", VA = "0x180A3FEF0")]
		public void SetBlockActive(bool value)
		{
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004204")]
		[Address(RVA = "0xA3FED0", Offset = "0xA3E4D0", VA = "0x180A3FED0")]
		public void SetParryActive(bool value)
		{
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004205")]
		[Address(RVA = "0x3630C60", Offset = "0x362F260", VA = "0x183630C60")]
		public void SetChainSawHold(bool value)
		{
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004206")]
		[Address(RVA = "0x3630C80", Offset = "0x362F280", VA = "0x183630C80")]
		public void EnableMeleeCollision()
		{
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004207")]
		[Address(RVA = "0x3630CA0", Offset = "0x362F2A0", VA = "0x183630CA0")]
		public void DisableMeleeCollision()
		{
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004208")]
		[Address(RVA = "0x3630D20", Offset = "0x362F320", VA = "0x183630D20")]
		public void MeleeAttackEvent()
		{
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004209")]
		[Address(RVA = "0x3630D40", Offset = "0x362F340", VA = "0x183630D40")]
		public void HeavyMeleeAttackEvent()
		{
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420A")]
		[Address(RVA = "0x3630D60", Offset = "0x362F360", VA = "0x183630D60")]
		public void MeleeSwingAudio()
		{
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420B")]
		[Address(RVA = "0x3630E60", Offset = "0x362F460", VA = "0x183630E60")]
		public void MeleeResetDamage()
		{
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420C")]
		[Address(RVA = "0x3630EA0", Offset = "0x362F4A0", VA = "0x183630EA0")]
		public void SetHitDirection(int dir)
		{
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420D")]
		[Address(RVA = "0x3630F10", Offset = "0x362F510", VA = "0x183630F10")]
		public void SetComboTransition(int value)
		{
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420E")]
		[Address(RVA = "0x3630F80", Offset = "0x362F580", VA = "0x183630F80")]
		public void EnableSmashCollision()
		{
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420F")]
		[Address(RVA = "0x3630FD0", Offset = "0x362F5D0", VA = "0x183630FD0")]
		public void DisableSmashCollision()
		{
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004210")]
		[Address(RVA = "0x3631050", Offset = "0x362F650", VA = "0x183631050")]
		public void StepLeft()
		{
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004211")]
		[Address(RVA = "0x3631080", Offset = "0x362F680", VA = "0x183631080")]
		public void StepRight()
		{
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004212")]
		[Address(RVA = "0x36310B0", Offset = "0x362F6B0", VA = "0x1836310B0")]
		public void LandLight()
		{
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004213")]
		[Address(RVA = "0x36310B0", Offset = "0x362F6B0", VA = "0x1836310B0")]
		public void LandHeavy()
		{
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004214")]
		[Address(RVA = "0x36310D0", Offset = "0x362F6D0", VA = "0x1836310D0")]
		public void BodyFallLand()
		{
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004215")]
		[Address(RVA = "0x36310F0", Offset = "0x362F6F0", VA = "0x1836310F0")]
		public void SetSpineBlendOff(bool value)
		{
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004216")]
		[Address(RVA = "0x3631130", Offset = "0x362F730", VA = "0x183631130")]
		public void SetUseHeadCollider(bool value)
		{
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004217")]
		[Address(RVA = "0x3631170", Offset = "0x362F770", VA = "0x183631170")]
		public void StandUpPropHide(int propId)
		{
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004218")]
		[Address(RVA = "0x2FF7330", Offset = "0x2FF5930", VA = "0x182FF7330")]
		[UsedImplicitly]
		private void goToCombo()
		{
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004219")]
		[Address(RVA = "0x2FF7330", Offset = "0x2FF5930", VA = "0x182FF7330")]
		[UsedImplicitly]
		private void goToStickCombo()
		{
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421A")]
		[Address(RVA = "0x36311C0", Offset = "0x362F7C0", VA = "0x1836311C0")]
		[UsedImplicitly]
		private void goToReset()
		{
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421B")]
		[Address(RVA = "0x28C3E10", Offset = "0x28C2410", VA = "0x1828C3E10")]
		[UsedImplicitly]
		public void ItemLeavesHand()
		{
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421C")]
		[Address(RVA = "0x36311E0", Offset = "0x362F7E0", VA = "0x1836311E0")]
		[UsedImplicitly]
		public void ProjectileReleased()
		{
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421D")]
		[Address(RVA = "0x3631200", Offset = "0x362F800", VA = "0x183631200")]
		[UsedImplicitly]
		public void ItemActivated()
		{
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421E")]
		[Address(RVA = "0x3631220", Offset = "0x362F820", VA = "0x183631220")]
		[UsedImplicitly]
		public void ItemDeactivated()
		{
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421F")]
		[Address(RVA = "0x3631240", Offset = "0x362F840", VA = "0x183631240")]
		public void LeanForwardEnter()
		{
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004220")]
		[Address(RVA = "0x3631260", Offset = "0x362F860", VA = "0x183631260")]
		public void LeanForwardLightLeavesUp()
		{
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004221")]
		[Address(RVA = "0x3631280", Offset = "0x362F880", VA = "0x183631280")]
		public void LeanForwardThrowLeaves()
		{
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004222")]
		[Address(RVA = "0x36312A0", Offset = "0x362F8A0", VA = "0x1836312A0")]
		public void LeanForwardToLight()
		{
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004223")]
		[Address(RVA = "0x36312C0", Offset = "0x362F8C0", VA = "0x1836312C0")]
		public void LeanForwardExit()
		{
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004224")]
		[Address(RVA = "0x36312E0", Offset = "0x362F8E0", VA = "0x1836312E0")]
		public void CombatKnifeShow()
		{
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004225")]
		[Address(RVA = "0x3631300", Offset = "0x362F900", VA = "0x183631300")]
		public void CombatKnifeHide()
		{
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004226")]
		[Address(RVA = "0x3631320", Offset = "0x362F920", VA = "0x183631320")]
		public void TacticalAxeShow()
		{
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004227")]
		[Address(RVA = "0x3631340", Offset = "0x362F940", VA = "0x183631340")]
		public void TacticalAxeHide()
		{
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004228")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AnimationEventReceiver()
		{
		}

		// Token: 0x04003666 RID: 13926
		[Token(Token = "0x4003666")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private animEventsManager _animEventsManager;

		// Token: 0x04003667 RID: 13927
		[Token(Token = "0x4003667")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlayerAnimatorControl _playerAnimatorControl;
	}
}
