using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sons.Electricity
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[Serializable]
	public class PowerGrid
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000020B4 File Offset: 0x000002B4
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000B")]
		public float TotalPower
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000020CC File Offset: 0x000002CC
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000C")]
		public float UsedPower
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x1700000D")]
		public float AvailablePower
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2F89780", Offset = "0x2F87D80", VA = "0x182F89780")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2F89790", Offset = "0x2F87D90", VA = "0x182F89790")]
		public static void HookUpWire(IPowerGridWire wire)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2F89C70", Offset = "0x2F88270", VA = "0x182F89C70")]
		private static void MergePowerGrids(PowerGrid powerGrid1, PowerGrid powerGrid2)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2F8A1C0", Offset = "0x2F887C0", VA = "0x182F8A1C0")]
		public static void RemoveWire(IPowerGridWire wire)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2F8A9F0", Offset = "0x2F88FF0", VA = "0x182F8A9F0")]
		private void RefreshDevicesState()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2F8AC10", Offset = "0x2F89210", VA = "0x182F8AC10")]
		private void AddPowerSources(IEnumerable<PowerSource> powerSources)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2F8AEC0", Offset = "0x2F894C0", VA = "0x182F8AEC0")]
		public void AddPowerSource(PowerSource powerSource)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2F8AF60", Offset = "0x2F89560", VA = "0x182F8AF60")]
		public void RemovePowerSource(PowerSource powerSource, bool canRefreshDevicesState = true)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2F8B000", Offset = "0x2F89600", VA = "0x182F8B000")]
		public void AddDevices(IEnumerable<ElectricDevice> devices)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2F8B1C0", Offset = "0x2F897C0", VA = "0x182F8B1C0")]
		public void AddDevice(ElectricDevice device)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2F8B2A0", Offset = "0x2F898A0", VA = "0x182F8B2A0")]
		public void RemoveDevice(ElectricDevice device)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2F8B360", Offset = "0x2F89960", VA = "0x182F8B360")]
		public PowerGrid()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2F8B560", Offset = "0x2F89B60", VA = "0x182F8B560")]
		[CompilerGenerated]
		internal static bool <HookUpWire>g__IdentifyUniqueConnectedPowerGrid|15_0(out PowerGrid grid1, ref PowerGrid.<>c__DisplayClass15_0 A_1)
		{
			return default(bool);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2F8B790", Offset = "0x2F89D90", VA = "0x182F8B790")]
		[CompilerGenerated]
		internal static int <MergePowerGrids>g__CalcPowerGridMergeScore|16_0(PowerGrid powerGrid)
		{
			return 0;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2F8B810", Offset = "0x2F89E10", VA = "0x182F8B810")]
		[CompilerGenerated]
		internal static void <RemoveWire>g__CleanUpWireFromConnectedWires|17_0(ref PowerGrid.<>c__DisplayClass17_0 A_0)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2F8BA70", Offset = "0x2F8A070", VA = "0x182F8BA70")]
		[CompilerGenerated]
		internal static void <RemoveWire>g__IdentifyWireGroups|17_1(ref PowerGrid.<>c__DisplayClass17_0 A_0)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2F8BF30", Offset = "0x2F8A530", VA = "0x182F8BF30")]
		[CompilerGenerated]
		internal static void <RemoveWire>g__CollectConnectedWires|17_2(Queue<IPowerGridWire> toProcessWires, HashSet<IPowerGridWire> wireGroup, IPowerGridWire currentWire, ref PowerGrid.<>c__DisplayClass17_0 A_3)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2F8C280", Offset = "0x2F8A880", VA = "0x182F8C280")]
		[CompilerGenerated]
		internal static void <RemoveWire>g__CreateNewPowerGridForEachWireGroup|17_3(ref PowerGrid.<>c__DisplayClass17_0 A_0)
		{
		}

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x0")]
		private static int LastPowerGridId;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x10")]
		private readonly int _id;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<IPowerGridWire> _wires;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<PowerSource> _powerSources;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<ElectricDevice> _devices;
	}
}
