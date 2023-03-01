using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x0200060D RID: 1549
	[Token(Token = "0x200060D")]
	public abstract class ItemInstanceModule
	{
		// Token: 0x06002795 RID: 10133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002795")]
		[Address(RVA = "0x2DBEA90", Offset = "0x2DBDA90", VA = "0x182DBEA90")]
		protected ItemInstanceModule()
		{
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x0000B910 File Offset: 0x00009B10
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000535")]
		protected bool Enabled
		{
			[Token(Token = "0x6002796")]
			[Address(RVA = "0x6B3E80", Offset = "0x6B2E80", VA = "0x1806B3E80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002797")]
			[Address(RVA = "0x6B3E90", Offset = "0x6B2E90", VA = "0x1806B3E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002798 RID: 10136
		[Token(Token = "0x6002798")]
		public abstract void Update();

		// Token: 0x06002799 RID: 10137
		[Token(Token = "0x6002799")]
		public abstract void Refresh(ItemInstance itemInstance, GameObject itemObject);

		// Token: 0x0600279A RID: 10138
		[Token(Token = "0x600279A")]
		protected abstract void Instantiate();

		// Token: 0x0600279B RID: 10139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279B")]
		[Address(RVA = "0x2DBE800", Offset = "0x2DBD800", VA = "0x182DBE800", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279C")]
		[Address(RVA = "0x2DBE910", Offset = "0x2DBD910", VA = "0x182DBE910")]
		protected void ModuleRefreshed(GameObject itemObject)
		{
		}

		// Token: 0x0600279D RID: 10141
		[Token(Token = "0x600279D")]
		public abstract void SetFromUdpPacket(ref UdpPacket packet);

		// Token: 0x0600279E RID: 10142
		[Token(Token = "0x600279E")]
		public abstract void PushToUdpPacket(ref UdpPacket packet);

		// Token: 0x0600279F RID: 10143
		[Token(Token = "0x600279F")]
		public abstract ItemInstanceModule.SaveData GetSaveData();

		// Token: 0x060027A0 RID: 10144
		[Token(Token = "0x60027A0")]
		public abstract void LoadFromSave(ItemInstanceModule.SaveData saveData);

		// Token: 0x040023A5 RID: 9125
		[Token(Token = "0x40023A5")]
		[FieldOffset(Offset = "0x10")]
		protected bool _isInstantiated;

		// Token: 0x040023A6 RID: 9126
		[Token(Token = "0x40023A6")]
		[FieldOffset(Offset = "0x14")]
		public int ItemId;

		// Token: 0x0200060E RID: 1550
		[Token(Token = "0x200060E")]
		[JsonConverter(typeof(ItemInstanceModuleSaveDataJsonConverter))]
		[Serializable]
		public class SaveData
		{
			// Token: 0x060027A1 RID: 10145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60027A1")]
			[Address(RVA = "0x2DC2180", Offset = "0x2DC1180", VA = "0x182DC2180")]
			public SaveData()
			{
			}

			// Token: 0x040023A8 RID: 9128
			[Token(Token = "0x40023A8")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x040023A9 RID: 9129
			[Token(Token = "0x40023A9")]
			[FieldOffset(Offset = "0x18")]
			public int ModuleId;
		}
	}
}
