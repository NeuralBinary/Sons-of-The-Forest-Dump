using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction.Multiplayer
{
	// Token: 0x02000289 RID: 649
	[Token(Token = "0x2000289")]
	[AddComponentMenu("Sons/Construction/FreeFormSystemNetworkProxy (Base)")]
	public abstract class FreeFormSystemNetworkProxyBase : GlobalEventListener
	{
		// Token: 0x060013C8 RID: 5064 RVA: 0x0000BD44 File Offset: 0x00009F44
		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x2F5CA40", Offset = "0x2F5B040", VA = "0x182F5CA40")]
		protected bool TryGetSenderPlayerEntity(FreeFormPlaceElement evnt, out BoltEntity playerEntity)
		{
			return default(bool);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0000BD5C File Offset: 0x00009F5C
		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x2F5CC90", Offset = "0x2F5B290", VA = "0x182F5CC90")]
		protected bool TryGetPlayerNetworkAnimation(BoltEntity playerEntity, out FreeFormPlayerNetworkAnimation networkAnim)
		{
			return default(bool);
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013CA")]
		[Address(RVA = "0x2F5CEC0", Offset = "0x2F5B4C0", VA = "0x182F5CEC0", Slot = "355")]
		public override void OnEvent(FreeFormPlayerFinishedAnim evnt)
		{
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x2F5D280", Offset = "0x2F5B880", VA = "0x182F5D280", Slot = "327")]
		public override void OnEvent(FreeFormPlaceElement evnt)
		{
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0000BD74 File Offset: 0x00009F74
		[Token(Token = "0x60013CC")]
		[Address(RVA = "0x2F5DBE0", Offset = "0x2F5C1E0", VA = "0x182F5DBE0")]
		protected bool IsDestroyedOrOutdatedStructure(int dbVersion, int typeId, ref int instanceId)
		{
			return default(bool);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x2F5DD00", Offset = "0x2F5C300", VA = "0x182F5DD00")]
		protected void CleanUpRecentlyDestroyedOrOutdatedStructures()
		{
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "384")]
		protected virtual void OnPlace(IConstructionModule module, TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "385")]
		protected virtual void SendStructurePlacementRejectedEvent(BoltConnection targetClient, int actionNum)
		{
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0000BD8C File Offset: 0x00009F8C
		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x2F5E050", Offset = "0x2F5C650", VA = "0x182F5E050")]
		protected static bool ValidateEvent(BoltEntity target, BoltConnection raisedBy, int maxDistance)
		{
			return default(bool);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0000BDA4 File Offset: 0x00009FA4
		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x2F5E440", Offset = "0x2F5CA40", VA = "0x182F5E440")]
		protected static bool ValidateEvent(BoltEntity target, BoltConnection raisedBy, int maxDistance, out BoltEntity playerEntity)
		{
			return default(bool);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0000BDBC File Offset: 0x00009FBC
		[Token(Token = "0x60013D2")]
		[Address(RVA = "0x2F5E8D0", Offset = "0x2F5CED0", VA = "0x182F5E8D0")]
		protected static bool ValidateEvent(Structure target, BoltConnection raisedBy, int maxDistance)
		{
			return default(bool);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0000BDD4 File Offset: 0x00009FD4
		[Token(Token = "0x60013D3")]
		[Address(RVA = "0x2F5EC30", Offset = "0x2F5D230", VA = "0x182F5EC30")]
		protected static bool ValidateEventSender(BoltConnection raisedBy, out BoltEntity playerEntity)
		{
			return default(bool);
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013D4")]
		[Address(RVA = "0x2F5EEF0", Offset = "0x2F5D4F0", VA = "0x182F5EEF0", Slot = "333")]
		public override void OnEvent(DwGateOpenEvent evnt)
		{
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013D5")]
		[Address(RVA = "0x2F5F080", Offset = "0x2F5D680", VA = "0x182F5F080", Slot = "334")]
		public override void OnEvent(DwGateCloseEvent evnt)
		{
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013D6")]
		[Address(RVA = "0x2F5F210", Offset = "0x2F5D810", VA = "0x182F5F210")]
		protected FreeFormSystemNetworkProxyBase()
		{
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0000BDEC File Offset: 0x00009FEC
		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x2F5F3B0", Offset = "0x2F5D9B0", VA = "0x182F5F3B0")]
		[CompilerGenerated]
		private bool <OnEvent>g__TryValidateAndExtractEventData|5_0(out IConstructionModule module, out TargetInfo targetInfo, out ModuleProfile profile, out int placementMode, out ItemData targetItem, ref FreeFormSystemNetworkProxyBase.<>c__DisplayClass5_0 A_6)
		{
			return default(bool);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0000BE04 File Offset: 0x0000A004
		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x2F5FA60", Offset = "0x2F5E060", VA = "0x182F5FA60")]
		[CompilerGenerated]
		private bool <OnEvent>g__TryGenerateTargetInfoFromEventData|5_1(FreeFormPlaceElement placeEvent, out TargetInfo targetInfoInstance, ref FreeFormSystemNetworkProxyBase.<>c__DisplayClass5_0 A_3)
		{
			return default(bool);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0000BE1C File Offset: 0x0000A01C
		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x2F60990", Offset = "0x2F5EF90", VA = "0x182F60990")]
		[CompilerGenerated]
		private bool <OnEvent>g__TryGetStructure|5_2(int eventTypeID, int eventInstanceID, AnticipatedStructureFlags searchedFlag, out Structure structure, ref FreeFormSystemNetworkProxyBase.<>c__DisplayClass5_0 A_5)
		{
			return default(bool);
		}

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x38")]
		protected BoltConnection _lastSender;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x40")]
		protected int _lastActionNum;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly List<FreeFormSystemNetworkProxyBase.DestroyedStructure> RecentlyDestroyedStructures;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x8")]
		protected static readonly List<FreeFormSystemNetworkProxyBase.OutdatedStructure> RecentlyOutdatedStructures;

		// Token: 0x0200028A RID: 650
		[Token(Token = "0x200028A")]
		protected class DestroyedStructure
		{
			// Token: 0x060013DB RID: 5083 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60013DB")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public DestroyedStructure()
			{
			}

			// Token: 0x040009A2 RID: 2466
			[Token(Token = "0x40009A2")]
			[FieldOffset(Offset = "0x10")]
			public int DbVersion;

			// Token: 0x040009A3 RID: 2467
			[Token(Token = "0x40009A3")]
			[FieldOffset(Offset = "0x14")]
			public int TypeId;

			// Token: 0x040009A4 RID: 2468
			[Token(Token = "0x40009A4")]
			[FieldOffset(Offset = "0x18")]
			public int InstanceId;
		}

		// Token: 0x0200028B RID: 651
		[Token(Token = "0x200028B")]
		protected class OutdatedStructure
		{
			// Token: 0x060013DC RID: 5084 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60013DC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public OutdatedStructure()
			{
			}

			// Token: 0x040009A5 RID: 2469
			[Token(Token = "0x40009A5")]
			[FieldOffset(Offset = "0x10")]
			public int DbVersion;

			// Token: 0x040009A6 RID: 2470
			[Token(Token = "0x40009A6")]
			[FieldOffset(Offset = "0x14")]
			public uint TypeId;

			// Token: 0x040009A7 RID: 2471
			[Token(Token = "0x40009A7")]
			[FieldOffset(Offset = "0x18")]
			public uint OldInstanceId;

			// Token: 0x040009A8 RID: 2472
			[Token(Token = "0x40009A8")]
			[FieldOffset(Offset = "0x1C")]
			public uint NewInstanceId;
		}
	}
}
