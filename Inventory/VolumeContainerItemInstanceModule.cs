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
	// Token: 0x02000628 RID: 1576
	[Token(Token = "0x2000628")]
	public class VolumeContainerItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600283C RID: 10300 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		// (set) Token: 0x0600283D RID: 10301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000551")]
		public float MaxVolume
		{
			[Token(Token = "0x600283C")]
			[Address(RVA = "0x8A27B0", Offset = "0x8A17B0", VA = "0x1808A27B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600283D")]
			[Address(RVA = "0x67DC20", Offset = "0x67CC20", VA = "0x18067DC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x0600283E RID: 10302 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		// (set) Token: 0x0600283F RID: 10303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000552")]
		public float CurrentVolume
		{
			[Token(Token = "0x600283E")]
			[Address(RVA = "0x5A1700", Offset = "0x5A0700", VA = "0x1805A1700")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600283F")]
			[Address(RVA = "0x5A1850", Offset = "0x5A0850", VA = "0x1805A1850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002840 RID: 10304 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[Token(Token = "0x17000553")]
		public float AvailableVolume
		{
			[Token(Token = "0x6002840")]
			[Address(RVA = "0x2DC5EA0", Offset = "0x2DC4EA0", VA = "0x182DC5EA0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x17000554")]
		public bool IsEmpty
		{
			[Token(Token = "0x6002841")]
			[Address(RVA = "0x2DC5EC0", Offset = "0x2DC4EC0", VA = "0x182DC5EC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06002842 RID: 10306 RVA: 0x0000BC10 File Offset: 0x00009E10
		[Token(Token = "0x17000555")]
		public bool IsFull
		{
			[Token(Token = "0x6002842")]
			[Address(RVA = "0x2DC5EE0", Offset = "0x2DC4EE0", VA = "0x182DC5EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x17000556")]
		public float FactorRemaining
		{
			[Token(Token = "0x6002843")]
			[Address(RVA = "0x2DC5EB0", Offset = "0x2DC4EB0", VA = "0x182DC5EB0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002844")]
		[Address(RVA = "0x2DC55D0", Offset = "0x2DC45D0", VA = "0x182DC55D0")]
		public IEnumerable<StatEffect> GetStatEffects()
		{
			return null;
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000557")]
		public StatRecipe Recipe
		{
			[Token(Token = "0x6002845")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002846")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x2DC5AB0", Offset = "0x2DC4AB0", VA = "0x182DC5AB0", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002848")]
		[Address(RVA = "0x2DC5690", Offset = "0x2DC4690", VA = "0x182DC5690", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002849")]
		[Address(RVA = "0x2DC5A90", Offset = "0x2DC4A90", VA = "0x182DC5A90")]
		public void Refill(StatRecipe statRecipe)
		{
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284A")]
		[Address(RVA = "0x2DC59D0", Offset = "0x2DC49D0", VA = "0x182DC59D0")]
		public void Refill(float refillVolume = 3.4028235E+38f, [Optional] StatRecipe statRecipe)
		{
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284B")]
		[Address(RVA = "0x2DC5460", Offset = "0x2DC4460", VA = "0x182DC5460")]
		public void Empty(float emptyVolume = 3.4028235E+38f)
		{
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284C")]
		[Address(RVA = "0x2DC5CB0", Offset = "0x2DC4CB0", VA = "0x182DC5CB0", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284D")]
		[Address(RVA = "0x2DC5920", Offset = "0x2DC4920", VA = "0x182DC5920", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600284E")]
		[Address(RVA = "0x2DC54D0", Offset = "0x2DC44D0", VA = "0x182DC54D0", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284F")]
		[Address(RVA = "0x2DC5730", Offset = "0x2DC4730", VA = "0x182DC5730", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002850")]
		[Address(RVA = "0x2DC5E20", Offset = "0x2DC4E20", VA = "0x182DC5E20")]
		public VolumeContainerItemInstanceModule()
		{
		}

		// Token: 0x040023F9 RID: 9209
		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0x20")]
		private VolumeContainerItemData _data;

		// Token: 0x040023FA RID: 9210
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0x28")]
		private StatRecipe _statRecipe;

		// Token: 0x040023FD RID: 9213
		[Token(Token = "0x40023FD")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<float> OnVolumeChanged;

		// Token: 0x02000629 RID: 1577
		[Token(Token = "0x2000629")]
		[Serializable]
		public class VolumeContainerSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x06002851 RID: 10321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002851")]
			[Address(RVA = "0x2DC2180", Offset = "0x2DC1180", VA = "0x182DC2180")]
			public VolumeContainerSaveData()
			{
			}

			// Token: 0x040023FE RID: 9214
			[Token(Token = "0x40023FE")]
			[FieldOffset(Offset = "0x20")]
			public int RecipeId;

			// Token: 0x040023FF RID: 9215
			[Token(Token = "0x40023FF")]
			[FieldOffset(Offset = "0x24")]
			public int CurrentVolume;
		}
	}
}
