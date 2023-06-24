using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000620 RID: 1568
	[Token(Token = "0x2000620")]
	public abstract class ItemInstanceModule
	{
		// Token: 0x060028AE RID: 10414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028AE")]
		[Address(RVA = "0x33E35A0", Offset = "0x33E1BA0", VA = "0x1833E35A0")]
		protected ItemInstanceModule()
		{
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x0000C048 File Offset: 0x0000A248
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054A")]
		protected bool Enabled
		{
			[Token(Token = "0x60028AF")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028B0")]
			[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028B1 RID: 10417
		[Token(Token = "0x60028B1")]
		public abstract void Update();

		// Token: 0x060028B2 RID: 10418
		[Token(Token = "0x60028B2")]
		public abstract void Refresh(ItemInstance itemInstance, GameObject itemObject);

		// Token: 0x060028B3 RID: 10419
		[Token(Token = "0x60028B3")]
		protected abstract void Instantiate();

		// Token: 0x060028B4 RID: 10420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028B4")]
		[Address(RVA = "0x33E3670", Offset = "0x33E1C70", VA = "0x1833E3670", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028B5")]
		[Address(RVA = "0x33E37B0", Offset = "0x33E1DB0", VA = "0x1833E37B0")]
		protected void ModuleRefreshed(GameObject itemObject)
		{
		}

		// Token: 0x060028B6 RID: 10422
		[Token(Token = "0x60028B6")]
		public abstract void SetFromUdpPacket(ref UdpPacket packet);

		// Token: 0x060028B7 RID: 10423
		[Token(Token = "0x60028B7")]
		public abstract void PushToUdpPacket(ref UdpPacket packet);

		// Token: 0x060028B8 RID: 10424
		[Token(Token = "0x60028B8")]
		public abstract ItemInstanceModule.SaveData GetSaveData();

		// Token: 0x060028B9 RID: 10425
		[Token(Token = "0x60028B9")]
		public abstract void LoadFromSave(ItemInstanceModule.SaveData saveData);

		// Token: 0x04002495 RID: 9365
		[Token(Token = "0x4002495")]
		[FieldOffset(Offset = "0x10")]
		protected bool _isInstantiated;

		// Token: 0x04002496 RID: 9366
		[Token(Token = "0x4002496")]
		[FieldOffset(Offset = "0x14")]
		public int ItemId;

		// Token: 0x02000621 RID: 1569
		[Token(Token = "0x2000621")]
		[JsonConverter(typeof(ItemInstanceModuleSaveDataJsonConverter))]
		[Serializable]
		public class SaveData
		{
			// Token: 0x060028BA RID: 10426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60028BA")]
			[Address(RVA = "0x33E3990", Offset = "0x33E1F90", VA = "0x1833E3990")]
			public SaveData()
			{
			}

			// Token: 0x04002498 RID: 9368
			[Token(Token = "0x4002498")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04002499 RID: 9369
			[Token(Token = "0x4002499")]
			[FieldOffset(Offset = "0x18")]
			public int ModuleId;
		}
	}
}
