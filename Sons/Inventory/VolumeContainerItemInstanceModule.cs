using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using UdpKit;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Inventory
{
	// Token: 0x0200063F RID: 1599
	[Token(Token = "0x200063F")]
	public class VolumeContainerItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x0000C360 File Offset: 0x0000A560
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000569")]
		public float MaxVolume
		{
			[Token(Token = "0x6002968")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002969")]
			[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x0000C378 File Offset: 0x0000A578
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056A")]
		public float CurrentVolume
		{
			[Token(Token = "0x600296A")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600296B")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x0000C390 File Offset: 0x0000A590
		[Token(Token = "0x1700056B")]
		public float AvailableVolume
		{
			[Token(Token = "0x600296C")]
			[Address(RVA = "0x2F89780", Offset = "0x2F87D80", VA = "0x182F89780")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600296D RID: 10605 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		[Token(Token = "0x1700056C")]
		public bool IsEmpty
		{
			[Token(Token = "0x600296D")]
			[Address(RVA = "0x33EBAD0", Offset = "0x33EA0D0", VA = "0x1833EBAD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		[Token(Token = "0x1700056D")]
		public bool IsFull
		{
			[Token(Token = "0x600296E")]
			[Address(RVA = "0x33EBAF0", Offset = "0x33EA0F0", VA = "0x1833EBAF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		[Token(Token = "0x1700056E")]
		public float FactorRemaining
		{
			[Token(Token = "0x600296F")]
			[Address(RVA = "0x33EBB10", Offset = "0x33EA110", VA = "0x1833EBB10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002970")]
		[Address(RVA = "0x33EBB20", Offset = "0x33EA120", VA = "0x1833EBB20")]
		public IEnumerable<StatEffect> GetStatEffects()
		{
			return null;
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700056F")]
		public StatRecipe Recipe
		{
			[Token(Token = "0x6002971")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002972")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002973")]
		[Address(RVA = "0x33EBC40", Offset = "0x33EA240", VA = "0x1833EBC40", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002974")]
		[Address(RVA = "0x33EBD70", Offset = "0x33EA370", VA = "0x1833EBD70", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002975")]
		[Address(RVA = "0x33EBEF0", Offset = "0x33EA4F0", VA = "0x1833EBEF0")]
		public void Refill(StatRecipe statRecipe)
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002976")]
		[Address(RVA = "0x33EBF10", Offset = "0x33EA510", VA = "0x1833EBF10")]
		public void SetContents(float volume, StatRecipe statRecipe)
		{
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002977")]
		[Address(RVA = "0x33EC060", Offset = "0x33EA660", VA = "0x1833EC060")]
		public void Refill(float refillVolume = 3.4028235E+38f, [Optional] StatRecipe statRecipe)
		{
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002978")]
		[Address(RVA = "0x33EC240", Offset = "0x33EA840", VA = "0x1833EC240")]
		public void Empty(float emptyVolume = 3.4028235E+38f)
		{
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002979")]
		[Address(RVA = "0x33EC320", Offset = "0x33EA920", VA = "0x1833EC320", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297A")]
		[Address(RVA = "0x33EC570", Offset = "0x33EAB70", VA = "0x1833EC570", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297B")]
		[Address(RVA = "0x33EC6C0", Offset = "0x33EACC0", VA = "0x1833EC6C0", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297C")]
		[Address(RVA = "0x33EC7F0", Offset = "0x33EADF0", VA = "0x1833EC7F0", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297D")]
		[Address(RVA = "0x33ECAA0", Offset = "0x33EB0A0", VA = "0x1833ECAA0")]
		public VolumeContainerItemInstanceModule()
		{
		}

		// Token: 0x040024F0 RID: 9456
		[Token(Token = "0x40024F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VolumeContainerItemData _data;

		// Token: 0x040024F1 RID: 9457
		[Token(Token = "0x40024F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private StatRecipe _statRecipe;

		// Token: 0x040024F4 RID: 9460
		[Token(Token = "0x40024F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent<float> OnVolumeChanged;

		// Token: 0x02000640 RID: 1600
		[Token(Token = "0x2000640")]
		[Serializable]
		public class VolumeContainerSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x0600297E RID: 10622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600297E")]
			[Address(RVA = "0x33CE370", Offset = "0x33CC970", VA = "0x1833CE370")]
			public VolumeContainerSaveData()
			{
			}

			// Token: 0x040024F5 RID: 9461
			[Token(Token = "0x40024F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int RecipeId;

			// Token: 0x040024F6 RID: 9462
			[Token(Token = "0x40024F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int CurrentVolume;
		}
	}
}
