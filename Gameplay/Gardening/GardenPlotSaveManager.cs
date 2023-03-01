using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;

namespace Sons.Gameplay.Gardening
{
	// Token: 0x02000718 RID: 1816
	[Token(Token = "0x2000718")]
	public class GardenPlotSaveManager : SingletonBehaviour<GardenPlotSaveManager>, ISaveGameSerializer<GardenPlotSaveManager.GardenPlotManagerSaveData>
	{
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002F4B RID: 12107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E9")]
		private string SerializedName
		{
			[Token(Token = "0x6002F4B")]
			[Address(RVA = "0x2E31D00", Offset = "0x2E30D00", VA = "0x182E31D00", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x0000D848 File Offset: 0x0000BA48
		[Token(Token = "0x170005EA")]
		private bool UniqueFile
		{
			[Token(Token = "0x6002F4C")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x0000D860 File Offset: 0x0000BA60
		[Token(Token = "0x170005EB")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6002F4D")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06002F4E RID: 12110 RVA: 0x0000D878 File Offset: 0x0000BA78
		[Token(Token = "0x170005EC")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6002F4E")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4F")]
		[Address(RVA = "0x2E31D30", Offset = "0x2E30D30", VA = "0x182E31D30")]
		private void Start()
		{
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F50")]
		[Address(RVA = "0x2E316B0", Offset = "0x2E306B0", VA = "0x182E316B0", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F51")]
		[Address(RVA = "0x2E31620", Offset = "0x2E30620", VA = "0x182E31620")]
		private void BeforeLoadCleanUp()
		{
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F52")]
		[Address(RVA = "0x2E31E60", Offset = "0x2E30E60", VA = "0x182E31E60")]
		private void ToggleVerbose()
		{
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F53")]
		[Address(RVA = "0x2E31760", Offset = "0x2E30760", VA = "0x182E31760")]
		public static void Register(GardenPlot plot)
		{
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F54")]
		[Address(RVA = "0x2E31EB0", Offset = "0x2E30EB0", VA = "0x182E31EB0")]
		public static void Unregister(GardenPlot plot)
		{
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F55")]
		[Address(RVA = "0x2E319E0", Offset = "0x2E309E0", VA = "0x182E319E0", Slot = "11")]
		private GardenPlotSaveManager.GardenPlotManagerSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F56")]
		[Address(RVA = "0x2E318B0", Offset = "0x2E308B0", VA = "0x182E318B0", Slot = "12")]
		private void OnDeserialize(GardenPlotSaveManager.GardenPlotManagerSaveData data)
		{
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F57")]
		[Address(RVA = "0x2E32030", Offset = "0x2E31030", VA = "0x182E32030")]
		public GardenPlotSaveManager()
		{
		}

		// Token: 0x040029DB RID: 10715
		[Token(Token = "0x40029DB")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;

		// Token: 0x040029DC RID: 10716
		[Token(Token = "0x40029DC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<GardenPlot> _gardenPlots;

		// Token: 0x02000719 RID: 1817
		[Token(Token = "0x2000719")]
		[Serializable]
		public class GardenPlotManagerSaveData
		{
			// Token: 0x06002F59 RID: 12121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F59")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public GardenPlotManagerSaveData()
			{
			}

			// Token: 0x040029DD RID: 10717
			[Token(Token = "0x40029DD")]
			[FieldOffset(Offset = "0x10")]
			public List<GardenPlot.GardenPlotData> _gardenPlotsData;
		}
	}
}
